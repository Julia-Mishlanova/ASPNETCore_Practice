﻿using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.Domain;
using ASPNETCore_Practice.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPNETCore_Practice.Models.DTO;

namespace ASPNETCore_Practice.DataAccess.Repository
{
    public class AirportRepository : Repository<AirportDTO>, IAirportRepository
    {
        private readonly ApplicationDbContext _db;
        public AirportRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(AirportDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.City = obj.City;
                objFromDb.CountryId = obj.CountryId;
                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
