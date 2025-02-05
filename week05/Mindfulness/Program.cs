using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Mindfulness Program by Devi Nauth!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        string choice = Console.ReadLine();
        Console.Write("Enter duration in seconds: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Activity activity = null;

        switch (choice)
        {
            case "1":
                activity = new BreathingActivity(duration);
                break;
            case "2":
                activity = new ReflectionActivity(duration);
                break;
            case "3":
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        activity.StartActivity();
    }
}
