public class Fraction
{
    // Member variables
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction() // Constructor that has no parameters that initializes the number to 1/1.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator) // Constructor that has one parameter for the top and that initializes the denominator to 1. 
    // So that if you pass in the number 5, the fraction would be initialized to 5/1.
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator) // Constructor that has two parameters, one for the top and one for the bottom.
    {
        _top = numerator;
        _bottom = denominator;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;

    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}