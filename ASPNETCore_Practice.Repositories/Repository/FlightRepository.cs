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
    public class FlightRepository : Repository<FlightDTO>, IFlightRepository
    {
        private readonly ApplicationDbContext _db;

        public FlightRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FlightDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.FlightStatusId = obj.FlightStatusId;

                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
