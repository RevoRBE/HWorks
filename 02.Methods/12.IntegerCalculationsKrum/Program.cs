using System;
using System.Linq;

namespace IntegerCalculationsKrum
{
    class Program
    {
        static void Main()
        {
            string[] strs = Console.ReadLine().Split(' ');
            int[] ints = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                ints[i] = int.Parse(strs[i]);
            }

            int minimum = MinFromArr(ints);
            int maximum = MaxFromArr(ints);
            float average = AvgFromArr(ints);
            int sum = SumFromArr(ints);
            long product = ProFromArr(ints);

            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}",average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }

        private static int MinFromArr(int[] array)
        {
 	        return array.Min();
        }
        private static int MaxFromArr(int[] array)
        {
            return array.Max();
        }
        private static float AvgFromArr(int[] array)
        {
            return (float)array.Average();
        }
        private static int SumFromArr(int[] array)
        {
            return array.Sum();
        }
        private static long ProFromArr(int[] array)
        {
            long product = 1;
            foreach (int element in array)
            {
                product *= element;
            }
            return product;
        }
    }
}
