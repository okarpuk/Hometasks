using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HomeTask_6_OOP;

namespace HomeTask_6_OOP
{
	public class Surgeon : Doctor
	{
        public override string Treat()
        {
            return "Surgical treatment";
        }
    }
}