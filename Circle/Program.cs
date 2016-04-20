using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double circleRadius = 2;
            double point = (x * x) + (y * y);
            bool isInCircle = point <= circleRadius * circleRadius;
            if (isInCircle)
            {
                Console.WriteLine("yes {0:F2}", Math.Sqrt(point));
            }
            else
            {
                Console.WriteLine("no {0:F2}", Math.Sqrt(point));
            }
        }
    }
}
