using System;
using System.Numerics;

public class NumbersAddingByArrays
{
    public static void Main()
    {
        string[] lengths = Console.ReadLine().Split(' ');
        int f = int.Parse(lengths[0]);
        int s = int.Parse(lengths[1]);

        int[] firstNum = GetArrays(f);
        int[] secNum = GetArrays(s);
        int[] sumnums = SumArr(firstNum, secNum);

        for (int i = 0; i < sumnums.Length; i++)
        {
            Console.Write("{0} ", sumnums[i]);
        }
    }
    static int[] GetArrays(int length)
    {
        string[] stringArray = Console.ReadLine().Split(' ');
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }
        return array;
    }
    public static int[] SumArr(int[] firstArray, int[] secondArray)
    {
        int maxLength = Math.Max(firstArray.Length,
             secondArray.Length);

        int[] resultArray = new int[maxLength];
        for (int i = 0; i < resultArray.Length; i++)
        {
            if (i < firstArray.Length)
            {
                resultArray[i] += firstArray[i];
                if (resultArray[i] >= 10)
                {
                    resultArray[i] -= 10;
                    resultArray[i + 1]++;
                }
            }

            if (i < secondArray.Length)
            {
                resultArray[i] += secondArray[i];
                if (resultArray[i] >= 10)
                {
                    resultArray[i] -=  10;
                    resultArray[i + 1]++;
                }
            }
        }
        return resultArray;
    }
}