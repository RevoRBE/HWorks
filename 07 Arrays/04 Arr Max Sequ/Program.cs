using System;


namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int maxCount = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    maxCount = (counter > maxCount) ? counter : maxCount; 
                }
                else counter = 1;
            }
            Console.WriteLine(maxCount);
        }
    }
}