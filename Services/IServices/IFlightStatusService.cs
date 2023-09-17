using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IFlightStatusService
    {
        IEnumerable<FlightStatusDTO> GetAllFlightStatuses();
        FlightStatusDTO GetFlightStatusById(int id);
        void AddFlightStatus(FlightStatusDTO flightStatus);
        void UpdateFlightStatus(FlightStatusDTO flightStatus);
        void DeleteFlightStatus(int id);
    }
}
