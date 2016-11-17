using System;

namespace _06_Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            foreach (int i in array) Console.WriteLine(i); 
        }
    }
}
