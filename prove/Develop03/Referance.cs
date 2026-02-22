using System.Dynamic;

public class Referance
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;
    private string _text;
    public Referance(string referance)
    {
        string[] parts = referance.Split(" ");
        _book = parts[0];
        string[] part = parts[1].Split(":");
        int chapter = int.Parse(part[0]);
        _chapter = chapter;
        string[] prt = part[1].Split("-");
        int verse = int.Parse(prt[0]);
        _verse = verse;
        if (prt.Length > 1)
        {
            int endVerse = int.Parse(prt[1]);
            _endVerse = endVerse;
            _text = ($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else
        {
            _text = ($"{_book} {_chapter}:{_verse}");
        }
    }
    public Referance(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = ($"{book} {chapter}:{verse}");
    }
    public Referance(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _text = ($"{book} {chapter}:{verse}-{endVerse}");
    }
    public string GetReferanceText()
    {
        return _text;
    }
}