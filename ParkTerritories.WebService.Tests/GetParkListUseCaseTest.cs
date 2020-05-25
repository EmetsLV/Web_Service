using System;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using ParkTerritories.ApplicationServices.Ports;
using ParkTerritories.ApplicationServices.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;

namespace ParkTerritories.WebService.Tests
{
    public class GetParkListUseCaseTest
    {
        private InMemoryParkRepository CreateRoteRepository()
        {
            var repo = new InMemoryParkRepository(new List<Park> {
                new Park { Id = 1,  Name = "Парк №1" , Water ="нет", Location ="на перекрёстке", PlayGround = "да", SportsGround ="да"},
                new Park { Id = 2,  Name = "новый парк" , Water ="нет", Location ="в жоке мира", PlayGround = "да", SportsGround ="да"},
                new Park { Id = 3,  Name = "маленький парк" , Water ="да", Location ="на перекрёстке", PlayGround = "да", SportsGround = "да"},
                new Park { Id = 4,  Name = "Парк паркович" , Water ="нет", Location ="во дворах", PlayGround = "да", SportsGround = "да"},
            });
            return repo;
        }

        [Fact]
        public void TestGetAllParks()
        {
            var useCase = new GetParkListUseCase(CreateRoteRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkListUseCaseRequest.CreateAllParksRequest(), outputPort).Result);
            Assert.Equal<int>(4, outputPort.Parks.Count());
            Assert.Equal(new long[] { 1, 2, 3, 4 }, outputPort.Parks.Select(r => r.Id));
        }

        [Fact]
        public void TestGetAllRoutesFromEmptyRepository()
        {
            var useCase = new GetParkListUseCase(new InMemoryParkRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkListUseCaseRequest.CreateAllParksRequest(), outputPort).Result);
            Assert.Empty(outputPort.Parks);
        }

        [Fact]
        public void TestGetPark()
        {
            var useCase = new GetParkListUseCase(CreateRoteRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkListUseCaseRequest.CreateParkRequest(2), outputPort).Result);
            Assert.Single(outputPort.Parks, r => 2 == r.Id);
        }

        [Fact]
        public void TestTryGetNotExistingPark()
        {
            var useCase = new GetParkListUseCase(CreateRoteRepository());
            var outputPort = new OutputPort();

            Assert.True(useCase.Handle(GetParkListUseCaseRequest.CreateParkRequest(999), outputPort).Result);
            Assert.Empty(outputPort.Parks);
        }

    }

    class OutputPort : IOutputPort<GetParkListUseCaseResponse>
    {
        public IEnumerable<Park> Parks { get; private set; }

        public void Handle(GetParkListUseCaseResponse response)
        {
            Parks = response.Parks;
        }
    }
}

