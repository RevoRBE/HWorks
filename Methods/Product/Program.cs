using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static int Product(params int[] numbers)
        {
            int product =1

            foreach (int n in numbers)
	        {
		        product *= n;
	        }
            return product;
        }
        static void Main(string[] args)
        {
            int pTest = Product(new int[] { 1, 32, 5 });
            int pTest2 = Product();
            int p1 =  Product(1,2,3,4,5,6);
            int p2 =  Product(3,4,6,4,5,6);
            int p3 = Product(21, 331, 423, 5321, -63);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
