public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>();
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public string GetRandomPrompts()
    {
        Random rando = new Random();
        int ran = rando.Next(1,_prompts.Count());
        string prompt = _prompts[ran];
        return prompt;
    }
    public void RunListingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompts()} ---\n");
        Console.Write("You may begin in:");
        Countdown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
        Console.Write(">");
        string response = Console.ReadLine();
        _responses.Add(response);
        }
        Console.WriteLine($"You listed {_responses.Count()} items!");
        Console.WriteLine();
        DisplayEndMessage();
    }

}