using System;

class MoonGravity
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        weight = (17 * weight) / 100;
        Console.WriteLine("{0:F3}", weight);
    }
}
