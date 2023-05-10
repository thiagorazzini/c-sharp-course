using CompositionTraining.Entities;
using CompositionTraining.Entities.Enums;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CompositionTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client (name, email, birthDate);

            Console.WriteLine("Enter order data");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order: ");
            int quantityProducts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantityProducts; i++)
            {
                Console.WriteLine($"Enter ${i} item data: ");
                Console.Write("Product name: ");
                
            }










        }
    }
}