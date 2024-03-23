using System;

public class BreathingActivity : Activity
{


    public BreathingActivity(string name, string description, int duration) : base (name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get Ready");
        ShowSpinner(5);

        Console.WriteLine();
        
        int duration = _duration;

        while (duration > 0)
        {
            duration -= 8;

            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.Write("\n");

            Console.Write("Breathe out..");
            ShowCountDown(4);

            Console.WriteLine("\n");
        }

    }

}

