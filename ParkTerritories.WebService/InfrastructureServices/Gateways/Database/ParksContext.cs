using Microsoft.EntityFrameworkCore;
using ParkTerritories.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkTerritories.ApplicationServices.Synchronization;

namespace ParkTerritories.InfrastructureServices.Gateways.Database
{
    public class ParksContext : DbContext
    {
        public DbSet<Park> Parks { get; set; } //набор сущностей, хранящихся в базе данных

        public ParksContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //DbModelBuilder: сопоставляет классы на языке C# с сущностями в базе данных
        {
            FillTestData(modelBuilder);
        }

        private void FillTestData(ModelBuilder modelBuilder)
        {
            var v = new UseCaseParks();

            modelBuilder.Entity<Park>().HasData( v.parks );
        }
    }
}
