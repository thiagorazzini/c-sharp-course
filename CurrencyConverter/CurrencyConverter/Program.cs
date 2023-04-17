using System.Globalization;
namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar, quantity;
            Console.Write("Qual é a cotação do dólar ?");
            dollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor pago em reais = {Convert.CalcValue(quantity, dollar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}