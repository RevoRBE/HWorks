using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static int IndexOf(char[] symbols, char search)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }
        
        static void Main()
        {
            char[] symbols = "az sym kon".ToCharArray();
            int indexOfO = IndexOf(symbols, 'o');
            int indexOfM = IndexOf(symbols, 'm');
            int indexOfT = IndexOf(symbols, 't');

            Console.WriteLine(indexOfO);
            Console.WriteLine(indexOfM);
            Console.WriteLine(indexOfT);
        }
    }
}
