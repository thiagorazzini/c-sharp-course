using ActionMethodsStudies.Entities;

namespace ActionMethodsStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();

            products.Add(new Products("Tv", 900.00));
            products.Add(new Products("Mouse", 50.00));
            products.Add(new Products("Tablet", 350.50));
            products.Add(new Products("HD Case", 80.90));

            //Action<Products> act = p => { p.Price += p.Price * 0.1; };

            products.ForEach(p => { p.Price += p.Price * 0.1; };);

            foreach (var product in products) {
                Console.WriteLine(product);
            }
            


        }

        static void UpdatePrice(Products products)
        {
            products.Price += products.Price * 0.1;
        }
    }
}