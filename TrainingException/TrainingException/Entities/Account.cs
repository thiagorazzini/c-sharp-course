using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingException.Entities.Exception;
using System.Globalization;

namespace TrainingException.Entities
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
            
        }

        public Account(int accountNumber, string holder, double balance, double withDrawLimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;

        }

        public override string ToString()
        {
            return "New Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
