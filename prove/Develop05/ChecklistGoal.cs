using System;
using System.Diagnostics;
using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted < _target)
            {
            Console.WriteLine($"Congratulations you have earned {_points} points!");
            }
        else if (_amountCompleted == _target)
        {
            int reward = _bonus + int.Parse(_points);
            Console.WriteLine($"Congratulations you have earned {reward} points!");
            _points = "0";
            _bonus = 0;
        }
        else
        {
            Console.WriteLine("This goal has been completed. No additional points will be rewarded.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string GetPoints()
    {
        if (_amountCompleted < _target-1)
        {
            return $"{_points}";
        }
        else
        {
            return $"{int.Parse(_points)+_bonus}";
        }
    }

        
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetRepresentation()
    {
        return $"c|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override string GetDetailString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }
        
    }

}