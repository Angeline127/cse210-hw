using System;


//Word class
public class Word {
    private string _text;
    private bool _IsHidden;

    public Word(string _text)
    {
        this._text = _text;
        _IsHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public bool IsHiddens()
    {
        return _IsHidden;
    }

    public void SetHidden(bool hidden)
    {
        _IsHidden = hidden;
    }
}