using AbstractTrainingExercise.Entities;
using System.Globalization;

namespace AbstractTrainingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int payersQuantity = int.Parse(Console.ReadLine());
            List<TaxPayers> list = new List<TaxPayers>();

            for (int i = 1; i <= payersQuantity; i++)
            {
                Console.Write("Individual or company (i/c) ? ");
                char typePayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(typePayer == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Individual individual = new Individual(name, anualIncome, healthExpenditures);
                    list.Add(individual);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());

                    Company company = new Company(name, anualIncome, numberOfEmployee);
                    list.Add(company);
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayers taxPayers in list)
            {
                Console.WriteLine($"{taxPayers.Name}: ${taxPayers.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            double sum = 0.0;

            foreach(TaxPayers taxPayers in list)
            {
                sum += taxPayers.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}