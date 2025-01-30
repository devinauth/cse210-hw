// Program.cs
// Developed by: Devi Nauth

using System;

public class Program
{
    public static void Main()
    {
        // Print your name at the start of the program
        Console.WriteLine("Program developed by: Devi Nauth\n");

        // Create Addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak St", "Vancouver", "BC", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Products
        Product product1 = new Product("Laptop", "P123", 800, 2);
        Product product2 = new Product("Headphones", "P124", 50, 1);
        Product product3 = new Product("Smartphone", "P125", 500, 1);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display Order Details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}\n");
    }
}
