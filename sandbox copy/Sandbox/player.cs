using system;

public class Player
{
    private string _name;
    private int _currentHealth;
    private int _maxHealth;
    private int _strength;

    public Player(string name, int startingHealth, int strength)
    {
        _name = name;
        _currentHealth = startingHealth;
        _maxHealth = startingHealth;
        _strength = strength;
    }
    public int GetCurrentHealth()
    {
        return _currentHealth;
    }
        public int GetMaxHealth()
    {
        return _maxHealth;

    }
    public ChangeHealth(int change)
    {
        _currentHealth += change;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }

        public ChangeMaxHealth(int change)
    {
        _maxHealth += change;
    }

}
