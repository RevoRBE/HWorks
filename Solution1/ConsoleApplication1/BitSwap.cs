using System;

class BitSwap
{
    static void Main()
    {
        // Input
        uint n = uint.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte q = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        //Solve
        if ((q > p + k - 1) || (p > q + k - 1))
        {
            for (int i = 0; i < k; i++)
            {
                uint bitP = (uint)(n & (1 << p)) >> p;  // Value of bit p
                uint bitQ = (uint)(n & (1 << q)) >> q;  // Value of bit q

                n &= (uint)(~(1 << q));  // Clear bit q (set to 0)
                n |= (uint)(bitP << q);   // Set bit q

                n &= (uint)(~(1 << p));   // Clear bit p (set to 0)
                n |= (uint)(bitQ << p);   // Set bit p

                p++;
                q++;
            }
            Console.WriteLine(n);
        }
    }
}

