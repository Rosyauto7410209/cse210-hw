public class Cycling:Activity
{
//-Speed:double
private double Speed;
//+Cycling(Date, Length, Speed)
public Cycling(string date, double length, double speed):base(date, length)
    {
        Speed = speed;
    }
//+getSpeed():double
public override double getSpeed()
    {
        return Speed;
    }
//+setSpeed(Speed):double
public void setSpeed(double speed)
    {
        Speed = speed;
    }
//+getDistance():double
public override double getDistance()
    {
        return Speed*getLength()/60;
    }
//+getPace():double
public override double getPace()
    {
        return 60/Speed;
    }
//+getName():string   
public override string getName()
    {
        return "Cycling";
    } 
}