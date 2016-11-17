using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_money
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int totalsheets = n*s;
            double realmsneeded = (double)totalsheets/500;
            double saved = realmsneeded*p;
            Console.WriteLine("{0:F2}", saved);
        }
    }
}
