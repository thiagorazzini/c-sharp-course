using System.Globalization;

namespace ActionMethodsStudies.Entities
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}
