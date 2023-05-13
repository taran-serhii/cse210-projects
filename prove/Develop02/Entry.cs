public class Entry
{
    // Member variables
    public string _dateAndTime;
    public string _prompt;
    public string _userInput;

    // Constructor to create a new Entry object
    public Entry(string dateAndTime, string prompt, string response)
    {
        _dateAndTime = dateAndTime;
        _prompt = prompt;
        _userInput = response;
    }

    public override string ToString()
    {
    return $"{_dateAndTime}: {_prompt}\n{_userInput}\n"; // returns a string representation of the entry object. 
    }
}