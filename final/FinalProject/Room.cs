using System;
using System.ComponentModel.DataAnnotations;

public class Room
{
    protected Enemy _enemy;

    public Room()
    {
        SpawnEnemy();
        
    }
    public virtual void SpawnEnemy()
    {
        double strength = RandomStrength(2, 4);
        double health = RandomHealth(20, 30);
        Monster monster = new Monster(health ,strength);
        _enemy = monster;
    }
    

    public double RandomStrength(int low, int high)
    {
        high += 1;
        Random randomGenerator= new Random ();
        int strength = randomGenerator.Next(low, high);

        return strength;
    }
    public double RandomHealth(int low, int high)
    {
        high += 1;
        Random randomGenerator= new Random ();
        int health = randomGenerator.Next(low, high);

        return health;
    }

    public Enemy GetEnemy()
    {
        return _enemy;
    }


}