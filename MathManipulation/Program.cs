using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abs of the number -7 is {0}", Math.Abs(-7));
        Console.WriteLine("The bigger number between 3 and 23 is {0}", Math.Max(3, 23));
        Console.WriteLine("Square of 120 is {0}", Math.Sqrt(10));
        Console.WriteLine("E is {0}", Math.E);

        int width = 10;
        int height = 4;
        int area = (width * height) / 2;
        Console.WriteLine("The area of triangle with width = 10 and height = 4 is {0}", area);
    }
}