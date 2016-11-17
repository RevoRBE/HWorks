using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (numberN <= 100)
            {
                for (int i = 2; i <= Math.Sqrt(numberN); i++)
                {
                    if (numberN % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (numberN == 1 || numberN < 1)
                {
                    isPrime = false;
                }
                Console.WriteLine(isPrime.ToString().ToLower());
            }
        }
    }
}