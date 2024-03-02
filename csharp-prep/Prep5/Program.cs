using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        DisplayWelcome();

        string name=PromptUserName();
        int num=PromptUserNumber();
        int numsq=SquareNumber(num);
        
        DisplayResuts(name, numsq);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite Number? ");
            int num=int.Parse(Console.ReadLine());

            return num;
        }
        static int SquareNumber(int num)
        {
           int numsq=num*num;

           return numsq;

        }
        static void DisplayResuts(string name, int numsq)
        {
            Console.WriteLine($"Hi, {name}; your number squared is {numsq}.");
        }

    }
}