using System;

namespace Bank_application
{
    public class Program
    {
        public static void Main(string[] args)
         {
            Customer c = new Customer();
            CustomerDetails cd = new CustomerDetails();
            Console.WriteLine("Please enter your bank name:");
            
           cd.BankName = Console.ReadLine();
            Console.WriteLine("Enter your Account number:");
            cd.AccountNumber = Console.ReadLine();
            bool isValidAccountNumber = c.IsAccountNumberValid(cd.AccountNumber);
            while(c.InvalidEntries <= 2 && isValidAccountNumber == false)
            {
                Console.WriteLine("Please enter your 16 digit Account number:");
                cd.AccountNumber = Console.ReadLine();
                isValidAccountNumber = c.IsAccountNumberValid(cd.AccountNumber);
            }

            if (isValidAccountNumber)
            {
                Console.WriteLine("Please enter your name:");
                cd.Name = Console.ReadLine();
                Console.WriteLine("How much amount you want to credit?");
                int amount = Int32.Parse(Console.ReadLine());
                c.CreditAmount(amount);
                Console.WriteLine("Do you want to add more money?");
                bool wantedToAddMoreMoney = Convert.ToBoolean(Console.ReadLine());
                while(wantedToAddMoreMoney)
                {
                    Console.WriteLine("How much amount you want to credit?");
                    amount = Int32.Parse(Console.ReadLine());
                    c.CreditAmount(amount);
                    Console.WriteLine("Do you want to add more money?");
                    wantedToAddMoreMoney = Convert.ToBoolean(Console.ReadLine());
                }

                Console.WriteLine(c.GetAccountDetails(cd));
            }
            else
            {
                Console.WriteLine("Sorry! You have reached the maximum number of trials");
            }

            Console.ReadLine();
        }
    }
}


