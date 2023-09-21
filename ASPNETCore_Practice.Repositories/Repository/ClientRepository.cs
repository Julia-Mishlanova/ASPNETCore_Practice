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
    public class ClientRepository : Repository<ClientDTO>, IClientRepository
    {
        private readonly ApplicationDbContext _db;
        public ClientRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ClientDTO obj)
        {
            var objFromDb = base.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Phone = obj.Phone;
                objFromDb.FullName = obj.FullName;
                objFromDb.CountryId = obj.CountryId;
                
                _db.Update(objFromDb);
                _db.SaveChanges();
            }
        }
    }
}
