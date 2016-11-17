using System;

namespace Calc
{
    class Calculate
    {
        static void Main()
        {
            double numN = double.Parse(Console.ReadLine());
            double numX = double.Parse(Console.ReadLine());
            // The formula is Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N
            double factorialN = 1;
            double numXPowN = 1;
            double sum = 1;
            for (int i = 1; i <= numN; i++)
            {
                factorialN *= i;
                numXPowN *= numX;
                sum += (factorialN / numXPowN);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}