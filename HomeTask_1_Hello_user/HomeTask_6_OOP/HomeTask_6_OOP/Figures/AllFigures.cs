using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
	public class AllFigures
	{
        public virtual double GetSquare()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}






