using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp.View.Page.Reporst
{
	/// <summary>
	/// Логика взаимодействия для HelpAboutGPZ.xaml
	/// </summary>
	public partial class HelpAboutGPZ : System.Windows.Controls.Page
	{
		public HelpAboutGPZ()
		{
			InitializeComponent();
		}

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            var header = sender as DataGridColumnHeader;
            //header.MinWidth = DataGridTemplateColumn.MinWidth;
        }
    }
}
