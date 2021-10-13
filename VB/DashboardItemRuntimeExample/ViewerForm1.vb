Imports DevExpress.XtraBars
Imports DevExpress.XtraMap
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardCommon

Namespace DashboardItemRuntimeExample

    Public Partial Class ViewerForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DashboardViewer_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
            Dim myCommandButton As DashboardToolbarItem = New DashboardToolbarItem()
            myCommandButton.Caption = "Modify Chart"
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             myCommandButton.ClickAction = new System.Action<DashboardToolbarItemClickEventArgs>((args) => {
'''                 this.ModifyChart();
'''             })
'''  e.Items.Add(myCommandButton)
        End Sub

        Private Sub ModifyChart()
            ' Change the argument's data source field from "Category" to "State" in all chart items.
            Dim dBoard As Dashboard = dashboardViewer.Dashboard
            For Each item As DashboardItem In dBoard.Items.Where(Function(x) TypeOf x Is ChartDashboardItem)
                Dim chart As ChartDashboardItem = CType(item, ChartDashboardItem)
                For Each dimension In chart.GetDimensions().Where(Function(d) d.DataMember Is "Category")
                    dimension.DataMember = "State"
                Next
            Next
        End Sub
    End Class
End Namespace
