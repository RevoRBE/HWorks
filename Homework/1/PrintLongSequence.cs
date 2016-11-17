using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        
        {
            // Console.BufferHeight = 1001;
            for (int i = 0, num = 2; i < 1000; i++, num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0}", num);
                }
                else
                {
                    Console.WriteLine("{0}", -num);
                }
            }
        }
    }
}