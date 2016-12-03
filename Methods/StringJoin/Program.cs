using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringJoin
{
    class Program
    {
        static string Join(int[] numbers, string separator = ",", string suffix= "")
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i]+ separator;

            }
            result += numbers[numbers.Length - 1]+suffix;
            return result;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 10, 15, 33 };
            Console.WriteLine(Join(numbers, suffix:"gergi", separator:" => "));
        }
    }
}
