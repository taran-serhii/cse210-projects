using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // creating a new instance of Journal class

        while(true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch(choice) // using switch statement to select one of 5 code blocks to be executed. https://www.w3schools.com/cs/cs_switch.php
            {
                case "1":
                    journal.AddNewEntry();
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                    Console.Write("Enter file name: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournalToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter file name: ");
                    string readFileName = Console.ReadLine();
                    journal.LoadJournalFromFile(readFileName);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Please select a number from the menu.");
                    break;
            }
        }
    }
}