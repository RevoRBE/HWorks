using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20132014_14_Sept_Morning_Decode_and_Decrypt
{
    class Program
    {
        static void Encrypt(string msg)
        {
            //for (int i = 0; i < string.GetLength(0); i++)
            //{
            //    for (int j = i; j < string.GetLength(1); j++)
            //    {
            //    }
            //}
        }

        static void Encode(string msg)
        {
            //int[,] result = new int[row, col];

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        result[i, j] = int.Parse(Console.ReadLine);
            //    }
            //}
            ////ReadMatrix the PrintMatrix here
            //return result;
        }

        
        static void Main()
        {
            string str = Console.ReadLine();
            int strL = str.Length-1;
            int cypherL = int.Parse(str[strL].ToString());
            Console.WriteLine(cypherL);
            string msg = str.Substring(0,strL-cypherL);
            string cyp = str.Substring(strL - cypherL, cypherL);
            GetCypLength(kjwefwef);
        }
    }
}

