using System;

namespace Problem1_Point3D
{
    class DistanceCalculator
    {
        public static double DistanceBetweenPoint3D(Point3D a,Point3D b)
        {
            double distance = 0;
            distance = Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2);
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
