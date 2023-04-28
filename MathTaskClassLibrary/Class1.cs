using System;

namespace MathTaskClassLibrarys
{
    public class Geometry
    {
        public int Rectangle(int a, int b)
        {
            return a * b;
        }

        public double Cylinder(double r, double h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 2);
        }
    }
}

   