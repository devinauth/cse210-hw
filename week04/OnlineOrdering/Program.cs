// Program.cs
// Developed by: Devi Nauth

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Program developed by: Devi Nauth\n");

        // Create Customers
        var customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        var customer2 = new Customer("Jane Smith", new Address("456 Oak St", "Vancouver", "BC", "Canada"));

        // Create Orders
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 800, 2));
        order1.AddProduct(new Product("Headphones", "P124", 50, 1));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P125", 500, 1));

        // Display Orders
        order1.DisplayOrder();
        order2.DisplayOrder();
    }
}
