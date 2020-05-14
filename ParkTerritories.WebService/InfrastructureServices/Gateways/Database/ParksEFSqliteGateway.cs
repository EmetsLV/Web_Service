using ParkTerritories.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkTerritories.ApplicationServices.Ports.Gateways.Database;

namespace ParkTerritories.InfrastructureServices.Gateways.Database
{
    public class ParksEFSqliteGateway : IParksDatabaseGateway
    {
        private readonly ParksContext _parksContext;

        public ParksEFSqliteGateway(ParksContext parksContext)
            => _parksContext = parksContext;

        public async Task<Park> GetPark(long id)
   => await _parksContext.Parks.Where(p => p.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<Park>> GetAllParks()
            => await _parksContext.Parks.ToListAsync();

        public async Task<IEnumerable<Park>> QueryParks(Expression<Func<Park, bool>> filter)
            => await _parksContext.Parks.Where(filter).ToListAsync();

        public async Task AddPark(Park park)
        {
            _parksContext.Parks.Add(park);
            await _parksContext.SaveChangesAsync();
        }

        public async Task UpdatePark(Park park)
        {
            _parksContext.Entry(park).State = EntityState.Modified;
            await _parksContext.SaveChangesAsync();
        }

        public async Task RemovePark(Park park)
        {
            _parksContext.Parks.Remove(park);
            await _parksContext.SaveChangesAsync();
        }

    }
}
