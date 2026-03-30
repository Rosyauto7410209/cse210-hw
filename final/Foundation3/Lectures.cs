using System.Reflection;

public class Lectures
{
//-speakerName:string
private string speakerName;
//-Capacity:int
private int Capacity;
//+Lectures(Title, Description, Date, Time, Address, speakerName, Capacity)
public Lectures(string Title,string Description,string Date,string Time, Address address,string speakerName,int Capacity)
    {
        
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
public void setspeakerName(speakerName)
    {
        
    }
//+setCapacity(Capacity):void
public void setCapacity(Capacity)
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