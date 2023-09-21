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
    public class FlightSeatPriceRepository : Repository<FlightSeatPriceDTO>, IFlightSeatPriceRepository
    {
        private readonly ApplicationDbContext _db;

        public FlightSeatPriceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FlightSeatPriceDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.FlightId = obj.FlightId;
                objFromDb.Price = obj.Price;

                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
