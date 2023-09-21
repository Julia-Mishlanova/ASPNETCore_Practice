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
            return _directions;
        }

        public DirectionDTO GetDirectionById(int id)
        {
            return _directions.FirstOrDefault(c => c.Id == id);
        }

        public void AddDirection(DirectionDTO direction)
        {
            direction.Id = nextId++;
            _directions.Add(direction);
        }

        public void UpdateDirection(DirectionDTO updatedDirection)
        {
            var existingDirection = _directions.FirstOrDefault(c => c.Id == updatedDirection.Id);
            if (existingDirection != null)
            {
                existingDirection.OriginIataCode = updatedDirection.OriginIataCode;
                existingDirection.DestinationIataCode = updatedDirection.DestinationIataCode;
            }
        }

        public void DeleteDirection(int id)
        {
            var directionToDelete = _directions.FirstOrDefault(c => c.Id == id);
            if (directionToDelete != null)
            {
                _directions.Remove(directionToDelete);
            }
        }
    }
}
