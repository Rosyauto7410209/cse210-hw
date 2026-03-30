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
public Event(string title,string description,string date, string time, Address adress)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        address = adress;    
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
      return address; 
    }
//+setTitle(Title):void
public void setTitle(string title)
    {
        Title = title;
    }
//+setDescription(Description):void
public void setDescription(string description)
    {
        Description = description;
    }
//+setDate(Date):void
public void setDate(string date)
    {
        Date = date;
    }
//+setTime(Time):void
public void setTime(string time)
    {
        Time = time;
    }
//+setAddress(Address):void
public void setAddress(Address adress)
    {
        address = adress;
    }
//+getfullDetails():string
public abstract string getfullDetails();

//+getstandardDetails():string
public string getstandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\n:Address: {address.getfullAddress()}";
    }
//+getshortDetails():string
public abstract string getshortDetails();
}