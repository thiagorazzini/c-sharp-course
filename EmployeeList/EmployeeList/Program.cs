using System.Collections.Generic;

namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ? ");
            int employeeToRegister = int.Parse(Console.ReadLine());
            List<string> list = new List<string>(employeeToRegister);

            

            for(int i = 1; i <= employeeToRegister; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

            }





        }
    }
}