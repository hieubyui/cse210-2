using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;

        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

    }
}