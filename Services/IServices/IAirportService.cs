using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IAirportService
    {
        IEnumerable<AirportDTO> GetAllAirports();
        AirportDTO GetAirportById(int id);
        void AddAirport(AirportDTO airport);
        void UpdateAirport(AirportDTO airport);
        void DeleteAirport(int id);
    }
}
