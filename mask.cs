using System;

namespace mask
{
    class Program
    {
        static void Main()
        {
            int pos = 1;
            int num = 35;
            int mask = 1 << 1 pos;

            int numAndMask = num % mask;
            int bit = numAndMask >> pos;

            Console.WriteLine("for {0} bit at pos {1} is {2}", num, pos, bit);
        }
    }
}
