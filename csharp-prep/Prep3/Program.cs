using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        // Console.Write("What is the magic number: ");
        // string n = Console.ReadLine();
        // int magic = int.Parse(n);
        int guess = -1;
        int run = 0;
        while (magic != guess)
        {
            Console.Write("What is your guess: ");
            string gus = Console.ReadLine();
            guess = int.Parse(gus);


            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            run++;

        }
        Console.WriteLine($"It took you {run} guesses.");
    }
}