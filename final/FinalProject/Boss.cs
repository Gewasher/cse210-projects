
public class Boss : Enemy
{
    private int _phase;
    private double _secondPhaseStrength;
    public Boss(double startingHealth, double strength) : base(startingHealth, strength)
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

    public void PhaseShift()
    {
        
    }

    public override string DisplayInfo()
    {
        return $"Boss: Health - {GetHealth()}/{GetMaxHealth()} Strength - {Attack()}";
    }
    
}