using System;

public class Fraction {
    private int _top;
    private int _buttom;

    public Fraction() 
    {
        _top = 1;
        _buttom = 1;
    }

    public Fraction (int wholeNumber)
    {
        _top = wholeNumber;
        _buttom = 1;
    }


    public Fraction (int top, int buttom)
    {
        _top = top;
        _buttom = buttom;
    }

    public string GetFractionString() 
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_buttom}";
        return text;
    }

    public double GetDecimalValue()
    {
         // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_buttom;
    }


}
