using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public int Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int StartVerse
    {
        get { return _startVerse; }
        set { _startVerse = value; }
    }

    public int EndVerse
    {
        get { return _endVerse; }
        set { _endVerse = value; }
    }

    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
            return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}