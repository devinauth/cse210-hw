// Address.cs
// Developed by: Devi Nauth

public class Address
{
    private string Street, City, State, Country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA() => Country == "USA";

    public string GetFullAddress() => $"{Street}, {City}, {State}, {Country}";
}

