// Goal.cs
using System;

public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }

    public abstract void RecordEvent(ref int score);
    public abstract string Display();
    public virtual bool IsCompleted() => _isCompleted;
    
    public virtual string SaveData()
    {
        return $"{this.GetType().Name}|{_name}|{_points}|{_isCompleted}";
    }

    public static Goal LoadData(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);
        bool isCompleted = bool.Parse(parts[3]);

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(name, points) { _isCompleted = isCompleted },
            "EternalGoal" => new EternalGoal(name, points),
            "ChecklistGoal" => new ChecklistGoal(name, points, int.Parse(parts[4]), int.Parse(parts[5])),
            _ => null
        };
    }
}
