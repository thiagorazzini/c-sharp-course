using System.Globalization;
namespace StaticMembers
{
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circumference(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circumference(double r)
        {
            return 2.0 * pi * r;
        }

        static double Volume( double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}