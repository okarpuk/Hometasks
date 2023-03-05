using System;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTask5_Phone Xiaomi = new();
            Xiaomi.number = 1234567;
            Xiaomi.model = "Mi 12 Lite";
            Xiaomi.weight = 120;
            Xiaomi.name = "John";
            Xiaomi.Print();
            Xiaomi.receiveCall();
            //Xiaomi.receiveCall("Ivan"); //ДЛЯ ПЕРЕГРУЖЕННОГО МЕТОДА #1
            Xiaomi.getNumber();
            Xiaomi.sendMessage();
            HomeTask5_Phone iPhone = new();
            iPhone.number = 9876543;
            iPhone.model = "14 pro";
            iPhone.weight = 154;
            iPhone.name = "Zoe";
            iPhone.Print();
            iPhone.receiveCall();
            // iPhone.receiveCall("Joe", 445566); //ДЛЯ ПЕРЕГРУЖЕННОГО МЕТОДА #2
            iPhone.getNumber();
            HomeTask5_Phone Samsung = new();
            Samsung.number = 1112233;
            Samsung.model = "Galaxy S23";
            Samsung.weight = 139;
            Samsung.name = "Max";
            Samsung.Print();
            Samsung.receiveCall();
            Samsung.getNumber();
        }
    }
}
