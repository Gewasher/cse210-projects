using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcom to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How Long in seconds, would you like for you for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well done!");
        ShowSpinner(3);
        Console.WriteLine();

        Console.Write($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        
    }
    
    public void ShowSpinner(int seconds)
    {
        int loops = 0; 

        while (loops < seconds)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            loops += 1;
        }
    }

    public void ShowCountDown( int seconds)
    {
        seconds += 1;
        

        while (1 < seconds)
        {
            seconds -= 1;
            Console.Write(seconds.ToString());
            Thread.Sleep(1000);
            if(seconds >= 10)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b");   
            }

        }
    }


}

