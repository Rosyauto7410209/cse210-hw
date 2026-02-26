using System;
using System.Threading;
public class ReflectingActivity: Activity
{
    private List<string> _prompt;
    private List<string> _questions;
    Random r;

    public ReflectingActivity():base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        r = new Random();
    }

    public string getRandomPrompt()
    {
        int index = r.Next(_prompt.Count);
        return _prompt[index]; 

    }
    public string getRandomQuestion()
    {
        int index = r.Next(_questions.Count);
        return _questions[index];
    }

    protected override void DoActivity()
    {
        Console.WriteLine();
        Console.WriteLine($"{getRandomPrompt()}");
        Console.WriteLine();
        Console.WriteLine("When you feel ready, press enter.");
        Console.ReadLine();
        Console.WriteLine("Reflect on the question given.");
        Console.Write("You will start in ");
        showCountdown(10);
        Thread.Sleep(1000);
        Console.WriteLine();
         DateTime endTime = DateTime.Now.AddSeconds(getDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.WriteLine(getRandomQuestion());
            showSpinner(10);
        }
    }
}
//- _prompt:List<string>
//- _questions:List<string>
//+ getRandomQuestion():string
//+ getRandomPrompt():string
//+ reflectingactivity()
//+ reflectingactivity(name:string, description:string)
// run():void

//After the starting message, select a random prompt to show the user such as:


//After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:

