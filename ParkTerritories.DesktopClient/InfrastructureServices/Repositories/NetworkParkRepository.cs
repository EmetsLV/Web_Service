using System;
using ParkTerritories.ApplicationServices.Ports.Cache;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkTerritories.InfrastructureServices.Repositories
{
    public class NetworkParkRepository : NetworkRepositoryBase, IReadOnlyParkRepository
    {
        private readonly IDomainObjectsCache<Park> _parkCache;

        public NetworkParkRepository(string host, ushort port, bool useTls, IDomainObjectsCache<Park> parkCache)
            : base(host, port, useTls)
            => _parkCache = parkCache;

        public async Task<Park> GetPark(long id)
            => CacheAndReturn(await ExecuteHttpRequest<Park>($"parks/{id}"));

        public async Task<IEnumerable<Park>> GetAllParks()
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<Park>>($"parks"), allObjects: true);

        public async Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria)
            => CacheAndReturn(await ExecuteHttpRequest<IEnumerable<Park>>($"parks"), allObjects: true)
               .Where(criteria.Filter.Compile());
               
        private IEnumerable<Park> CacheAndReturn(IEnumerable<Park> parks, bool allObjects = false)
        {
            if (allObjects)
            {
                _parkCache.ClearCache();
            }
            _parkCache.UpdateObjects(parks, DateTime.Now.AddDays(1), allObjects);
            return parks;
        }

        private Park CacheAndReturn(Park park)
        {
            _parkCache.UpdateObject(park, DateTime.Now.AddDays(1));
            return park;
        }
    }
}
