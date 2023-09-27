using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeAirportService : IAirportService
    {
        private IAirportRepository _airportRepository;

        public IEnumerable<AirportDTO> GetAllAirports()
        {
            return _airportRepository.GetAll();
        }

        public AirportDTO GetAirportById(int id)
        {
            return _airportRepository.Find(id);
        }

        public void AddAirport(AirportDTO airport)
        {
            _airportRepository.Add(airport);
        }

        public void UpdateAirport(AirportDTO updatedAirport)
        {
            _airportRepository.Update(updatedAirport);
        }

        public void DeleteAirport(int id)
        {
            var airportToDelete = _airportRepository.Find(id);
            if (airportToDelete != null)
            {
                _airportRepository.Remove(airportToDelete);
            }
        }
    }
}
