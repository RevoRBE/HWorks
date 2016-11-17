using System;

namespace ExchangeIf
{
    class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secoundNum = double.Parse(Console.ReadLine());
            if (firstNum <= secoundNum)
            {
                Console.WriteLine("{0} {1}", firstNum, secoundNum);
            }
            else
            {
                Console.WriteLine("{1} {0}", firstNum, secoundNum);
            }
        }
    }
}
