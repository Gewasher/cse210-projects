using System;
using System.ComponentModel.DataAnnotations;

public class Room
{
    private Enemy _enemy;
    private bool _enemydead;

    public virtual void SpawnEnemy()
    {

    }
    
    public string DisplayInfo()
    {
        return "";
    }



}