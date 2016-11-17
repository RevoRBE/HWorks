using System;

namespace TestMySelf
{
	class EmptyClass
		{
		static void Main()
				{
					byte centuries = 20;    // Usually a small number
					ushort years = 2000;
					uint days = 730480;
					ulong hours = 17531520; // May be a very big number
					Console.WriteLine("{0} centuries is {1} years," +
					" or {2} days, " + "or {3} hours.",
					centuries, years, days, hours);
					


					float floatPI = 3.141592653589793238f;
					double doublePI = 3.141592653589793238;

					Console.WriteLine("Float PI is: {0}", floatPI);
					Console.WriteLine("Double PI is: {0}", doublePI);
					double a = 1.0f;
					double b = 0.33f;
					double sum = 1.33f;
					bool equal = (a+b == sum); // False!!!
					Console.WriteLine("a+b={0}  sum={1}  equal={2}",
					a+b, sum, equal);

				}	
		}
}