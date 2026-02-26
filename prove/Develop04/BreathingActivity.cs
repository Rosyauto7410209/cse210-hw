using System;
using System.Threading;
public class BreathingActivity: Activity
{
    private int _breathInSeconds;
    private int _exhaleSeconds;
    public BreathingActivity():base("Breathing Activity", "This activity will help you relax and slow down.")
    {
        _breathInSeconds = 3;
        _exhaleSeconds = 3;
    }

    protected override void DoActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(getDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale ");            
            for (int i = 0; i < _breathInSeconds && DateTime.Now < endTime; i++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("Exhale ");
            for (int i = 0; i < _exhaleSeconds && DateTime.Now < endTime; i++)
            {
                Thread.Sleep(1000);
            }
        }

    }
}
//- _breathInSeconds:int
//- _exhaleSeconds:int
//+ breathIn():void
//+ exhale():void
//+ breathingactivity()
//+ breathingactivity(name:string, description:string)
//+ run():void