using System;

public class Reference
{
    private int _startVerse;
    private int _endVerse;
    private int _Chapter;
    private string _Book;

  public Reference(string book, int chapter, int verse)
    {
        _Book = book;
        _Chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

 public Reference(string book, int chapter, int startverse, int endverse)
    {
        _Book = book;
        _Chapter = chapter;
        _startVerse = startverse;
        _endVerse = endverse;
    }

    public string Getdisplaytext()
    {
        if(_startVerse == _endVerse)
        {
            return $"{_Book} {_Chapter} {_startVerse}";
        }
        else
        {
            return $"{_Book} {_Chapter} {_startVerse} -{_endVerse}";   
        }

    }
}
