<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ReportListDataSet = New KSoft_Inventory.ReportListDataSet
        Me.ReportListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportListTableAdapter = New KSoft_Inventory.ReportListDataSetTableAdapters.ReportListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ReportListDataSetTableAdapters.TableAdapterManager
        Me.ReportListGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colReportName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReportFormListId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReportFormNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ReportFormListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFormListDataSet = New KSoft_Inventory.ReportFormListDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReportPathHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ShowHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.ReportFormListTableAdapter = New KSoft_Inventory.ReportFormListDataSetTableAdapters.ReportFormListTableAdapter
        CType(Me.ReportListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportPathHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportListDataSet
        '
        Me.ReportListDataSet.DataSetName = "ReportListDataSet"
        Me.ReportListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportListBindingSource
        '
        Me.ReportListBindingSource.DataMember = "ReportList"
        Me.ReportListBindingSource.DataSource = Me.ReportListDataSet
        '
        'ReportListTableAdapter
        '
        Me.ReportListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ReportListTableAdapter = Me.ReportListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ReportListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportListGridControl
        '
        Me.ReportListGridControl.DataSource = Me.ReportListBindingSource
        Me.ReportListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportListGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReportListGridControl.MainView = Me.GridView1
        Me.ReportListGridControl.Name = "ReportListGridControl"
        Me.ReportListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ReportPathHyperLinkEdit, Me.RepositoryItemTextEdit1, Me.ReportFormNameGridLookUpEdit, Me.ShowHyperLinkEdit})
        Me.ReportListGridControl.Size = New System.Drawing.Size(759, 447)
        Me.ReportListGridControl.TabIndex = 1
        Me.ReportListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReportName, Me.colReportFormListId, Me.colDescription})
        Me.GridView1.GridControl = Me.ReportListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colReportName
        '
        Me.colReportName.FieldName = "ReportName"
        Me.colReportName.Name = "colReportName"
        Me.colReportName.OptionsColumn.AllowEdit = False
        Me.colReportName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colReportName.Visible = True
        Me.colReportName.VisibleIndex = 0
        Me.colReportName.Width = 155
        '
        'colReportFormListId
        '
        Me.colReportFormListId.Caption = "Report Form Name"
        Me.colReportFormListId.ColumnEdit = Me.ReportFormNameGridLookUpEdit
        Me.colReportFormListId.FieldName = "ReportFormListId"
        Me.colReportFormListId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colReportFormListId.Name = "colReportFormListId"
        Me.colReportFormListId.OptionsColumn.AllowEdit = False
        Me.colReportFormListId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colReportFormListId.Visible = True
        Me.colReportFormListId.VisibleIndex = 1
        Me.colReportFormListId.Width = 142
        '
        'ReportFormNameGridLookUpEdit
        '
        Me.ReportFormNameGridLookUpEdit.DataSource = Me.ReportFormListBindingSource
        Me.ReportFormNameGridLookUpEdit.DisplayMember = "ReportFormName"
        Me.ReportFormNameGridLookUpEdit.Name = "ReportFormNameGridLookUpEdit"
        Me.ReportFormNameGridLookUpEdit.NullText = ""
        Me.ReportFormNameGridLookUpEdit.ValueMember = "ReportFormListId"
        Me.ReportFormNameGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ReportFormListBindingSource
        '
        Me.ReportFormListBindingSource.DataMember = "ReportFormList"
        Me.ReportFormListBindingSource.DataSource = Me.ReportFormListDataSet
        '
        'ReportFormListDataSet
        '
        Me.ReportFormListDataSet.DataSetName = "ReportFormListDataSet"
        Me.ReportFormListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 444
        '
        'ReportPathHyperLinkEdit
        '
        Me.ReportPathHyperLinkEdit.Name = "ReportPathHyperLinkEdit"
        Me.ReportPathHyperLinkEdit.SingleClick = True
        Me.ReportPathHyperLinkEdit.ValidateOnEnterKey = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'ShowHyperLinkEdit
        '
        Me.ShowHyperLinkEdit.AutoHeight = False
        Me.ShowHyperLinkEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)})
        Me.ShowHyperLinkEdit.Name = "ShowHyperLinkEdit"
        '
        'ReportFormListTableAdapter
        '
        Me.ReportFormListTableAdapter.ClearBeforeFill = True
        '
        'frmSearchReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 447)
        Me.Controls.Add(Me.ReportListGridControl)
        Me.Name = "frmSearchReport"
        Me.Text = "Search Report"
        CType(Me.ReportListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportPathHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportListDataSet As KSoft_Inventory.ReportListDataSet
    Friend WithEvents ReportListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportListTableAdapter As KSoft_Inventory.ReportListDataSetTableAdapters.ReportListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ReportListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReportListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReportName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportFormListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportPathHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents ReportFormNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ReportFormListDataSet As KSoft_Inventory.ReportFormListDataSet
    Friend WithEvents ReportFormListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportFormListTableAdapter As KSoft_Inventory.ReportFormListDataSetTableAdapters.ReportFormListTableAdapter
    Friend WithEvents ShowHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
