using System;

namespace Age_after10Years
{
    class Age_after10Years
    {
        static void Main()
        {
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            System.TimeSpan myCurrentAge = (DateTime.Now - birthDay);
            Console.WriteLine("Your age is: {0:F0}", myCurrentAge.Days / 365.242199);
            int age10 = (int)(myCurrentAge.Days / 365.242199 + 10);
            Console.WriteLine("Your age after ten years will be: {0:F0}", age10);
        }
    }
}