using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        Fraction newFraction = new Fraction();
        newFraction.GetFractionString();
        newFraction.GetDecimalValue();
        newFraction.SetTop(5);
        newFraction.GetFractionString();
        newFraction.GetDecimalValue();
        newFraction.SetTop(3);
        newFraction.SetBottom(4);
        newFraction.GetFractionString();
        newFraction.GetDecimalValue();
        newFraction.SetTop(1);
        newFraction.SetBottom(3);
        newFraction.GetFractionString();
        newFraction.GetDecimalValue();
    }
}