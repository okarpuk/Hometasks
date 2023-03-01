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
        /// TASK #1 - Change [test] to [testing] in text. Delete all numbers from text. 
        /// </summary>
        public static void HW4_T1()
        {
            string text = "33JustTEST22venenatis555TESTsedTESTdo55";
            text = text.Replace("TEST", "TESTING");
            text = Regex.Replace(text, "[0-9]", "", RegexOptions.IgnoreCase);
            Console.WriteLine(text);
        }

        /// <summary>
        /// TASK #2 -  
        /// </summary>
        public static void HW4_T2()
        {
        
        
        
        
        }















    }
}
