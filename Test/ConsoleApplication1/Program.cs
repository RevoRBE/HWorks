using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = 200;           
            var apt = 180;        
            var pass = 63;
            var transPls = 65*2;
            var transSf = 110 * 2;
            Console.WriteLine("cenata s transfer ot pld predi namalenie: {0} sled namalenie: {1} ", (car + apt * 4 + transPls), (car + apt * 4 + transPls) * 0.7);       
        }
    }
}
