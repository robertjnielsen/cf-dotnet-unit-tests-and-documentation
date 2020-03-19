using System;

namespace UnitTestingAndDocumentation
{
    class Program
    {
        /// <summary>
        /// The user's current banking balance.
        /// </summary>
        private static decimal balance = 42.57M;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To FakeBank!");
            Menu();
        }

        /// <summary>
        /// Allows the user to select from a variety of menu options, and calls the appropriate method(s) in response to the user's selection.
        /// </summary>
        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Please input a menu number to make a selection:");
            Console.WriteLine("1) View My Balance \n2) Withdraw Funds \n3) Deposit Funds \n4) Exit ATM");
            int menuSelection;
            bool validSelection = int.TryParse(Console.ReadLine(), out menuSelection);
            if (validSelection)
            {
                switch (menuSelection)
                {
                    case 1:
                        // call balance method
                        Console.WriteLine();
                        GetBalance();
                        Menu();
                        break;
                    case 2:
                        // call withdraw method
                        Console.WriteLine("Withdraw method goes here.");
                        break;
                    case 3:
                        // call deposit method
                        Console.WriteLine("Deposit method goes here.");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose a valid menu option.");
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please choose a valid menu option.");
                Menu();
            }

        }

        /// <summary>
        /// Retrieves the current balance and outputs it to the console.
        /// </summary>
        static void GetBalance()
        {
            Console.WriteLine($"Your current balance is ${balance}");
        }
    }
}
