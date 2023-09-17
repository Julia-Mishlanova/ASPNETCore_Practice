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
        private List<AirportDTO> airports;
        private int nextId = 1;

        public FakeAirportService()
        {
            airports = new List<AirportDTO>();
        }

        public IEnumerable<AirportDTO> GetAllAirports()
        {
            return airports;
        }

        public AirportDTO GetAirportById(int id)
        {
            return airports.FirstOrDefault(a => a.Id == id);
        }

        public void AddAirport(AirportDTO airport)
        {
            airport.Id = nextId++;
            airports.Add(airport);
        }

        public void UpdateAirport(AirportDTO updatedAirport)
        {
            var existingAirport = airports.FirstOrDefault(a => a.Id == updatedAirport.Id);
            if (existingAirport != null)
            {
                existingAirport.Name = updatedAirport.Name;
                existingAirport.City = updatedAirport.City;
                existingAirport.CountryId = updatedAirport.CountryId;
            }
        }

        public void DeleteAirport(int id)
        {
            var airportToDelete = airports.FirstOrDefault(a => a.Id == id);
            if (airportToDelete != null)
            {
                airports.Remove(airportToDelete);
            }
        }
    }
}
