using System;
using System.Numerics;

namespace 10.NFactorial
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            NFactorial(n, ref factorial);
            Console.WriteLine(factorial);
        }
        static void NFactorial(int n, ref BigInteger factorial)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        }
    }
}