using System.Collections.Generic;
using CSVReadAveragePrice.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace CSVReadAveragePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] prod = sr.ReadLine().Split(',');
                    string productName = prod[0];
                    double price = double.Parse(prod[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(productName, price));

                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine("Average price " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p=> p.Name);
            
            foreach(var p in names)
            {
                Console.WriteLine(p);
            }





        }
    }
}