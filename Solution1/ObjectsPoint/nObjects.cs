﻿using System;


namespace PointinNObjects
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
            bool inRectangle = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 2));

            if (inCircle == true && inRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (inCircle == false && inRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
            else if (inCircle == true && inRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle inside rectangle");
            }

        }
    }
}