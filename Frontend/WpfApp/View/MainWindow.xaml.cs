using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using WpfApp.Core;

namespace WpfApp.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame FrameMainWindow { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            FrameMainWindow = Frame;
            FrameMainWindow.Navigated += OnNaviganePage;
            EventBroker.ChangeNamePageEvent += OnChangeNamePage;
        }

        private void OnNaviganePage(object sender, NavigationEventArgs e)
        {
            System.Windows.Controls.Page pageNavigate = e.Content as System.Windows.Controls.Page;
            EventBroker.OnChangeNamePageEvent(pageNavigate.Title);
        }

        private void OnChangeNamePage(string name) => NamePage_TextBlock.Text = name;
    }
}