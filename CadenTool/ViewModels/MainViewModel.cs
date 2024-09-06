using CadenTool.Views;
using System.Windows.Controls;

namespace CadenTool.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private Dictionary<string, UserControl> _viewCache = new Dictionary<string, UserControl>();

        private UserControl _currentView;
        public UserControl CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainViewModel()
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string viewName)
        {
            if (!_viewCache.ContainsKey(viewName))
            {
                switch (viewName)
                {
                    case "CadenBase":
                        _viewCache[viewName] = new CadenBaseControl();
                        break;
                    case "CadenBaseGene":
                        _viewCache[viewName] = new CadenBaseGeneControl();
                        break;
                    case "Setting":
                        _viewCache[viewName] = new SettingControl();
                        break;
                    // 可以添加更多的视图
                    default:
                        break;
                }
            }

            CurrentView = _viewCache[viewName];
        }
    }

}
