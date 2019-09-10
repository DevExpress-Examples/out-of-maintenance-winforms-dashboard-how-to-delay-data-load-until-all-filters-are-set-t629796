Imports DevExpress.DashboardWin
Imports System
Imports System.Linq

Namespace CustomShowDataExample
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			AddHandler dashboardDesigner.CustomizeDashboardTitle, AddressOf DashboardDesigner_CustomizeDashboardTitle
			dashboardDesigner.LoadDashboard("..\..\Dashboards\dashboard1.xml")
		End Sub

		#Region "#CustomizeDashboardTitle"
		Private Sub DashboardDesigner_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim showDataParameter As DevExpress.Data.IParameter = dashboardDesigner.Parameters.FirstOrDefault(Function(p) p.Name = "ShowData")
			If showDataParameter IsNot Nothing Then
				Dim showData As Boolean = DirectCast(showDataParameter.Value, Boolean)
				Dim showDataItem As DashboardToolbarItem = New DashboardToolbarItem(showData, "Select states in the State list box and click this button to display data", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
					showDataParameter.Value = Not showData
				End Sub))
				showDataItem.Caption = "Show Data"
				showDataItem.SvgImage = svgImageCollection1(0)
				e.Items.Insert(0, showDataItem)
			End If
		End Sub
		#End Region ' #CustomizeDashboardTitle
	End Class
End Namespace
