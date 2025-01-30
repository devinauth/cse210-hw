// Product.cs
// Developed by: Devi Nauth

using System;

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetProductId()
    {
        return productId;
    }

    public string GetName()
    {
        return name;
    }
}
