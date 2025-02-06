using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "Relax by following guided breathing.", duration) {}

    protected override void Run()
    {
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
        }
    }
}
