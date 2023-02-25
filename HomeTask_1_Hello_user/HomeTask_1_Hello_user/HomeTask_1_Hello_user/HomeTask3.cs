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
            HW3_T2_Max_Min_Average_Value();

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



        //TASK 2 - MAX_MIN_AVERAGE_VALUE
        public static void HW3_T2_Max_Min_Average_Value()
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

        //TASK 3 - AVERAGE_OF_ARRAY_ELEMENTS
        public static void HW3_T3_Average_of_array_elements()
        {
            int[] myArray1 = new int[5];
            Random random1 = new Random();
            for (int i1 = 0; i1 < myArray1.Length; i1++)
            {
                myArray1[i1] = random1.Next(1, 50);
                Console.Write(myArray1[i1] + " ");
            }
            Console.WriteLine();

            int[] myArray2 = new int[5];
            Random random2 = new Random();
            for (int i2 = 0; i2 < myArray2.Length; i2++)
            {
                myArray2[i2] = random2.Next(1, 50);
                Console.Write(myArray2[i2] + " ");
            }
            Console.WriteLine();

            double average1 = (double)myArray1.Sum() / 5;
            Console.WriteLine("Average of array #1 is " + "{0: 0.00}", average1);

            double average2 = (double)myArray2.Sum() / 5;
            Console.WriteLine("Average of array #2 is " + "{0: 0.00}", average2);

            if (average1 > average2)
            {
                Console.WriteLine("Average of array #1 is bigger then average of array #2");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("Average of array #2 is bigger then average of array #1");
            }
            else
            {
                Console.WriteLine("Average of array #1 is the same like average of array #2");
            }
        }


    }

}

