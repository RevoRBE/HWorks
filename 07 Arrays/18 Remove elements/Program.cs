using System;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] LIS = new int[n];
        for (int i = 0; i < n; i++)
        {
            LIS[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i])
                {
                    LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                }
            }
        }
        Console.WriteLine(n - LIS.Max());
    }
}