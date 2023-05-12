using solvedExerciseHeranca.Entities;
using System.Globalization;

namespace solvedExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number employees: ");
            int qntEmployee = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= qntEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsorcedQuestion = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();
                Console.Write("Hours: ");
                int workedHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(outsorcedQuestion == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourceEmployee(nameEmployee, workedHours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(nameEmployee, workedHours, valuePerHour));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}