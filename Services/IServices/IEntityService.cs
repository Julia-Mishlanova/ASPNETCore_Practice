using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IEntityService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T product);
        void Update(T product);
        void Delete(int id);
    }
}
