using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            SetAppInfo();

            GreetUser(); 
            
            while (true)
            {
                // Randomly generate the number to be guessed
                Random rand = new Random();
                int myNumber = rand.Next(1, 10);

                int guess = 0;
                Console.WriteLine("Guess a whole number between 1 and 10!");

                while (guess != myNumber)
                {
                    // Get user's input
                    string userNumber = Console.ReadLine();

                    // Check if user has given us a number
                    if (!int.TryParse(userNumber, out guess))
                    {
                        PrintMessage(ConsoleColor.Red, "Invalid input! Please enter an actual number:");
                        continue;
                    }
                    guess = Int32.Parse(userNumber);

                    if (guess != myNumber)
                    {
                        PrintMessage(ConsoleColor.Red, "Wrong! Please try again:");
                    }
                }

                // When number matches, print success message
                PrintMessage(ConsoleColor.Green, "You guessed it!");

                // Ask user if they want to play again
                Console.WriteLine("Would you like to play again? [y or n]");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain == "y")
                {
                    continue;
                }
                else if (playAgain =="n")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Set and display the app name, version, author, and colors
        static void SetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Varija Agarwal";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Get user's name and greet them
        static void GreetUser()
        {
            // Ask user for their name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a guessing game!", userName);
        }

        static void PrintMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
