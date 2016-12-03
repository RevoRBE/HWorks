using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Reversed_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string normString = Console.ReadLine();
            string revString = Reverse2(normString);
            Console.WriteLine(revString);
        }
        static string Reverse1(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public static string Reverse2(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
