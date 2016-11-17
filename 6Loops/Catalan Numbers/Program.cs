using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger Factorial2N = 1;
            BigInteger FactorialN = 1;
            BigInteger FacturialNPlus1 = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                Factorial2N *= i;
                if (i <= n)
                {
                    FactorialN *= i;
                }
            }
            for (int i = 1; i <= n + 1; i++)
            {
                FacturialNPlus1 *= i;
            }
            Console.WriteLine("{0}", Factorial2N / (FactorialN *
            FacturialNPlus1));
        }
    }
}