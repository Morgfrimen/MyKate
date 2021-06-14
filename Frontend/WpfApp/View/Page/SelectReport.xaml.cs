using System.Windows.Input;

using WpfApp.View.Page.Reporst;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SelectReport.xaml
    /// </summary>
    public partial class SelectReport : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateReport31 = new();

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new Report3_1());
        }

        public SelectReport()
        {
            InitializeComponent();
        }
    }
}