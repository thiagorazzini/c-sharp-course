using InherintAndPolimorfism.Entities;
using System.Globalization;
namespace InherintAndPolimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c')
                {
                    products.Add(new Product(productName, productPrice));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY) ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                }else
                {
                    Console.Write("Customs fee: ");
                    double customFeeValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(productName, productPrice, customFeeValue));
                }



            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }


        }
    }
}