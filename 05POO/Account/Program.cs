using System;
using System.Collections.Generic;
using System.Globalization;
using Bank.Entities;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Ana", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 500.0));
            list.Add(new SavingsAccount(1003, "Joao", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Pedro", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account"
                    + acc.Number
                    + ": "
                    +acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }


            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 300.0, 500.0);
            //SavingsAccount sacc = new SavingsAccount(1003, "Ana", 300.0, 0.01);

            //bacc.Withdraw(10.0);
            //sacc.Withdraw(10.0);

            //Console.WriteLine("Businness Account" + bacc.Balance);
            //Console.WriteLine("Savings Account " + sacc.Balance);

            ////UPCASTING
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 500.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            ////BusinnessAccount acc5 = (BusinessAccount);
            //if (acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}

        }
    }
}
