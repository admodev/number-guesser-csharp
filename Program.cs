using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            Console.WriteLine("¿What is your name?");

            string inputName = Console.ReadLine();

            GreetUser(inputName);

            while (true)
            {

                Random random = new Random();

                int correctNumber = Convert.ToInt32(random.Next(1, 10));

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");

                        continue;
                    }

                    guess = Convert.ToInt32(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please, try again.");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You guessed! Congratulations!");

                Console.WriteLine("Do you want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                    continue;
                else if (answer == "N")
                    return;
                else
                    return;
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "admodev";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName} version {appVersion} by {appAuthor}");

            Console.ResetColor();
        }

        static void GreetUser(string input)
        {
            Console.WriteLine($"Hello, {input}, let's play a game!");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
