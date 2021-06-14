using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для Reports.xaml
    /// </summary>
    public partial class Reports : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateReport31 = new();

#region Implemented

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new DataGridExcelPage());
        }

#endregion

        public Reports()
        {
            InitializeComponent();
        }
    }
}