using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }


    public override string GetRepresentation()
    {
        return $"b|{_shortName}|{_description}|{_points}";
    }
}