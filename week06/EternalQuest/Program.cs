// Program.cs
using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal\n2. Record Goal\n3. Display Goals\n4. Save & Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.RecordGoal();
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals();
                    Console.WriteLine("Progress saved. Goodbye, Devi Nauth!");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
