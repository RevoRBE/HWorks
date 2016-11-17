using System;

namespace CompareN
{
    class CompareN
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Math.Max(a, b));
        }
    }
}