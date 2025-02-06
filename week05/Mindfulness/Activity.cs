using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; }
    protected string Description { get; }
    protected int Duration { get; }

    protected Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {Name} Activity: {Description}\nDuration: {Duration} seconds.");
        Pause(3);
        Run();
        Console.WriteLine("Well done! You've completed the activity.");
        Pause(2);
    }

    protected abstract void Run();

    protected void Pause(int seconds) => Thread.Sleep(seconds * 1000);
}
