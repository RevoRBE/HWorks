using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main()
        {
            char symbol = int.Parse(Console.ReadKey());
            switch (symbol)
            {
                case 'a': Console.WriteLine("Monday"); break;
                case 'b': Console.WriteLine("Tuesday"); break;
                case 'c': Console.WriteLine("Wednesday"); break;
                case 'v': Console.WriteLine("Thursday"); break;
                case 'g': Console.WriteLine("Friday"); break;
                case 'h': Console.WriteLine("Saturday"); break;
                case 's': Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
    }
}
