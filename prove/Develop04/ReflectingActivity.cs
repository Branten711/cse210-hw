public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(): base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    public string GetRandomPrompt()
    {
        Random rando = new Random();
        int ran = rando.Next(1,_prompts.Count());
        string prompt = _prompts[ran];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random rando = new Random();
        int ran = rando.Next(1,_questions.Count());
        string question = _questions[ran];
        return question;
    }
    public void RunReflectingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Loading(4);
        Console.WriteLine("\nConsider the following prompt:\n");
        string prmpt = GetRandomPrompt();
        Console.WriteLine($"--- {prmpt} ---");
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();
        if (enter == ""){}
        else
        {
            Console.WriteLine("You didn't press enter but continuing anyways.");
            Countdown(3);
            Console.WriteLine();
        }
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        Countdown(5);
        Console.Clear();
        Console.WriteLine($"--- {prmpt} ---\n");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($">{GetRandomQuestion()}");
            Loading(8);
            Console.WriteLine("\n");
        }
        Console.WriteLine();
        DisplayEndMessage();

    }

}