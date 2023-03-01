using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class HomeTask4_Strings
    {
        public static void Tasks()
        {
            HW4_T1();
            HW4_T2();

        }

        /// <summary>
        /// TASK #1 - Change [TEST] to [TESTING] in text. Delete all numbers from text. 
        /// </summary>
        public static void HW4_T1()
        {
            string text = "33JustTEST22venenatis555TESTsedTESTdo55";
            text = text.Replace("TEST", "TESTING"); //или тоже использовать Regex
            text = Regex.Replace(text, "[0-9]", "", RegexOptions.IgnoreCase);
            Console.WriteLine(text);
        }

        /// <summary>
        /// TASK #2 -  Сreate a string of words [Welcome to the TMS lesons]
        /// </summary>
        public static void HW4_T2()
        {
            string word1 = "\"Welcome\"";
            string word2 = "\"to\"";
            string word3 = "\"the\"";
            string word4 = "\"TMS\"";
            string word5 = "\"lessons\"";
            string[] words = new string[] { word1, word2, word3, word4, word5 };
            Console.WriteLine(string.Join(" ", words));
        }















    }
}
