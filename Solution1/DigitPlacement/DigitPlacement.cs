using System;

namespace DigitPlacement
{
    class FourDigits
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());

            uint d = number % 10;
            uint c = (number / 10) % 10;
            uint b = (number / 100) % 10;
            uint a = (number / 1000) % 10;

            Console.WriteLine("{0}", a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}