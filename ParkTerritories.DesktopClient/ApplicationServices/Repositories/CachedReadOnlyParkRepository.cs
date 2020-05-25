using System;
using ParkTerritories.ApplicationServices.Ports.Cache;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.DomainObjects.Repositories;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ParkTerritories.ApplicationServices.Repositories
{
    public class CachedReadOnlyParkRepository : ReadOnlyParkRepositoryDecorator
    {
        private readonly IDomainObjectsCache<Park> _parksCache;

        public CachedReadOnlyParkRepository(IReadOnlyParkRepository parkRepository,
                                             IDomainObjectsCache<Park> parksCache)
            : base(parkRepository)
            => _parksCache = parksCache;

        public async override Task<Park> GetPark(long id)
            => _parksCache.GetObject(id) ?? await base.GetPark(id);

        public async override Task<IEnumerable<Park>> GetAllParks()
            => _parksCache.GetObjects() ?? await base.GetAllParks();

        public async override Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria)
            => _parksCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryParks(criteria);

    }
}
