using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositionStudiesExercise.Entities.Enums;

namespace CompositionStudiesExercise.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public void addItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }


        public double total()
        {
            double sum = 0.0;

            foreach (OrderItem item in OrderItem)
            {
                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Ordem items");
            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: {total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }


    }
}
