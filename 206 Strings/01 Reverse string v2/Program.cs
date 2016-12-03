using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        public static string ReversingString(string str)
        {
            var sb = new StringBuilder();   // using System.Text;
            //  StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        static void Main()
        {
            string str = Console.ReadLine();

            //string reversed = ReversingString(str);

            //Console.WriteLine(reversed);

            // other way
            Console.WriteLine(new string(str.ToCharArray().Reverse().ToArray()));   // using System.Linq;
        }
    }
}