using System;
using System.Diagnostics;
using System.Runtime;

public class ResetingChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ResetingChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
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
        }
        else
        {
            Console.WriteLine($"Congratulations you have earned {_points} points!");
            _amountCompleted = 1;
        }
    }

    public override bool IsComplete()
    {
            return false;
    }

    public override string GetPoints()
    {
        if (_amountCompleted == _target-1)
        {
        return $"{int.Parse(_points)+_bonus}";

        }
        else
        {
            return $"{_points}";
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