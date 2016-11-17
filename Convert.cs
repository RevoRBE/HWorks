using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 15;
            
            Console.WriteLine(Convert.ToString(num));

            
            //Console.WriteLine(Convert.ToSByte(num));
            Console.WriteLine(num.GetTypeCode());
        }
    }
}
