using System;


namespace ConsoleApp1
{
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            string appName = "ConsoleApp - Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hiruth Marie Stautland";
            string description = "Console app based on Brad Traversy's youtube tutorial";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: version: {1} by {2}.", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("Description: {0}", description);

            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello " + inputName + ". Let us play a game!", inputName);

            // Game
            int winningNumber = 3;
            int guess = 0;
            int guesses = 0;

            Console.WriteLine("Guess a number from 0 to 10");

            while (guess != winningNumber)       
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);
                guesses += 1;

                Console.WriteLine("You guessed: {0}", guess);

                if (guess != winningNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is the wrong nomber!", guess);
                    Console.WriteLine("Please try again!");
                    Console.ResetColor();
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulation!");
                    Console.WriteLine("{0} was the right number!", winningNumber);
                    Console.WriteLine("You used {0} guesses!", guesses);
                    Console.ResetColor();

                }

            }
        }
    } 
     
}
