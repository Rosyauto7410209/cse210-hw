
public class Address
{
//-Street:string
private string Street;
//-City:string
private string City;
//-StateProvince:string
private string StateProvince;
//-Country:string
private string Country;


//+Address(Street, City, StateProvince, Country)
public Address(string street,string city,string stateProvince,string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }
//+getStreet():string
public string getStreet()
    {
        return Street;
    }
//+getCity():string
public string getCity()
    {
        return City;
    }
//+getStateProvince():string
public string getStateProvince()
    {
        return StateProvince;
    }
//+getCountry():string
public string getCountry()
    {
        return Country;
    }
//+setStreet(Street):string
public void setStreet(string street)
    {
        Street = street;
    }
//+setCity(City):string
public void setCity(string city)
    {
        City = city;
    }
//+setStateProvince(StateProvince):string
public void setStateProvince(string stateProvince)
    {
        StateProvince = stateProvince;
    }
//+setCountry(Country):string
public void setCountry(string country)
    {
       Country = country; 
    }
//+getfullAddress():string
public string getfullAddress()
    {
        return $"{Street}\n{City},{StateProvince}\n{Country}";
    }
}