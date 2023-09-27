using ASPNETCore_Practice.DataAccess.Repository.IRepository;
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
        private IBookingRepository _bookingRepository;
        private List<BookingDTO> bookings;
        private int nextId = 1;

        public FakeBookingService()
        {
            bookings = new List<BookingDTO>
            {
                new BookingDTO { Id = nextId++, ClientId = 1, FlightSeatPriceId = 101 },
                new BookingDTO { Id = nextId++, ClientId = 2, FlightSeatPriceId = 102 },
                new BookingDTO { Id = nextId++, ClientId = 3, FlightSeatPriceId = 103 }
            };
        }

        public IEnumerable<BookingDTO> GetAllBookings()
        {
            return _bookingRepository.GetAll();
        }

        public BookingDTO GetBookingById(int id)
        {
            return _bookingRepository.Find(id);
        }

        public void AddBooking(BookingDTO booking)
        {
            _bookingRepository.Add(booking);
        }

        public void UpdateBooking(BookingDTO updatedBooking)
        {
            _bookingRepository.Update(updatedBooking);
        }

        public void DeleteBooking(int id)
        {
            var bookingToDelete = _bookingRepository.Find(id);
            if (bookingToDelete != null)
            {
                _bookingRepository.Remove(bookingToDelete);
            }
        }
    }
}
