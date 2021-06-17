using System;
using System.Windows;
using System.Windows.Controls;

using Users;

using WpfApp.View.UserControl;

namespace WpfApp.View.Page.Reporst
{
    public abstract class ReportBaseView : System.Windows.Controls.Page
    {
        protected Grid GridPanel { get; private set; }

#region Overrides of FrameworkElement

        protected override void OnInitialized(EventArgs e)
        {
            if (GridPanel is not null)
            {
                UserResponce.Types.StatusUser status = (Application.Current as App).StatusUser;
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

        //TODO:Костыль - чтобы GridPanel не был null, потом убрать,а то сроки немного горят
        protected void GridPanel_OnInitialized(object sender, EventArgs e)
        {
            SetGridPanel(sender as Grid);
        }

        protected void SetGridPanel(Grid grid)
        {
            if (grid is null) return;

            GridPanel = grid;
        }
    }
}