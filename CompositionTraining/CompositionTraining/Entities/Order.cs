﻿using CompositionTraining.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CompositionTraining.Entities
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


        public void addIdem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveIdem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double total()
        {
            double sum = 0.0;

            foreach (OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " +  Client);
            sb.AppendLine("Order items");
            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());

            }
            sb.AppendLine("Total price: $" + total());
            return sb.ToString();
        }


    }
}
