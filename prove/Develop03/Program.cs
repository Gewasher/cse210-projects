using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter the book");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the starting verse");
        int sVerse = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the ending verse (enter '0' to skip)");
        int eVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter verse text");
        string verseText = Console.ReadLine();

        if(eVerse < 1 )
        {
            Reference reference = new Reference(book, chapter, sVerse, eVerse);   
            Scripture scripture = new Scripture(reference, verseText);
            bool run=true;
        bool nextTime=false;
            while (run)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                string quit = Console.ReadLine();
                scripture.HideRandomWords(4);
                if (nextTime)
                {
                    run = false;
                }
                if (quit == "quit")
                {
                    run = false;
                }
                else if (scripture.IsCompletelyHidden())
                {
                    nextTime=true;
                }
                else
                {
                    run = true;
                }
            }
            Console.Clear();
        }
        else
        {
            Reference reference = new Reference(book, chapter, sVerse);
            Scripture scripture = new Scripture(reference, verseText);
            bool run=true;
            bool nextTime=false;
            while (run)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                string quit = Console.ReadLine();
                scripture.HideRandomWords(3);
                if (nextTime)
                {
                    run = false;
                }
                if (quit == "quit")
                {
                    run = false;
                }
                else if (scripture.IsCompletelyHidden())
                {
                    nextTime=true;
                }
                else
                {
                    run = true;
                }
                
            }
            Console.Clear();
        }


        
        
    }
}