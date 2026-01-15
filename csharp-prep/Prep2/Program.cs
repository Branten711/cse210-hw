using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the grade percentage %");
        string grd = Console.ReadLine();

        
        int grade = int.Parse(grd);
        string letter;
        if (grade >= 90)
        {
            letter = "A"; 
        }
        else if (grade >= 80)
        {
            letter = "B"; 
        }
        else if (grade >= 70)
        {
            letter = "C"; 
        }
        else if (grade >= 60)
        {
            letter = "D"; 
        }
        else if (grade <= 60)
        {
            letter = "F"; 
        }
        else
        {
            letter = "An error has occured";
        }

        Console.WriteLine($"The letter grade is {letter}.");
        if (grade < 70)
        {
            Console.WriteLine("Sorry you did not pass. Keep going you got this!");
        }
        else if (grade > 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        
   
    }

}