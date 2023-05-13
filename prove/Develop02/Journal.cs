public class Journal
{
    // Member variables
    public List<Entry> _allEntries;
  
    // Constructor to create a new Journal object
    public Journal()
    {
    _allEntries = new List<Entry>();
    }
   
    // A method to add new entry to the Journal
    public void AddNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator(); // creating a new PrompGenerator object.
        string prompt = promptGenerator.GetRandomPrompt(); // getting a random prompt and assigning it to a string variable named prompt.

        Console.WriteLine(prompt); // showing the prompt to the user
        string response = Console.ReadLine(); // getting input from the user and assigning it to a string variable response.
        string dateAndTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"); // get current DateTime and convert DateTime to string

        Entry entry = new Entry(dateAndTime, prompt, response);
        _allEntries.Add(entry); // adding the entry to the list of all entries ni the current Journal object
    }

    // A method for displaying all entries from the Journal
    public void DisplayAllEntries()
    {
        //Iterate trough each entry in the list to display them one by one
        foreach (Entry entry in _allEntries)
        {
        Console.WriteLine(entry);
        }
    }

    // A method for saving the journal to a file
    public void SaveJournalToFile(string fileName) 
    {
        using (StreamWriter writer = new StreamWriter(fileName)) // opening a new StreamWriter for the provided fileName
        {
            foreach (Entry entry in _allEntries) // looping through each line in _allEntries and recoding them to the file
            {
                writer.WriteLine($"{entry._dateAndTime}~~{entry._prompt}~~{entry._userInput}"); // recodring each entry as a string with ~~ separators between 3 key pieces of info.
            }
        }
        Console.WriteLine ($"Journal was saved to {fileName}"); // informative message that the file with a specified fileName was saved.
    }


    // A method for loading the journal from a file
    public void LoadJournalFromFile(string fileName)
    {
      string[] lines = System.IO.File.ReadAllLines(fileName); // reading all lines from the file and storing them in the array called lines

      foreach (string line in lines) //itterating through each line in the lines array
      {
        string[] parts = line.Split("~~"); // split current line into the array of strings called parts using the separator ~~
        // getting 3 pieces of parts array and assigning them to 3 sting variables
        string dateAndTime = parts[0];
        string prompt = parts[1];
        string _userInput = parts[2];

        Entry entry = new Entry(dateAndTime, prompt, _userInput); // creating new Entry object using the above variables
        _allEntries.Add(entry); // adding the created entry object to _allEntries list
      }
      Console.WriteLine("Journal loaded sucesfully."); // informative message
    }
}

    