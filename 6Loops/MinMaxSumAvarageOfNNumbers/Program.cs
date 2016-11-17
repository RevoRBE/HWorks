using System;
using System.Linq;

namespace MinMaxSumAvarageOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            double[] arrayOfDoubles = new double[numN];

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                arrayOfDoubles[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:F2}", arrayOfDoubles.Min());
            Console.WriteLine("max={0:F2}", arrayOfDoubles.Max());
            Console.WriteLine("sum={0:F2}", arrayOfDoubles.Sum());
            Console.WriteLine("avg={0:F2}", arrayOfDoubles.Average());
        }
    }
}
