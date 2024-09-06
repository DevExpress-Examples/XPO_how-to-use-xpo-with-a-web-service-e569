Namespace TestApplication

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
            Me.session1 = New DevExpress.Xpo.Session()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoneNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWebSite = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpCollection1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(809, 372)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.ObjectType = GetType(ContactManagement.Company)
            Me.xpCollection1.Session = Me.session1
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colPhoneNumber, Me.colCreatedOn, Me.colDisplayName, Me.colName, Me.colWebSite})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            ' 
            ' colOid
            ' 
            Me.colOid.Caption = "Oid"
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            ' 
            ' colPhoneNumber
            ' 
            Me.colPhoneNumber.Caption = "PhoneNumber"
            Me.colPhoneNumber.FieldName = "PhoneNumber"
            Me.colPhoneNumber.Name = "colPhoneNumber"
            Me.colPhoneNumber.Visible = True
            Me.colPhoneNumber.VisibleIndex = 2
            ' 
            ' colCreatedOn
            ' 
            Me.colCreatedOn.Caption = "CreatedOn"
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.OptionsColumn.[ReadOnly] = True
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 4
            ' 
            ' colDisplayName
            ' 
            Me.colDisplayName.Caption = "DisplayName"
            Me.colDisplayName.FieldName = "DisplayName"
            Me.colDisplayName.Name = "colDisplayName"
            Me.colDisplayName.OptionsColumn.[ReadOnly] = True
            Me.colDisplayName.Visible = True
            Me.colDisplayName.VisibleIndex = 1
            ' 
            ' colName
            ' 
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' colWebSite
            ' 
            Me.colWebSite.Caption = "WebSite"
            Me.colWebSite.FieldName = "WebSite"
            Me.colWebSite.Name = "colWebSite"
            Me.colWebSite.Visible = True
            Me.colWebSite.VisibleIndex = 3
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(809, 372)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private xpCollection1 As DevExpress.Xpo.XPCollection

        Private session1 As DevExpress.Xpo.Session

        Private colOid As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhoneNumber As DevExpress.XtraGrid.Columns.GridColumn

        Private colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn

        Private colDisplayName As DevExpress.XtraGrid.Columns.GridColumn

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colWebSite As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
