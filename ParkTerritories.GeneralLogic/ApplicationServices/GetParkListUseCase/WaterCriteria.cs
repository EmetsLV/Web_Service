using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text;

namespace ParkTerritories.ApplicationServices.GetParkListUseCase
{
    public class WaterCriteria : ICriteria<Park>
    {
        public string Water { get; }

        public WaterCriteria(string water)
            => Water = water;

        public Expression<Func<Park, bool>> Filter
            => (pt => pt.Water == Water);

    }
}
