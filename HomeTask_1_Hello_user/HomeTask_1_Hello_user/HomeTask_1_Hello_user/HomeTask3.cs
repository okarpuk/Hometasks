using System;
using System.Linq;

namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class HomeTask3
    {
        public static void Tasks()
        {
            HW3_T0_Is_Number_in_array();
            //HW3_T1_Delete_Entered_Number();
            HW3_T2_Delete_Max_Min_Mid_Value();

        }

        // TASK 0 - Is_Number_in_array
        public static void HW3_T0_Is_Number_in_array()
        {
            int[] numbers = { 17, 2, 55, 6, 11, };
            Console.WriteLine("Please enter your number");
            int findNumber = int.Parse(Console.ReadLine());
            bool checkNumber = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (findNumber == numbers[i])
                {
                    checkNumber = true;
                }
            }

            if (checkNumber == true)
            {
                Console.WriteLine("Entered number is in array");
            }
            else
            {
                Console.WriteLine("Entered number is not in array");
            }
        }

        /*
        //TASK 1 - DELETE_ENTERED_NUMBER        
        
            public static void HW3_T1_Delete_Entered_Number()
        {
            int[] myArray = { 11, 32, 3, 44, 51 };
            int indexToDelete = Array.IndexOf(myArray, int.Parse(Console.ReadLine()));

            
            
            
            
            bool checkNumber = false;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (indexToDelete == myArray[i])
                {
                    checkNumber = true;
                }
            }

            if (checkNumber == true)
            {
                //RemoveAt(ref myArray, indexToDelete);
            }
            else
            {
                Console.WriteLine("Entered number is not in array");
            }      
        }
        */



        //TASK 2 - MAX_MIN_MID_VALUE
        public static void HW3_T2_Delete_Max_Min_Mid_Value()
        {
            Console.WriteLine("Enter array length");
            int[] myArray = new int[int.Parse(Console.ReadLine())];
            Random random = new Random();
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 20);
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Max value of array is " + myArray.Max());
            Console.WriteLine("Min value of array is " + myArray.Min());
            Console.WriteLine("Average value of array is " + myArray.Average());
        }


    
    
    
    
    
    
    
    
    
    
    
    
    
    }

}

