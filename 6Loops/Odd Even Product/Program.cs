using System;

namespace LoopsCSharp
{
    class LoopsCSharp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int num = numbers.Length;
            long oddProduct = 1L;
            long evenProduct = 1L;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                    oddProduct *= Convert.ToInt64(numbers[i]);
                else
                    evenProduct *= Convert.ToInt64(numbers[i]);
            }
            if (oddProduct == evenProduct)
                Console.WriteLine("yes {0}", evenProduct);
            else
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}