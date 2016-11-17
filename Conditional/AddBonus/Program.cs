using System;

namespace AddBonus
{
    class Program
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            if (N>=1 && N<=3)
            {
                Console.WriteLine(N*10);
            }
            else if (N >= 4 && N <= 6)
            {
                Console.WriteLine(N * 100);
            }
            else if (N >= 7 && N <= 9)
            {
                Console.WriteLine(N * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
