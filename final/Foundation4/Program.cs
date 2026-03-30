using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{ 
//-activities:List<Activity>
private List<Activity> activities;
//+main()
public Program()
    {
        activities = new List<Activity>();
    }

//+Displayactivities():void
public void Displayactivities()
    {
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
//+addActivity(Activity):void
public void addActivity(Activity activity)
    {
        activities.Add(activity);
    }
//+removeActivity(Activity):void
public void removeActivity(Activity activity)
        {
            activities.Remove(activity);
        }

   public static void Main(string[] args)
    {
    Program program = new Program();

        program.addActivity(new Running("05/5/2025", 30, 3.0));

        program.addActivity(new Cycling("06/01/2025", 40, 10.0));

        program.addActivity(new Swimming("10/01/2026",30,40));

program.Displayactivities();
    }
}