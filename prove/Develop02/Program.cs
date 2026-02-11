using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal run = new Journal();
        run.Run();
        Console.WriteLine("Thank you for writing in your journal");
    }
}