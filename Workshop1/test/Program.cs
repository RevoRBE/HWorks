using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int g = 0;
            int s1 = int.MaxValue;
            for (int i = 0; i < b; i++)
            {
                int sn = int.Parse(Console.ReadLine());
                if (s1 < sn)
                {
                    continue;
                    //s1 = sn;
                }
                else
                {
                    g++;
                    s1 = sn;
                }
            }
            Console.WriteLine(g);
        }
    }
}