Imports DevExpress.XtraBars
Imports DevExpress.XtraMap
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardCommon
Imports System.Linq

Namespace DashboardItemRuntimeExample
	Partial Public Class ViewerForm1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DashboardViewer_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs) Handles dashboardViewer.CustomizeDashboardTitle
			Dim myCommandButton As New DashboardToolbarItem()
			myCommandButton.Caption = "Modify Chart"
			myCommandButton.ClickAction = New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
				ModifyChart()
			End Sub)
			e.Items.Add(myCommandButton)
		End Sub

		Private Sub ModifyChart()
			' Change the argument's data source field from "Category" to "State" in all chart items.
			Dim dBoard As Dashboard = dashboardViewer.Dashboard
			For Each item As DashboardItem In dBoard.Items.Where(Function(x) TypeOf x Is ChartDashboardItem)
				Dim chart As ChartDashboardItem = CType(item, ChartDashboardItem)
				For Each dimension In chart.GetDimensions().Where(Function(d) d.DataMember = "Category")
					dimension.DataMember = "State"
				Next dimension
			Next item
		End Sub
	End Class
End Namespace
