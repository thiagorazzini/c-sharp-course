using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class EmployeeRegister
    {


        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public EmployeeRegister(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary *= (percentage / 100);
        }
    }
}
