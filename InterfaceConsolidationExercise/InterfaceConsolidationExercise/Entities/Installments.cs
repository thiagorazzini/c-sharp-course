using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsolidationExercise.Entities
{
    internal class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dataDue, double amount)
        {
            DueDate = dataDue;
            Amount = amount;
        }


        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
