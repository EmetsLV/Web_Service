using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkTerritories.ApplicationServices.Repositories
{
    public class InMemoryParkRepository : IReadOnlyParkRepository,
                                           IParkRepository
    {
        private readonly List<Park> _parks = new List<Park>();

        public InMemoryParkRepository(IEnumerable<Park> parks = null)
        {
            if (parks != null)
            {
                _parks.AddRange(parks);
            }
        }

        public Task AddPark(Park park)
        {
            _parks.Add(park);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Park>> GetAllParks()
        {
            return Task.FromResult(_parks.AsEnumerable());
        }

        public Task<Park> GetPark(long id)
        {
            return Task.FromResult(_parks.Where(p => p.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria)
        {
            return Task.FromResult(_parks.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemovePark(Park park)
        {
            _parks.Remove(park);
            return Task.CompletedTask;
        }

        public Task UpdatePark(Park park)
        {
            var foundPark = GetPark(park.Id).Result;
            if (foundPark == null)
            {
                AddPark(park);
            }
            else
            {
                if (foundPark != park)
                {
                    _parks.Remove(foundPark);
                    _parks.Add(park);
                }
            }
            return Task.CompletedTask;
        }
    }
}
