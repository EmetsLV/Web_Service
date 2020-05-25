using Microsoft.Extensions.DependencyInjection;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using ParkTerritories.ApplicationServices.Ports.Cache;
using ParkTerritories.ApplicationServices.Repositories;
using ParkTerritories.DesktopClient.InfrastructureServices.ViewModels;
using ParkTerritories.DomainObjects;
using ParkTerritories.DomainObjects.Ports;
using ParkTerritories.InfrastructureServices.Cache;
using ParkTerritories.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ParkTerritories.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<Park>, DomainObjectsMemoryCache<Park>>();
            services.AddSingleton<NetworkParkRepository>(
                x => new NetworkParkRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<Park>>())
            );
            services.AddSingleton<CachedReadOnlyParkRepository>(
                x => new CachedReadOnlyParkRepository(
                    x.GetRequiredService<NetworkParkRepository>(),
                    x.GetRequiredService<IDomainObjectsCache<Park>>()
                )
            );
            services.AddSingleton<IReadOnlyParkRepository>(x => x.GetRequiredService<CachedReadOnlyParkRepository>());
            services.AddSingleton<IGetParkListUseCase, GetParkListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
