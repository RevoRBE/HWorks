using System;
class AllNumbersFrom1ToN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i <= N; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}