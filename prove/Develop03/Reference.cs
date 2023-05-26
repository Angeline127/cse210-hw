using System;

//Reference class
public class Reference {
    private string _book;
    private int _chapter;
    private int _StartVerse;
    private int _EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _StartVerse = verse;
        _EndVerse = verse;
    }

    public Reference(string book, int chapter, int StartVerse, int EndVerse)
    {
        _book = book;
        _chapter = chapter;
        _StartVerse = StartVerse;
        _EndVerse = EndVerse;
    }

    public override string ToString()
    {
        if (_StartVerse == _EndVerse)
        {
            return $"{_book} {_chapter}:{_StartVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_StartVerse}-{_EndVerse}";
        }
    }
   
}
