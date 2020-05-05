using ParkTerritories.DomainObjects;
using ParkTerritories.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkTerritories.ApplicationServices.GetParkListUseCase
{
    public class GetParkListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<Park> Parks { get; }

        public GetParkListUseCaseResponse(IEnumerable<Park> parks) => Parks = parks;
    }
}
