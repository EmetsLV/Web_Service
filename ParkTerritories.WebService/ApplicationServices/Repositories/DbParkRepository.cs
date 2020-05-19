using ParkTerritories.ApplicationServices.Ports.Gateways.Database;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkTerritories.ApplicationServices.Repositories
{
    public class DbParkRepository : IReadOnlyParkRepository, IParkRepository
    {
        private readonly IParksDatabaseGateway _databaseGateway;

        public DbParkRepository(IParksDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<Park> GetPark(long id)
            => await _databaseGateway.GetPark(id);

        public async Task<IEnumerable<Park>> GetAllParks()
            => await _databaseGateway.GetAllParks();

        public async Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria)
            => await _databaseGateway.QueryParks(criteria.Filter);

        public async Task AddPark(Park park)
            => await _databaseGateway.AddPark(park);

        public async Task RemovePark(Park park)
            => await _databaseGateway.RemovePark(park);

        public async Task UpdatePark(Park park)
            => await _databaseGateway.UpdatePark(park);
    }
}
