using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "admodev";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName} version {appVersion} by {appAuthor}");

            Console.ResetColor();

            Console.WriteLine("¿What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {inputName}, let's play a game!");

            Random random = new Random();

            int correctNumber = Convert.ToInt32(random.Next(1, 10));

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number.");
                    Console.ResetColor();

                    continue;
                }

                guess = Convert.ToInt32(input);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number! Please, try again.");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You guessed! Congratulations!");
            Console.ResetColor();
        }
    }
}
