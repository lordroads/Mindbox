using System;

namespace Geometry
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }
    }
}

