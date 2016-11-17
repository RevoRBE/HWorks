using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class alignment
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 23;
            Console.WriteLine("{0:X} end" , a);

            Console.WriteLine("{0:C} end", a);

            Console.WriteLine("{0:0.00} end", a);
        }
    }
}
