using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");

        Console.Write("What was your points? ");
        string grade = Console.ReadLine();

        
        if (float.TryParse(grade, out float grade_number))
        {
            if (grade_number >= 90) 
            {
                Console.WriteLine("Your grade for this semester is A");
            }
            else if (grade_number >= 80) 
            {
                Console.WriteLine("Your grade for this semester is B");
            }
            else if (grade_number >= 70) 
            {
                Console.WriteLine("Your grade for this semester is C");
            }
            else if (grade_number >= 60) 
            {
                Console.WriteLine("Your grade for this semester is D");
            }
            else
            {
                Console.WriteLine("Your grade for this semester is F"); // Fixed wrong grade output
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }

        if (int.Parse(grade) >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
    
}