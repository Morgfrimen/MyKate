using System.Windows.Input;

using WpfApp.Core;

namespace WpfApp.View.Page
{
	/// <summary>
	///     Логика взаимодействия для StartPage.xaml
	/// </summary>
	public partial class StartPage : System.Windows.Controls.Page
	{
		public static RoutedCommand NavigateSecondPageCommand { get; } = new();

		private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e) => _ = MainWindow.FrameMainWindow.Navigate(new SecondPage());

		public StartPage()
		{
			InitializeComponent();
            EventBroker.OnChangeNamePageEvent(string.Empty);
		}

		private void Navigate_CommonPage(object sender, ExecutedRoutedEventArgs e) => _ = MainWindow.FrameMainWindow.Navigate(new CommonReportPage());
	}
}