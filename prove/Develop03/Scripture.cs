public class Scripture
{
    // Attributes
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text) // takes two parameters - reference object and scripture text
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>(); // crates a new empty list called _words
        InitializeWords(); // calls the method to populate the above created list
    }

     public Reference GetReference()
    {
        return _reference;
    }

    private void InitializeWords()  // a method to populate the _words list based on scripture text
    {
        // Split the scripture text into individual words
        string[] wordArray = _text.Split(' '); // splits the _text string into individual words using 'space' as a separator

        // Create a Word object for each word and add it to the _words list 
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);  // creates a new Word object for each word
            _words.Add(word); // adds each word to the _words list
        }
    }

public void HideRandomWords()
    {
        Random random = new Random();

        int wordsToHide = random.Next(2, 4); // Generate a random number of words to hide (2 or 3)

        // Create a new list called unhiddenWords that contains all the words in _words list that are not currently hidden. 
        // This is done using Where method and the !word.IsHidden() condition.
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();  // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0

        while (wordsToHide > 0 && unhiddenWords.Count > 0)  // a loop runs until the desired number of words is hidden or there are no more unhidden words available
        {
            int randomIndex = random.Next(unhiddenWords.Count); //generate a random index within the range of the unhiddenWords list using
            unhiddenWords[randomIndex].SetHidden(true); // hide the word
            unhiddenWords.RemoveAt(randomIndex);  // remove the word from the unhiddenWords list to ensure it's not selected again in the next iteration
            wordsToHide--; // minus one to wordsToHide counter
        }
    }


    public bool AreAllWordsHidden() 
    {
        // Check if all words in the scripture are hidden
        foreach (Word word in _words) // iterate through the each word in the _words list
        {
            if (!word.IsHidden())
            {
                return false; // if any word in the list is not hidden, return false
            }
        }

        return true;
    }

    public void DisplayScripture()
    {
        Console.Clear(); // clean the sonsole screen

        // Display the scripture reference
        Console.WriteLine(_reference.DisplayReference());  //calls the DisplayReference() method on the _reference object, which belongs to the Reference class
        Console.WriteLine();

        // Display the scripture text with hidden words
        foreach (Word word in _words)  // iterates over each Word object in the _words list
        {
            // For each word, calls the GetText() method on the word object to retrieve the word's text. 
            // If the word is hidden, it will return a string with underscores representing the hidden letters. 
            // If the word is not hidden, it will return the original text of the word.
            // The retrieved text is then printed on the console using Console.Write(), followed by a space (' ') to separate each word.
            Console.Write(word.GetText() + " "); 
        }

        Console.WriteLine();
    }
}