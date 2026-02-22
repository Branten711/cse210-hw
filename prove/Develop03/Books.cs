public class Books
{
    private string _referance;
    private string _scripture;
    private List<string> _scriptures = new List<string>
    {
        "",
        "Proverbs 3:5-6>Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.",
        "John 3:16>For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Philippians 4:13>I can do all things through Christ which strengtheneth me.",
        "Psalm 23:1>The Lord is my shepherd; I shall not want." 
    };
    public Books()
    {
         Random rando = new Random();
        int ran = rando.Next(1,_scriptures.Count());
        string[] prts = _scriptures[ran].Split(">");
        _referance = prts[0];
        _scripture = prts[1];
    }
    public string GetReferance()
    {
        return _referance;
    }
    public string GetScripture()
    {
        return _scripture;
    }
}
