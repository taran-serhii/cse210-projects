using System;

class Program
{
    static void Main(string[] args)
    {
        // Adding a bool variable named again
        bool again = true;

        while (again == true)
        {
            // asking the user for the magic number
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            //  Generate a random number from 1 to 100.
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // Adding a int variable guessNumber
            int guessNumber = -1;

            // Adding a int variable guessCount
            int guessCount = 0;

            // Add a loop that keeps looping as long as the guess does not match the magic number.
            while (guessNumber != magicNumber)
            {
                // Asking user to guess the magic number
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                // Adding +1 to guess count
                guessCount ++;

                // Setting up the conditions to display hints for the user
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    Console.WriteLine("Do you want to play again? (type yes or no)");
                    string answer = Console.ReadLine();

                    // Setting up the conditions to ask the user if they want to play again
                    if (answer == "yes")
                    {
                        again = true;
                    }

                    else
                    {
                        again = false;
                    }
                }
            }
        }
    }
}