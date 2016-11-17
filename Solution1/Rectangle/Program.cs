using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            double widthRectangle = double.Parse(Console.ReadLine());
            double heightRectangle = double.Parse(Console.ReadLine());

            double perimeterRectangle = (2 * widthRectangle) + (2 * heightRectangle);
            double areaRectangle = widthRectangle * heightRectangle;

            Console.WriteLine("{0:F2} {1:F2}", areaRectangle, perimeterRectangle);
        }
    }
}