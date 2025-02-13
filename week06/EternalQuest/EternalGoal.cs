// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"Recorded progress for '{_name}'. Gained {_points} points.");
    }

    public override string Display() => "[∞] " + _name;
}
