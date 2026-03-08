using System.ComponentModel.DataAnnotations;

public class Activity
{
    protected string _name;
    protected string _descrition;
    protected int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _descrition = description;

    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_descrition}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);


    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        Loading(6);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        Loading(6);
    }
    public void Loading(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
    public void Pong(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            Console.Write("|- |");
            Thread.Sleep(80);
            Console.Write("\b\b\b \b\b\b");

            Console.Write("| -|");
            Thread.Sleep(80);
            Console.Write("\b\b\b \b\b\b"); 
        }
        Console.WriteLine("\nThere is always more in life than there seems at a glance.");
    }
    public void Animation(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            Console.Write("<");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("v");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write(">");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("v");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
    public void Countdown(int time) // time must be single digit.
    {
        for( int i = time; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SetDuration (int seconds)
    {
        _duration = seconds;
    }
    public int GetDuration()
    {
        return _duration;
    }
    
}
