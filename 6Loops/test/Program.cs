using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] numbers = new long[N];
            long sum = 0;
            decimal average;

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(numbers);                                                //НЕ РАБОТИ!!!

            for (int i = 0; i < N; i++)
            {
                sum += numbers[i];
            }

            average = ((decimal)sum / N);

            Console.Write("min=");
            Console.WriteLine("{0:F2}", numbers[0]);
            Console.Write("max=");
            Console.WriteLine("{0:F2}", numbers[N - 1]);
            Console.Write("sum=");
            Console.WriteLine("{0:F2}", sum);
            Console.Write("avg=");
            Console.WriteLine("{0:F2}", Math.Round(average, 2));
        }
    }
}