using System;

class Program
{
    static void Main(string[] args)
    {
            Scripture scripture = new Scripture("And now, my brethren, I would that ye should humble yourselves before God, and bring forth afruit meet for repentance, that ye may also enter into that rest.");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }
    }
}
