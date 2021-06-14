using System.Windows.Input;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateSecondPageCommand { get; } = new();

#region Implemented

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _ = MainWindow.FrameMainWindow.Navigate(new SecondPage());
        }

#endregion

        public StartPage()
        {
            InitializeComponent();
        }
    }
}