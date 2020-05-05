using ParkTerritories.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkTerritories.ApplicationServices.GetParkListUseCase
{
    public class GetParkListUseCaseRequest : IUseCaseRequest<GetParkListUseCaseResponse>
    {
        public long? ParkId { get; private set; }

        private GetParkListUseCaseRequest()
        { }

        public static GetParkListUseCaseRequest CreateAllRoutesRequest()
        {
            return new GetParkListUseCaseRequest();
        }

        public static GetParkListUseCaseRequest CreateRouteRequest(long routeId)
        {
            return new GetParkListUseCaseRequest() { ParkId = routeId };
        }

    }
}
