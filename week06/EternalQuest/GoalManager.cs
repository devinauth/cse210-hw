// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _filePath = "goals.txt";

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points value: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordGoal()
    {
        DisplayGoals();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent(ref _score);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
        }
        Console.WriteLine($"Total Score: {_score}\n");
    }

    public void SaveGoals()
    {
        using StreamWriter writer = new StreamWriter(_filePath);
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.SaveData());
        }
    }

    public void LoadGoals()
    {
        if (File.Exists(_filePath))
        {
            string[] lines = File.ReadAllLines(_filePath);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                _goals.Add(Goal.LoadData(lines[i]));
            }
        }
    }
}
