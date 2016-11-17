using System;

namespace Trailing0InNFact
{
    class Trailing0InNFact
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            int maxPower = (int)Math.Log(N, 5);

            for (int power = 1; power <= maxPower; power++)
            {
                count += N / (int)Math.Pow(5, power);
            }

            Console.WriteLine("{0}", count);
        }
    }
}