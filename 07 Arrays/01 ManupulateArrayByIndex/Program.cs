using System;

class ManipulateArray
{
    static void Main()
    {
        //int number = int.Parse(Console.ReadLine());
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(i * 5);
        }
    }
}