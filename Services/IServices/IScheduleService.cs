using ASPNETCore_Practice.Models.Domain;
using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IScheduleService
    {
        IEnumerable<ScheduleDTO> GetAllSchedules();
        ScheduleDTO GetScheduleById(int id);
        void AddSchedule(ScheduleDTO client);
        void UpdateSchedule(ScheduleDTO client);
        void DeleteSchedule(int id);
    }
}
