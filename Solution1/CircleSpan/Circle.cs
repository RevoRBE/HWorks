using System;

namespace Circle
{
    class CircleSpan
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double isPointIn = (x * x) + (y * y);
            double distance = Math.Sqrt(isPointIn);
            if (isPointIn <= 2 * 2)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
                Console.WriteLine("no {0:F2}", distance);
        }
    }
}
