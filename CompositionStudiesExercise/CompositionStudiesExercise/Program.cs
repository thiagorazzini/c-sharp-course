using CompositionStudiesExercise.Entities;
using CompositionStudiesExercise.Entities.Enums;
using System.Globalization;

namespace CompositionStudiesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientMail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientMail, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus statusOrder = Enum.Parse<OrderStatus>(Console.ReadLine());
            

            Order order = new Order(DateTime.Now, statusOrder, client);
            Console.Write("How many items to this order ? ");
            int orderQuantity = int.Parse(Console.ReadLine());

            for(int i = 1; i <= orderQuantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}