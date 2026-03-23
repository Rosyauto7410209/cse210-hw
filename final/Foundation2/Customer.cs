
public class Customer
{
//-Name:string
private string Name;
//-address:Address
private Address address;

//+Customer(Name, address)
public Customer(string name, Address a)
    {
        Name = name;
        address = a;
    }

//+getName():string
public string getName()
    {
        return Name;
    }

//+getaddress():Address

public Address getaddress()
    {
        return address;
    }
//+setName(Name):void
public void setName(string name)
    {
        Name = name;
    }

//+setaddress(Address):void
public void seta(Address a)
    {
        address = a;
    }

//+LivesinUSA():bool
public bool LivesinUSA()
    {
        return address.LivesinUSA();
    }

}
