using System;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double circlePointX = x - 1;
            double y = double.Parse(Console.ReadLine());
            double circlePointY = y - 1;
            double circleRadius = 1.5;
            double point = (circlePointX * circlePointX) + (circlePointY * circlePointY);
            bool isInCircle = point <= circleRadius * circleRadius;
            double rectangleHeight = 2;
            double rectangleWidth = 6;
            double topY = 0 + (rectangleHeight / 2);
            double rightX = 0 + (rectangleWidth / 2);
            double bottomY = 0 - (rectangleHeight / 2);
            double leftX = 0 - (rectangleWidth / 2);
            double rectanglePointX = x - (-1);
            double rectanglePointY = y - 1;
            bool isInRec = ((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX));
            if ((isInCircle) && (isInRec))
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
