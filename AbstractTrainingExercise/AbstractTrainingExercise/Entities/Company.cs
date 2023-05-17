using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrainingExercise.Entities
{
    internal class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }


        public Company()
        {
            
        }

        public Company(string name, double anualIncome, int numberOfEmployees):base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxValue = 0.0;
            if (NumberOfEmployees > 10) {
                taxValue = AnualIncome * 0.14;
            }
            else
            {
                taxValue = AnualIncome * 0.16;
            }

            return taxValue;
        }


    }
}
