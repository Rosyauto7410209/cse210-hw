using System.Diagnostics;

public abstract class Activity
{
//-Date:string
private string Date;
//-Length:double
private double Length;
//+Activity(Date, Length)
public Activity(string Date, double Length)
    {
        
        
    }
//getDate():void
public void getDate()
    {
        return Date;
    }
//+getLength():void
public void getLength()
    {
        return Length;
    }
//+setDate(Date):string
public string setDate(Date)
    {
        Date = Date;
    }
//+setLength(Length):double
public double setLength(Length)
    {
        Length = length;
    }
//+getDistance():double
public double getDistance()
    {
        return Distance;
    }
//+getSpeed():double
public double getSpeed()
    {
        return Speed;
    }
//+getPace():double
public double getPace()
    {
        return Pace;
    }
//+getName():string
public string getName()
    {
        return Name;
    }
//+getSummary():string   
public string getSummary()
    {
        return Summary;
    }
}