using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixing_numbers
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

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] %= 10);
            }
        }
    }
}
