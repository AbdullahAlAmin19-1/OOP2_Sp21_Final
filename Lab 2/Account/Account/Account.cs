﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account : Transaction
    {
        string accName;
        string accid;
        int balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public Account() { listOfTransaction = new Transaction[100]; }

        public Account(string accName, string accid, int balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
            listOfTransaction = new Transaction[100];
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Money Deposit Completed.");
            Console.WriteLine();
            Transaction t= new Transaction(this, this, amount, "Self Deposit");
            this.addtransaction(t);
        }

        public void Withdraw(int amount)
        {
            if(balance>amount)
            {
            balance = balance - amount;
            Console.WriteLine("Money Withdraw Completed.");
            Console.WriteLine();
            Transaction t = new Transaction(this, this, amount, "Self Withdraw");
            this.addtransaction(t);
            }
            else
            {
                Console.WriteLine("Insufficien Balance");
                Console.WriteLine();
            } 
        }
        public void Transfer(int amount, Account acc)
        {
            if(balance>amount)
            {
            balance = balance - amount;
            acc.Balance = acc.Balance + amount;
            Console.WriteLine("Balance Transfered.");
            Console.WriteLine();
            Transaction t = new Transaction(this, acc, amount, "Money Transfer");
            this.addtransaction(t);
            acc.addtransaction(t);
            }
            else
            {
                Console.WriteLine("Insufficien Balance");
                Console.WriteLine();
            }   
        }

        public int TotalNumberOfTransaction { get; set; }

        private Transaction[] listOfTransaction;

        public void addtransaction(Transaction transaction)
        {
            listOfTransaction[TotalNumberOfTransaction++] = transaction;

                
        }
        public void showAllTransactions()
        {
            for (int i = 0; i < TotalNumberOfTransaction; ++i)
            {
                listOfTransaction[i].showInfo();
            }
        }
    }
}
