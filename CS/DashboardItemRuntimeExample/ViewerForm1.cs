using DevExpress.XtraBars;
using DevExpress.XtraMap;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardWin;
using DevExpress.DashboardCommon;
using System.Linq;

namespace DashboardItemRuntimeExample
{
    public partial class ViewerForm1 : XtraForm
    {
        public ViewerForm1()
        {
            InitializeComponent();
        }

        private void DashboardViewer_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            DashboardToolbarItem myCommandButton = new DashboardToolbarItem();
            myCommandButton.Caption = "Modify Chart";
            myCommandButton.ClickAction = new Action<DashboardToolbarItemClickEventArgs>((args) => {
                ModifyChart();
            });
            e.Items.Add(myCommandButton);
        }

        private void ModifyChart()
        {
            // Change the argument's data source field from "Category" to "State" in all chart items.
            Dashboard dBoard = dashboardViewer.Dashboard;
            foreach (DashboardItem item in dBoard.Items.Where(x => x is ChartDashboardItem)) {
                ChartDashboardItem chart = (ChartDashboardItem)item;
                foreach (var dimension in chart.GetDimensions().Where(d => d.DataMember == "Category"))
                    dimension.DataMember = "State";
            }
        }
    }
}
