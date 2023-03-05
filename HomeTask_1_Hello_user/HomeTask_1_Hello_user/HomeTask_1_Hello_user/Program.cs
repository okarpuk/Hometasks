using System;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK _ PHONE
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

            // TASK - CREDIT CARD
            HomeTask5_CreditCard RefillAccount = new();
            RefillAccount.Refill();
            HomeTask5_CreditCard WithdrawalAccount = new();
            RefillAccount.Withdrawal();
            HomeTask5_CreditCard TotalSum = new();
            RefillAccount.SumOnAccount();
            // CREATED 3 CREDIT CARDS
            HomeTask5_CreditCard Card_1 = new();
            Card_1.accountNumber = 1111;
            Card_1.currentSum = 1111;
            HomeTask5_CreditCard Card_2 = new();
            Card_2.accountNumber = 2222;
            Card_2.currentSum = 2222;
            HomeTask5_CreditCard Card_3 = new();
            Card_3.accountNumber = 3333;
            Card_3.currentSum = 3333;
            //TEST SCENARIO FOR CREDIT CARDs
            Card_1.Refill();
            Card_2.Refill();
            Card_3.Withdrawal();
            Card_1.SumOnAccount();
            Card_2.SumOnAccount();
            Card_3.SumOnAccount();
        }
    }
}
