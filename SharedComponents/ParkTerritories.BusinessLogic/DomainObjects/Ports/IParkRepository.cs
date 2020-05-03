using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text;

namespace ParkTerritories.DomainObjects.Ports
{
    public interface IReadOnlyRouteRepository
    {
        Task<Park> GetPark(long id);

        Task<IEnumerable<Park>> GetAllParks();

        Task<IEnumerable<Park>> QueryParks(ICriteria<Park> criteria);

    }

    public interface IParkRepository
    {
        Task AddPark(Park park);

        Task RemovePark(Park park);

        Task UpdatePark(Park park);
    }
}
