using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the functions in order
        
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    // Adding DisplayWelcome function, which displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Adding PromptUserName function, which asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Adding PromptUserNumber function, which asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Adding SquareNumber function, which accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber (int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    // Adding DisplayResult fucntion, which accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.Write($"{name}, the square of your number is {squaredNumber}.");
    }
}
