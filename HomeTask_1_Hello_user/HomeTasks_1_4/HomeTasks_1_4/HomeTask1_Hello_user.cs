using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_1_4.HomeTasks_1_4
{
    internal class HomeTask1_Hello_user
    {
        // HELLO USER
        public static void HW1_Hello_user()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !!!");
        }
    }
}
