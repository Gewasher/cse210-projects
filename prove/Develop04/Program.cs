using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string breathingDescription = "This activity will help you relax by walking you through breathing slowly.\nClear your mind and focus on your breathing.";
        
        
        string listingDescription = "This activity will help you reflect on good things in your life by having you list as many as you can in a certian area.";
        
        List<String> listingPrompts = new List<string>();
        listingPrompts.Add("Who in your life are you greatful for?");
        listingPrompts.Add("What things do you find beautiful?");
        listingPrompts.Add("What are some of your favorite places?");
        listingPrompts.Add("What lessons did you learn today?");
        listingPrompts.Add("What did you accomplish today?");

        
        string reflectionDescription = "This activity will help you to recognize times in your life when you have shown strength and resilience. This will help you recognize your the power you have and how you can use it in other aspects of your life.";
        
        List<string> reflectionPrompts = new List<string>();
        reflectionPrompts.Add("Think of a time you acomplished something you thought you couldn't.");
        reflectionPrompts.Add("Think of a time when you helped someone in need.");
        reflectionPrompts.Add("Think of a time you started something daunting.");
        reflectionPrompts.Add("Think of a time you came up with an idea that helped others.");
        
        List<string> reflectionQuestions = new List<string>();
        reflectionQuestions.Add("How did this experince make you feel?");
        reflectionQuestions.Add("How did you get started?");
        reflectionQuestions.Add("What did you learn about yourself?");
        reflectionQuestions.Add("Why did this experience come to mind?");
        reflectionQuestions.Add("What is favorite thing about this experience?");
        reflectionQuestions.Add("What can you apply in your life now from this experience?");
        


        string choice="0";
        while(choice!="4")
        {

            Console.Clear();

            Console.WriteLine("Menu Options:");

            Console.WriteLine("1. Start Breathing Activity");        

            Console.WriteLine("2. Start Listing Activity");

            Console.WriteLine("3. Start Reflecting Activity");

            Console.WriteLine("4. Quit");

                        
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if(choice=="1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", breathingDescription, 0);
                breathingActivity.Run();
            }
            else if(choice=="2")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity",listingDescription, 0, 0, listingPrompts);
                listingActivity.Run();
            }

            else if(choice=="3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", reflectionDescription, 0, reflectionQuestions, reflectionPrompts);
                reflectingActivity.Run();
            }

            else if(choice=="4")
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please select a valid option. 1-4");
                Thread.Sleep(2000);
            }
        }


    }
}