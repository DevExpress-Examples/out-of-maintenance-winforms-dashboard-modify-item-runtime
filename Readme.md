*Files to look at*:

* [Form1.cs](./CS/DashboardItemRuntimeExample/ViewerForm1.cs) (VB: [Form1.vb](./VB/DashboardItemRuntimeExample/ViewerForm1.vb))

# Dashboard for WinForms - How to change the dashboard item's data source field at runtime

This example demonstrates how to change the data source field specified for the Chart's argument in the [Dashboard Viewer](https://docs.devexpress.com/Dashboard/117122/winforms-dashboard/winforms-viewer).

To get access to a dashboard loaded in the Dashboard Viewer control, the [DashboardViewer.Dashboard](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Dashboard) property is used.

Dashboard items are contained in the [Dashboard.Items](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.Items) collection. In this example, a LINQ query obtains all dashboard items of the Chart type. The [DashboardItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItem) object is converted to the [ChartDashboardItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartDashboardItem) type. The [ChartDashboardItem.GetDimensions](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataDashboardItem.GetDimensions) method obtains a list of all chart's dimensions. As a result, the dimension's `Category` data member value is replaced with `State`.

## Documentation
- [Chart Dashboard Item](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartDashboardItem)
- [Dashboard Items](https://docs.devexpress.com/Dashboard/116521)
