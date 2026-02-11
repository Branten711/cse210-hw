public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
     static List <string> journalPrompts = new List<string>
{
     "What was the best part of your day?",
    "What challenged you today?",
    "What are you grateful for?",
    "What did you learn today?",
    "How did you see personal growth today?"
};
        static Random prom = new Random();
        string prompt = journalPrompts[prom.Next(journalPrompts.Count)];
  public void Create()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.Write("Do you have a prompt you would like to use? (yes / no): ");
        string ans = Console.ReadLine();
        if (ans == "yes")
        {
            Console.Write("Enter Prompt:> ");
            prompt = Console.ReadLine();
            _prompt=prompt;
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.Write(">");
            _entry = Console.ReadLine();
        }
        else
        {
            Console.WriteLine(prompt);
            Console.Write(">");
            _entry = Console.ReadLine();
            _prompt = prompt;
        }
        
    }
    public string FormattedEntry()
    {
        return ($"Date: {_date} - Prompt: {_prompt} \n>{_entry}");
    }


}

