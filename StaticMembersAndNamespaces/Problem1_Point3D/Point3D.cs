using System;

namespace Problem1_Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static Point3D startPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }
    }
}
