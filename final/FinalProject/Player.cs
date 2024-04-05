using System;

public class Player : Entity
{
    public string _name;
    public bool _braced;

    public Player(double startingHealth, double strength, string name) : base(startingHealth, strength)
    {
        _braced = false;
        _name = name;
    }

    public void Heal(double health)
    {
        double currentHealth = GetHealth();
        SetHealth(currentHealth + health);
        if (GetHealth() > GetMaxHealth())
        {
            SetHealth(GetMaxHealth());
        }
    }

    public void Brace()
    {
        _braced = true;
    }
    
    public void Unbrace()
    {
        _braced = false;
    }

    public override string takeDamage(double damage)
    {
        if (_braced)
        {
           double bracedDamage = damage * .25;
           return base.takeDamage(bracedDamage);
        }
        else
        {
           return base.takeDamage(damage);
        }
    }



    public override string DisplayInfo()
    {
        return $"{_name}: Health - {GetHealth()}/{GetMaxHealth()} Strength - {Attack()}";
    }
    
}