using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    public static class HomeTask4_Document_Task
    {
        public static void HW4_T5()
        {
            HW4_T5_1();
            HW4_T5_2();
            HW4_T5_3();
            HW4_T5_4();
            HW4_T5_5();
            HW4_T5_6();
            HW4_T5_7();
        }
        /// <summary>
        /// TASK #5 - 1 "Two first blocks of numbers"
        /// </summary>
        public static void HW4_T5_1()
        {
            string myDocument = "5831-aSD-0564-eRt-4u6W";
            Console.WriteLine(myDocument);
            Console.WriteLine();
            string[] numbers = myDocument.Split(new char[] { '-' });
            Console.WriteLine(numbers[0] + numbers[2]);
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 2 "Change letters to ***"
        /// </summary>
        public static void HW4_T5_2()
        {
            var myString = new StringBuilder("5831-aSD-0564-eRt-4u6W");
            myString.Replace("aSD", "***");
            myString.Replace("eRt", "***");
            string result = myString.ToString();
            Console.WriteLine(result);
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 3 "Delete numbers"
        /// </summary>
        public static void HW4_T5_3()
        {
            var myString2 = new StringBuilder("5831-aSD-0564-eRt-4u6W");
            myString2.Remove(0, 5);
            myString2.Replace("-0564-", "/");
            myString2.Replace("-4", "/");
            myString2.Replace("6", "/");
            string result2 = myString2.ToString();
            Console.WriteLine(result2.ToLower());
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 4 "Letters"
        /// </summary>
        public static void HW4_T5_4()
        {
            var myString3 = new StringBuilder("5831-aSD-0564-eRt-4u6W");
            myString3.Replace("5831-", "letters:");
            myString3.Replace("-0564-", "/");
            myString3.Replace("-4", "/");
            myString3.Replace("6", "/");
            string result3 = myString3.ToString();
            Console.WriteLine(result3.ToUpper());
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 5 "Find ABC/abc" 
        /// </summary>
        public static void HW4_T5_5()
        {
            string myDocument2 = "5831-ABC-0564-eRt-4u6W";
            bool mySearch = Regex.IsMatch(myDocument2, "\\babc\\b");
            bool mySearch2 = Regex.IsMatch(myDocument2, "\\bABC\\b");
            if (mySearch == true || mySearch2 == true)
            {
                Console.WriteLine("[ABC/abc] founded in the text");
            }
            else
            {
                Console.WriteLine("[ABC/abc] not founded in the text");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 6 "Begins with"
        /// </summary>
        public static void HW4_T5_6()
        {
            string myDocument3 = "5551-abc-0564-eRt-4u6W";
            if (myDocument3.StartsWith("555"))
            {
                Console.WriteLine("Number of document starts with 555");
            }
            else
            {
                Console.WriteLine("Number of document is not start with 555");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 7 "Ends with"
        /// </summary>
        public static void HW4_T5_7()
        {
            string myDocument3 = "5551-abc-0564-eRt-1a2b";
            if (myDocument3.EndsWith("1a2b"))
            {
                Console.WriteLine("Number of document ends with 1a2b");
            }
            else
            {
                Console.WriteLine("Number of document is not end with 1a2b");
            }
            Console.WriteLine();
        }
    }
}
