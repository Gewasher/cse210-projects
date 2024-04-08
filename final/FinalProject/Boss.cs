
public class Boss : Enemy
{
    private int _phase;
    private double _phaseTwoStrength;
    public Boss(double startingHealth, double strength, double phaseTwoStrength) : base(startingHealth, strength)
    {
        _phaseTwoStrength = phaseTwoStrength;
        _phase = 1;
    }

    public override double AttackCycle()
    {
        
        if(_phase == 1)
        {
        if (GetCycle() == 1)
        {
            SetCycle(2);
            PhaseShift();
            return Attack();
        }
        else if (GetCycle() == 2)
        {
            SetCycle(3);
            PhaseShift();
            return Attack();
        }
        else
        {
            SetCycle(1);
            double attack = Attack();
            PhaseShift();
            return attack*2;
        }
        }
        else
        {
            
        
            if (GetCycle() == 1)
            {
                SetCycle(2);
                double attack = Attack();
                return attack*2;
            }
            else if (GetCycle() == 2)
            {
                SetCycle(3);
                return Attack();
            }
            else if (GetCycle() == 3)
            {
                SetCycle(4);
                double attack = Attack();
                return attack/2;

            }
            else 
            {
                SetCycle(1);
                double attack = Attack();
                return attack*2;

            }
        }
    }

    public void PhaseShift()
    {
        if (GetHealth() < GetMaxHealth()/2)
        {
            _phase = 2;
            SetStrength(_phaseTwoStrength);
        }

    }

    public override string DisplayInfo()
    {
        return $"Boss: Health - {GetHealth()}/{GetMaxHealth()} Strength - {Attack()}";
    }
    
}