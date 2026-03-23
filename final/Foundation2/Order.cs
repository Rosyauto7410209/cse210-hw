class Order
{
//-product:List<Product>
private List<Product> product;
//-customer:Customer
private Customer customer;

//+Order(product, customer)
public Order(Customer c)
{
    product = new List<Product>();
    customer = c;
}
//+getproduct():List<Product>
public List<Product> getproduct()
    {
        return product;
    }
//+getcustomer():Customer
public Customer getcustomer()
    {
        return customer;
    }
//+addproduct(Product):void
public void addproduct(Product p)
    {
        product.Add(p);
    }
//+setcustomer(Customer):void
public void setcustomer(Customer c)
    {
        customer = c;
    }

//+gettotalPrice():double
public double gettotalPrice()
    {
        double total = 0;
        foreach (Product p in product)
        {
            total += p.gettotalCost();
        }
        if (customer.LivesinUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

//+getpackinglabel():string
public string getpackinglabel()
    {
        string result = "Packing Label:\n";
        foreach (Product p in product)
        {
            result += $"{p.getName()} (ID:{p.getID()})\n";
        }
        return result;
    }

//+getshippinglabel():string
public string getshippinglabel()
    {
       string result = "Shipping Label:\n";
       result += $"{customer.getName()}\n";
       result += customer.getaddress().getfullAddress();
       return result;
    }
}