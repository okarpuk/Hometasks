using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace HomeTask_6_OOP.HomeTask_6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EquiletarlTriangle triangle = new EquiletarlTriangle();
            Console.Write(triangle.GetSquare());

        }
    }
}