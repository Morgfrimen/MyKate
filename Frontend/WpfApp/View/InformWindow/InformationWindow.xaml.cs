using System.Windows;
using System.Windows.Input;

using WpfApp.ViewModels.Information;

namespace WpfApp.View.InformWindow
{
    /// <summary>
    ///     Логика взаимодействия для InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public static RoutedCommand CancelConnectionApp { get; } = new();

        private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (DataContext is not InformWindowViewModels vm) return;

            vm.CancellationTokenSource.Cancel();
            vm.OnExitAppEvent();
        }

        public InformationWindow()
        {
            InitializeComponent();
        }
    }
}