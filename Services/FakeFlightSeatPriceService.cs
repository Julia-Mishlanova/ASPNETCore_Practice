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
            return flightSeatPrices;
        }

        public FlightSeatPriceDTO GetFlightSeatPriceById(int id)
        {
            return flightSeatPrices.FirstOrDefault(f => f.Id == id);
        }

        public void AddFlightSeatPrice(FlightSeatPriceDTO flightSeatPrice)
        {
            flightSeatPrice.Id = nextId++;
            flightSeatPrices.Add(flightSeatPrice);
        }

        public void UpdateFlightSeatPrice(FlightSeatPriceDTO updatedFlightSeatPrice)
        {
            var existingFlightSeatPrice = flightSeatPrices.FirstOrDefault(f => f.Id == updatedFlightSeatPrice.Id);
            if (existingFlightSeatPrice != null)
            {
                existingFlightSeatPrice.FlightId = updatedFlightSeatPrice.FlightId;
            }
        }

        public void DeleteFlightSeatPrice(int id)
        {
            var flightSeatPriceToDelete = flightSeatPrices.FirstOrDefault(f => f.Id == id);
            if (flightSeatPriceToDelete != null)
            {
                flightSeatPrices.Remove(flightSeatPriceToDelete);
            }
        }
    }
}
