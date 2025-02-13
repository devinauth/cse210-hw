// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            score += _points;
            Console.WriteLine($"Progressed '{_name}' ({_currentCount}/{_targetCount}). Gained {_points} points.");

            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                score += _bonus;
                Console.WriteLine($"Completed '{_name}'! Bonus {_bonus} points awarded.");
            }
        }
    }

    public override string Display() => (_isCompleted ? "[X] " : "[ ] ") + $"{_name} ({_currentCount}/{_targetCount})";

    public override string SaveData()
    {
        return $"{base.SaveData()}|{_targetCount}|{_currentCount}";
    }
}
