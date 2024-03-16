using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        string[] strings=text.Split(" ");
        _reference = Reference;

        foreach (string i in strings)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
 
    }
    public void HideRandomWords(int numberToHide)
    {
        int options = _words.Count();
        int n = 0;
        Random randomGenerator= new Random ();
        
        while (n != numberToHide)
        {
            int var = randomGenerator.Next(0, options);
            _words[var].Hide();
            n+=1;
        }


    }
    public string GetDisplayText()
    {
        string display = "";
        foreach (Word i in _words)
        {
            string text=i.GetDisplayText();
            display+=$" {text}";
        }
        return _reference.GetDisplayText() + display;
        
    }
        public bool IsCompletelyHidden()
    {
        int num = 0;
            foreach (Word i in _words)
            {
                if(i.IsHidden())
                {
                    num += 1;
                }
                else
                {
                    num = 0;
                }

            }
        if(num == _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
