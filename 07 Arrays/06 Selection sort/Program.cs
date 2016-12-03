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

            for (int i = 0; i < array.Length-1; i++)                          /*   (could do j < n-1 because single element is also min element) */
            {
                int iMin = i;                                         /* assume the min is the first element */ 
                for (int j = i+1; j < array.Length; j++)                    /* test against elements after j to find the smallest */
                {                                   
                    if (array[j] < array[iMin])                              /* if this element is less, then it is the new minimum */
                    {
                        iMin = j;                                  /* found new minimum; remember its index */
                    }
                }
                if (array[iMin] != array[i])
                {
                    int swap = array[i];
                    array[i] = array[iMin];
                    array[iMin] = swap;
                }
            }
            // or simply => Array.Sort(a);
            foreach (int k in array) Console.WriteLine(k); 
        }
    }
}