using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateToReportsPage { get; } = new();

#region Implemented

        private void NavigateToReportsPageOnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new Reports());
        }

#endregion

        public SecondPage()
        {
            InitializeComponent();
        }
    }
}