using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[int.Parse(Console.ReadLine())];
        int count = 1;
        int maxCount = 0;
        int numKeep = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
                if (maxCount < count)
                {
                    maxCount = count;
                    numKeep = arr[i];
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(numKeep + " ({0} times)", maxCount);
    }
}
