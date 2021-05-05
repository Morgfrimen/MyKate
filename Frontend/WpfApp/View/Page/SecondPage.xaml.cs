using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : System.Windows.Controls.Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        public static RoutedCommand NavigateToReportsPage { get; } = new();

        private void NavigateToReportsPageOnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new Reports());
        }
    }
}