﻿using System;
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
            EquiletarlTriangle triangle = new EquiletarlTriangle(5, 5, 5);
            Console.Write(triangle.GetSquare());

        }
    }
}