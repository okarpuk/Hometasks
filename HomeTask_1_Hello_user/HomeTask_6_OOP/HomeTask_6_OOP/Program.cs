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
            Console.WriteLine(triangle1.GetSquare());
            Triangle triangle2 = new TriangleBuilder().CreateTriangle(6, 4, 6);
            Console.WriteLine(triangle2.GetSquare());
            Triangle triangle3 = new TriangleBuilder().CreateTriangle(6, 8, 10);
            Console.WriteLine(triangle3.GetSquare());
            Triangle triangle4 = new TriangleBuilder().CreateTriangle(5, 7, 10);
            Console.WriteLine(triangle4.GetSquare());
            //Rectangle
            Rectangle rectangle1 = new RectangleBuilder().CreateRectangle(5, 8);
            Console.WriteLine(rectangle1.GetSquare());
            Rectangle rectangle2 = new RectangleBuilder().CreateRectangle(5, 5);
            Console.WriteLine(rectangle2.GetSquare());
        }
    }
}   