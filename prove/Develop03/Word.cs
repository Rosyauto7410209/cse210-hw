using System;

class Word
{
    private bool _hidden;
    private string _text;


public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

public void Hidewords()
    {
        _hidden = true;
    }
public bool ishidden()
    {
       return _hidden;
    }

    public string GetDisplaytext()
    {
        return _hidden ? "___" : _text;

    }

}