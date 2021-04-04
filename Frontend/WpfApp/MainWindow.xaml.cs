using System.Windows;

using Autorize;

using GrpcProtoClient;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
#region Constructors

        public MainWindow() => InitializeComponent();

#endregion

#region Methods

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            App app = Application.Current as App;
            Token token = new() {Role = (int) app.UserToken};
            RequestAutorize requestAutorize = new() {Token = token};
            ResponseAutorize response = await Broker.Instanse.AutorizedAsync(requestAutorize);
            TextBlockResponse.Text = response.Result.ToString();
        }

#endregion
    }
}