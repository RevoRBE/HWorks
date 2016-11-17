using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mythical_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string num = Console.ReadLine();
            int[] numbers = new int[num.Length];
            double result = 0;

            for (int i = 0; i < num.Length; i++)
            {
                numbers[i] = Int32.Parse(num[i].ToString());
            }
            double fir = (numbers[0]);
            double sec = (numbers[1]);
            double trd = (numbers[2]);

            if (trd == 0)
            {
                result = (fir * sec);
            }
            else if (trd <=5 && trd >0 )
            {
                result = (fir * sec)/trd;
            }
            else if (trd > 0)
            {
                result = ((fir + sec) * trd);
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
