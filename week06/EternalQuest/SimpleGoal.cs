// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent(ref int score)
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            score += _points;
            Console.WriteLine($"Completed '{_name}'! Gained {_points} points.");
        }
        else
        {
            Console.WriteLine($"'{_name}' is already completed.");
        }
    }

    public override string Display() => (_isCompleted ? "[X] " : "[ ] ") + _name;
}
