// Author: Devi Nauth
// Description: Tracks YouTube videos and comments for monitoring product awareness.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("YouTube Video Tracker\nCreated by: Devi Nauth\n");

        // Create and populate videos
        List<Video> videos = new List<Video>
        {
            new Video("Understanding Abstraction", "Devi Nauth", 120, new List<Comment>
            {
                new Comment("Alice", "Great video! Very informative."),
                new Comment("Bob", "I love the way you explain things."),
                new Comment("Charlie", "Could you make a video on a similar topic?")
            }),

            new Video("Mastering C# Classes", "Devi Nauth", 150, new List<Comment>
            {
                new Comment("Dave", "This helped me understand classes better!"),
                new Comment("Eve", "Please cover inheritance next."),
                new Comment("Frank", "Your explanations are really clear!")
            }),

            new Video("Encapsulation in C#", "Devi Nauth", 180, new List<Comment>
            {
                new Comment("Grace", "This was exactly what I needed!"),
                new Comment("Hank", "Can you make more videos like this?"),
                new Comment("Ivy", "Great job explaining encapsulation!")
            })
        };

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine(video);
        }
    }
}
