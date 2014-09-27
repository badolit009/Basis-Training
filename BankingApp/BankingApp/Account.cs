using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;

        public void Deposit(double amount)
        {
               balance =amount;
        }

        public void Withdraw(double amount)
        {
            balance = amount;
        }

        public string GetNameAccount()
        {
          return  customerName + " , Your Account Number : " + accountNumber;

        }



    }
}
