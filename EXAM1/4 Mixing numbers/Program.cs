using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= numbers.Length-2; i++)
            {
                Console.Write("{0} ", (numbers[i] % 10) * (numbers[i + 1] / 10));
            }
            Console.WriteLine();
            for (int i = 0; i <= numbers.Length - 2; i++)
            {
                Console.Write("{0} ", Math.Abs(numbers[i+1] - numbers[i]));
            }
        }
    }
}