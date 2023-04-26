using System;
using System.Linq; // provides a set of extensions such sum, average, max etc.
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Adding a new integer list called numbers
        List<int> numbers = new List<int>();

        int userNumber;

        // Adding a do-while loop to keep asking user for the number until the condition is met
        do
        {
            // Asking a user for a number and turning the input into integer
            Console.Write("Enter a series of numbers one by one, (type 0 to finish):");
            userNumber = int.Parse(Console.ReadLine());

            // Adding the number provided by the user to the list called numbers, if the number is no equal to 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0); //a condition for do-while loop to continue to operate

        // Printing the list for testing purposes
        // foreach (int number in numbers)
        // {
        //    Console.WriteLine(number);
        // }

        // Compute the sum, or total, of the numbers in the list.
        int sum = numbers.Sum();
        Console.WriteLine($"The sum of all numbers in the list is: {sum}.");

        // Compute the average of the numbers in the list.
        double average = numbers.Average();
        Console.WriteLine($"The average of all numbers in the list is: {average}");

        // Find the maximum, or largest, number in the list.
        int max = numbers.Max();
        Console.WriteLine($"The biggest number in the list is: {max}");

        // Find the smallest positive number (the positive number that is closest to zero).
        int smallestPositiveNumber = 1000000;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number in the list is: {smallestPositiveNumber}");

        // Sort the numbers in the list and display the new, sorted list. 
        numbers.Sort();
        Console.WriteLine("The sorted list of numbers is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}