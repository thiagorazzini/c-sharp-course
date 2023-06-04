using System.Globalization;
using InterfaceConsolidationExercise.Entities;
using InterfaceConsolidationExercise.Services;

namespace InterfaceConsolidationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int contractInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalServices());
            contractService.ProcessContract(contract, contractInstallments);

            Console.WriteLine("Installments: ");
           
            
            
            foreach(Installments installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }

        }
    }
}