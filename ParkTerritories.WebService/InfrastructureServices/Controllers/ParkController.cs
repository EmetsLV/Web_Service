using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkTerritories.DomainObjects;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using ParkTerritories.InfrastructureServices.Presenters;

namespace ParkTerritories.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParksController : ControllerBase
    {
        private readonly ILogger<ParksController> _logger;
        private readonly IGetParkListUseCase _getParkListUseCase;

        public ParksController(ILogger<ParksController> logger,
                                IGetParkListUseCase getParkListUseCase)
        {
            _logger = logger;
            _getParkListUseCase = getParkListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllParks()
        {
            var presenter = new ParkListPresenter();
            await _getParkListUseCase.Handle(GetParkListUseCaseRequest.CreateAllParksRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{parkId}")]
        public async Task<ActionResult> GetPark(long parkId)
        {
            var presenter = new ParkListPresenter();
            await _getParkListUseCase.Handle(GetParkListUseCaseRequest.CreateParkRequest(parkId), presenter);
            return presenter.ContentResult;
        }

    }
}
