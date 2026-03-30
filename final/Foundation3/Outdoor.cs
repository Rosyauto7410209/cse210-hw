using System.Reflection;

public class Outdoor:Event
{
//-weatherStatement:string
private string weatherStatement;
//+Outdoor(Title, Description, Date, Time, Address, weatherStatement)
public Outdoor(string title,string description,string date,string time, Address adress,string weatherstatement):base(title, description, date, time, adress)
    {
        weatherStatement = weatherstatement;
    }
//+getweatherStatement():string
public string getweatherStatement()
    {
        return weatherStatement;
    }
//+setweatherStatement(weatherStatement):void
public void setweatherStatement(string weatherstatement)
    {
        weatherStatement = weatherstatement;        
    }
//+getfullDetails():string
public override string getfullDetails()
    {
        return $"{getstandardDetails()}\nType: Outdoor Gathering\nWeather: {weatherStatement}";
    }
//+getshortDetails():string
public override string getshortDetails()
    {
        return $"Type: Outdoor Gathering\nTitle: {getTitle()}\nDate: {getDate()}";
    }
}