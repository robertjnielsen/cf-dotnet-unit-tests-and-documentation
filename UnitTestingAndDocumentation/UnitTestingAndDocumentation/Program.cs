using System;

namespace UnitTestingAndDocumentation
{
    public class Program
    {
        /// <summary>
        /// The user's current banking balance.
        /// </summary>
        public static decimal Balance = 42.57M;
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
                        Console.WriteLine();
                        GetBalance();
                        Menu();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("How much would you like to withdraw?");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        Balance = WithdrawFunds(withdrawAmount);
                        GetBalance();
                        Menu();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("How much would you like to deposit?");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        Balance = DepositFunds(depositAmount);
                        GetBalance();
                        Menu();
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
        public static void GetBalance()
        {
            Console.WriteLine($"Your current balance is ${Balance}");
        }

        /// <summary>
        /// Determines if there is a large enough balance left to withdraw funds. If there is, then the funds are withdrawn and the remaining balance is returned.
        /// </summary>
        /// <param name="withdrawAmount">The amount that the user has specified to withdraw from the account.</param>
        /// <returns>The current remaining balance in the account.</returns>
        public static decimal WithdrawFunds(decimal withdrawAmount)
        {
            if (withdrawAmount > Balance)
            {
                Console.WriteLine("You do not have enough funds to complete this transaction.");
                return Balance;
            }
            decimal currentBalance = Balance - withdrawAmount;
            return currentBalance;
        }

        /// <summary>
        /// Adds the deposit amount specified by the user to the account balance.
        /// </summary>
        /// <param name="depositAmount">The amount that the user has specified to deposit to the account.</param>
        /// <returns>The current remaining balance in the account.</returns>
        public static decimal DepositFunds(decimal depositAmount)
        {
            if (depositAmount < 0)
            {
                Console.WriteLine("You can not deposit a negative amount.");
                return Balance;
            }
            decimal currentBalance = Balance + depositAmount;
            return currentBalance;
        }
    }
}
