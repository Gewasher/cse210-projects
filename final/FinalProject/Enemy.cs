using System;

public abstract class Enemy : Entity
{
    private int _cycle;
    public Enemy(double startingHealth, double strength) : base(startingHealth, strength)
    {
        _cycle = 1;
    }

    public int GetCycle()
    {
        return _cycle;
    }
    public void SetCycle(int cycle)
    {
        _cycle = cycle;
    }

    public abstract double AttackCycle();
}