using System;

namespace test
{
    class BitModify
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine()); // 00000000 00000010
            int position = int.Parse(Console.ReadLine());
            byte bit = byte.Parse(Console.ReadLine());
            ulong mask = 1UL << position;        // 00000000 00100000
            if (bit == 0)
	            {
		            ulong result = number & ~mask;
                    Console.WriteLine(result);
                }
               else
	            {
                     ulong result = number | mask;
                     Console.WriteLine(result);
	            }
        }
    }
}
