using System;


namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int prevNum = arr[n - 1];
            int counter = 1;
            int maxCount = 1;

            for (int i = 1; i < arr.Length+1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] == arr[i-1])
                {
                    counter++;
                    if (counter < maxCount)
                    {
                        maxCount = counter;
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}