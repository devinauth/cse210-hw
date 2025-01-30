// Author: Devi Nauth
// Date: [Insert Date]
// Description: This program tracks YouTube videos and comments for a company monitoring product awareness.

using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Display author information
        Console.WriteLine("YouTube Video Tracker");
        Console.WriteLine("Created by: Devi Nauth\n");

        // Create three Video objects
        Video video1 = new Video("Understanding Abstraction in Programming", "Devi Nauth", 120);
        video1.Comments.Add(new Comment("Alice", "Great video! Very informative."));
        video1.Comments.Add(new Comment("Bob", "I love the way you explain things."));
        video1.Comments.Add(new Comment("Charlie", "Could you make a video on a similar topic?"));

        Video video2 = new Video("Mastering C# Classes", "Devi Nauth", 150);
        video2.Comments.Add(new Comment("Dave", "This helped me understand classes better!"));
        video2.Comments.Add(new Comment("Eve", "Please cover inheritance next."));
        video2.Comments.Add(new Comment("Frank", "Your explanations are really clear!"));

        Video video3 = new Video("Encapsulation in C#", "Devi Nauth", 180);
        video3.Comments.Add(new Comment("Grace", "This was exactly what I needed!"));
        video3.Comments.Add(new Comment("Hank", "Can you make more videos like this?"));
        video3.Comments.Add(new Comment("Ivy", "Great job explaining encapsulation!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate over the list and display video details
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
