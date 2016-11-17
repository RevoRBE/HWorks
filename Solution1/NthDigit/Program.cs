using System;

namespace ThirdDdigit
{
    class ThirdDdigit
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            uint firstNum = (N / 100);
            // 7543/100 takes the whole part = 75
            uint isThirdNum = (firstNum % 10);
            // 75 % 10 takes the remainder  = 5
            if (isThirdNum == 7)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false {0}", isThirdNum);
        }
    }
}
