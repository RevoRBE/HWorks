using System;

namespace intSizeTest
{
	class MainClass
	{
		static void Main()
		{
			byte num1 = 97;
			short num3 = -10000;
			ushort num4 = 52130; 
			sbyte num2 = -115; 
			int num5 = 4825932; 
			Console.WriteLine (num1);
			Console.WriteLine (num2);
			Console.WriteLine (num3);
			Console.WriteLine (num4);
			Console.WriteLine (num5);
            Console.WriteLine();


			double d3 = 34.567839023;
			float f1 = 12.345F; 
			double d4 = 8923.1234857; 
			float f2 = 3456.091F;
			Console.WriteLine (d3);
			Console.WriteLine (f1);
			Console.WriteLine (d4);
			Console.WriteLine (f2);
            Console.WriteLine();


			int first = 0xFE;
			Console.WriteLine (first);

		}
	}
}