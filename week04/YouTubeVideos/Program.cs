using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create some comments
        Comment comment1 = new Comment("Alice", "Great video! Very informative.");
        Comment comment2 = new Comment("Bob", "I love the way you explain things.");
        Comment comment3 = new Comment("Charlie", "Could you make a video on a similar topic?");

        // Create a few videos
        Video video1 = new Video("Understanding Abstraction in Programming", "Devi Nauth", 120);
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);

        Video video2 = new Video("Mastering C# Classes", "Devi Nauth", 150);
        video2.Comments.Add(new Comment("Dave", "This helped me understand classes better!"));
        video2.Comments.Add(new Comment("Eve", "Please cover inheritance next."));
        
        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2 };

        // Iterate over the list of videos and display the details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(); // Adds a line break between video details
        }
    }
}

