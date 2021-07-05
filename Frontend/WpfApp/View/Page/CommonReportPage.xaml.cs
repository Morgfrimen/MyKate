using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApp.Core;
using WpfApp.View.Page.Reporst;

namespace WpfApp.View.Page
{
	/// <summary>
	/// Логика взаимодействия для CommonReportPage.xaml
	/// </summary>
	public partial class CommonReportPage : System.Windows.Controls.Page
    {
        public static readonly RoutedCommand NavigateInformationAboutExpensePage = new();
        public static readonly RoutedCommand NavigateHelpAboutPage = new();
		public CommonReportPage()
		{
			InitializeComponent();
			EventBroker.OnChangeNamePageEvent(Title);
		}

        private void NavigateCommonReport_OnExecuted(object sender, ExecutedRoutedEventArgs e) => _ = MainWindow.FrameMainWindow.Navigate(new InformationAboutExpense());

        private void NavigateHelpAbout_OnExecuted(object sender, ExecutedRoutedEventArgs e) =>
            _ = MainWindow.FrameMainWindow.Navigate(new HelpAboutGPZ());
    }
}
