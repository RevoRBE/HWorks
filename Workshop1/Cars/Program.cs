using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            short buses = short.Parse(Console.ReadLine());
            int groupSpeed = int.MaxValue;
            short g = 0;
            for (int i = 0; i < buses; i++)
            {
                short speed = short.Parse(Console.ReadLine());
                if (groupSpeed >= speed)
                {
                    g++;
                    groupSpeed = speed;
                }
            }
            Console.WriteLine(g);
        }
    }
}
