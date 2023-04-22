using System.Globalization;

namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account p;
            Console.Write("Entre o número da conta: ");
            int account = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string owner = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char verify = char.Parse(Console.ReadLine());
            if (verify == 's' || verify == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new Account (account, owner, value);

            }
            else
            {
                p = new Account(account, owner); 
            }


   


            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p);

            Console.Write("Entre um valor para deposito: ");
            double quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposit(quantity);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

            Console.Write("Entre um valor para saque: ");
            quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Withdrawal(quantity);

            Console.WriteLine(p);



        }
    }
}