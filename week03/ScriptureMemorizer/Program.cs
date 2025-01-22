// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        // Create a scripture with reference and text
        Scripture scripture = new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        );

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Great job memorizing!");
        Console.WriteLine(scripture.GetDisplayText());
    }
}

// Scripture.cs
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.ToString();
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{referenceText}\n{scriptureText}";
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (var word in _words.Where(w => !w.IsHidden).OrderBy(_ => random.Next()).Take(3))
        {
            word.Hide();
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}

// Reference.cs
public class Reference
{
    private string _book;
    private int _startChapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _startChapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _startChapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_startChapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_startChapter}:{_startVerse}";
        }
    }
}

// Word.cs
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden => _isHidden;

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
