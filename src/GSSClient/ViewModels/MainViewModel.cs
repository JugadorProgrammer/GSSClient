using GSSClient.Constants;
using GSSClient.Views.Auth;
using Prism.Navigation.Regions;
using ReactiveUI;
using System.Windows.Input;

namespace GSSClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public ICommand LoadedCommand { get; }

        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            LoadedCommand = ReactiveCommand.Create(Loaded);
        }

        private void Loaded()
        {
            _regionManager.Regions[RegionNames.MainRegion].RequestNavigate(nameof(AuthView));
        }
    }
}
