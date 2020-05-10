using System.Threading.Tasks;
using System.Collections.Generic;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.ApplicationServices.Ports;

namespace ParkTerritories.ApplicationServices.GetParkListUseCase
{
    public class GetParkListUseCase : IGetParkListUseCase
    {
        private readonly IReadOnlyParkRepository _readOnlyParkRepository;

        public GetParkListUseCase(IReadOnlyParkRepository readOnlyParkRepository)
            => _readOnlyParkRepository = readOnlyParkRepository;

        public async Task<bool> Handle(GetParkListUseCaseRequest request, IOutputPort<GetParkListUseCaseResponse> outputPort)
        {
            IEnumerable<Park> parks = null;
            if (request.ParkId != null)
            {
                var park = await _readOnlyParkRepository.GetPark(request.ParkId.Value);
                parks = (park != null) ? new List<Park>() { park } : new List<Park>();

            }
            else
            {
                parks = await _readOnlyParkRepository.GetAllParks();
            }
            outputPort.Handle(new GetParkListUseCaseResponse(parks));
            return true;
        }

    }
}
