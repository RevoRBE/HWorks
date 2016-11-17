using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages2Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int d = 0;
            var length = p.ToString().Length;
            for (int i = p; i >= 1; i--)
            {
                length+;
            }
            Console.WriteLine(length);
               
        }
    }
}
