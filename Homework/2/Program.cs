using System;

namespace ComparingFloats
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			// Initialize two doubles for comparison
			double double1 = double.Parse(Console.ReadLine());
			double double2 = double.Parse(Console.ReadLine());

			// Define the tolerance for variation in their values
			double tolerance = 0.000001;

			if (Math.Abs(double1 - double2) <= tolerance)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");				
		}
	}
}