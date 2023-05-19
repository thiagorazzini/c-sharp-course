using CustomException.Entities;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out (dd/MM/yyyy): ");

            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be  after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }

        }
    }
}