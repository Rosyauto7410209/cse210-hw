public class Reception:Event
{
//-Email:string
private string Email;

//+Reception(Title, Description, Date, Time, Address, Email)
public Reception(string title, string description,string date, string time, Address adress,string email):base(title, description, date, time, adress)
    {
        Email = email;
    }
//+getEmail():string
public string getEmail()
    {
       return Email; 
    }
//+setEmail(Email):void
public void setEmail(string email)
    {
        Email = email;
    }
//+getfullDetails():string
public override string getfullDetails()
    {
        return $"{getstandardDetails()}\nType: Reception\nRSVP Email: {Email}";
    }
//+getshortDetails():string  
public override string getshortDetails()
    {
        return $"Type: Reception\nTitle: {getTitle()}\nDate: {getDate()}";
    }
}