public class BreathingActivity : Activity
{
    
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}
    
    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Loading(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in...");
            Countdown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            Countdown(5);
        }
        Console.WriteLine("\n");
        DisplayEndMessage();

    }
}