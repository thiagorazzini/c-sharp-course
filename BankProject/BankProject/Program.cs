using System.Globalization;

namespace BankProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int account = int.Parse(Console.ReadLine());

            Account p = new Account(account);


            
            Console.Write("Entre o titular da conta: ");
            p.NameOwner = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char verify = char.Parse(Console.ReadLine());

            p.Verify(verify);



            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p);

            p.Deposit();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);


            p.Withdrawal();

            Console.WriteLine(p);



        }
    }
}