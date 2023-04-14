using System.Globalization;

namespace second_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Emproyee p1 = new Emproyee();
            Emproyee p2 = new Emproyee();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryAvarege = (p2.Salary + p1.Salary) / 2.0 ;

            Console.WriteLine($"Salário médio = {salaryAvarege.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}