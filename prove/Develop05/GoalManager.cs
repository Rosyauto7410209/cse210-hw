using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    //- _goals: List<Goal>
    private List<Goal> _goals;
    //- _score:int
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    //+ Start():void
    public void Start()
    {
        string choice="";
        while(choice !="6")
        {
            Console.Clear();
            GetScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create New Goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Events");
            Console.WriteLine("6.Quit");
            Console.Write("Please choose an option.");
            choice = Console.ReadLine();
            Console.WriteLine("");
            switch (choice)
            {
                case "1":
                CreateGoal();
                break;
                case "2":
                ListGoals();
                break;
                case "3":
                SaveGoals();
                break;
                case "4":
                LoadGoals();
                break;
                case "5":
                RecordEvent();
                break;
                case "6":
                break;
                default:
                Console.WriteLine("invalid choice.");
                break;   
            }
            if(choice != "6")
            {
                Console.WriteLine("");
                Console.Write("Press any key to continue");
                Console.ReadLine();
            }
        }
    }
    //- CreateGoal():void
    public void CreateGoal()
    {     
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Simple Goal");
            Console.WriteLine("2.Eternal Goal");
            Console.WriteLine("3.Checklist");
            Console.Write("Please choose an option.");
            string choice = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("What would you like to name your goal?");
            string name = Console.ReadLine();
            Console.Write("Please give a short description of your goal.");
            string description = Console.ReadLine();
            Console.Write("How many points do you want to assign for this goal?");
            int point = int.Parse(Console.ReadLine());
            if(choice == "1")
            {
                _goals.Add(new Simple(name, description, point));
            }
            else if(choice == "2")
            {
                _goals.Add(new Eternal(name, description, point));
            }
            else if(choice == "3")
            {
                Console.Write("How many times would you like to complete this goal?");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What would the bonus be for completing this goal for that limit?");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new Checklist(name, description, point, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
    }
    //- ListGoals():void
    public void ListGoals()
    {
        if(_goals.Count == 0)
        {
            Console.WriteLine("There are no goals available.");
            return;
        }
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].getDisplayString()}");
        }
    }
    //- RecordEvents():void
    public void RecordEvent()
    {
        if(_goals.Count == 0)
        {
        Console.WriteLine("There are no goals to record.");
        return;
        }
        Console.WriteLine("The goals are: ");
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
        Console.Write("What goal would you like to record?");
        int record = int.Parse(Console.ReadLine());
        if(record >= 0 &&(record < _goals.Count))
        {
            int points = _goals[record].RecordEvent();
            _score += points;
            Console.WriteLine($"Congratulations, you earned {points} points!");
            Console.WriteLine($"You now have {_score} points!");
        }
        else 
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    // - SaveEvents(filename:string):void
    public void SaveGoals()
    {
        Console.Write("What is the name for your goal file?");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goal saved Successfully.");
    }
    // - LoadEvents(filename:string):void
    public void LoadGoals()
    {
        Console.Write("What is the name for your goal file?");
        string file = Console.ReadLine();
        if(!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        string[] lines = File.ReadAllLines(file);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        for(int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string goalType = parts[0];
            if(goalType == "Simple")
            {
                _goals.Add(Simple.Deserialize(parts));
            }
            else if(goalType == "Eternal")
            {
                _goals.Add(Eternal.Deserialize(parts));
            }
            else if(goalType == "Checklist")
            {
                _goals.Add(Checklist.Deserialize(parts));
            }            
        }
        Console.WriteLine("Goals were loaded successfully.");
    }
    //+ GetScore(): int
    public int GetScore()
    {
        Console.WriteLine($"You have {_score} points!");
        return _score;
    }
}