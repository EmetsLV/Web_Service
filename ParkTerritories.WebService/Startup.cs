using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using ParkTerritories.ApplicationServices.Repositories;
using ParkTerritories.ApplicationServices.Ports.Gateways.Database;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.DomainObjects;
using System.Collections.Generic;
using ParkTerritories.InfrastructureServices.Gateways.Database;

namespace ParkTerritories.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ParksContext>(opts =>
            opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "ParkTerritories.db")}")
            );

            services.AddScoped<IParksDatabaseGateway , ParksEFSqliteGateway>();

            services.AddScoped<DbParkRepository>();
            services.AddScoped<IReadOnlyParkRepository>(x => x.GetRequiredService<DbParkRepository>());
            services.AddScoped<IParkRepository>(x => x.GetRequiredService<DbParkRepository>());

            services.AddScoped<IGetParkListUseCase, GetParkListUseCase>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
