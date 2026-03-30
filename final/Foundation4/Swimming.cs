using System.ComponentModel.DataAnnotations;

public class Swimming
{
//-Laps:int
private int Laps;

//+Swimming(Date, Length, Laps)
public Swimming(string Date,double Length, int Laps)
    {
        
        
    }
//getLaps():int
public int getLaps()
    {
        return Laps;
    }
//setLaps(Laps):void
public void setLaps(Laps)
    {
        Laps = Laps;
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

}