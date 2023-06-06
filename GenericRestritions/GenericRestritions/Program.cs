using GenericRestritions.Entities;
using GenericRestritions.Services;
using System.Globalization;

namespace GenericRestritions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationServices calculationServices = new CalculationServices();

            Product max = calculationServices.Max(list);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(max);
        }
    }
}