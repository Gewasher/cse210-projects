using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName} ({_description})";
        }
        else
        {
            return $"[] {_shortName} ({_description})";
        }
        
    }
    
    public abstract string GetRepresentation();

    public string GetShortName()
    {
        return _shortName;
    }
        public virtual string GetPoints()
    {
        return _points;
    }
}