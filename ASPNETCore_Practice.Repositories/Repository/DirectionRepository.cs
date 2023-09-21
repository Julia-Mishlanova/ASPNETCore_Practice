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
    public class DirectionRepository : Repository<DirectionDTO>, IDirectionRepository
    {
        private readonly ApplicationDbContext _db;
        public DirectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DirectionDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.OriginIataCode = obj.OriginIataCode;
                objFromDb.DestinationIataCode = obj.DestinationIataCode;

                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
