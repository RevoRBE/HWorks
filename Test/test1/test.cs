using System;

namespace OddOrEvena
{
    class OddOrEvena
    {
        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
            else
                Console.WriteLine(number+ " Odd");
        }
    }
}