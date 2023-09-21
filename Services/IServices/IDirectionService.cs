using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IDirectionService
    {
        IEnumerable<DirectionDTO> GetAllDirections();
        DirectionDTO GetDirectionById(int id);
        void AddDirection(DirectionDTO client);
        void UpdateDirection(DirectionDTO client);
        void DeleteDirection(int id);
    }
}
