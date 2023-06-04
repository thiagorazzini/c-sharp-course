using ContractProcess.Entities;
using ContractProcess.Services;
using System.Globalization;

namespace ContractProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, date, contractValue);
            ContractServices contractProcess = new ContractServices(new PaypalServices());

            contractProcess.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach(Installments installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }



        }
    }
}