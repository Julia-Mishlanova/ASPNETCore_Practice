using ASPNETCore_Practice.DataAccess.Data;
using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.DataAccess.Repository
{
    public class ScheduleRepository : Repository<ScheduleDTO>, IScheduleRepository
    {
        private readonly ApplicationDbContext _db;
        public ScheduleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ScheduleDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ArrivalTimeGMT = obj.ArrivalTimeGMT;
                objFromDb.DepartureTimeGMT = obj.DepartureTimeGMT;
                objFromDb.DirectionId = obj.DirectionId;

                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
