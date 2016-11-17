using System;

namespace CompareFloats1
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if      ((a>=b & a>=c)&& b>=c)
            {
                Console.WriteLine("{0} {1} {2}",a , b, c);
            }
            else if ((a>= c && a>= b) && c>= b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if ((b>=a && b>=c)&& a>=c)
            {
                Console.WriteLine("{0} {1} {2}",b , a, c);
            }
            else if ((b>= a && b>= c) && c>= a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if ((c>=b && c>=a)&& a>=b)
            {
                Console.WriteLine("{0} {1} {2}",c , a, b);
            }
            else if ((c>=a && c>=b)&&b>=a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
