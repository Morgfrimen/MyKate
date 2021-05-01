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

        public static RoutedCommand GpzСurrentYear { get; } = new();

        private void GPZCurrentYear_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new DataGridExcelPage());
        }
    }
}