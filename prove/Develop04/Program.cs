using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
class Program
{
    private List<Activity> _activities;

    public Program()
    {
        _activities = new List<Activity>
        {
        new BreathingActivity(),
        new ReflectingActivity(),
        new ListingActivity()    
        };
    }
    static void Main(string[] args)
    {
        
        Program program = new Program();
        program.run();

    }

    public void run()
    {
        bool running = true;
        while (running)
        {
            displayMenu();
            int choice = getMenuchoice();
            switch (choice)
            {
                case 1:
                _activities[0].run();
                break;
                case 2:
                _activities[1].run();
                break;
                case 3:
                _activities[2].run();
                break;
                case 4:
                running = false;
                break;
                default:
                Console.WriteLine("invalid choice.");
                break;
            }
        }
        Console.WriteLine("Thank you for your time.");
    }

    public void displayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Please choose an option.");
    }

    public int getMenuchoice()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out int choice)&& choice>=1 && choice <=34)
            {
                return choice;
            }
        }
    }
}