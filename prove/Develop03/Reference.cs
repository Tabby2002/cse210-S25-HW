public class Reference
{
    // Grabs book name
    private string _book;
    // Grabs chapter number
    private int _chapter;
    // Grabs first verse number
    private int _firstverse;
    // Grabs end verse number, if there is one
    private int? _endVerse;

    // If the reference is a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstverse = verse;
        _endVerse = null;
    }

    // If reference has multiple scriptures
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstverse = verse;
        _endVerse = endVerse;
    }

    // Display scripture reference whether single or multiple verses
    public string GetDisplayText()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_firstverse}-{_endVerse}"
            : $"{_book} {_chapter}:{_firstverse}";
    }
}