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
    public class FakeScheduleService : IScheduleService
    {
        IScheduleRepository
        private List<ScheduleDTO> _schedules;
        private int nextId = 1;

        public FakeScheduleService()
        {
            // Инициализируйте список flightStatuses с примерами объектов
            _schedules = new List<ScheduleDTO>
        {
            new ScheduleDTO { Id = nextId++ },
            new ScheduleDTO { Id = nextId++ },
            new ScheduleDTO { Id = nextId++ }
        };
        }

        public IEnumerable<ScheduleDTO> GetAllSchedules()
        {
            return _schedules;
        }

        public ScheduleDTO GetScheduleById(int id)
        {
            return _schedules.FirstOrDefault(fs => fs.Id == id);
        }

        public void AddSchedule(ScheduleDTO schedule)
        {
            schedule.Id = nextId++;
            _schedules.Add(schedule);
        }

        public void UpdateSchedule(ScheduleDTO updatedSchedule)
        {
            var existingSchedule = _schedules.FirstOrDefault(fs => fs.Id == updatedSchedule.Id);
            if (existingSchedule != null)
            {
                existingSchedule.DepartureTimeGMT = updatedSchedule.DepartureTimeGMT;
                existingSchedule.ArrivalTimeGMT = updatedSchedule.ArrivalTimeGMT;
            }
        }

        public void DeleteSchedule(int id)
        {
            var scheduleToDelete = _schedules.FirstOrDefault(fs => fs.Id == id);
            if (scheduleToDelete != null)
            {
                _schedules.Remove(scheduleToDelete);
            }
        }
    }
}
