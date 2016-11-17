using System;

namespace printASCII
{
	class MainClass
	{
		static void Main ()
		{
			for (byte counter = 33; counter < 127; counter++)
			{
				Console.Write((char)counter);
			}
		}
	}
}