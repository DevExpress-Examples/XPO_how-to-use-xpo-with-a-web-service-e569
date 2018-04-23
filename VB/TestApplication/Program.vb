Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace TestApplication
    Friend Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread> _
        Shared Sub Main()
            InitDAL()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub

        Private Shared Sub InitDAL()
            Dim serviceUrl As String = "http://localhost:2224/XpoGate/MyXpoService.asmx"
            XpoDefault.DataLayer = New SimpleDataLayer(New MyWebDataStore(serviceUrl))
        End Sub
    End Class
End Namespace