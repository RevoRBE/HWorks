using System;
using System.Numerics;

namespace Calc
{
    class Calculate
    {
        static void Main()
        {
            int numN = 5; //int.Parse(Console.ReadLine());
            int numK = 7; //int.Parse(Console.ReadLine());
            BigInteger resultDivision = 1;
            if (numK > numN)
            {
                int swaper= numN;
                numN = numK;
                numK = swaper;
            }
            for (int i = numN; i > numK; i--)
            {
                resultDivision *= i;
            }
            Console.WriteLine("{0}", resultDivision);
        }
    }
}