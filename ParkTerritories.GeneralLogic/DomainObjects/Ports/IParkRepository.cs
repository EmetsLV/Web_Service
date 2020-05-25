using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ParkTerritories.DomainObjects.Ports
{
    public interface IReadOnlyParkRepository
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
