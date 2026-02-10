using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string []parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplaytext()
    {
        List<string> displaywords = new List<string>();
        foreach (Word word in _words)
        {
            displaywords.Add(word.GetDisplaytext());
        }
        return $"{_reference.Getdisplaytext()} {string.Join(" ",displaywords)}";
    }

    public void HideRandom(int count)
    {
        Random random = new Random();
        int unhidden = 0;
        foreach (Word word in _words)
        {
            if (!word.ishidden())
            {
                unhidden++;
            }


        }
            if (unhidden < count)
            {
                count = unhidden;
            }
        for ( int i = 0; i < count; i++)
        {
            bool wordfound = false;
            while (wordfound == false)
            {
            int randomindex = random.Next(_words.Count);
            if (!_words[randomindex].ishidden())
            {
            _words[randomindex].Hidewords();    
            wordfound = true;              
            }             
            } 
        }
        

    }

    public bool isallhidden()
    {
        foreach (Word word in _words)
        {
            if (!word.ishidden())
            {
                return false;

            }
        }
        return true;
    }
    
}