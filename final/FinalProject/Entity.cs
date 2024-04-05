using System;

public abstract class Entity
{
    private double _health;
    private double _maxHealth;
    private double _strength;

    public Entity(double startingHealth, double strength)
    {
        _health = startingHealth;
        _maxHealth = startingHealth;
        _strength = strength;
    }
    public virtual string takeDamage(double damage)
    {
        SetHealth(_health-damage);
        if (_health < 0)
        {
            SetHealth(0);
        }
        return $"{damage}";
    }
    
    public void SetHealth(double health)
    {
        _health = health;
    }
    
    public double Attack()
    {
        return _strength;
    }

    public double GetHealth()
    {
        return _health;
    }
        public double GetMaxHealth()
    {
        return _maxHealth;
    }


    public abstract string DisplayInfo();

}