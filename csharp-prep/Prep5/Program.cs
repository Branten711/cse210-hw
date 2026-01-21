using System;
using System.Runtime.CompilerServices;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string n = Console.ReadLine();
        int number = int.Parse(n);
        return number;
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string y = Console.ReadLine();
        year = int.Parse(y);
    }
    static int SquareNumber(int favorite)
    {
        int square = favorite * favorite;
        return square;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favorite = PromptUserNumber();
        int year;
        PromptUserBirthYear(out year);
        int age = 2026-year;
        int square = SquareNumber(favorite);
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, your will turn {age} this year.");
    }
}