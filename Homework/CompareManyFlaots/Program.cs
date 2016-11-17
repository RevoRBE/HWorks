using System;

namespace CompareManyFlaots
{
    class Program
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float v = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(x, y) ,v) ,c), z));
        }
    }
}
