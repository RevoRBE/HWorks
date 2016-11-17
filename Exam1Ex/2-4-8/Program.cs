using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r;
            if (b == 2)
	            {
		            r=a%c;
                    if (r % 4 == 0)
                    {
                        Console.WriteLine(r / 4);
                        Console.WriteLine(r);
                    }
                    else
                    {
                        Console.WriteLine(r % 4);
                        Console.WriteLine(r);
                    }
	            }
            else if (b == 4)
	            {
                    r = a + c;
                    if (r % 4 == 0)
                    {
                        Console.WriteLine(r / 4);
                        Console.WriteLine(r);

                    }
                    else
                    {
                        Console.WriteLine(r % 4);
                        Console.WriteLine(r);

                    }
	            } 
            else if (b == 8)
	            {
                    r = a * c;
                    if (r % 4 == 0)
                    {
                        Console.WriteLine(r / 4);
                        Console.WriteLine(r);

                    }
                    else
                    {
                        Console.WriteLine(r % 4);
                        Console.WriteLine(r);

                    }
	            }
        }   
    }
}
