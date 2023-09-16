using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade(0-100): ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You pass!");
        }
        else
        {
            Console.WriteLine("You did not pass. Let's get you some help.");
        }

    }
}