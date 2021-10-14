<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/145868570/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830537)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Change the Dashboard Item's Data Source Field at Runtime

This example demonstrates how to change the data source field specified for the Chart's argument in the [Dashboard Viewer](https://docs.devexpress.com/Dashboard/117122/winforms-dashboard/winforms-viewer).

To get access to a dashboard loaded in the Dashboard Viewer control, the [DashboardViewer.Dashboard](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Dashboard) property is used.

Dashboard items are contained in the [Dashboard.Items](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.Items) collection. In this example, a LINQ query obtains all dashboard items of the Chart type. The [DashboardItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItem) object is converted to the [ChartDashboardItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartDashboardItem) type. The [ChartDashboardItem.GetDimensions](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataDashboardItem.GetDimensions) method obtains a list of all chart's dimensions. As a result, the dimension's `Category` data member value is replaced with `State`.

<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/DashboardItemRuntimeExample/ViewerForm1.cs) (VB: [Form1.vb](./VB/DashboardItemRuntimeExample/ViewerForm1.vb))
<!-- default file list end -->
## Documentation
- [Chart Dashboard Item](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartDashboardItem)
- [Dashboard Items](https://docs.devexpress.com/Dashboard/116521)
