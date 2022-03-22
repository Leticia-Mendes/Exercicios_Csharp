using System;
using BankAccount.Entities;
using BankAccount.Entities.Exceptions;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawBalance = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawBalance);

            Console.WriteLine();
            Console.Write("Enter amount for deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Nem balance: " + account.Balance.ToString(("F2")));

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("Nem balance: " + account.Balance.ToString(("F2")));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}