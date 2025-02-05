using System;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity: {_activityDescription}");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Pause(3);  // Pause before starting
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Pause(2);  // Pause before ending
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        Pause(3);  // Final pause
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);  // 1-second pause
        }
        Console.WriteLine();
    }

    public int Duration { get { return _duration; } }
}
