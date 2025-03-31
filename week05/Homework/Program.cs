using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assigment = new Assignment("Rogelio Guerra", "Multiplication");
        Console.WriteLine(assigment.GetSummary());
        Console.WriteLine();

        //Second Class Child
        MathAssingment mathAssingment = new MathAssingment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssingment.GetSummary());
        Console.WriteLine(mathAssingment.GetHomeworkList());
        Console.WriteLine();

        //Third Class Child
        WritingAssingment writingAssingment = new WritingAssingment("Mary Waters", "European History", "The Causes of World II");
        Console.WriteLine(writingAssingment.GetSummary());
        Console.WriteLine(writingAssingment.GetWritingInformation());
    }
}