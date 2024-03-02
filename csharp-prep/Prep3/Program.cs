using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator= new Random ();
        int magicnumber=randomGenerator.Next(1,100);

        int guess=0;

        while (magicnumber!=guess)
        {
            Console.Write("What is your guess? ");
            guess=int.Parse(Console.ReadLine());
            if (magicnumber>guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber<guess)
            {
                Console.WriteLine("Lower");       
            }
        }
        Console.WriteLine("You guessed it!");       

    }
}