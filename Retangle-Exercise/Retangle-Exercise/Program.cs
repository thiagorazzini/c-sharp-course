using System.Globalization;

namespace Retangle_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangle retangle = new Retangle();

            Console.WriteLine("Entre a largura e altura do retângulo");
            retangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangle.Height = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangle);
        }
    }
}