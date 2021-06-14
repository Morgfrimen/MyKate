using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using Users;

using WpfApp.View.UserControl;

namespace WpfApp.View.Page.Reporst
{
	public abstract class ReportBaseView : System.Windows.Controls.Page
	{
        protected void SetGridPanel(Grid grid)
        {
            if(grid is null)
                return;
            GridPanel = grid;
        }

        protected Grid GridPanel { get; private set; }

#region Overrides of FrameworkElement

        protected override void OnInitialized(EventArgs e)
        {
            if(GridPanel is not null)
            {
                var status = (App.Current as App).StatusUser;
                System.Windows.Controls.UserControl footer = status switch
                {
                    UserResponce.Types.StatusUser.Admin => new FooterAdminDataGrid(),
                    UserResponce.Types.StatusUser.User  => new FooterUserDataGrid(),
                    _                                   => throw new ArgumentException()
                };
                GridPanel.Children.Add(footer);
                Grid.SetRow(footer, 1);
            }
            base.OnInitialized(e);
        }

#endregion
	}
}
