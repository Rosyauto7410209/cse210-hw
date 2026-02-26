using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Threading;
public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity()
    {
        _name = "Unnamed Activity";
        _description = "No Description";
        _duration = 0;   
    }
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;         
    }

    public string getName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public int getDuration()
    {
        return _duration;
    }

    public void setDuration(int duration)
    {
        if (duration < 0)
        {
            _duration = 0;
        }
        _duration = duration;
    }

    public void displayStartingmessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        while (true)
        {
            Console.Write("In seconds, how long would you like your session to be?");
            string input = Console.ReadLine()??"";
            
            if(int.TryParse(input, out int seconds)&& seconds > 0)
            {
                setDuration(seconds);
                break;
            }
            Console.WriteLine("Please enter a Positive whole number.");
        }
        Console.WriteLine();
        Console.WriteLine("Activity starts Shortly, get ready.");
        showSpinner(3);
        Console.WriteLine(); 
    }

    public void displayEndmessage()
    {
        Console.WriteLine();
        Console.WriteLine("Thank you for participating.");
        showSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds");
        showSpinner(2);
        Console.WriteLine();
    }

    public void showSpinner(int seconds)
    {
        char[] frames = {'|','/','—','\\' };
        int totalTicks = seconds * 10;
        int indexTicks = 0;
        for(int i = 0; i < totalTicks; i++)
        {
            Console.Write(frames[indexTicks]);
            Thread.Sleep(100);
            Console.Write("\b");
            indexTicks = (indexTicks + 1) % frames.Length;
        }

    }

    public void showCountdown(int seconds)
    {
          for(int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            if (i >= 10)
            {
                Console.Write(" \b\b");
            }
        }

    }
    
    public void run()
    {
        displayStartingmessage();
        DoActivity();
        displayEndmessage();
    }
    protected abstract void DoActivity();
}