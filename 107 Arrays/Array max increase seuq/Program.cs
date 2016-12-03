using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            int bigcounter = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j - 1] < nums[j])
                {
                    counter++;
                    if (counter > bigcounter)
                    {
                        bigcounter = counter;

                    }
                }
                else
                {
                    counter = 0;
                }
            }
            if (counter > bigcounter)
            {
                Console.WriteLine(counter + 1);
            }
            else
            {
                Console.WriteLine(bigcounter + 1);
            }
        }
    }
}