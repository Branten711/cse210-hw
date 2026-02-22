using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Referance _referance;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private List<string> _scriptures = new List<string>
    {
        "Proverbs 3:5-6: Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.",
        "John 3:16: For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Philippians 4:13: I can do all things through Christ which strengtheneth me.",
        "Psalm 23:1: The Lord is my shepherd; I shall not want." 
    };
    public Scripture(Referance referance, string text)
    {
        _referance = referance;
        _words = new List<Word>();
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int num)
    {
        int hidden = 0;
        while (hidden < num && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }
    public string GetDisplaytext()
    {
        string scripture = _referance.GetReferanceText() + " ";
        foreach (Word word in _words)
        {
            scripture += word.GetWordText() + " ";
        }
        return scripture;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void Run()
    {
        bool run = false;
        while (!run)
        {
            Console.Clear();
            Random random = new Random();
            int number = random.Next(2,6);
            Console.WriteLine();
            Console.WriteLine(GetDisplaytext());
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string enter = Console.ReadLine();
            if (IsCompletelyHidden())
                {
                    run = true;
                    Console.WriteLine();
                } 
            if (enter == "")
            {
                HideRandomWords(number);
            }
            else if (enter == "quit")
            {
                Console.Clear();
                run = true;
            }
        }
    }
    public string GetScripture()
    {
        Random rando = new Random();
        int ran = rando.Next(0,_scriptures.Count());
        return _scriptures[ran];
    }
    public void GetSplit(string scripture)
    {
        string[] prts = scripture.Split(":");

    }
}