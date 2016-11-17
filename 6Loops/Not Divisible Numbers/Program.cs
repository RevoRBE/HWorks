using System;

class NotDivisibleBy3and7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.Write("{0} ",i);
        }
    }
}