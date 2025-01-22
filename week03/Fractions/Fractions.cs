using System;

public class Fraction
{
    // Private fields for numerator and denominator
    private int numerator;
    private int denominator;

    // Default constructor (1/1)
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter for numerator (denominator defaults to 1)
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor with two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
