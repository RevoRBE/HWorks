using System;

namespace PageCounter
{
    class Program
    {
        static void Main()
        {
            int nOfPages = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < nOfPages; i++)
            {
                if (nOfPages < 10)
                {
                    count++;
                }
                if (nOfPages < 100 && nOfPages >10 )
                {
                    count += 10;
                    count++;

                }
            }
            
            Console.WriteLine(count);
            
        }
    }
}
