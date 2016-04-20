using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                if (x1 > x2)
                {
                    Console.WriteLine("{1:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);
                }
                
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("{0:F2}", x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}