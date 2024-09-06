using CadenTool.Views;
using System.Windows.Controls;

namespace CadenTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string viewName)
        {
            _regionManager.Regions["MainViewRegion"].RequestNavigate(viewName);
        }
    }

}
