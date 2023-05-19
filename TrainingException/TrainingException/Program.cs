using System.Globalization;
using TrainingException.Entities;
using TrainingException.Entities.Exception;

namespace TrainingException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(accountNumber, accountHolder, initialBalance, withDrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(withdrawValue);
                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }


        }
    }
}