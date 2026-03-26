using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Order order1 = new Order(new Customer("Jim Teacher", new Address("1234 East way","fakecity", "NY", "USA")));

order1.addproduct(new Product("Bulk Pens","02432532",4.99,3));
order1.addproduct(new Product("Bulk Pencils","09876547", 3.00,6));
//Second Product here
orders.Add(order1);






Order order2 = new Order(new Customer("Bill Charger",new Address("1254 East way", "fakecity", "new york", "USA" )));
order2.addproduct(new Product("Iphone","02432436",800.00,1));
order2.addproduct(new Product("Iphone Charger","07464755",8.99,1));
orders.Add(order2);

foreach(Order order in orders)
        {
            Console.WriteLine("");
            Console.WriteLine(order.getpackinglabel());
            Console.WriteLine("Total Price:");
            Console.WriteLine(order.gettotalPrice());
            Console.WriteLine("");
            Console.WriteLine(order.getshippinglabel());
        }
    }
}