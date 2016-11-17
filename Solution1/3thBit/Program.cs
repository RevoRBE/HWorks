using System;

namespace test
{
    class nthBit
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine()); // 00000000 00000010
            int position = 3;
            ulong mask = 1UL << position;        // 00000000 00100000
            ulong andMask = number & mask;  // 00000000 00100000
            ulong bit = andMask >> position;  // 00000000 00000001
            Console.WriteLine(bit);   // 1
        }
    }
}
