using System;
using System.Numerics;
class NumberAsArray
{
    static void Main()
    {
        string[] lengths = Console.ReadLine().Split(' ');
        int f = int.Parse(lengths[0]);
        int s = int.Parse(lengths[1]);
        int[] firstNum = GetArrays(f);
        int[] secNum = GetArrays(s);
        int[] sum = SumArr(firstNum, secNum);
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write("{0} ", sum[i]);
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

    static int[] SumArr(int[] firstArray, int[] secondArray)
    {
        int maxLength = Math.Max(firstArray.Length,
            secondArray.Length);

        int[] resultArray = new int[maxLength];
        if (firstArray.Length > secondArray.Length)
        {
            int[] thirdArray = new int[maxLength];
            for (int i = 0; i < secondArray.Length; i++)
            {
                thirdArray[i] = secondArray[i];
            }
            for (int i = thirdArray.Length - 1; i >= secondArray.Length; i--)
            {
                thirdArray[i] = 0;
            }

            for (int i = 0; i < maxLength; i++)
            {
                resultArray[i] += firstArray[i] + thirdArray[i];
                if (resultArray[i] >= 10)
                {
                    resultArray[i] %= 10;
                    resultArray[i + 1] += 1;
                }
            }
            return resultArray;
        }

        else
        {
            int[] thirdArray = new int[maxLength];

            for (int i = 0; i < firstArray.Length; i++)
            {
                thirdArray[i] = firstArray[i];
            }

            for (int i = thirdArray.Length - 1; i >= firstArray.Length; i--)
            {
                thirdArray[i] = 0;
            }

            for (int i = 0; i < maxLength; i++)
            {
                resultArray[i] += secondArray[i] + thirdArray[i];
                if (resultArray[i] >= 10)
                {
                    resultArray[i] %= 10;
                    resultArray[i + 1] += 1;
                }
            }
            return resultArray;
        }
    }
}