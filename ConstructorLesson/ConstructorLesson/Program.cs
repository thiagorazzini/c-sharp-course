using Product;
using System.Globalization;

namespace ConstructorLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductNam p = new ProductNam("TV", 500.00, 10);

            p.Name = "T";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Quantity);

        }
    }
}