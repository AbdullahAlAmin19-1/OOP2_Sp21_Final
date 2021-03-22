using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Account a1 = new Account("Abdullah", "1234", 5000);
            Account a2 = new Account("Al-Amin", "4321", 4000);
            a1.Withdraw(500);
            a1.Deposit(1000);
            a1.Transfer(1000, a2);
            a1.showAllTransactions();
            a2.showAllTransactions();
        }
    }
}
