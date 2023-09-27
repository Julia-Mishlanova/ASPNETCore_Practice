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
    public class FakeFlightStatusService : IFlightStatusService
    {
        private IFlightStatusRepository _flightStatusRepository { get; set; }
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
            return _flightStatusRepository.GetAll();
        }

        public FlightStatusDTO GetFlightStatusById(int id)
        {
            return _flightStatusRepository.Find(id);
        }

        public void AddFlightStatus(FlightStatusDTO flightStatus)
        {
            _flightStatusRepository.Add(flightStatus);
        }

        public void UpdateFlightStatus(FlightStatusDTO updatedFlightStatus)
        {
            _flightStatusRepository.Update(updatedFlightStatus);
        }

        public void DeleteFlightStatus(int id)
        {
            var flightStatusToDelete = _flightStatusRepository.Find(id);
            if (flightStatusToDelete != null)
            {
                _flightStatusRepository.Remove(flightStatusToDelete);
            }
        }
    }
}
