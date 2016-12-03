using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void SwapInts(int[] array, int position1, int position2)
        {
            int temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= n - 1; i += 2)
            {
                if (arr[i] > arr[i + 1])
                {
                    SwapInts(arr, i, i + 1);
                }
            }
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }

            //mylist.Add(a);
            //Array.Sort(arr);

        }
    }
}