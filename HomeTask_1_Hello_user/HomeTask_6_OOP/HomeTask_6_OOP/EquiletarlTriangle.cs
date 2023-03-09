using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
    public class EquiletarlTriangle : Triangle
    {
        public EquiletarlTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }
        public override double GetSquare()
        {
            Console.WriteLine("Get square EquiletarlTriangle");
            return Math.Pow(firstSide, 2) * Math.Sqrt(3) / 4;
        }
    }
}
