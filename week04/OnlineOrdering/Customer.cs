
// Customer.cs
// Developed by: Devi Nauth

public class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA() => Address.IsInUSA();
}
