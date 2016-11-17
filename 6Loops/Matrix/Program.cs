 using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = 3; //int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1 + i; j <= n + i; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }