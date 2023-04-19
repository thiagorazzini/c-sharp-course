using System.Globalization;

namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;

            char verify;
            double balance;


            Console.Write("Entre o número da conta: ");
            int account = int.Parse(Console.ReadLine());

            Account p = new Account(account);


            
            Console.Write("Entre o titular da conta: ");
            p.NameOwner = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            verify = char.Parse(Console.ReadLine());

            p.Verify(verify);



            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p);

            p.Deposit();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
            //Console.WriteLine($"Conta {account}, Titular: {nameOwner}, Saldo: ${balance.ToString("F2", CultureInfo.InvariantCulture)}");


            //Console.Write("Entre um valor para depósito: ");
            //value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //balance += value;
            //Console.WriteLine("Dados da conta atualizados: ");
            //Console.WriteLine($"Conta {account}, Titular: {nameOwner}, Saldo: ${balance.ToString("F2", CultureInfo.InvariantCulture)}");

            //Console.Write("Entre um valor para saque: ");
            //double withdrawal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //balance -= withdrawal + 5.00;

            //Console.WriteLine("Dados da conta atualizados: ");
            //Console.WriteLine($"Conta {account}, Titular: {nameOwner}, Saldo: ${balance.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}