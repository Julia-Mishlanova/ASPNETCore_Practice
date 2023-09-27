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
    public class FakeFlightSeatPriceService : IFlightSeatPriceService
    {
        private IFlightSeatPriceRepository _flightSeatPriceRepository;
        private List<FlightSeatPriceDTO> flightSeatPrices;
        private int nextId = 1;

        public FakeFlightSeatPriceService()
        {
            // Инициализируйте список flightSeatPrices с примерами объектов
            flightSeatPrices = new List<FlightSeatPriceDTO>
        {
            new FlightSeatPriceDTO { Id = nextId++, FlightId = 1 },
            new FlightSeatPriceDTO { Id = nextId++, FlightId = 2 },
            new FlightSeatPriceDTO { Id = nextId++, FlightId = 3 }
        };
        }

        public IEnumerable<FlightSeatPriceDTO> GetAllFlightSeatPrices()
        {
            return _flightSeatPriceRepository.GetAll();
        }

        public FlightSeatPriceDTO GetFlightSeatPriceById(int id)
        {
            return _flightSeatPriceRepository.Find(id);
        }

        public void AddFlightSeatPrice(FlightSeatPriceDTO flightSeatPrice)
        {
            _flightSeatPriceRepository.Add(flightSeatPrice);
        }

        public void UpdateFlightSeatPrice(FlightSeatPriceDTO updatedFlightSeatPrice)
        {
            _flightSeatPriceRepository.Update(updatedFlightSeatPrice);
        }

        public void DeleteFlightSeatPrice(int id)
        {
            var flightSeatPriceToDelete = _flightSeatPriceRepository.Find(id);
            if (flightSeatPriceToDelete != null)
            {
                _flightSeatPriceRepository.Remove(flightSeatPriceToDelete);
            }
        }
    }
}
