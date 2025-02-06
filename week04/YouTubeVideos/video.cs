using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; } // in seconds
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length, List<Comment> comments = null)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = comments ?? new List<Comment>();
    }

    public override string ToString()
    {
        string videoInfo = $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments ({Comments.Count}):";
        foreach (var comment in Comments)
        {
            videoInfo += $"\n- {comment}";
        }
        return videoInfo + "\n";
    }
}

