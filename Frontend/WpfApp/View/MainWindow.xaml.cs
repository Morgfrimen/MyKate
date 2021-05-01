using System.Windows;
using System.Windows.Controls;

namespace WpfApp.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMainWindow = Frame;
        }

        public static Frame FrameMainWindow { get; private set; }
    }
}