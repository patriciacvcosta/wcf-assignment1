using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1ServiceReference.Assignment_1_ServiceClient service = new Assignment1ServiceReference.Assignment_1_ServiceClient();

            string optionChoice;

            do
            {
                Console.Clear();

                Console.WriteLine("\t\tWCF Assignment 1");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");

                optionChoice = Console.ReadLine();

                if (!CheckIsInteger(optionChoice) || Convert.ToInt32(optionChoice) < 1 || Convert.ToInt32(optionChoice) > 6)
                {
                    Console.WriteLine("Please, inform a valid option from the menu. Press ENTER to return.");
                    Console.ReadLine();
                    continue;
                }
                else if (optionChoice == "1")
                {
                    Console.Write("Enter number to check if it's prime: ");
                    string number = Console.ReadLine();

                    while (!CheckIsInteger(number))
                    {
                        Console.Write("Please, inform a valid integer: ");
                        number = Console.ReadLine();
                    }
                    bool isPrime = service.CheckPrimeNumber(Convert.ToInt32(number));
                    if (isPrime)
                    {
                        Console.WriteLine(number + " IS a prime number. Press any key to return to main menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(number + " Is NOT a prime number. Press any key to return to main menu.");
                        Console.ReadLine();
                    }
                }
                else if (optionChoice == "2")
                {
                    Console.Write("Enter any positive integer number: ");
                    string number = Console.ReadLine();
                    while (!CheckIsPositiveInteger(number))
                    {
                        Console.Write("Please, inform a valid positive integer: ");
                        number = Console.ReadLine();
                    }
                    Console.WriteLine("The sum of digits is: " + service.SumDigits(Convert.ToInt32(number)));
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadLine();

                }
                else if (optionChoice == "3")
                {
                    Console.Write("Enter input: ");
                    string stringInput = Console.ReadLine();
                    while (string.IsNullOrEmpty(stringInput))
                    {
                        Console.Write("Please, inform a valid input: ");
                        stringInput = Console.ReadLine();
                    }
                    Console.WriteLine("The reverse string is: " + service.ReverseString(stringInput));
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadLine();

                }
                else if (optionChoice == "4")
                {
                    Console.WriteLine("Enter tag: ");
                    string tag = Console.ReadLine();
                    Console.WriteLine("Enter string: ");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine(service.PrintHtmlTags(tag, stringInput));
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadLine();
                }
                else if (optionChoice == "5")
                {
                    int [] numbers = new int[5];
                    string numberInput;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Inform number {i+1}: ");
                        numberInput = Console.ReadLine();
                        while (!CheckIsInteger(numberInput))
                        {
                            Console.Write("Please, inform a valid integer: ");
                            numberInput = Console.ReadLine();
                        }
                        numbers[i] = Convert.ToInt32(numberInput);
                    }

                    Console.Write("Press \"A\" for Ascending order or \"D\" for Descending order: ");
                    string order = Console.ReadLine();
                    while (order.ToUpper() != "A" && order.ToUpper() != "D")
                    {
                        Console.Write("Please, inform a valid sorting option -> \"A\" for Ascending or \"D\" for Descending: ");
                        order = Console.ReadLine();
                    }
                    Console.WriteLine("The sorted order is: " + service.SortNumbers(order, numbers));
                    Console.WriteLine("Press any key to return to main menu.");
                    Console.ReadLine();

                }

            } while (optionChoice != "6");

            Console.WriteLine("\nBye...");
            Console.ReadLine();
        }

        private static bool CheckIsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        private static bool CheckIsPositiveInteger(string input)
        {
            if (CheckIsInteger(input) && Convert.ToInt32(input) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
