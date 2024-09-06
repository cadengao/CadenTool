using CadenTool.View;
using System.Windows.Controls;

namespace CadenTool.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private UserControl _currentView;
        public UserControl CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }

        public DelegateCommand CadenBaseCommand { get; private set; }
        public DelegateCommand CadenBaseGeneCommand { get; private set; }
        public DelegateCommand SettingCommand { get; private set; }

        public MainViewModel()
        {
            CurrentView = new CadenBaseControl();

            CadenBaseCommand = new DelegateCommand(() => CurrentView = new CadenBaseControl());
            CadenBaseGeneCommand = new DelegateCommand(() => CurrentView = new CadenBaseGeneControl());
            SettingCommand = new DelegateCommand(() => CurrentView = new SettingControl());
        }
    }
}
