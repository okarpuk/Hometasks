using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
	public class Square : Rectangle
    {
        public Square(double height, double width) : base(height, width)
        {
        }
        public override double GetSquare()
        {
            Console.WriteLine("Get Square figure square");
            return Math.Pow(height, 2);
        }
    }
}

