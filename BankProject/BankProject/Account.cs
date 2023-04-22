using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Account
    {
        public string NameOwner { get; set; }
        public int AccountNumber  { get; private set; }
        public double Balance { get; private set; }

        public Account( int accountNumber, string nameOwner)
        {
            NameOwner = nameOwner;
            AccountNumber = accountNumber;
   
        }

        public Account(int accountNumber, string nameOwner, double balanceInitial) : this(accountNumber, nameOwner)
        {
            Deposit(balanceInitial);
        }
        

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }


        public void Withdrawal(double value)
        {
            
            Balance -= value + 5;

        }
        public override string ToString()
        {
            return "Conta "
                   + AccountNumber
                   + ", Titular: "
                   + NameOwner
                   + ", Saldo: $ "
                   + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
