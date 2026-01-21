using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        int run = 0;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string i = Console.ReadLine();
            number = int.Parse(i);
            if (number != 0)
            {
              run++;
              numbers.Add(number); 
            }
            
        }
        int total = 0;
        int large = 0;
        foreach (int num in numbers)
        {
            if (num > large)
            {
                large = num;
            }
            total += num;
        }
        double average = total / run;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");

    }
}