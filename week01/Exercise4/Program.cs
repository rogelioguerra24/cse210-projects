using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        
        int inputNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
            Console.Write("Enter a number : ");
            
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        } while (inputNumber != 0);

        // second part
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // third part
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}