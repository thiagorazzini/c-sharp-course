using System.Globalization;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            p.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            p.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.calcSalary();

            Console.WriteLine($"Funcionário: {p}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            p.GrowthSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.growthSalaryCalc();


            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}