class Product
{
//-Name:string
private string Name;
//-ID:string
private string ID;
//-Price:double
private double Price;
//-Quantity:int
private int Quantity;
//+Product(Name, ID, Price, Quantity)
public Product(string name, string id, double price, int quantity)
    {
        Name = name;
        ID = id;
        Price = price;
        Quantity = quantity;
    }
//+getName():string
public string getName()
    {
        return Name;
    }
//+getID():string
public string getID()
    {
        return ID;
    }
//+getPrice():double
public double getPrice()
    {
        return Price;
    }
//+getQuantity():int
public int getQuantity()
    {
        return Quantity;
    }
//+setName(Name):void
public void setName(string name)
    {
       Name = name; 
    }
//+setID(ID):void
public void setID(string id)
    {
       ID = id; 
    }
//+setPrice(Price):void
public void setPrice(double price)
    {
       Price = price; 
    }
//+setQuantity(Quantity):void
public void setQuantity(int quantity)
    {
       Quantity = quantity; 
    }
//+gettotalCost():double
public double gettotalCost()
    {
        return Price * Quantity;
    }
}