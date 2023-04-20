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
        private string _nameOwner;
        public int AccountNumber  { get; private set; }
        private double _balance;



        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public string NameOwner
        {
            get { return _nameOwner; }
            set { _nameOwner = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public void Verify(char isDeposite)
        {
            if(isDeposite == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Balance += value;
            }
        }

        public void Deposit()
        {
            Console.Write("Entre um valor para deposito: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Balance += value;
        }


        public void Withdrawal()
        {
            Console.Write("Entre um valor para saque: ");
            double withDrawal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double rate = 5.00;
            Balance -= withDrawal;
            Balance -= rate;
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
