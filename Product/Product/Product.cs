using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Product
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalValue()
        {
            return Price * Quantity;
        }


        public void AddProducts(int quantity)
        {

            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {

            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $"
                + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
