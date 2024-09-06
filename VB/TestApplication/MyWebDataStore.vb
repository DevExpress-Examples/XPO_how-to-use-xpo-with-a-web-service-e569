Imports System.Web.Services

Namespace TestApplication

    ' TODO: change MyWebDataSource namespace to match the published service's namespace
    <WebServiceBinding([Namespace]:=WebServiceAttribute.DefaultNamespace)>
    Friend Class MyWebDataStore
        Inherits DevExpress.Xpo.WebServiceDataStore

        Public Sub New(ByVal url As String)
            MyBase.New(url, DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
        End Sub
    End Class
End Namespace
