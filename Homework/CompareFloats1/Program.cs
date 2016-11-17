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
            if (a>=b & a>=c)
            {
                Console.WriteLine(a);
            }
            else if (a<=b && b>=c)
            {
                Console.WriteLine(b);
            }
            else if (c>=b && b<=c)
            {
                Console.WriteLine(c);
            }
        }
    }
}
