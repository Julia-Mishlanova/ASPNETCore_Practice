using ASPNETCore_Practice.DataAccess.Repository.IRepository;
using ASPNETCore_Practice.Models.Domain;
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
        private IFlightRepository _flightRepository;
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
            return _flightRepository.GetAll();
        }

        public FlightDTO GetFlightById(int id)
        {
            return _flightRepository.Find(id);
        }

        public void AddFlight(FlightDTO flight)
        {
            _flightRepository.Add(flight);
        }

        public void UpdateFlight(FlightDTO updatedFlight)
        {
            _flightRepository.Update(updatedFlight);
        }

        public void DeleteFlight(int id)
        {
            var flightToDelete = _flightRepository.Find(id);
            if (flightToDelete != null)
            {
                _flightRepository.Remove(flightToDelete);
            }
        }
    }
}
