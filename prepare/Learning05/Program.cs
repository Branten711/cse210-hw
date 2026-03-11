using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 4);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());
        
        Console.WriteLine();
        Rectangle r1 = new Rectangle("yellow", 4, 5);
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());

        Console.WriteLine();
        Circle c1 = new Circle("white", 2);
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());
        Console.WriteLine("**************************");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);
        foreach(Shape s in shapes)
        {
            Console.Write("Color: ");
            Console.WriteLine(s.GetColor());
            Console.Write("Area: ");
            Console.WriteLine(s.GetArea());
        }
        

    }
}