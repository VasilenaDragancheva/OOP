using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem1.Models;
using Problem1.Interfaces;

namespace Problem1
{
    public class ShapeTestProgram
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Rectangle(20, 3));
            shapes.Add(new Circle(5));
            shapes.Add(new Rhombus(3, 4, 1));
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine( shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());

            }
        }
    }
}
