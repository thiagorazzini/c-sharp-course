using ServiceCarRent.Entities;
using ServiceCarRent.Services;
using System.Globalization;

namespace ServiceCarRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) ;
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRentel carRentel = new CarRentel(start, finish, new Vehicle(model));
            RentelService rentelService = new RentelService(hour, day, new BrazilTaskService());

            rentelService.ProcessInvoice(carRentel);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRentel.Invoice);



        }
    }
}