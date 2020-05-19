using System;
using ParkTerritories.DomainObjects.Ports;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace ParkTerritories.DomainObjects.Repositories 
{
    public abstract class ReadOnlyParkRepositoryDecorator : IReadOnlyParkRepository
    {
        private readonly IReadOnlyParkRepository _parkRepository;

        public ReadOnlyParkRepositoryDecorator(IReadOnlyParkRepository parkRepository)
        {
            _parkRepository = parkRepository;
        }

        public virtual async Task<IEnumerable<Park>> GetAllParks()
        {
            return await _parkRepository?.GetAllParks();
        }

        public virtual async Task<Park> GetPark(long id)
        {
            return await _parkRepository?.GetPark(id);
        }

        public virtual async Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria)
        {
            return await _parkRepository?.QueryParks(criteria);
        }
    }
}
