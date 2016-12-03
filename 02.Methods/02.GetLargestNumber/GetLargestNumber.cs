using System;
class IntCompare 
{
    static void Main()
    {
        GetMax(Console.ReadLine().Split(' '));
    }
    static void GetMax(string[] numbers)
    {
        int int1 = int.Parse(numbers[0]);
        int int2 = int.Parse(numbers[1]);
        int int3 = int.Parse(numbers[2]);
        int largestNum = Math.Max(Math.Max(int1, int2), int3);
        Console.WriteLine(largestNum);
    }
}