using System;

public class ReflectionActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly string[] Questions =
    {
        "Why was this meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity(int duration) : base("Reflection", "Reflect on meaningful moments in your life.", duration) {}

    protected override void Run()
    {
        Console.WriteLine($"Prompt: {Prompts[new Random().Next(Prompts.Length)]}");
        foreach (var question in Questions)
        {
            Console.WriteLine(question);
            Pause(3);
        }
    }
}
