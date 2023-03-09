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
            Triangle triangle = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Console.Write(triangle.GetSquare());

        }
    }
}