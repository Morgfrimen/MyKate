using GrpcService;

using System.Windows;

namespace WpfApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() => InitializeComponent();

		private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			HelloReply response = await (Application.Current as App).Client.SayHelloAsync(new HelloRequest() { Name = TextBoxName.Text });
			TextBlockResponse.Text = response.Message;
		}
	}
}
