using System;

namespace DefineType
{
    class IntDoubleString
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    int typeInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(typeInt + 1);
                    break;
                case "real":
                    double typeDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", typeDouble + 1);
                    break;
                case "text":
                    string typeString = Console.ReadLine();
                    Console.WriteLine(typeString + "*");
                    break;
            }
        }
    }
}