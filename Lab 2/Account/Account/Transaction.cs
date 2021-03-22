using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver{ get; set; }
        public int Amount { get; set; }
        public String AdditionalInfo { get; set; }

        public Transaction() { }
        public Transaction(Account Sender, Account Receiver, int Amount, String AdditionalInfo)
        {
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Amount = Amount;
            this.AdditionalInfo = AdditionalInfo;
        }

        public void showInfo()
        {
            Console.WriteLine("Sender Name:{0}; Account ID:{1}",Sender.AccName,Sender.Accid);
            Console.WriteLine("Receiver Name:{0}; Account ID:{1}", Receiver.AccName, Receiver.Accid);
            Console.WriteLine("Ammount:" + Amount);
            Console.WriteLine("Additional Information:" + AdditionalInfo);
            Console.WriteLine();
        }
    }
}
