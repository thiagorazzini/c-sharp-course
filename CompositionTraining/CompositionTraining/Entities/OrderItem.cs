using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionTraining.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price
                + " Quantity: "
                + Quantity
                + " Subtotal: $"
                + SubTotal();
        }

    }
}
