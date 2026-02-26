using System;
using System.Threading;

public class ListingActivity: Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity():base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public string randomprompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        return _prompts[index];
    }

    public int getCount()
    {
        return _count;
    }

        protected override void DoActivity()
    {
        Console.WriteLine();
        Console.Write("List as many responses as you can. ");
        Console.WriteLine($"{randomprompt()}");
        Console.WriteLine();
        Console.Write("You may start in ");
        Thread.Sleep(1000);
        showCountdown(10);
        Console.WriteLine();
        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(getDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string item = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(item))
            {
                _count++;
            }
        }
        Console.WriteLine($"Congratulations, you finished {_count} items.");
    }
}