using System;


namespace MatchingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint head = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int bestToothCount = 0;
            int bestComb = 0;

            for (int i = 0; i < c; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                bool canUseComb = true;
                if ((comb&head) != 0)
                {
                    
                }
                int toothCount = 0;

                for (int j = 0; j < 32; ++j)
                {
                    uint hasHair = (head >> j) & 1;
                    uint hasTooth = (comb >> j) & 1;
                    if (hasHair == 1 && hasTooth == 1)
                    {
                        canUseComb = false;
                        break;
                    }
                    if (hasTooth == 0)
                    {
                        Console.WriteLine("{0} {1}", comb, toothCount);
                        if (bestToothCount >= bestToothCount)
                        {
                            bestToothCount = toothCount;
                            bestComb = comb;
                        }
                    }
                }
            }
            Console.WriteLine(bestC);
        }
    }
}
