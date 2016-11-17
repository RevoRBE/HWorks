using System;


namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countCol = 1;

            for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < 2 * n; j++)
                    {
                        if (countCol <= n)
                        {
                            Console.Write("{0} ", j);
                            countCol++;
                        }
                    }
                Console.WriteLine();
                countCol = 1;
            }
        }
    }
}