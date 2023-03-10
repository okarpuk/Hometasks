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

            else if ((firstSide != secondSide) && (firstSide != thirdSide) && (secondSide != thirdSide))
            {
                return new ScaleneTriangle(firstSide, secondSide, thirdSide);
            }

            else if ((firstSide == secondSide) && (firstSide != thirdSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else if ((firstSide == thirdSide) && (firstSide != secondSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }
            else if ((secondSide == thirdSide) && (firstSide != secondSide))
            {
                return new IsoscelesTriangle(firstSide, secondSide, thirdSide);
            }

            double hypotenuse = firstSide;
            double cathetFirst = secondSide;
            double cathetSecond = thirdSide;

            if (secondSide > hypotenuse)
            {
                hypotenuse = secondSide;
                cathetFirst = firstSide;
                cathetSecond = thirdSide;
            }
            if (thirdSide > hypotenuse)
            {
                hypotenuse = thirdSide;
                cathetFirst = firstSide;
                cathetSecond = secondSide;
            }
            if (Math.Pow(hypotenuse, 2) == Math.Pow(cathetFirst, 2) + Math.Pow(cathetSecond, 2))
            {
                return new RightTriangle(cathetFirst, cathetSecond, hypotenuse);
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
