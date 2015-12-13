using System;
using System.IO;

namespace Problem1_Point3D
{
    public class TestingPaths
    {
        static void Main(string[] args)
        {
            Point3D start = Point3D.StartPoint;
            Point3D a = new Point3D(1, 1, 1);
            Point3D b= new Point3D(2.1, 2, 3.4);
            double distanceStartA = DistanceCalculator.DistanceBetweenPoint3D(start, a);
            double distanceStartB = DistanceCalculator.DistanceBetweenPoint3D(start, b);
            Path3D first = new Path3D(start, a);
            Path3D second = new Path3D(start, a, b);
            Storage.SavePath(first, "pathFirst.txt");
            Storage.SavePath(second, "pathSecond.txt");

            try
            {
                Path3D loadedFirst = Storage.LoadPath("pathFirst.txt");
                foreach (Point3D point in loadedFirst.Points)
                {
                    Console.WriteLine("{0} {1} {2}",point.X,point.Y,point.Z);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
