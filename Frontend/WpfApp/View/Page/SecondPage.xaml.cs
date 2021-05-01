using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : System.Windows.Controls.Page
    {
        public static RoutedCommand GPZСurrentYear = new();


        public SecondPage()
        {
            InitializeComponent();
        }

        private void GPZCurrentYear_OnExecuted(object sender, ExecutedRoutedEventArgs e) => MainWindow.FrameMainWindow.Navigate(new DataGridExcelPage());
    }
}