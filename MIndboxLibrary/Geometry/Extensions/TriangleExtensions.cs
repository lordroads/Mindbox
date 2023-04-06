using System;

namespace Geometry
{
    public static class TriangleExtensions
    {
        public static bool CheckRightAngle(this Triangle triangle)
        {
            var c2 = Math.Pow(triangle.C, 2);
            var a2 = Math.Round(Math.Pow(triangle.A, 2));
            var b2 = Math.Round(Math.Pow(triangle.B, 2));

            var result = c2 == a2 + b2;

            return result;
        }
    }
}

