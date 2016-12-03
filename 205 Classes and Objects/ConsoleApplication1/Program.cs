using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TriangleSurface
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = Convert.ToDouble((Math.PI * 90) / 180);
        SurfaceByTwoSidesAndAngleBetweenThem(a, b, angle);
    }
 
    static void SurfaceByTwoSidesAndAngleBetweenThem(double s1, double s2, double ang)
    {
        double surface = Convert.ToDouble((s1 * s2 * Math.Sin(ang)) / 2);
        Console.WriteLine("{0}sm", surface);
    }
}