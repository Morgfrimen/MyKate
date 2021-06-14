using System;
using System.Windows.Controls;

using Users;

using WpfApp.View.UserControl;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для DataGridExcelPage.xaml
    /// </summary>
    public partial class DataGridExcelPage : System.Windows.Controls.Page
    {
        public DataGridExcelPage()
        {
            InitializeComponent();
        }

#region Overrides of FrameworkElement

        protected override void OnInitialized(EventArgs e)
        {
            var status = (App.Current as App).StatusUser;
            System.Windows.Controls.UserControl footer = status switch
            {
                UserResponce.Types.StatusUser.Admin => new FooterAdminDataGrid(),
                UserResponce.Types.StatusUser.User  => new FooterUserDataGrid(),
                _                                   => throw new ArgumentException()
            };
            GridPanel.Children.Add(footer);
            Grid.SetRow(footer,1);
            base.OnInitialized(e);
        }

#endregion
    }
}