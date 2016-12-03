using System;
class BinarySearch
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        var arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int tar = int.Parse(Console.ReadLine());
        int min = 0;
        int max = size;
        int mid;
        while (true)
        {
            mid = (min + max) / 2;
            if (tar > arr[mid])
            {
                min = mid ;
            }
            else
            {
                max = mid;
            }
            if(min==max||min==max-1)
            {
                if (arr[min] == tar)
                {
                    Console.WriteLine(min);
                    return;
                }
                else if (arr[max] == tar)
                {
                    Console.WriteLine(max);
                    return;
                }
                else
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
        }
    }
}