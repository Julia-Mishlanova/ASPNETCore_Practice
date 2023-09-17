using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeFlightService : IFlightService
    {
        private List<FlightDTO> flights;
        private int nextId = 1;

        public FakeFlightService()
        {
            // Инициализируйте список flights с примерами объектов
            flights = new List<FlightDTO>
        {
            new FlightDTO { Id = nextId++, FlightStatusId = 1 },
            new FlightDTO { Id = nextId++, FlightStatusId = 2 },
            new FlightDTO { Id = nextId++, FlightStatusId = 1 }
        };
        }

        public IEnumerable<FlightDTO> GetAllFlights()
        {
            return flights;
        }

        public FlightDTO GetFlightById(int id)
        {
            return flights.FirstOrDefault(f => f.Id == id);
        }

        public void AddFlight(FlightDTO flight)
        {
            flight.Id = nextId++;
            flights.Add(flight);
        }

        public void UpdateFlight(FlightDTO updatedFlight)
        {
            var existingFlight = flights.FirstOrDefault(f => f.Id == updatedFlight.Id);
            if (existingFlight != null)
            {
                existingFlight.FlightStatusId = updatedFlight.FlightStatusId;
            }
        }

        public void DeleteFlight(int id)
        {
            var flightToDelete = flights.FirstOrDefault(f => f.Id == id);
            if (flightToDelete != null)
            {
                flights.Remove(flightToDelete);
            }
        }
    }
}
