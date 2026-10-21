using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; private set; } =0;

        public BankAccount(int accountNumber, string ownerName)
        {

            AccountNumber = accountNumber;
            OwnerName = ownerName;
        

        }
        public decimal Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return Balance;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return Balance;
            }
            else
            {
                throw new ArgumentException("Withdrawal amount must be positive and less than or equal to the current balance.");
            }


        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

}
