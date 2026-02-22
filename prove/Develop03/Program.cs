using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Books b1 = new Books();
        string referance = b1.GetReferance();
        string scripture = b1.GetScripture();
        Referance r1 = new Referance(referance);
        Scripture s1 = new Scripture(r1, scripture);
        s1.Run();
    }
}