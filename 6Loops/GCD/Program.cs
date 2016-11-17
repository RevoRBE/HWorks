using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        int a = Math.Abs(int.Parse(input[0]));
        int b = Math.Abs(int.Parse(input[1]));
        int c = 0;

        while (a != b)
        {
            if (a > b)
            {
                c = a - b;
                a = b;
                b = c;
            }
            else if (a < b)
            {
                c = b - a;
                b = a;
                a = c;
            }
        }
        Console.WriteLine(a);
    }
}