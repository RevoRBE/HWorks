using System;

namespace Pages2Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int page;
            for (page = 1; digits !=0; page++)
            {
                digits -= page.ToString().Length;
            }
            Console.WriteLine(--page);
        }
    }
}
