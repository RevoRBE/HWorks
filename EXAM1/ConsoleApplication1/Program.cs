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
            string j = "41238";// Console.ReadLine();
            string[] jumps = new string[j.Length];
            int keep = 0;
            for (int i = 0; i < j.Length; i++)
            {
                jumps[i] = j[i].ToString();
            }

            for (int i = 0; i < j.Length && i >-1 ; i++)
            {
                if (Char.IsDigit(j[i]) == true)
                {
                    if (Int32.Parse(jumps[i]) == 0)
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", i); break;
                    }
                    else if (Int32.Parse(jumps[i]) % 2 != 0)
                    {
                        i -= Int32.Parse(jumps[i])+1; 
                        keep = i+1;
                        continue;
                    }
                    else if (Int32.Parse(jumps[i]) % 2 == 0)
                    {
                        i += Int32.Parse(jumps[i]) - 1;
                        keep = i+1;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }
            }
            if (keep > j.Length || keep < 0)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", keep);
            }
        }
    }
}