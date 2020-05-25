using ParkTerritories.ApplicationServices.GetParkListUseCase;
using System.Net;
using Newtonsoft.Json;
using ParkTerritories.ApplicationServices.Ports;

namespace ParkTerritories.InfrastructureServices.Presenters
{
    public class ParkListPresenter : IOutputPort<GetParkListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ParkListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetParkListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.Parks) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
