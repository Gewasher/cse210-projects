using System;
using System.ComponentModel.DataAnnotations;

public class Bossroom : Room
{

    public Bossroom()
    {
        SpawnEnemy();
        
    }
    
    public override void SpawnEnemy()
    {
        double strength = RandomStrength(4, 5);
        double health = RandomHealth(30, 40);
        double phaseTwoStrength = RandomStrength(6, 6);

        Boss boss = new Boss(health, strength, phaseTwoStrength);
        _enemy = boss;
    }
    

}