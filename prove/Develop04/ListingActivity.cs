using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base (name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get Ready");
        ShowSpinner(5);

        Console.WriteLine("\nList as many repsonses as you can to the following prompt:");
        GetRandomPrompt();
        
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"You listed {_count} Items");

        Console.WriteLine();

        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
        int num = _prompts.Count();

        Random randomGenerator= new Random ();
        int var = randomGenerator.Next(0, num);

        string rprompt = _prompts[var];
            
        Console.WriteLine($"---{rprompt}---");
    }    

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            userList.Add(Console.ReadLine());
        }


        return userList;
    }

}