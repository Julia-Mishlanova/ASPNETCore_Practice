using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeFlightStatusService : IFlightStatusService
    {
        private List<FlightStatusDTO> flightStatuses;
        private int nextId = 1;

        public FakeFlightStatusService()
        {
            // Инициализируйте список flightStatuses с примерами объектов
            flightStatuses = new List<FlightStatusDTO>
        {
            new FlightStatusDTO { Id = nextId++, Name = "On Time" },
            new FlightStatusDTO { Id = nextId++, Name = "Delayed" },
            new FlightStatusDTO { Id = nextId++, Name = "Canceled" }
        };
        }

        public IEnumerable<FlightStatusDTO> GetAllFlightStatuses()
        {
            return flightStatuses;
        }

        public FlightStatusDTO GetFlightStatusById(int id)
        {
            return flightStatuses.FirstOrDefault(fs => fs.Id == id);
        }

        public void AddFlightStatus(FlightStatusDTO flightStatus)
        {
            flightStatus.Id = nextId++;
            flightStatuses.Add(flightStatus);
        }

        public void UpdateFlightStatus(FlightStatusDTO updatedFlightStatus)
        {
            var existingFlightStatus = flightStatuses.FirstOrDefault(fs => fs.Id == updatedFlightStatus.Id);
            if (existingFlightStatus != null)
            {
                existingFlightStatus.Name = updatedFlightStatus.Name;
            }
        }

        public void DeleteFlightStatus(int id)
        {
            var flightStatusToDelete = flightStatuses.FirstOrDefault(fs => fs.Id == id);
            if (flightStatusToDelete != null)
            {
                flightStatuses.Remove(flightStatusToDelete);
            }
        }
    }
}
