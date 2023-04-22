using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a string variable letter
        string letter = "";

        // Asking user for grade percentage, and converting string to integer
        Console.Write("What is your grade percentage? ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);

        // Determining the grade letter
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

        // Show the user their grade in form of the letter
        Console.WriteLine($"Your grade is {letter}.");

        // Checking if user passed and printing the result
        if (grade >= 70)
        {
            Console.WriteLine("Congragulations! You passed!");
        }
        else
        {
            Console.WriteLine("I am sorry! You didn't pass this time. Please try again.");
        }
    }
}