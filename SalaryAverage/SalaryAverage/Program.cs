using SalaryAverage.Entities;
using System.Globalization;
using System.IO;

namespace SalaryAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] employee = sr.ReadLine().Split(',');
                    string employeeName = employee[0];
                    string employeeEmail = employee[1];
                    double employeePrice = double.Parse(employee[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(employeeName, employeeEmail, employeePrice));
                }
            }

            Console.Write("Enter salary: ");
            double salaryAvg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than: " + salaryAvg.ToString("F2", CultureInfo.InvariantCulture));

            var avg = employees.Where(p => p.Salary > salaryAvg).OrderBy(p => p.Email).Select(p => p.Email);
            var salarySum = employees.Where(p => p.Name.StartsWith('M')).Sum(p => p.Salary);

            foreach(var em in avg)
            {
                Console.WriteLine(em);
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salarySum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}