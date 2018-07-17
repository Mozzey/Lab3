using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userName;
            int num;
            char runAgain;
            bool isRunning = true;
            while (isRunning)
            {
                // Give the user instruction/ ask for input
                Console.WriteLine("Hello there! What is your name?");
                userName = Console.ReadLine();
                Console.Write($"Hello {userName}! Please enter a number between 1 and 100: ");
                num = Convert.ToInt32(Console.ReadLine());

                // If int is odd print "odd"
                if (num % 2 != 0)
                {
                    Console.WriteLine($"{userName}'s Number is Odd");
                }
                // if int is even and between 2 to 25 print "even and less than 25"
                else if (num % 2 == 0 && (num > 1 && num <= 25))
                {
                    Console.WriteLine($"{userName}'s Number is Even and less than 25");
                }
                // if int is even and between 26 and 60 print "even"
                else if (num % 2 == 0 && (num >= 26 && num <= 60))
                {
                    Console.WriteLine($"{userName}'s Number is Even");
                }
                // if int is even and greater than 60  print "num and even"
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine($"{userName}'s Number is {num} and Even");
                }
                // if int is odd and greater than 60  print "num and odd"
                else if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine($"{userName}'s Number is {num} and Odd");
                }

                Console.WriteLine("Continute? (y/n)");
                runAgain = Convert.ToChar(Console.ReadLine().ToLower());

                switch (runAgain)
                {
                    case 'y':
                        continue;
                    case 'n':
                        Console.WriteLine("Thanks for playing! Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter y or n");
                        break;
                }
            }
        }
    }
}
