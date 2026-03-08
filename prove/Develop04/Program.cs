using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool run = true;
        while (run == true)
        {
            Console.WriteLine("Welcome to the Activity Program.");
            Console.WriteLine("Reflection often begins with a single unexpected key.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("5. Hint");
            Console.Write("Select a choice from the menu: ");
            string entry = Console.ReadLine();
            if (entry == "1")
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.RunBreathingActivity();
            }
            else if (entry == "2")
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.RunReflectingActivity();
            }
            else if (entry == "3")
            {
                ListingActivity l1 = new ListingActivity();
                l1.RunListingActivity();
            }
            else if (entry == "4") run = false;

            else if (entry == "5")
            {
                
                Console.WriteLine("It is the month right before December.");
                Activity a2 = new Activity("","");
                a2.Loading(5);
                Console.WriteLine("Its a number.");

                
            }
            else if (entry == "11")
            {
                Activity a1 = new Activity("","");
                a1.Pong(5);
                a1.Animation(5);
            }
            else
            {
                Console.WriteLine("You did something Wrong :( \n try again");
                Thread.Sleep(5000);
            }
            Console.Clear();
        }
        

    }

}