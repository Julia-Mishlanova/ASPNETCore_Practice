using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IFlightSeatPriceService
    {
        IEnumerable<FlightSeatPriceDTO> GetAllFlightSeatPrices();
        FlightSeatPriceDTO GetFlightSeatPriceById(int id);
        void AddFlightSeatPrice(FlightSeatPriceDTO flightSeatPrice);
        void UpdateFlightSeatPrice(FlightSeatPriceDTO flightSeatPrice);
        void DeleteFlightSeatPrice(int id);
    }
}
