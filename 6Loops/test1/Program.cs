using System;

class Conductors
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int rowCounter = 0;
        for (int i = 1, t = 1; ; t++, i++)
        {
            if (rowCounter == input)
            {
                break;
            }
            if (i == input + 1)
            {
                rowCounter++;
                i = 0;
                t = rowCounter;
                Console.WriteLine();
            }
            else
                Console.Write("{0} ", t);
        }
    }
}