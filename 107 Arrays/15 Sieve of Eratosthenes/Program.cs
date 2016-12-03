using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxN = int.Parse(Console.ReadLine());
            bool[] primes = new bool[maxN+1];

            for (int i = 2; i < Math.Sqrt(maxN); i++)
            {
                if (primes[i] == false)
                {
                    for (int j = i*i; j < maxN; j+=i)
                    {
                        primes[j] = true;
                    }
                }
                
            }
            for (int i = maxN; i >= 2; i--)
            {
                if (primes[i] == false)
                {
                    Console.WriteLine(i); break;
                }
            }
        }
    }
}
