using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IFlightService
    {
        IEnumerable<FlightDTO> GetAllFlights();
        FlightDTO GetFlightById(int id);
        void AddFlight(FlightDTO flight);
        void UpdateFlight(FlightDTO flight);
        void DeleteFlight(int id);
    }
}
