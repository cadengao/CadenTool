using CadenTool.ViewModels;
using System.Windows;

namespace CadenTool.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; // 订阅 Loaded 事件
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainWindowViewModel)DataContext;
            viewModel.NavigateToDefaultView(); // 调用 ViewModel 中的方法进行导航
        }
    }
}