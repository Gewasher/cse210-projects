
public class Monster : Enemy
{
    public Monster(double startingHealth, double strength) : base(startingHealth, strength)
    {
    }

    public override double AttackCycle()
    {
        
        if (GetCycle() == 1)
        {
            SetCycle(2);
            return Attack();
        }
        else if (GetCycle() == 2)
        {
            SetCycle(3);
            return Attack();
        }
        else
        {
            SetCycle(1);
            double attack = Attack();
            return attack*2;

        }
    }

    public override string DisplayInfo()
    {
        return $"Monster: Health - {GetHealth()}/{GetMaxHealth()} Strength - {Attack()}";
    }
    
}