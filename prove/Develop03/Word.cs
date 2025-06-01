// using Microsoft.Win32.SafeHandles;

public class Word
{
    // Grabs and hides each word from text
    private string _text;
    // See whether the words in scripture is hidden
    private bool _isHidden;

    // Grabs each word and makes in not hidden, makes sure it is visible to start
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    // Creates underscore where words are hidden.
    public string GetDisplayText()
    {
       return _isHidden ? "_____" : _text;
    }
    
}