using System;

public class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration, List<string> questions, List<string> prompts) : base (name, description, duration)
    {
        _questions = questions;
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get Ready");
        ShowSpinner(5);

        Console.WriteLine("\nConsider the following prompt:");

        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();       

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DisplayQuestion();

        Console.WriteLine();

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
        {
            int num = _prompts.Count();

            Random randomGenerator= new Random ();
            int var = randomGenerator.Next(0, num);

            string rprompt = _prompts[var];
            
            return($"{rprompt}");
        }

    public string GetRandomQuestion()
        {
            int num = _questions.Count();

            Random randomGenerator= new Random ();
            int var = randomGenerator.Next(0, num);

            string rprompt = _questions[var];
            
            return($"{rprompt}");

        }

        public void DisplayPrompt()
        {
            Console.WriteLine($"---{GetRandomPrompt()}---");
        }

        public void DisplayQuestion()
        {
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                if (_questions.Count > 0)
                {
                    string question = GetRandomQuestion();
                    Console.Write($">{question}");
                    ShowSpinner(15);
                    Console.WriteLine();
                    _questions.Remove(question);
                }
            }
        }
}