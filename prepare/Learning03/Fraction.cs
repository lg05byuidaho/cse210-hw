using System;

public class Fraction
{
    
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }


      public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

    public Fraction(int numera, int denomi)
    {
        numerator = numera;
        denominator = denomi;
    }


    public string GetFractionString()
    {
        string text = $"{numerator}/{denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)numerator / (double)denominator;
    }

}
