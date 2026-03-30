using System.ComponentModel.DataAnnotations;

public class Swimming:Activity
{
//-Laps:int
private int Laps;

//+Swimming(Date, Length, Laps)
public Swimming(string date,double length, int laps):base(date, length)
    {
        Laps = laps;
    }
//getLaps():int
public int getLaps()
    {
        return Laps;
    }
//setLaps(Laps):void
public void setLaps(int laps)
    {
        Laps = laps;
    }
//+getDistance():double
public override double getDistance()
    {
        return Laps*50/1000*0.62;
    }
//+getSpeed():double
public override double getSpeed()
    {
        return getDistance()/getLength()*60;
    }
//+getPace():double
public override double getPace()
    {
        return getLength()/getDistance();
    }
//+getName():string
public override string getName()
    {
        return "Swimming";
    } 
}