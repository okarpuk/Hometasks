using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    public class HomeTask5_Phone
    {
        public int number = 0;
        public string model = "Unknown";
        public int weight = 0;
        public string name = "Unknown";

        //public HomeTask5_Phone() { number = 12345678; model = "qwerty"; weight = 222; }
        //public HomeTask5_Phone() { number = 12345678; model = "qwerty"; }
        //public HomeTask5_Phone() { }


        //public HomeTask5_Phone(int number, string model) : this(number, model, 0)
        //{

        //}
        //public HomeTask5_Phone(int number, string model, int weight)
        //{
        //    this.number = number;
        //    this.model = model;
        //    this.weight = weight;
        //}

        public void Print()
        {
            Console.WriteLine($"Phone number: {number}, Phone model: {model}, Phone weight: {weight}");
        }

        public void receiveCall()
        {
            Console.Write($"Caller: {name} ");
        }

        public void getNumber()
        {
            Console.WriteLine(number);
        }






    }
}
