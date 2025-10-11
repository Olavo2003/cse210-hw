using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Denver", "CO", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L123", 850.00, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

        Address addr2 = new Address("45 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Carlos Mendes", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "H789", 60.00, 1));
        order2.AddProduct(new Product("Keyboard", "K321", 40.00, 1));
        order2.AddProduct(new Product("USB Cable", "U654", 10.00, 3));

        List<Order> orders = new List<Order>() { order1, order2 };

        foreach (Order o in orders)
        {
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Total Price: ${o.GetTotalCost()}\n");
            Console.WriteLine("----------------------------------\n");
        }
    }
}
