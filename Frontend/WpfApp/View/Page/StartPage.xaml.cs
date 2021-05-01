using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateSecondPageCommand = new();
        public StartPage()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new SecondPage());
        }
    }
}