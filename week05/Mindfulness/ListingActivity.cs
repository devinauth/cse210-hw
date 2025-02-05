using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration) {}

    public override void StartActivity()
    {
        base.StartActivity();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine($"Listing prompt: {prompt}");

        Console.WriteLine("You have 5 seconds to think. Start listing as many things as you can!");
        Pause(5);

        List<string> list = new List<string>();
        int timeElapsed = 0;

        while (timeElapsed < Duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                list.Add(item);
            }
            timeElapsed += 2;  // Each entry takes approximately 2 seconds
        }

        Console.WriteLine($"You listed {list.Count} items.");
        EndActivity();
    }
}
