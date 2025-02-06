using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?"
    };

    public ListingActivity(int duration) : base("Listing", "List positive things related to a prompt.", duration) {}

    protected override void Run()
    {
        Console.WriteLine($"Prompt: {Prompts[new Random().Next(Prompts.Length)]}");
        Console.WriteLine("List as many things as you can!");

        List<string> responses = new();
        int timeElapsed = 0;

        while (timeElapsed < Duration)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) responses.Add(input);
            timeElapsed += 2;
        }

        Console.WriteLine($"You listed {responses.Count} items!");
    }
}
