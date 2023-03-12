using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6_OOP
{
    public class Therapist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Therapeutic treatment");
        }
    }
}