using ASPNETCore_Practice.DataAccess.Data;
using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.DataAccess.Repository
{
    public class BookingRepository : Repository<BookingDTO>, IBookingRepository
    {
        private readonly ApplicationDbContext _db;
        public BookingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookingDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ClientId = obj.ClientId;
                objFromDb.FlightSeatPriceId = obj.FlightSeatPriceId;
            }
            _db.Update(objFromDb);
            _db.SaveChanges();
        }
    }
}
