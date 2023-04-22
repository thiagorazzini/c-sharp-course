using System.Globalization;
using System.Numerics;

namespace Array_Partll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Product[] products = new Product[n];

            for (int i = 0; i < products.Length; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;

            for (int i = 0; i < products.Length; i++)
            {
                sum += products[i].Price;
            }

            double avg = sum / products.Length;

            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}