using System;


namespace _12.N_th_Bit
{
    class NthBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine()); // 0001 0101 /21
            int position = int.Parse(Console.ReadLine());   // 2
            ulong moveBit = number >> position;             // 0000 0101 
            ulong bit = moveBit & 1;                        // 0000 0001 /1
            Console.WriteLine(bit);                         // 0000 0001 /1

            ulong numberA = ulong.Parse(Console.ReadLine()); // 0001 0101 /21
            int positionA = int.Parse(Console.ReadLine());   // 2
            ulong mask = (ulong)(1 << positionA);            // 0000 0100
            ulong numAndMask = numberA & mask;               // 0000 0100 
            ulong bitA = numAndMask >> positionA;            // 0000 0001 /1
            Console.WriteLine(bitA);
        }
    }
}