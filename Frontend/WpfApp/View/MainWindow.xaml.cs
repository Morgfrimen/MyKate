using System.Windows;
using System.Windows.Controls;

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
            EventBroker.ChangeNamePageEvent += OnChangeNamePage;
        }

        private void OnChangeNamePage(string name) => NamePage_TextBlock.Text = name;
    }
}