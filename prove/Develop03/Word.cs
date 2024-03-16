using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
public class Word
{
 private string _text;
 private bool _isHidden;

public Word(string text)
{
    _text = text;
    _isHidden = false;
}
public void Hide()
{
    _isHidden = true;
}
public void Show()
{
    _isHidden = false;
}
public bool IsHidden(){
    return _isHidden;
}

public string GetDisplayText()
{
    if (_isHidden)
    {
        string underscore = "";
        foreach (char c in _text)
        {
            underscore+="_";
        }
        return underscore;
    }
    else
    {
        return _text;
    }
}

}