using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str2Int
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            //string opera = "+";
            //string str2 = Console.ReadLine();
            string[] arr1, arr2;
            for (int i = 0; i <= str1.Length; i++)
            {
                arr1[i] = (char)(str1[i - 1]);
            }
            //Console.WriteLine(int1);
            for (int i = 0; i < arr1.Length; i++)
			{
			    Console.WriteLine(arr1[i]); 
			}
        }
    }
}
