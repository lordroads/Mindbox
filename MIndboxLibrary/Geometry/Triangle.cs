using Geometry.Exceptions;
using System;

namespace Geometry
{
    public class Triangle : Figure
    {

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            if (A + B <= C
            || A + C <= B
            || B + C <= A)
            {
                throw new NotExistTriangleException("Треугольника с такими сторонами не существует.");
            }

            var halfP = HalfP();

            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }

        private double HalfP()
        {
            return (A + B + C) / 2;
        }
    }
}

