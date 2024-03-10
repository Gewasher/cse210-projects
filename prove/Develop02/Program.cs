using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome");
        
        string choice="0";
        Journal journal = new Journal();
        while(choice!="5")
        {



            Console.WriteLine("Please Select one of the following choices.");

            Console.WriteLine("1.Write");        

            Console.WriteLine("2.Display");

            Console.WriteLine("3.Load");

            Console.WriteLine("4.Save");

            Console.WriteLine("5.Quit");

                        
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if(choice=="1")
            {
                PromptGenerator prompter = new PromptGenerator();

                prompter._prompts.Add("What did you learn today?");
                prompter._prompts.Add("How would you rate yout day on a scale of 1-10 and why?");
                prompter._prompts.Add("What do you wish you did different today?");
                prompter._prompts.Add("What did you acomplish today?");
                prompter._prompts.Add("Who are you gratefull for today?");


                string prompt = prompter.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine();
            
                Entry userEntry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                userEntry._date = theCurrentTime.ToShortDateString();

                userEntry._promptText = prompt;
                Console.Write(">");

                userEntry._entryText = Console.ReadLine();
                
                journal.AddEntry(userEntry);

            }
            else if(choice=="2")
            {
                journal.DisplayAll();
            }

            else if(choice=="3")
            {
                Console.WriteLine("What file would you like to load?");
                Console.Write(">");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if(choice=="4")
            {
                Console.WriteLine("What would you like to name your file?");
                Console.Write(">");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if(choice=="5")
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Please select a valid option. 1-5");
                Console.WriteLine();
            }

        }

    }
}