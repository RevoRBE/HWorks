using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseInt
{
    class Program
    {
        static int ParseInt(string numAsStr)
        {
            int result = 0;
            //for (int i = 0; i < numAsStr.Length; i++)
            //{
            //    int digitValue = numAsStr[i] - '0';
            //    result += (int)(digitValue * Math.Pow(10, numAsStr - 1 - i));
            //}
            foreach (char digit in numAsStr)
            {
                result = result * 10 + (digit - '0');
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = ParseInt("123456");
            Console.WriteLine(number +5));
        }
    }
}
