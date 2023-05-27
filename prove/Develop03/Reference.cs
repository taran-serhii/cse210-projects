public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructors
    public Reference(string bookName, int chapterNumber, int startVerseNumber) // constructor for one verse scripture
    {
        _book = bookName;
        _chapter = chapterNumber;
        _startVerse = startVerseNumber;
        _endVerse = startVerseNumber; // By default, assumes a single verse
    }

    public Reference(string bookName, int chapterNumber, int startVerseNumber, int endVerseNumber) // constructor for multiple verses scripture
    {
        _book = bookName;
        _chapter = chapterNumber;
        _startVerse = startVerseNumber;
        _endVerse = endVerseNumber; 
    }

    public string DisplayReference() // a method which returns a formated string of the reference
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

}

