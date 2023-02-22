namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework_2_Task_3_Weather_translator();
        }

        public static void Homeworks()
        {
            Homework_1_Hello_user();

            Homework_2_Task_1_Calculator();
            Homework_2_Task_2_Number_ranges();
            Homework_2_Task_3_Weather_translator();
            Homework_2_Task_4();
        }

        // HOMEWORK #1
        // HELLO USER
        public static void Homework_1_Hello_user()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !!!");
        }

        // HOMEWORK #2
        // TASK 1 - CALCULATOR
        public static void Homework_2_Task_1_Calculator()
        {
            Console.WriteLine("Please enter first number");
            double operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter operation");
            string sign = (Console.ReadLine());

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        double result = operand1 + operand2;
                        Console.WriteLine("Addition result = " + result);
                        break;
                    }

                case "-":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        double result = operand1 - operand2;
                        Console.WriteLine("Subtraction result = " + result);
                        break;
                    }

                case "*":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        double result = operand1 * operand2;
                        Console.WriteLine("Multiplication result = " + result);
                        break;
                    }

                case "/":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        double result = operand1 / operand2;
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Warning! Can't divide by zero!");
                        }
                        else
                        {
                            Console.WriteLine("Division result = " + result);
                        }
                        break;
                    }
            }
        }

        // TASK 2 - NUMBER RANGES
        public static void Homework_2_Task_2_Number_ranges()
        {
            Console.WriteLine("Please enter your number");
            int number = int.Parse(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("Entered number is in [0-14] range");
            }

            else
            if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Entered number is in [15-35] range");
            }

            else
            if ((number >= 36) && (number <= 49))
            {
                Console.WriteLine("Entered number is in [36-49] range");
            }

            else
            if ((number >= 36) && (number <= 49))
            {
                Console.WriteLine("Entered number is in [50-100] range");
            }

            else
            {
                Console.WriteLine("Entered number is out of [0-100] range");
            }
        }

        









    }




}