using System.Globalization;

namespace ternaryExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double off = price < 20 ? price * 0.01 : price * 0.05 ;

            Console.WriteLine(off);


        }
    }
}