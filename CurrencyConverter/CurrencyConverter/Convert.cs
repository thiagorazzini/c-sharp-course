using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Convert
    {
        public static double Iof = 0.06;

        public static double CalcValue(double valueToBuy, double quantity)
        {
            double taxes = (valueToBuy * quantity) * Iof;
            double totalValue = (valueToBuy * quantity) + taxes;

            return totalValue;  
        }
    }
}
