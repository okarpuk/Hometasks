using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
    public class TriangleBuilder
    {
        public TriangleBuilder() { }

        public Triangle CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return new EquiletarlTriangle(firstSide, secondSide, thirdSide);
            }

            else if ((firstSide == secondSide) && (firstSide != thirdSide) && (secondSide != thirdSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }

            else if ((firstSide != secondSide) && (firstSide != thirdSide) && (secondSide != thirdSide))
            {
                return new ScaleneTriangle(firstSide, secondSide, thirdSide);
            }




            else if (firstSide == Math.Round(Math.Sqrt(Math.Pow(secondSide, 2) - (Math.Pow(thirdSide, 2))), 0));
            {
                return new RightTriangle(firstSide, secondSide, thirdSide);
            }





           // else if (thirdSide == Math.Round(Math.Sqrt(Math.Pow(firstSide, 2) - (Math.Pow(secondSide, 2))), 0));
           // {
           //     return new RightTriangle(thirdSide, firstSide, secondSide);
           // }





            return new Triangle(firstSide, secondSide, thirdSide);

        }
    }
}

