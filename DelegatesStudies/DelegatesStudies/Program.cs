using DelegatesStudies.Services;

namespace DelegatesStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;



            double result  = op(a, b);
            Console.WriteLine(result);
        }
    }
}