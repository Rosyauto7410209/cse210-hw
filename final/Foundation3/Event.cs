public abstract class Event
{
    //-Title:string
    private string Title;

//-Description:string
private string Description;
//-Date:string
private string Date;
//-Time:string
private string Time;
//-Address:Address
private Address address;
//+Event(Title, Description, Date, Time, Address)
public Event(string Title,string Description,string Date, string Time, Address address)
    {
        
    }
//+getTitle():string
public string getTitle()
    {
        return Title;
    }
//+getDescription():string
public string getDescription()
    {
        return Description;
    }
//+getDate():string
public string getDate()
    {
        return Date;
    }
//+getTime():string
public string getTime()
    {
        return Time;
    }
//+getAddress():Address
public Address GetAddress()
    {
      return Address; 
    }
//+setTitle(Title):void
public void setTitle(Title)
    {
        Title = title;
    }
//+setDescription(Description):void
public void setDescription(Description)
    {
        Description = description;
    }
//+setDate(Date):void
public void setDate(Date)
    {
        Date = date;
    }
//+setTime(Time):void
public void setTime(Time)
    {
        Time = time;
    }
//+setAddress(Address):void
public void setAddress(Address address)
    {
        Address = address;
    }
//+getfullDetails():string
public string getfullDetails()
    {
        return fullDetails;
    }
//+getstandardDetails():string
public string getstandardDetails()
    {
        return standardDetails;
    }
//+getshortDetails():string
public string getshortDetails()
    {
        return shortDetails;
    }
}