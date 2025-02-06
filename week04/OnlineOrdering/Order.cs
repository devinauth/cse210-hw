// Order.cs
// Developed by: Devi Nauth

using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Shipping To: {customer.Name}, {customer.Address.GetFullAddress()}");
        Console.WriteLine("Packing List:");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name} ({product.ProductId})");
        }

        double total = GetTotalPrice();
        Console.WriteLine($"Total Price: ${total:F2}\n");
    }

    private double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }
}
