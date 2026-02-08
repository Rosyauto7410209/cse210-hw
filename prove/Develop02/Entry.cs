using System;

public class Entry
{
    public DateTime _currentTime;
    public string Response;
    public string Prompt;
    public Entry(DateTime date, string prompt, string response)
    {
        _currentTime = date;
        Response = response;
        Prompt = prompt;
    }
    public void display()
    {
        Console.WriteLine($"{_currentTime.ToShortDateString()}");
        Console.WriteLine($"{Prompt}");
        Console.WriteLine($"{Response}");
        Console.WriteLine();
    }
}