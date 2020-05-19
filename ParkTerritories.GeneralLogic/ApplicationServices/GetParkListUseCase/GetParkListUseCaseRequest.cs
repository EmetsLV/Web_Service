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

        public static GetParkListUseCaseRequest CreateAllParksRequest()
        {
            return new GetParkListUseCaseRequest();
        }

        public static GetParkListUseCaseRequest CreateParkRequest(long parkId)
        {
            return new GetParkListUseCaseRequest() { ParkId = parkId };
        }

    }
}
