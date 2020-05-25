using ParkTerritories.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace ParkTerritories.ApplicationServices.Ports.Gateways.Database
{
    public interface IParksDatabaseGateway
    {
        Task AddPark(Park park);

        Task RemovePark(Park park);

        Task UpdatePark(Park park);

        Task<Park> GetPark(long id);

        Task<IEnumerable<Park>> GetAllParks();

        Task<IEnumerable<Park>> QueryParks(Expression<Func<Park, bool>> filter);
         
    }
}
