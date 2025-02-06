using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Mindfulness Program by Devi Nauth!");
        Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing");
        Console.Write("Select an activity: ");
        
        string choice = Console.ReadLine();
        Console.Write("Enter duration in seconds: ");

        if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a valid number.");
            return;
        }

        Activity activity = choice switch
        {
            "1" => new BreathingActivity(duration),
            "2" => new ReflectionActivity(duration),
            "3" => new ListingActivity(duration),
            _ => null
        };

        if (activity == null)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        activity.StartActivity();
    }
}

