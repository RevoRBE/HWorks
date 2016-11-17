using System;

namespace Dividable
{
    class DivideBy7and5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool firstDiv = (number % 7 == 0);
            bool secondDiv = (number % 5 == 0);
            if (firstDiv && secondDiv)
            {
                Console.WriteLine("true {0}", number);
            }
            else
                Console.WriteLine("false {0}", number);
        }
    }
}