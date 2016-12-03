using System;

namespace MethodsLesson
{
    class Program
    {
        static void SayHi(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            SayHi(Console.ReadLine());
        }
    }
}
