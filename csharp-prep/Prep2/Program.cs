using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response= Console.ReadLine();
        int grade = int.Parse(response);
        string letter;

        if (grade>=90)
        {
            letter="A";
        }
        else if (grade>=80)
        {
            letter="B";
        }
        else if (grade>=70)
        {
            letter="C";
        }
        else if (grade>=60)
        {
            letter="D";
        }
        else 
        {
            letter="F";
        }
        Console.WriteLine($"Your grade: {letter}");
        if (grade<70)
        {
            Console.WriteLine("Sorry you failed. Better luck next time.");
        }
        else
        {
            Console.WriteLine("Congratualtions, you passed.");
        }
    }
}