using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if(!_isComplete)
        {
            Console.WriteLine($"Congratulations you have earned {_points} points!");
            _points = "0";
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("This goal has been completed. No additional points will be rewarded.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete()
    {
        _isComplete = true;
    }

    public override string GetRepresentation()
    {
        return $"a|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

}