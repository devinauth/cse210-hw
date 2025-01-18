using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nJournal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = prompts[new Random().Next(prompts.Count)];
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(new Entry(prompt, response, DateTime.Now.ToString("yyyy-MM-dd")));
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter the filename to save the journal: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;

                    case "4":
                        Console.Write("Enter the filename to load the journal: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"[{Date}] {Prompt}\nResponse: {Response}";
        }
    }

    class Journal
    {
        private List<Entry> Entries { get; set; } = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
            Console.WriteLine("Entry added successfully.");
        }

        public void DisplayEntries()
        {
            if (Entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
            }
            else
            {
                Console.WriteLine("\nJournal Entries:");
                foreach (var entry in Entries)
                {
                    Console.WriteLine(entry);
                    Console.WriteLine(new string('-', 40));
                }
            }
        }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var entry in Entries)
                    {
                        writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                    }
                }
                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal: {ex.Message}");
            }
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    Entries.Clear();
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split('|');
                            if (parts.Length == 3)
                            {
                                Entries.Add(new Entry(parts[1], parts[2], parts[0]));
                            }
                        }
                    }
                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }
    }
}
