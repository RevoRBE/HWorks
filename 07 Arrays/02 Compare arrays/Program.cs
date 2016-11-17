using System;
using System.Linq;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            //bool equal = new bool();
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            } 
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            if (array1.SequenceEqual(array2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            //for (int i = 0; i < n; i++)
            //{
            //    if (array1[i] == array2[i])
            //    {
            //        equal = true;
            //    }
            //    else
            //    {
            //        equal = false;
            //        break;
            //    }
            //}
            //if (equal == true)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not equal");
            //}
        }
    }
}
