Imports System
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins

Namespace DashboardItemRuntimeExample

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            BonusSkins.Register()
            Call Application.Run(New ViewerForm1())
        End Sub
    End Module
End Namespace
