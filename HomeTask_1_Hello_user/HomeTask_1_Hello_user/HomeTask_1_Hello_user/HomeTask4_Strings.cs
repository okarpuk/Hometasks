using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            HW4_T3();
            HW4_T4();

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
        /// <summary>
        /// TASK #3 - Create 2 variables of string [teamwithsomeofexcersicesabcwanttomakeitbetter]
        /// </summary>
        public static void HW4_T3()
        {
            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            Console.WriteLine(text);
            text = text.Replace("abc", " ");
            string[] words = text.Split(new char[] {' '});
            string firstWord = words[0];
            string secondWord = words[1];
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
        }
        /// <summary>
        /// TASK #4 - Change [Bad day] to [Good day!!!!!!!!?]
        /// </summary>
        public static void HW4_T4()
        {
            string text = "Bad day";
            Console.WriteLine(text);
            text = text.Substring(3);
            Console.WriteLine(text);
            text = text.Insert(0, "Good");
            text = text.Insert(text.Length, "!!!!!!!!!");
            Console.WriteLine(text);
            text = text.Remove(text.Length - 1);
            text = text.Insert(text.Length, "?");
            Console.WriteLine(text);
        }










    }
}
