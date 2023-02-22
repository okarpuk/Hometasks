namespace HomeTask_1_Hello_user.HomeTask_1_Hello_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework_2_Task_4_Even_Odd_V2();
        }

        public static void Homeworks()
        {
            Homework_1_Hello_user();

            Homework_2_Task_1_Calculator();
            Homework_2_Task_2_Number_ranges();
            Homework_2_Task_3_Weather_translator();
            Homework_2_Task_4_Even_Odd_V1();
            Homework_2_Task_4_Even_Odd_V2();
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

        // TASK 3 - WEATHER TRANSLATOR
        public static void Homework_2_Task_3_Weather_translator()
        {
            Console.WriteLine("Please enter the word about weather on russian to get english translation");
            string word = Console.ReadLine();

            switch (word)
            {
                //1
                case "солнечно":
                    {
                        Console.WriteLine("sunny");
                        break;
                    }
                //2
                case "пасмурно":
                    {
                        Console.WriteLine("cloudy");
                        break;
                    }
                //3
                case "ветер":
                    {
                        Console.WriteLine("wind");
                        break;
                    }
                //4
                case "дождь":
                    {
                        Console.WriteLine("rain");
                        break;
                    }
                //5
                case "снег":
                    {
                        Console.WriteLine("snow");
                        break;
                    }
                //6
                case "ураган":
                    {
                        Console.WriteLine("hurricane");
                        break;
                    }
                //7
                case "температура":
                    {
                        Console.WriteLine("temperature");
                        break;
                    }
                //8
                case "давление":
                    {
                        Console.WriteLine("pressure");
                        break;
                    }
                //9
                case "туман":
                    {
                        Console.WriteLine("fog");
                        break;
                    }
                //10
                case "влажность":
                    {
                        Console.WriteLine("humidity");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This word is not in the dictionary");
                        break;
                    }
            }
        }

        // TASK 4 - EVEN_ODD VERSION 1
        public static void Homework_2_Task_4_Even_Odd_V1()
        {
            Console.WriteLine("Please enter your number");
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;
            if (result == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }

        // TASK 5 - EVEN_ODD VERSION 2
        public static void Homework_2_Task_4_Even_Odd_V2()
        {
            Console.WriteLine("Please enter your number");
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;

            switch (result)
            {
                case 0:
                    {
                        Console.WriteLine("Even number");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Odd number");
                        break;
                    }
            }
        }
    }
}