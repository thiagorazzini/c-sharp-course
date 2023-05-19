using System;
using HotelReservation.Entities.Exceptions;

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
            if (checkout <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

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
            DateTime now = DateTime.Now;
            if (checkIn < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update  must be future dates");

            }
            if (checkout <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
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