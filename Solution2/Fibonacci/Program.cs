using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {            
            ulong n = ulong.Parse(Console.ReadLine());
            ulong firstNum = 0;
            ulong secondNum = 1;
            if (n == 0)
            { 
                Console.WriteLine("Invalid input!");
            }
            else if (n == 1)
            {
                Console.WriteLine(firstNum);
            }
            else if (n > 1 && n <= 50)
                Console.Write("{0}, {1}", firstNum, secondNum);
                for (ulong i = 2; i < n; i++)
                {
                    ulong nextNum = firstNum + secondNum;
                    Console.Write(", {0}", nextNum);
                    firstNum = secondNum;
                    secondNum = nextNum;
                }
            Console.WriteLine();
        }
    }
}
