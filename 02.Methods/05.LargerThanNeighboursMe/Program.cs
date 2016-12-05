using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighboursMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayL = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            CountBiggerThanNeighbours(arrayL, array);
        }

        static void CountBiggerThanNeighbours(int arrayL, string[] array)
        {
            int counter = new int();
            int[] numArr = new int[arrayL];
            for (int i = 0; i < arrayL; i++)
            {
                numArr[i] = int.Parse(array[i]);
            }
            for (int i = 1; i < arrayL -1; i++)
            {
                if (numArr[i] > numArr[i - 1] && numArr[i] > numArr[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
