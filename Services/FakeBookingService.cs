using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeBookingService : IBookingService
    {
        private List<BookingDTO> bookings;
        private int nextId = 1;

        public FakeBookingService()
        {
            bookings = new List<BookingDTO>
            {
                new BookingDTO { Id = nextId++, ClientId = 1, FlightId = 101 },
                new BookingDTO { Id = nextId++, ClientId = 2, FlightId = 102 },
                new BookingDTO { Id = nextId++, ClientId = 3, FlightId = 103 }
            };
        }

        public IEnumerable<BookingDTO> GetAllBookings()
        {
            return bookings;
        }

        public BookingDTO GetBookingById(int id)
        {
            return bookings.FirstOrDefault(b => b.Id == id);
        }

        public void AddBooking(BookingDTO booking)
        {
            booking.Id = nextId++;
            bookings.Add(booking);
        }

        public void UpdateBooking(BookingDTO updatedBooking)
        {
            var existingBooking = bookings.FirstOrDefault(b => b.Id == updatedBooking.Id);
            if (existingBooking != null)
            {
                existingBooking.ClientId = updatedBooking.ClientId;
                existingBooking.FlightId = updatedBooking.FlightId;
            }
        }

        public void DeleteBooking(int id)
        {
            var bookingToDelete = bookings.FirstOrDefault(b => b.Id == id);
            if (bookingToDelete != null)
            {
                bookings.Remove(bookingToDelete);
            }
        }
    }
}
