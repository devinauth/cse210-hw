using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.", duration) {}

    public override void StartActivity()
    {
        base.StartActivity();
        
        int timeElapsed = 0;
        while (timeElapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(3); // Wait for 3 seconds
            Console.WriteLine("Breathe out...");
            Pause(3); // Wait for 3 seconds
            timeElapsed += 6;  // Each breath cycle takes 6 seconds
        }

        EndActivity();
    }
}
