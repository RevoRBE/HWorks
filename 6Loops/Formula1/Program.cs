using System;
using System.Numerics;

namespace Formula1
{
    class Program
    {
        static void Main()
        {
            long numN = long.Parse(Console.ReadLine());
            long numK = long.Parse(Console.ReadLine());
            BigInteger factorialNtoK = 1;
            for (int i = (int)numN; i > numK; i--)
            {
                factorialNtoK *= i;
            }
            BigInteger dividerFactorial = 1;
            for (int j = 2; j <= (numN - numK); j++)
            {
                dividerFactorial *= j;
            }
            BigInteger resultDivision = factorialNtoK / dividerFactorial;
            Console.WriteLine("{0}", resultDivision);
        }
    }
}