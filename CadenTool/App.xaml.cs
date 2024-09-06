using CadenTool.Common;
using CadenTool.Views;
using System.Windows;

namespace CadenTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 注册你的服务和窗口
            containerRegistry.RegisterSingleton<DataService>();
            containerRegistry.RegisterSingleton<MainWindow>();

            //// 如果有其他视图和视图模型也可以在这里注册
            containerRegistry.RegisterForNavigation<CadenBaseControl>();
            containerRegistry.RegisterForNavigation<CadenBaseGeneControl>();
            containerRegistry.RegisterForNavigation<SettingControl>();
        }

        protected override Window CreateShell()
        {
            // 创建并返回主窗口
            return Container.Resolve<MainWindow>();
        }
    }
}

