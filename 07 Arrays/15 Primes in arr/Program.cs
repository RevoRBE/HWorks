using System;
using System.Linq;

namespace Arrays
{
    class Prime_Numbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] A = new bool[N + 1];
            A = Enumerable.Repeat(true, N + 1).ToArray();

            for (int i = 2; i < Math.Sqrt(N); i++)
            {
                if (A[i] == true)
                {
                    for (int j = i * i; j <= N; j += i)
                    {
                        A[j] = false;
                    }
                }
            }
            for (int i = N; i >= 2; i--)
            {
                if (A[i] == true)
                {
                    Console.WriteLine(i); break;
                }
            }
        }
    }
}