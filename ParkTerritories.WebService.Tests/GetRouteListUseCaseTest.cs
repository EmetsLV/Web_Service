using MoscowTransport.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using MoscowTransport.ApplicationServices.GetRouteListUseCase;
using System.Linq.Expressions;
using MoscowTransport.ApplicationServices.Ports;
using MoscowTransport.DomainObjects.Ports;
using MoscowTransport.ApplicationServices.Repositories;

namespace MoscowTransport.WebService.Core.Tests
{
    public class GetRouteListUseCaseTest
    {
        private InMemoryRouteRepository CreateRoteRepository(InMemoryTransportOrganizationRepository transportOrganizationRepository)
        {
            var transavtoliz = transportOrganizationRepository.GetTransportOrganization(2).Result;
            var mosgortrans = transportOrganizationRepository.GetTransportOrganization(1).Result;
            var repo = new InMemoryRouteRepository(new List<Route> {
                new Route { Id = 1, Number = "591", Name = "Метро \"Войковская\" - Станция Ховрино", Organization = transavtoliz, Type = TransportType.Bus },
                new Route { Id = 2, Number = "191", Name = "Метро \"Селигерская\" - Станция Ховрино", Organization = transavtoliz, Type = TransportType.Bus },
                new Route { Id = 3, Number = "215к", Name = "Метро \"Селигерская\" - Станция Ховрино", Organization = mosgortrans, Type = TransportType.Bus },
                new Route { Id = 4, Number = "56", Name = "Тверская Застава - Базовская улица", Organization = mosgortrans, Type = TransportType.Trolley },
            });
            return repo;
        }

        private InMemoryTransportOrganizationRepository CreateTransportOrganizationRepository()
            => new InMemoryTransportOrganizationRepository(new List<TransportOrganization> {
                new TransportOrganization
                { Id = 1, Name = "Мосгортранс", TimeZone = "Europe/Moscow", WebSite = "http://mosgortrans.ru" },
                new TransportOrganization
                { Id = 2, Name = "Трансавтолиз", TimeZone = "Europe/Moscow", WebSite = "http://avtoline.ru" }
               });

        [Fact]
        public void TestGetAllRoutes()
        {
            var useCase = new GetRouteListUseCase(CreateRoteRepository(CreateTransportOrganizationRepository()));
            var outputPort = new OutputPort();
                        
            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateAllRoutesRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.Routes.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.Routes.Select(r => r.Id));
        }

        [Fact]
        public void TestGetAllRoutesFromEmptyRepository()
        {
            var useCase = new GetRouteListUseCase(new InMemoryRouteRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateAllRoutesRequest(), outputPort).Result);
            Assert.Empty(outputPort.Routes);
        }

        [Fact]
        public void TestGetRoute()
        {
            var useCase = new GetRouteListUseCase(CreateRoteRepository(CreateTransportOrganizationRepository()));
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateRouteRequest(2), outputPort).Result);
            Assert.Single(outputPort.Routes, r => 2 == r.Id);
        }

        [Fact]
        public void TestTryGetNotExistingRoute()
        {
            var useCase = new GetRouteListUseCase(CreateRoteRepository(CreateTransportOrganizationRepository()));
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateRouteRequest(999), outputPort).Result);
            Assert.Empty(outputPort.Routes);
        }

        [Fact]
        public void TestGetOrganizationRoutes()
        {
            var useCase = new GetRouteListUseCase(CreateRoteRepository(CreateTransportOrganizationRepository()));
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateOrganizationRoutesRequest(1), outputPort).Result);
            Assert.Equal<int>(2, outputPort.Routes.Count());
            Assert.Equal(new long[] { 3, 4 }, outputPort.Routes.Select(r => r.Id));
        }

        [Fact]
        public void TestGetNonExistingOrganizationRoutes()
        {
            var useCase = new GetRouteListUseCase(CreateRoteRepository(CreateTransportOrganizationRepository()));
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetRouteListUseCaseRequest.CreateOrganizationRoutesRequest(999), outputPort).Result);
            Assert.Empty(outputPort.Routes);
        }
    }

    class OutputPort : IOutputPort<GetRouteListUseCaseResponse>
    {
        public IEnumerable<Route> Routes { get; private set; }

        public void Handle(GetRouteListUseCaseResponse response)
        {
            Routes = response.Routes;
        }
    }
}
