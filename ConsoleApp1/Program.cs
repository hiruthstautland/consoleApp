using System;


namespace ConsoleApp1
{
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();
            bool play = true;

            // bool play = false;

            // while (!play)
            // {
            //     if (inputPlay == "yes")
            //     {
            //         play = true;
            //     }
            //     else if (inputPlay == "q")
            //     {
            //         return;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Please type yes, or q");
            //         inputPlay = Console.ReadLine();
            //     }
            // }

            while (play)
            {
                // Game
                Random random = new Random();

                int winningNumber = random.Next(1, 10);
                int guess = 0;
                int guesses = 0;

                Console.WriteLine("Guess a number from 0 to 10");

                while (guess != winningNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        string msg = "You have to type a number.";
                        PrintColorMessage(ConsoleColor.Red, msg);

                        continue;
                    }
                    guess = Int32.Parse(input);
                    guesses += 1;

                    Console.WriteLine("You guessed: {0}", guess);

                    if (guess != winningNumber)
                    {
                        string msg = ("Sorry, " + guess + " is the wrong number!");
                        PrintColorMessage(ConsoleColor.Red, msg);
                        Console.WriteLine("Press enter to try again! Or q to quite");
                    }
                    else
                    {
                        string msg = "Congratulation!" + winningNumber + "was the right number! /n You used " + guesses + "!!";

                        // Console.WriteLine("Congratulation!");
                        // Console.WriteLine("{0} was the right number!", winningNumber);
                        // Console.WriteLine("You used {0} guesses!", guesses);

                        PrintColorMessage(ConsoleColor.Green, msg);

                        Console.WriteLine("Do you want to play again? [yes] to play again, [q] to quit!");
                        string playAgain = Console.ReadLine();
                        if (playAgain == "yes")
                        {
                            play = true;
                            continue;
                        }
                        else if (playAgain == "q")
                        {
                            play = false;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Do you want to play again? [yes] to play again, [q] to quit!");
                            playAgain = Console.ReadLine();
                        }

                    }
                }
            }
        }
        static void GetAppInfo()
        {
            string appName = "ConsoleApp - Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hiruth Marie Stautland";
            string description = "Console app based on Brad Traversy's youtube tutorial";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version: {1} by {2}.", appName, appVersion, appAuthor);
            Console.ResetColor();
            Console.WriteLine("Description: {0}", description);
        }

        static void GreetUser()
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello " + inputName + ". Do you want to play a game? Type [yes] to start or [q] if you want to leave.", inputName);
            string inputPlay = Console.ReadLine();
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
