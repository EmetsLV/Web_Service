using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using ParkTerritories.ApplicationServices.Repositories;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.DomainObjects;
using System.Collections.Generic;

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
            services.AddScoped<InMemoryParkRepository>(x => new InMemoryParkRepository(
                new List<Park> {
                    new Park()
                    {
                        Id = 1, Name = "Памятник садово-паркового искусства – «Парк Дворца творчества детей и юношества» по адресу ул.Косыгина д.17", 
                        Location = "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности " +
                        "спокойный, резкопересечённый, с перепадом высот до 30 м, " +
                        "площадки и дорожки выложены плиткой и асфальтом, за корпусами расположен парк с многолетними деревьями", 
                        PlayGround = PlayGrounds.no, SportsGround = SportsGrounds.no, Water = "нет"
                    },
                    new Park()
                    {
                        Id = 1, Name = "Детский парк «Фили»", Location = "улица Большая Филёвская, дом 9",
                        PlayGround = PlayGrounds.yes, SportsGround = SportsGrounds.no, Water = "нет"
                    },
                    new Park()
                    {
                         Id = 1, Name = "Природно-исторический парк «Битцевский лес»", Location = "Восточная часть района Ясенево",
                        PlayGround = PlayGrounds.yes, SportsGround = SportsGrounds.yes, Water = "нет"
                    }
            }));
            services.AddScoped<IReadOnlyParkRepository>(x => x.GetRequiredService<InMemoryParkRepository>());
            services.AddScoped<IParkRepository>(x => x.GetRequiredService<InMemoryParkRepository>());

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
