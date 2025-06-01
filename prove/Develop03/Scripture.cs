public class Scripture
{
    // Hides scripture reference
    private Reference _reference;
    
    // Creates and hides a list of words from the scriptrue reference
    private List<Word> _words;

    // Takes each word in the scripture reference and makes them into their own string and then adds to list
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hides 3 random words from the scripture at a time until none left
    public void HideWords(int count = 3)
    {
        var rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[rand.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }

    // Makes sure all words in scripture are hidden.
    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    } 

    // Displays text after each time hiding words.
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{text}";
    }
}