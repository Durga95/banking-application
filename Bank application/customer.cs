using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_application
{
    public class Customer
    {
        public int TotalBalance { get; private set;}

        public int InvalidEntries { get; private set; }

        public bool IsAccountNumberValid(string acNumber)
        {
            if(acNumber.Length != 16)
            {
                InvalidEntries += 1;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CreditAmount(int balance)
        {
            TotalBalance += balance;
        }

        public string GetAccountDetails(CustomerDetails customerDetails)
        {
            return $"Dear {customerDetails.Name}, your {customerDetails.BankName} account { customerDetails.AccountNumber } has a total balance of { TotalBalance }. Thank you";
        }

        public bool WantedToAddMoreMoney(string userDecision)
        {
            if(userDecision=="true")
            {
                userDecision.ToLower();
               return true;
            }
            else
            { 
                userDecision.ToLower();
                return false;
            }
        }
    }
}
