using System;

public class GoalManager
{   
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
       _goals = new List<Goal>();
       _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        string choice = "0";
        while (choice !="6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create new Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if(choice=="1")
            {
                CreateGoal();
            }
            else if(choice=="2")
            {
                Console.WriteLine("Your goals are:");
                ListGoalDetails();
            }

            else if(choice=="3")
            {
                Console.Write("What is the filename of the goal file? ");
                SaveGoals(Console.ReadLine());

            }

            else if(choice=="4")
            {
                Console.Write("What is the filename of the goal file? ");
                LoadGoals(Console.ReadLine());
            }
            else if(choice=="5")
            { 
                Console.WriteLine("Your goals are:");
                ListGoalNames();
                RecordEvent();
            }
            else if(choice=="6")
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Please select a valid option. 1-6");
                Console.WriteLine();
            }

        }


    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {   
        int goalNumber = 0;
        foreach (Goal goal in _goals)
        {
            goalNumber += 1;
            Console.WriteLine($"{goalNumber}. {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        int goalNumber = 0;
        foreach (Goal goal in _goals)
        {
            goalNumber += 1;
            Console.WriteLine($"{goalNumber}. {goal.GetDetailString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        String name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        String description = Console.ReadLine();

        Console.Write("What is the amout of points associated with this goal? ");
        String points = Console.ReadLine();
        int intVar;
        while (!int.TryParse(points, out intVar))
        {
            Console.Write("Please Enter a number: ");
            points = Console.ReadLine();
        }


        if (goalType == "1")
        {
            SimpleGoal simplegoal = new SimpleGoal(name, description, points);

            _goals.Add(simplegoal);
        }
        else if (goalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);

            _goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("What is the bonus for acomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());


            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);

            _goals.Add(checklistGoal);
        }
        else if (goalType == "4")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("What is the bonus for acomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());


            ResetingChecklistGoal resetingChecklistGoal = new ResetingChecklistGoal(name, description, points, target, bonus);

            _goals.Add(resetingChecklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you acomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = int.Parse(_goals[goalNumber].GetPoints());
        _goals[goalNumber].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"You now have {_score} points.");
    }
    
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {   
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetRepresentation());
            }
        }
    }
    
    public void LoadGoals(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        _score = int.Parse(lines[0]);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts[0] == "a")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    if (parts[4] == "True")
                        simpleGoal.SetIsComplete();
                        _goals.Add(simpleGoal);
                }
            else if (parts[0] == "b")
                {
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(eternalGoal);
                }
            else if (parts[0] == "c")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                    checklistGoal.SetAmountCompleted(int.Parse(parts[6]));
                    _goals.Add(checklistGoal);
                }
            else if (parts[0] == "d")
                {
                    ResetingChecklistGoal resetingChecklistGoal = new ResetingChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                    resetingChecklistGoal.SetAmountCompleted(int.Parse(parts[6]));
                    _goals.Add(resetingChecklistGoal);
                }
        }
    }
    
}