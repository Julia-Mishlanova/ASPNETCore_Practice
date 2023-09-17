using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IBookingService
    {
        IEnumerable<BookingDTO> GetAllBookings();
        BookingDTO GetBookingById(int id);
        void AddBooking(BookingDTO booking);
        void UpdateBooking(BookingDTO booking);
        void DeleteBooking(int id);
    }
}
