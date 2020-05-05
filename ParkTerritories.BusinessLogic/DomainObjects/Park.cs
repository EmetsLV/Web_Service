using System;
using System.Collections.Generic;
using System.Text;

namespace ParkTerritories.DomainObjects
{
    public class Park : DomainObject
    {
        public string Location { get; set; }

        public string FullName { get; set; }

        public Waters Water { get; set; }

        public PlayGrounds PlayGround { get; set; }

        public SportsGrounds SportsGround { get; set; }
    }
}
