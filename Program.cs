using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                // Variables
                string userName = UserInput.GetUserName();
                int num = UserInput.GetUserNumber(userName);
                bool isEven = IsNumEven(userName, num);
                char runAgain;

                // if int is odd and greater than 60  print "num and odd"
                if (!(isEven) && num > 60)
                {
                    Console.WriteLine($"{userName}'s Number is {num} and Odd");
                }
                // if int is even and between 2 to 25 print "even and less than 25"
                else if (isEven && (num > 1 && num <= 25))
                {
                    Console.WriteLine($"{userName}'s Number is Even and less than 25");
                }
                // if int is even and between 26 and 60 print "even"
                else if (isEven && (num >= 26 && num <= 60))
                {
                    Console.WriteLine($"{userName}'s Number is Even");
                }
                // if int is even and greater than 60  print "num and even"
                else if (isEven && num > 60)
                {
                    Console.WriteLine($"{userName}'s Number is {num} and Even");
                }
                // If int is odd print "odd"
                else if (!isEven)
                {
                    Console.WriteLine($"{userName}'s Number is Odd");
                }

                Console.WriteLine("Continute? (y/n)");
                runAgain = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                if (runAgain != 'y')
                {
                    Console.WriteLine($"Thanks for playing {userName}! Goodbye!");
                    isRunning = false;
                }
            }
        }

        private static class UserInput
        {
            public static string GetUserName()
            {
                // Give the user instruction / ask for input
                Console.WriteLine("Hello there! What is your name?");
                string userName = Console.ReadLine();
                return userName;
            }

            public static int GetUserNumber(string userName)
            {
                Console.Write($"Hello {userName}! Please enter a number between 1 and 100: ");
                int userNumber = Int32.Parse(Console.ReadLine());
                return userNumber;

            }
        }

        private static bool IsNumEven(string userName, int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsValidNumber(string numIn)
        {
            return !string.IsNullOrWhiteSpace(numIn) && int.TryParse(numIn, out _);
        }
    }
}
