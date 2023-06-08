using understandoHashCodeWorks.Entities;

namespace understandoHashCodeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod));//considera os endereços de memoria.

            Point p = new Point(3, 4);

            Console.WriteLine(b.Contains(p));
        }
    }
}