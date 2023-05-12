using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InherintAndPolimorfism.Entities
{
    sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() 
        {
            
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
            + " (used) $ "
                   + Price.ToString("F2", CultureInfo.InvariantCulture)
                   + $"(Manufactue date fee: $ {ManufactureDate.ToString("dd/MM/yyyy")}) ";
        }

    }
}
