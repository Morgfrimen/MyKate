using System.Windows.Input;

using WpfApp.View.GPZ;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateToGPZCurrentYearPage { get; } = new();
        public static RoutedCommand NavigateToGPZPastYearPage { get; } = new();
        public static RoutedCommand NavigateToReportsPage { get; } = new();

        private void NavigateToGPZCurrentYearPage_OnExecuted(
            object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new GpzCurrentYearPage());
        }

        private void NavigateToGPZPastYearPage_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new GPZPastYearPage());
        }

        private void NavigateToReportsPage_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new SelectReport());
        }

        public SecondPage()
        {
            InitializeComponent();
        }
    }
}