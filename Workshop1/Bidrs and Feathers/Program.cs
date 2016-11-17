using System;

namespace Bidrs_and_Feathers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint b = 1000; //uint.Parse(Console.ReadLine());
            uint f = 450; //uint.Parse(Console.ReadLine());
            double avFpB = (double)f / (double)b;
            if (b % 2 == 0)
            {
                Console.WriteLine("{0:F4}", avFpB * 123123123123);
            }
            else
            {
                Console.WriteLine("{0:F4}", avFpB / 317);
            }
        }
    }
}