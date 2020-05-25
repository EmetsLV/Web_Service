using ParkTerritories.DomainObjects;
using ParkTerritories.ApplicationServices.Ports;
using ParkTerritories.ApplicationServices.GetParkListUseCase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ParkTerritories.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged 
    {
            private readonly IGetParkListUseCase _getParkListUseCase;

     public MainViewModel(IGetParkListUseCase getParkListUseCase)
        => _getParkListUseCase = getParkListUseCase;

     private Task<bool> _loadingTask;
     private Park _currentPark;
     private ObservableCollection<Park> _parks;

     public event PropertyChangedEventHandler PropertyChanged;

     public Park CurrentPark
     {
        get => _currentPark;
        set
        {
            if (_currentPark != value)
            {
                 _currentPark = value;
                OnPropertyChanged(nameof(CurrentPark));
            }
        }
     }

     private async Task<bool> LoadParks()
     { 
        var outputPort = new OutputPort();
        bool result = await _getParkListUseCase.Handle(GetParkListUseCaseRequest.CreateAllParksRequest(), outputPort);
        if (result)
        {
            Parks = new ObservableCollection<Park>(outputPort.Parks);
        }
        return result;
     }

     public ObservableCollection<Park> Parks
     {
         get
         {
             if (_loadingTask == null)
             {
                 _loadingTask = LoadParks();
             }
             
             return _parks;
         }
         set
         {
             if (_parks != value)
             {
                 _parks = value;
                 OnPropertyChanged(nameof(Parks));
             }
         }
     }

     private void OnPropertyChanged(string propertyName)
     {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
     }

     private class OutputPort : IOutputPort<GetParkListUseCaseResponse>
     {
         public IEnumerable<Park> Parks { get; private set; }
             
         public void Handle(GetParkListUseCaseResponse response)
         {
             if (response.Success)
             {
                 Parks = new ObservableCollection<Park>(response.Parks);
             }
         }
     }
    }
}
