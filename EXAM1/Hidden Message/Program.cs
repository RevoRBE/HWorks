using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidden_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            int I = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            char[] array = str.ToCharArray();
            if (S>=0)
            {
                for (int i = S; i < array.Length; i += I)
                {
                    Console.Write(array[i]);
                } 
            }
            else
            {
                for (int i = array.Length; i < array.Length; i -= I)
                {
                    Console.Write(array[i]);
                } 
            }
            
        }
    }
}
