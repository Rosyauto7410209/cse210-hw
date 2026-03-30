public class Running:Activity
{
//-Distance:double
private double Distance;
//+Running(Date, Length, Distance)
public Running(string date, double length, double distance):base(date, length)
    {
        Distance = distance;
    }
//+getDistance():double
public override double getDistance()
    {
        return Distance;
    }
//+setDistance(Distance):void
public void setDistance(double distance)
    {
        Distance = distance;
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
        return "Running";
    }
}