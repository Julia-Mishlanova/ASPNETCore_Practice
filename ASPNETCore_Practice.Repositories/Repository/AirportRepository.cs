using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.Domain;
using ASPNETCore_Practice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.DataAccess.Repository
{
    public class AirportRepository : Repository<Airport>, IAirportRepository
    {
        private readonly ApplicationDbContext _db;
        public AirportRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Airport obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.City = obj.City;
                objFromDb.CountryId = obj.CountryId;
            }
        }
    }
}
