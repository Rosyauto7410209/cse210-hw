using System.Diagnostics;

public abstract class Activity
{
//-Date:string
private string Date;
//-Length:double
private double Length;
//+Activity(Date, Length)
public Activity(string date, double length)
    {
        Date = date;
        Length = length;
    }
//getDate():void
public string getDate()
    {
        return Date;
    }
//+getLength():void
public double getLength()
    {
        return Length;
    }
//+setDate(Date):string
public void setDate(string date)
    {
        Date = date;
    }
//+setLength(Length):double
public void setLength(double length)
    {
        Length = length;
    }
//+getDistance():double
public abstract double getDistance();

//+getSpeed():double
public abstract double getSpeed();

//+getPace():double
public abstract double getPace();


//+getName():string
public abstract string getName();

//+getSummary():string   
public string getSummary()
    {
        return $"{Date} {getName()} ({Length} min): Distance {getDistance():0,0} Miles, Speed:{getSpeed():0,0} mph, Pace:{getPace():0,0} min per mile";
    }
}