using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
    internal class Program
    {
        static void Main()
        {
            //Triangle
            Triangle triangle1 = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Triangle triangle2 = new TriangleBuilder().CreateTriangle(6, 4, 6);
            Triangle triangle3 = new TriangleBuilder().CreateTriangle(6, 8, 10);
            Triangle triangle4 = new TriangleBuilder().CreateTriangle(5, 7, 10);
            //Rectangle
            Rectangle rectangle1 = new RectangleBuilder().CreateRectangle(5, 8);
            Rectangle rectangle2 = new RectangleBuilder().CreateRectangle(5, 5);
            //Arrays
            Triangle[] allTriangles = { triangle1, triangle2, triangle3, triangle4 };
            foreach (var figureTriangle in allTriangles)
            {
                Console.WriteLine(figureTriangle.GetSquare().ToString());
            }
            Rectangle[] allRectangles = { rectangle1, rectangle2 };
            foreach (var figureRectangle in allRectangles)
            {
                Console.WriteLine(figureRectangle.GetSquare().ToString());
            }
        }
    }
}