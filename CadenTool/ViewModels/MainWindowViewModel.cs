using CadenTool.Views;
using System.Windows.Controls;

namespace CadenTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "CadenTool";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        //区域管理
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string viewName)
        {
            _regionManager.Regions["ContentRegion"].RequestNavigate(viewName);
        }

        public void NavigateToDefaultView() // 新增的方法
        {
            Navigate("CadenBaseControl");
        }
    }

}
