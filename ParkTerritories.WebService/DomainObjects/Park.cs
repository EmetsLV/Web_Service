using System;
using System.Collections.Generic;
using System.Text;

namespace ParkTerritories.DomainObjects
{
    public class Park : DomainObject
    {
        public string Location { get; set; }

        public string Name { get; set; }

        public string Water { get; set; }

        public PlayGrounds PlayGround { get; set; }

        public SportsGrounds SportsGround { get; set; }
    }
}
