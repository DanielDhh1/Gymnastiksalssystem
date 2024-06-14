using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gymnastiksalssystem
{
    public class BookingManager
    {
        public int HallId { get; set; }
        public DateTime Hour { get; set; }
        public DateTime Day { get; set; }

        public BookingManager(int hallid, DateTime hour, DateTime day)
        {
            HallId = hallid;
        }

            List<BookingManager> bookings = new List<BookingManager>();

            public void AddBooking(BookingManager booking)
            {
                booking.AddBooking(booking);
            }
            public void RemoveBooking(BookingManager booking)
            {
                booking.RemoveBooking(booking);
            }
            public void UpdateBooking(BookingManager updatedBooking)
            {
                BookingManager bookingToUpdate = bookings.Find(b => b.HallId == updatedBooking.HallId);
                if (bookingToUpdate != null)
                {
                    bookingToUpdate.HallId = updatedBooking.HallId;
                    bookingToUpdate.Day = updatedBooking.Day;
                    bookingToUpdate.Hour = updatedBooking.Hour;
                }

            }
            public void PrintAllBookings()
            {
                foreach (BookingManager booking in bookings)
                {
                    Console.WriteLine($"Booking ID: {booking.HallId}, Bestilt dag: {booking.Day}, Tidsrummet: {booking.Hour} ");
                }
            }
        }
    }
}
