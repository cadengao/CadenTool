using CadenTool.Views;
using System.Windows.Controls;

namespace CadenTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Dictionary<string, UserControl> _viewCache = new Dictionary<string, UserControl>();
        private readonly IRegionManager _regionManager;
        private UserControl _currentView;
        public UserControl CurrentView
        {
            get { return _currentView; }
            set 
            { 
                SetProperty(ref _currentView, value);
                //或者用下面的
                //this.RaisePropertyChanged();
            }
        }

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
