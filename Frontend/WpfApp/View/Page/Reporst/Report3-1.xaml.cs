using System;
using System.Windows.Controls;

using Users;

using WpfApp.View.UserControl;

namespace WpfApp.View.Page.Reporst
{
    /// <summary>
    ///     Логика взаимодействия для Report3_1.xaml
    /// </summary>
    public partial class Report3_1 : ReportBaseView
    {
        public Report3_1()
        {
            InitializeComponent();
        }

        //TODO:Костыль - чтобы GridPanel не был null, потом убрать,а то сроки немного горят
		private void GridPanel_Initialized(object sender, EventArgs e) => SetGridPanel(sender as Grid);
    }
}