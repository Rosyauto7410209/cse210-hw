using System.Reflection;

public class Lectures:Event
{
//-speakerName:string
private string speakerName;
//-Capacity:int
private int Capacity;
//+Lectures(Title, Description, Date, Time, Address, speakerName, Capacity)
public Lectures(string title,string description,string date,string time, Address adress,string speakername,int capacity):base(title, description, date, time, adress)
    {
        speakerName = speakername;
        Capacity = capacity;
    }
//+getspeakerName():string
public string getspeakerName()
    {
        return speakerName;
    }
//+getCapacity():int
public int getCapacity()
    {
        return Capacity;
    }
//+setspeakerName(speakerName):void
public void setspeakerName(string speakername)
    {
        speakerName = speakername;
    }
//+setCapacity(Capacity):void
public void setCapacity(int capacity)
    {
        Capacity = capacity;
    }
//+getfullDetails():string
public override string getfullDetails()
    {
        return $"{getstandardDetails()}\nType:Lecture\nSpeaker:{speakerName}\nCapacity:{Capacity}";
    }
//+getshortDetails():string  
public override string getshortDetails()
    {
        return $"Type: Lecture\nTitle:{getTitle()}\nDate: {getDate()}";
    }  
}