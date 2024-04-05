using System;
using System.Runtime.InteropServices;

public class UI
{
    private Player _player;
    private Monster _monster;

    public UI()
    {
        Console.Clear();
        Console.Write("Please enter your characters name: ");
        string name = Console.ReadLine();

        Player player = new Player(30, 4, name);
        _player = player;
        
        Monster monster = new Monster(25, 4);
        _monster = monster;

        Run();
    }

    public void Run()
    {

        Console.Clear();

        Console.WriteLine(_player.DisplayInfo());
        Console.WriteLine (_monster.DisplayInfo());

        Console.Write("Press 'Enter' to begin combat.");
        Console.ReadLine();

        CombatManager();

        Console.Clear();
        Console.WriteLine("Goodbye");

    }

    public void CombatManager()
    {
        Console.Clear();
        Console.WriteLine(_player.DisplayInfo());
        Console.WriteLine (_monster.DisplayInfo());
        
        bool combat = true;

        while (combat)
            {
                Console.WriteLine();
                Console.Write("Type '1' to brace, or '2' to attack: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    _player.Brace();
                    Console.WriteLine("You brace for an attack.");
                }
                else if (choice == "2")
                {
                    double damage = _player.Attack();
                    Console.WriteLine($"You strike your foe for {_monster.takeDamage(damage)} damage.");
                    
                    Console.WriteLine();

                    Console.WriteLine(_player.DisplayInfo());
                    Console.WriteLine (_monster.DisplayInfo());
                }
                Console.WriteLine();
                Thread.Sleep(2000);

                if (_monster.GetHealth() > 0)
                {
                    double enemyDamage = _monster.AttackCycle();
                    Console.WriteLine($"The monster hits you for {_player.takeDamage(enemyDamage)} damage.");

                    

                    Console.WriteLine();

                    Console.WriteLine(_player.DisplayInfo());
                    Console.WriteLine (_monster.DisplayInfo());
                    
                    _player.Unbrace();
                }

                if(_player.GetHealth() <= 0)
                {
                    Console.WriteLine("You have died :(");
                    Thread.Sleep(5000);
                    combat = false;
                }
                else if(_monster.GetHealth() <= 0)
                {
                    Console.WriteLine("You have slain the beast!!");
                    Thread.Sleep(5000);
                    combat = false;
                }
            }
    }
}