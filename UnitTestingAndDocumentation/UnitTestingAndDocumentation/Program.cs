using System;

namespace UnitTestingAndDocumentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Welcome To FakeBank!");
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
                        Console.WriteLine("Balance method goes here.");
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
    }
}
