using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //  D = b*b - 4ac
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (discriminant == 0)
            {
                double x = (-1 * b) / (2 * a);
                Console.WriteLine("{0:F2}", x);
            }
            else
            {
                double x1 = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = ((-1 * b) + Math.Sqrt(discriminant)) / (2 * a);
                if (x1 < x2)
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:0.00}", x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
            }
        }
    }
}