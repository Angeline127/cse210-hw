using System;


//Scripture Class
public class Scripture {
    private Reference _reference;
    private List<Word> _words;
    private int _HiddenWordCount;
    private Random _random;

    public Scripture (string book, int chapter, int StartVerse, int EndVerse, string _text)
    {
        _reference = new Reference(book, chapter, StartVerse, EndVerse);
        _words = new List<Word>();
        _HiddenWordCount = 0;
        _random = new Random();

        string[] WordStrings = _text.Split(' ');

        foreach (string WordString in WordStrings)
        {
            _words.Add(new Word(WordString));
        }
    }

    public void HiddenRandomWord(int NumWords)
    {
        int WordsToHide = Math.Min(NumWords, _words.Count - _HiddenWordCount);
        for (int i = 0; i <  WordsToHide; i++)
        {
            int index; 
            do
            {
                index = _random.Next(0, _words.Count);

            } while (_words[index].IsHiddens());

            _words[index].SetHidden(true);
            _HiddenWordCount++;
        }
           
    }

    public string GetHiddenText()
    {
        String HiddenText = "";

        foreach (Word word in _words )
        {
            HiddenText += word.IsHiddens() ? new string('_', word.GetText().Length) :  word.GetText();
            HiddenText += " ";
        }

            return $"{_reference.ToString()} {HiddenText.Trim()}";
        }

    public int CountHiddenWords()
    {
        return _HiddenWordCount;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }
}
