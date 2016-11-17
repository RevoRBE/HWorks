using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] array = new int[input];
        int inc = 1;
        int result = 1;

        for (int i = 0; i < input; i++)
            array[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < input - 1; i++)
            if ((array[i]) < array[i + 1])
            {
                inc++;
                if (inc > result)
                    result = inc;
            }
            else
                inc = 1;

        Console.WriteLine(result);
    }
}