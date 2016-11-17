using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingBools
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tru1 = true;
            bool tru2 = true;
            bool fal1 = false;
            bool fal2 = false;
            Console.WriteLine(tru1 | tru2 ^ fal1 ^ fal2);
        }
    }
}
