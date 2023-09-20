using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter your magic number: ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,20);
        
        int guess = -1;

        
        
            

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.Write("You guessed it!");
            }
        }
    }
}