Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace TestApplication

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call InitDAL()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub

        Private Sub InitDAL()
            Dim serviceUrl As String = "http://localhost:2224/XpoGate/MyXpoService.asmx"
            XpoDefault.DataLayer = New SimpleDataLayer(New MyWebDataStore(serviceUrl))
        End Sub
    End Module
End Namespace
