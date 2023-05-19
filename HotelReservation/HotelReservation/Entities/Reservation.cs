using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {
            
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            Checkout = checkout;
        }


        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkout)
        {
            CheckIn = checkIn;
            Checkout = checkout; 
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }
    }
}