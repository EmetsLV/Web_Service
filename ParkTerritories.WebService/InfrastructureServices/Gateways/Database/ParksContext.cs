using Microsoft.EntityFrameworkCore;
using ParkTerritories.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkTerritories.InfrastructureServices.Gateways.Database
{
    public class ParksContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }

        public ParksContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }

        private void FillTestData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Park>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Памятник садово-паркового искусства – «Парк Дворца творчества детей и юношества» по адресу ул.Косыгина д.17",
                    Location = "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности " +
                        "спокойный, резкопересечённый, с перепадом высот до 30 м, " +
                        "площадки и дорожки выложены плиткой и асфальтом, за корпусами расположен парк с многолетними деревьями",
                    PlayGround = PlayGrounds.no,
                    SportsGround = SportsGrounds.no,
                    Water = "нет"
                },
                new
                {
                    Id = 2L, 
                    Name = "Детский парк «Фили»", 
                    Location = "улица Большая Филёвская, дом 9",
                    PlayGround = PlayGrounds.yes, 
                    SportsGround = SportsGrounds.no, 
                    Water = "нет"
                },
                new
                {
                    Id = 3L,
                    Name = "Природно-исторический парк «Битцевский лес»",
                    Location = "Восточная часть района Ясенево",
                    PlayGround = PlayGrounds.yes,
                    SportsGround = SportsGrounds.yes,
                    Water = "нет"
                }
            );
        }
    }
}
