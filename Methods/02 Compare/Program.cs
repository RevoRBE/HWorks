using System;

namespace MethodsLesson
{
    class Program
    {
        static int IntComp(int int1, int int2)
        {
            return Math.Max(int1, int2);
        }
        static void Main()
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int Max = IntComp(int1, int2);
            Max = IntComp(int3, int2);
            Console.WriteLine(Max = IntComp(int1, int3));
        }
    }
}
