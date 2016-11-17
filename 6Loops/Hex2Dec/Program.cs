using System;
using System.Globalization;
class HexadecimalToDecimalNum
{
    static void Main()
    {
        string hexa = Console.ReadLine();
        long dec = long.Parse(hexa, NumberStyles.HexNumber);
        Console.WriteLine(dec);
    }
}