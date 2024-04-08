using System;
using System.Runtime.InteropServices;

public class UI
{
    private Player _player;
    private Dungeon _dungeon;
    private bool _running;

    public UI()
    {
        Console.Clear();
        Console.Write("Please enter your characters name: ");
        string name = Console.ReadLine();

        Player player = new Player(60, 6, name);
        _player = player;
        
        Dungeon dungeon = new Dungeon(4);
        _dungeon = dungeon;
        _running = true;

    }

    public void Run()
    {
        
        while (_running)
        {
            Console.Clear();

            Console.WriteLine(_dungeon.DisplayInfo());
            Console.WriteLine(_player.DisplayInfo());
            Console.WriteLine ($"Next Enemy: {_dungeon.GetEnemy().DisplayInfo()}");

            Console.Write("Press 'Enter' to begin combat.");
            Console.ReadLine();

            CombatManager(_dungeon.GetEnemy());
            _dungeon.NextRoom();
            
            if (_player.GetHealth() > 0)
            {
                    _player.Heal(5);

                    Console.WriteLine();
                    Console.WriteLine("5 health restored.");

                    Thread.Sleep(2000);
                

                if (_dungeon.GetCurrentRoom() == _dungeon.GetMaxRooms())
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations you have cleared the dungeon!");
                    Thread.Sleep(3000);
                    _running = false;
                }
            }

        }

            Console.Clear();
            Console.WriteLine("Goodbye");

    }

    public void CombatManager(Enemy enemy)
    {
        Console.Clear();
        Console.WriteLine(_player.DisplayInfo());
        Console.WriteLine (enemy.DisplayInfo());
        
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
                    Console.WriteLine($"You strike your foe for {enemy.takeDamage(damage)} damage.");
                    
                }
                Console.WriteLine();
                Thread.Sleep(1000);

                if (enemy.GetHealth() > 0)
                {
                    double enemyDamage = enemy.AttackCycle();
                    Console.WriteLine($"The monster hits you for {_player.takeDamage(enemyDamage)} damage.");

                    
                    Thread.Sleep(2000);

                    Console.Clear();

                    Console.WriteLine(_player.DisplayInfo());
                    Console.WriteLine (enemy.DisplayInfo());
                    
                    
                }
                _player.Unbrace();

                if(_player.GetHealth() <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have died :(");
                    Thread.Sleep(3000);
                    combat = false;
                    _running = false;
                }
                else if(enemy.GetHealth() <= 0)
                {   
                    Console.WriteLine();
                    Console.WriteLine("You have slain the beast!!");
                    Thread.Sleep(3000);
                    combat = false;
                }
            }
    }
}