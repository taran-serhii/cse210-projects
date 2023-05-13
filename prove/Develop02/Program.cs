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
            Console.WriteLine("3. Edit an Entry");
            Console.WriteLine("4. Save Journal to File");
            Console.WriteLine("5. Load Journal from File");
            Console.WriteLine("6. Exit");

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
                    Console.Write("Enter the index of the entry to edit: ");
                    string indexText = Console.ReadLine();
                    if (int.TryParse(indexText, out int index)) // converting a string number into integer. https://code-maze.com/csharp-parse-tryparse/
                    {
                        if (index >= 0 && index < journal._allEntries.Count) // checking if index is within the bounds of all elemnets in _allEntries list.
                            {
                                journal.EditEntry(index); // if the index is present, calling a method to modify the specified entry
                            }
                        else
                            {
                                Console.WriteLine("Invalid index. Please enter a valid index."); // informative message which appears when the index is not present in _allEntries list.
                            }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid index."); // informative message when the program can't parse indexText into an integer.
                    }
                    break;
                case "4":
                    Console.Write("Enter file name: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournalToFile(saveFileName);
                    break;
                case "5":
                    Console.Write("Enter file name: ");
                    string readFileName = Console.ReadLine();
                    journal.LoadJournalFromFile(readFileName);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Please select a number from the menu.");
                    break;
            }
        }
    }
}