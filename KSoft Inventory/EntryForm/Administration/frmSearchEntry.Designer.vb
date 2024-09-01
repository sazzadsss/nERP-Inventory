<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchEntry))
        Me.ReportListDataSet = New KSoft_Inventory.ReportListDataSet
        Me.ReportListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportListTableAdapter = New KSoft_Inventory.ReportListDataSetTableAdapters.ReportListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ReportListDataSetTableAdapters.TableAdapterManager
        Me.ReportListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ReportListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateFormButton = New System.Windows.Forms.ToolStripButton
        Me.ReportListGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colReportName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReportFormListId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReportFormListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ReportFormListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFormListDataSet = New KSoft_Inventory.ReportFormListDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colReportFormName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RptModule = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ModuleGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ReportPath = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ReportPathHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.ReportPathGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ReportPathButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.ReportFormListTableAdapter = New KSoft_Inventory.ReportFormListDataSetTableAdapters.ReportFormListTableAdapter
        CType(Me.ReportListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReportListBindingNavigator.SuspendLayout()
        CType(Me.ReportListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFormListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuleGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportPathHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportPathGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportPathButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ReportListBindingNavigator
        '
        Me.ReportListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReportListBindingNavigator.BindingSource = Me.ReportListBindingSource
        Me.ReportListBindingNavigator.CountItem = Nothing
        Me.ReportListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReportListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReportListBindingNavigatorSaveItem, Me.BindingNavigatorSeparator2, Me.UpdateFormButton})
        Me.ReportListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReportListBindingNavigator.MoveFirstItem = Nothing
        Me.ReportListBindingNavigator.MoveLastItem = Nothing
        Me.ReportListBindingNavigator.MoveNextItem = Nothing
        Me.ReportListBindingNavigator.MovePreviousItem = Nothing
        Me.ReportListBindingNavigator.Name = "ReportListBindingNavigator"
        Me.ReportListBindingNavigator.PositionItem = Nothing
        Me.ReportListBindingNavigator.Size = New System.Drawing.Size(864, 25)
        Me.ReportListBindingNavigator.TabIndex = 0
        Me.ReportListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ReportListBindingNavigatorSaveItem
        '
        Me.ReportListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReportListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReportListBindingNavigatorSaveItem.Name = "ReportListBindingNavigatorSaveItem"
        Me.ReportListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ReportListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UpdateFormButton
        '
        Me.UpdateFormButton.Image = CType(resources.GetObject("UpdateFormButton.Image"), System.Drawing.Image)
        Me.UpdateFormButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateFormButton.Name = "UpdateFormButton"
        Me.UpdateFormButton.Size = New System.Drawing.Size(117, 22)
        Me.UpdateFormButton.Text = "Update Form List"
        '
        'ReportListGridControl
        '
        Me.ReportListGridControl.DataSource = Me.ReportListBindingSource
        Me.ReportListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportListGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ReportListGridControl.MainView = Me.GridView1
        Me.ReportListGridControl.Name = "ReportListGridControl"
        Me.ReportListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ReportFormListGridLookUpEdit, Me.ModuleGridLookUpEdit, Me.ReportPathGridLookUpEdit, Me.ReportPathButtonEdit, Me.ReportPathHyperLinkEdit})
        Me.ReportListGridControl.Size = New System.Drawing.Size(864, 466)
        Me.ReportListGridControl.TabIndex = 1
        Me.ReportListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReportName, Me.colReportFormListId, Me.colDescription, Me.RptModule, Me.ReportPath})
        Me.GridView1.GridControl = Me.ReportListGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colReportName
        '
        Me.colReportName.FieldName = "ReportName"
        Me.colReportName.Name = "colReportName"
        Me.colReportName.Visible = True
        Me.colReportName.VisibleIndex = 0
        Me.colReportName.Width = 231
        '
        'colReportFormListId
        '
        Me.colReportFormListId.Caption = "Report Form Name"
        Me.colReportFormListId.ColumnEdit = Me.ReportFormListGridLookUpEdit
        Me.colReportFormListId.FieldName = "ReportFormListId"
        Me.colReportFormListId.Name = "colReportFormListId"
        Me.colReportFormListId.Visible = True
        Me.colReportFormListId.VisibleIndex = 1
        Me.colReportFormListId.Width = 196
        '
        'ReportFormListGridLookUpEdit
        '
        Me.ReportFormListGridLookUpEdit.AutoHeight = False
        Me.ReportFormListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportFormListGridLookUpEdit.DataSource = Me.ReportFormListBindingSource
        Me.ReportFormListGridLookUpEdit.DisplayMember = "ReportFormName"
        Me.ReportFormListGridLookUpEdit.Name = "ReportFormListGridLookUpEdit"
        Me.ReportFormListGridLookUpEdit.NullText = ""
        Me.ReportFormListGridLookUpEdit.ValueMember = "ReportFormListId"
        Me.ReportFormListGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReportFormName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colReportFormName
        '
        Me.colReportFormName.FieldName = "ReportFormName"
        Me.colReportFormName.Name = "colReportFormName"
        Me.colReportFormName.Visible = True
        Me.colReportFormName.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 419
        '
        'RptModule
        '
        Me.RptModule.Caption = "Module"
        Me.RptModule.ColumnEdit = Me.ModuleGridLookUpEdit
        Me.RptModule.FieldName = "ReportFormListId"
        Me.RptModule.Name = "RptModule"
        '
        'ModuleGridLookUpEdit
        '
        Me.ModuleGridLookUpEdit.AutoHeight = False
        Me.ModuleGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModuleGridLookUpEdit.DataSource = Me.ReportFormListBindingSource
        Me.ModuleGridLookUpEdit.DisplayMember = "Module"
        Me.ModuleGridLookUpEdit.Name = "ModuleGridLookUpEdit"
        Me.ModuleGridLookUpEdit.NullText = ""
        Me.ModuleGridLookUpEdit.ValueMember = "ReportFormListId"
        Me.ModuleGridLookUpEdit.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ReportPath
        '
        Me.ReportPath.Caption = "ReportPath"
        Me.ReportPath.ColumnEdit = Me.ReportPathHyperLinkEdit
        Me.ReportPath.FieldName = "ReportFormListId"
        Me.ReportPath.Name = "ReportPath"
        '
        'ReportPathHyperLinkEdit
        '
        Me.ReportPathHyperLinkEdit.AutoHeight = False
        Me.ReportPathHyperLinkEdit.Name = "ReportPathHyperLinkEdit"
        '
        'ReportPathGridLookUpEdit
        '
        Me.ReportPathGridLookUpEdit.AutoHeight = False
        Me.ReportPathGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportPathGridLookUpEdit.DataSource = Me.ReportFormListBindingSource
        Me.ReportPathGridLookUpEdit.DisplayMember = "ReportPathName"
        Me.ReportPathGridLookUpEdit.Name = "ReportPathGridLookUpEdit"
        Me.ReportPathGridLookUpEdit.NullText = ""
        Me.ReportPathGridLookUpEdit.ValueMember = "ReportFormListId"
        Me.ReportPathGridLookUpEdit.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'ReportPathButtonEdit
        '
        Me.ReportPathButtonEdit.AutoHeight = False
        Me.ReportPathButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ReportPathButtonEdit.Name = "ReportPathButtonEdit"
        '
        'ReportFormListTableAdapter
        '
        Me.ReportFormListTableAdapter.ClearBeforeFill = True
        '
        'frmSearchEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.ReportListGridControl)
        Me.Controls.Add(Me.ReportListBindingNavigator)
        Me.Name = "frmSearchEntry"
        Me.Text = "Search Entry"
        CType(Me.ReportListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReportListBindingNavigator.ResumeLayout(False)
        Me.ReportListBindingNavigator.PerformLayout()
        CType(Me.ReportListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFormListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModuleGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportPathHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportPathGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportPathButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportListDataSet As KSoft_Inventory.ReportListDataSet
    Friend WithEvents ReportListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportListTableAdapter As KSoft_Inventory.ReportListDataSetTableAdapters.ReportListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ReportListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReportListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReportListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UpdateFormButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReportName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportFormListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportFormListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportFormListDataSet As KSoft_Inventory.ReportFormListDataSet
    Friend WithEvents ReportFormListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportFormListTableAdapter As KSoft_Inventory.ReportFormListDataSetTableAdapters.ReportFormListTableAdapter
    Friend WithEvents RptModule As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ModuleGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReportPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportPathGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReportFormName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReportPathHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents ReportPathButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

End Class
