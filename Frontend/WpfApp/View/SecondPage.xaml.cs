using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp.View
{
    /// <summary>
    ///     Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public static RoutedCommand GPZСurrentYear = new();


        public SecondPage()
        {
            InitializeComponent();
        }

        private void GPZCurrentYear_OnExecuted(object sender, ExecutedRoutedEventArgs e) => MainWindow.FrameMainWindow.Navigate(new DataGridExcelPage());
    }
}