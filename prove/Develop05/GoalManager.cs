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

    }
    //- ListGoals():void
    public void ListGoals()
    {

    }
    //- RecordEvents():void
    public void RecordEvent()
    {
        
    }
    // - SaveEvents(filename:string):void
    public void SaveGoals(string filename)
    {

    }
    // - LoadEvents(filename:string):void
    public void LoadGoals(string filename)
    {

    }
    //+ GetScore(): int
    public int GetScore()
    {
        Console.WriteLine($"You have {_score} points!");
    }
}







