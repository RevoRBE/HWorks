using System;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(string.Join("\n", i));
            }
        }
    }
}