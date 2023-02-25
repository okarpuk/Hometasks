namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class HomeTask3
    {
        public static void Tasks()
        {
            Homework_3_Task_0_Is_Number_in_array();
        }

        // TASK 0 - Is_Number_in_array
        public static void Homework_3_Task_0_Is_Number_in_array()
        {
            int[] numbers = { 17, 2, 55, 6, 11, };
            Console.WriteLine("Please enter your number");
            int findNumber = int.Parse(Console.ReadLine());
            bool check = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (findNumber == numbers[i])
                {
                    check = true;
                }
            }

            if (check == true)
            {
                Console.WriteLine("Entered number is in array");
            }
            else
            {
                Console.WriteLine("Entered number is not in array");
            }
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
