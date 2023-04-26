using System.Collections.Generic;
using System.Globalization;

namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ? ");
            int employeeToRegister = int.Parse(Console.ReadLine());
            List<EmployeeRegister> list = new List<EmployeeRegister>(employeeToRegister);
            EmployeeRegister employee = new EmployeeRegister(0, "", 0.0) ; 
            

            for(int i = 1; i <= employeeToRegister; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                list.Add(new EmployeeRegister(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
             int idSearch = int.Parse(Console.ReadLine());
            EmployeeRegister idEmployeeSearching = list.Find(x => x.Id == idSearch);

            if (idEmployeeSearching != null)
            {
                Console.Write("Enter the percentage: ");
                double thePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idEmployeeSearching.increaseSalary(thePercentage);
            }
            else
            {
                Console.WriteLine("The id dows not exist!");
            }

            Console.WriteLine( );
            Console.WriteLine("Updated list of employees: ");
            foreach (EmployeeRegister employeeRegister in list) { 
                Console.WriteLine($"{employeeRegister.Id}, {employeeRegister.Name}, {employeeRegister.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }




        }
    }
}