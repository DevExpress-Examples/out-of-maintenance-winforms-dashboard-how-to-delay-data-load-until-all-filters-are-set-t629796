using DevExpress.DashboardWin;
using System;
using System.Linq;

namespace CustomShowDataExample
{
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1()
        {
            InitializeComponent();
            dashboardDesigner.CustomizeDashboardTitle += DashboardDesigner_CustomizeDashboardTitle;
            dashboardDesigner.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");
        }

        #region #CustomizeDashboardTitle
        private void DashboardDesigner_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            DevExpress.Data.IParameter showDataParameter = dashboardDesigner.Parameters.FirstOrDefault(p => p.Name == "ShowData");
            if (showDataParameter != null)
            {
                bool showData = (bool)showDataParameter.Value;
                DashboardToolbarItem showDataItem = new DashboardToolbarItem(showData, "Select states in the State list box and click this button to display data",
                    new Action<DashboardToolbarItemClickEventArgs>((args) => {
                        showDataParameter.Value = !showData;
                    }));
                showDataItem.Caption = "Show Data";
                showDataItem.SvgImage = svgImageCollection1[0];
                e.Items.Insert(0, showDataItem);
            }
        }
        #endregion #CustomizeDashboardTitle
    }
}
