public class Word 
{
    // Attributes
    private string _text;
    private bool _hidden;

    // Constructor
    public Word(string wordText)
    {
        _text = wordText;
        _hidden = false; // the word is not hidden by default
    }

    public string GetText()
    {
        if(_hidden)
        {
            // if the word is hidden, displaying blanks for each letter
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void SetText(string wordText)
    {
        _text = wordText;
    }

    public bool IsHidden()
    {
        return _hidden; // returns a value of _hidden atribute
    }

    public void SetHidden(bool isHidden) // takes the parameter isHidden, which indicates whether or not the word should be hidden
    {
        _hidden = isHidden; // assigns the value of isHidden to _hidden atribute
    }
}