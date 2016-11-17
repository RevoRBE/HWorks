using System;


namespace _14A.BitExchange2
{
    class BitExchange2
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask1 = (number & 56) >> 3;
            uint mask2 = (number & (56 << 21)) >> 24;
            uint shift = mask1 ^ mask2;
            number = number ^ shift << 3;
            number = number ^ shift << 24;
            Console.WriteLine(number);

            //uint n = uint.Parse(Console.ReadLine());
            //uint mask3 = (n & (7 << 3)) >> 3;
            //uint mask24 = (n & (7 << 24)) >> 24;
            //uint identity = mask3 ^ mask24;
            //n = n ^ identity << 3;
            //n = n ^ identity << 24;
            //Console.WriteLine(n);

            //uint farMask = (uint)(7 << farPosition);            // 0111 0000 0000 0000 0000 0000 0000 mask7Moved<24
            //Console.WriteLine(Convert.ToString(farMask, 2));
            //uint nAndFarMask = n & farMask;                     // 0010 0000 0000 0000 0000 0000 0000 bits
            //Console.WriteLine(Convert.ToString(nAndFarMask, 2));
            //uint far3Bits = nAndFarMask >> farPosition;         // 0000 0000 0000 0000 0000 0000 0010 result
            //Console.WriteLine(Convert.ToString(far3Bits, 2));
            //uint bitExchange = close3Bits ^ far3Bits;           // 0000 0000 0000 0000 0000 0000 0111 result
            //Console.WriteLine(Convert.ToString(bitExchange, 2));            
            //                                                    // 0101 0010 1100 1100 0000 0010 1000 num
            //n = n ^ bitExchange << 3;                           // 0000 0000 0000 0000 0000 0000 0111
            //Console.WriteLine(Convert.ToString(n,2));
            //                                                    // 0101 0010 1100 1100 0000 0010 1111
            //                                                    // 1001 0110 0110 0000 0001 0111 1000

            //                                                    // 1001 0110 0110 0000 0001 0111 1000
            //n = n ^ bitExchange << 24;
            //Console.WriteLine(Convert.ToString(n, 2));
            //                                                    // 1001 0110 0110 0000 0001 0000 1111
            //                                                    // 1110 0000 0000 0000 0000 0000 0000
            //Console.WriteLine(n);
            //Console.WriteLine(Convert.ToString(n,2));
        }
    }
}
