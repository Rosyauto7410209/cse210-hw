using System.Reflection;

public class Outdoor
{
//-weatherStatement:string
private string weatherStatement;
//+Outdoor(Title, Description, Date, Time, Address, weatherStatement)
public Outdoor(string Title,string Description,string Date,string Time, Address address,string weatherStatement)
    {
        
    }
//+getweatherStatement():string
public string getweatherStatement()
    {
        return weatherStatement;
    }
//+setweatherStatement(weatherStatement):void
public void setweatherStatement(weatherStatement)
    {
        
    }
//+getfullDetails():string
public string getfullDetails()
    {
        return fullDetails;
    }
//+getshortDetails():string
public string getshortDetails()
    {
        return shortDetails;
    }
}