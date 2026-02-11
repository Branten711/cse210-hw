using System;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Sandbox World!");
            //Console.WriteLine("World");
            //int x = 5;
            //Console.WriteLine("Value of x is " + x);
            // Console.Write("What is your favorite color? ");
            // string color = Console.ReadLine();
            // Console.Write("Please enter a noun: ");
            // string non = Console.ReadLine();
            // Console.Write("Please enter a adjective: ");
            // string adj = Console.ReadLine();
            // Console.Write("Please enter a verb: ");
            // string vrb = Console.ReadLine();
            // Console.WriteLine("Your sentence is...");
            // Console.WriteLine($"The {adj} {non} likes to {vrb}");
            //Getting a number 
            // Console.Write("Please enter a number: ");
            // string num = Console.ReadLine();
            // //Console.Readline() always returns a string must change to a int.
            // int number = int.Parse(num);
            // int y = 5;
            // if (number > 5 || number < 5)
            // {
            //     Console.WriteLine("Not 5");

            // }
            // else
            // {
            //     Console.WriteLine($"Number is {number}");
            // }
            // Console.WriteLine(number);
            // Console.WriteLine(y);

            // int number = 8;
            // if (number < 10 && number > -10) 
            // {
            //     Console.WriteLine($"Your number {number} is singgle digit");
            // }
            // else if (number >= 10 || number <= -10)
            // {
            //     Console.WriteLine($"Your number {number} is double digit");
            // } 

            // //While loop
            // string response = "yes";
            // //do ()
            // // goes through loop
            // // while () :::: Checks at the end of the loop instead of the begining.
            // while (response == "yes")
            // {
            //     Console.Write("Do you want to continue? ");
            //     response = Console.ReadLine();// if this is yellow can go !; and fixes it
            // }
            // // foreach loop
            // List<string> words = new List<string>();
            // words.Add("cold");
            // words.Add("snow");
            // words.Add("soccer");

            // foreach (string word in words)
            // {
            //     Console.WriteLine(word);
            // }

            // for loop
            //can also initialize the variable i up above
            //int i = 0 

            // counting from 10-1
            // for(int i = 10; i >= 1; i--)
            // {
            //     Console.WriteLine(i);
            // }
            // // Counting from 0-10
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // List<string> words = new List<string>();
            // words.Add("cold");
            // words.Add("snow");
            // words.Add("soccer");

            // for (int i = words.Count - 1;i >= 0; i--)
            // {
            //     Console.WriteLine(words[i]);
            // }
            // void DisplayMessage(string name)
            // {
            //     Console.WriteLine($"Hello {name}");
            // }
            // DisplayMessage("World");
            // int Add(int a, int b)
            // {
            //     return a + b;
            // }
        // List<int> numbers = new List<int>();
        // int number = 1;
        // int run = 0;
        // while (run != 10)
        // {
        //     Console.Write("Enter number: ");
        //     string i = Console.ReadLine();
        //     number = int.Parse(i);
        //     if (number != 0)
        //     {
        //       run++;
        //       numbers.Add(number); 
        //     }
            
        // }
        // List<int> evens = new List<int>();
        // foreach (int num in numbers)
        //     {
                   
        //         if (num % 2 == 0)
        //         {
        //            evens.Add(num); 
        //         } 
        //     }
        // foreach (int even in evens)
        //     {
        //         Console.Write($"{even}, ");
        //     }
        // Console.WriteLine("");
        // Console.Write("Please enter string: ");
        // string str = Console.ReadLine();
        // for ( int i = str.Length - 1; i >= 0; i--)
        //     {
        //         Console.Write(str[i]);
                
        //     }
        // Console.WriteLine("");
        // char [] array = str.ToCharArray();
        
        // Array.Reverse(array);
        // new string (array);
        // Console.WriteLine(array);
        ///////////////////////// Starting Progrmming with classes /////////////////////////
        /// 
        /// class: is a recipe or blueprint
        /// object: Choclate cake or building (can build liots of different objects like m1 Ex: Message m1 = new Message();)
        /// 
        /// TitleCase-Classes and Methods
        /// camelCase
        /// 
        /// ////////Abstraction////////
        /// 
        /// Class is a container for variables and functions
        // Console.WriteLine("Hello world");
        // Counter myCounter = new Counter();
        // Counter.Run();
        // Message m1 = new Message();
        // m1._message = "Send Help!";
        // m1._priority = 1;
       
        // Message m2 = new Message();
        // m2._message = "Please pick up some carrots at the store";
        // m2._priority = 3;
        // Console.WriteLine(m1.GetMessage());
        // Console.WriteLine(m2.GetMessage());

        //  SecretFamilyRecipe pb = new SecretFamilyRecipe();
        //  pb.Display();


        }
    }
}
