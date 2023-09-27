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
    public class FakeDirectionService : IDirectionService
    {
        private IDirectionRepository _directionRepository;
        private List<DirectionDTO> _directions;
        private int nextId = 1;

        public FakeDirectionService()
        {
            _directions = new List<DirectionDTO>
            {
                new DirectionDTO { Id = nextId++ },
                new DirectionDTO { Id = nextId++ },
                new DirectionDTO { Id = nextId++ }
            };
        }

        public IEnumerable<DirectionDTO> GetAllDirections()
        {
            return _directionRepository.GetAll();
        }

        public DirectionDTO GetDirectionById(int id)
        {
            return _directionRepository.Find(id);
        }

        public void AddDirection(DirectionDTO direction)
        {
            _directionRepository.Add(direction);
        }

        public void UpdateDirection(DirectionDTO updatedDirection)
        {
            _directionRepository.Update(updatedDirection);
        }

        public void DeleteDirection(int id)
        {
            var directionToDelete = _directionRepository.Find(id);
            if (directionToDelete != null)
            {
                _directionRepository.Remove(directionToDelete);
            }
        }
    }
}
