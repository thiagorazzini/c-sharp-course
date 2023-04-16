using System;
using System.Globalization;

namespace Employee
{
    internal class Person
    {
        public string Name;
        public double Salary;
        public double Taxes;
        public double GrowthSalary;


        public void calcSalary()
        {
            Salary -=  Taxes;
        }

        public void growthSalaryCalc()
        {
            GrowthSalary = GrowthSalary / 100;

            Salary += ((Salary + Taxes) * GrowthSalary);
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
