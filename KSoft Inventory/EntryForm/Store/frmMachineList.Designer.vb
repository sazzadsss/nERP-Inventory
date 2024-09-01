<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachineList))
        Me.MachineListDataSet = New KSoft_Inventory.MachineListDataSet()
        Me.MachineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachineListTableAdapter = New KSoft_Inventory.MachineListDataSetTableAdapters.MachineListTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.MachineListDataSetTableAdapters.TableAdapterManager()
        Me.MachineListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MachineListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MachineListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMachineListId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMCType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditAllocationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInternalSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New KSoft_Inventory.BrandDataSet()
        Me.BrandTableAdapter = New KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        CType(Me.MachineListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MachineListBindingNavigator.SuspendLayout()
        CType(Me.MachineListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MachineListDataSet
        '
        Me.MachineListDataSet.DataSetName = "MachineListDataSet"
        Me.MachineListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachineListBindingSource
        '
        Me.MachineListBindingSource.DataMember = "MachineList"
        Me.MachineListBindingSource.DataSource = Me.MachineListDataSet
        '
        'MachineListTableAdapter
        '
        Me.MachineListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MachineListTableAdapter = Me.MachineListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.MachineListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachineListBindingNavigator
        '
        Me.MachineListBindingNavigator.AddNewItem = Nothing
        Me.MachineListBindingNavigator.BindingSource = Me.MachineListBindingSource
        Me.MachineListBindingNavigator.CountItem = Nothing
        Me.MachineListBindingNavigator.DeleteItem = Nothing
        Me.MachineListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MachineListBindingNavigatorSaveItem})
        Me.MachineListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MachineListBindingNavigator.MoveFirstItem = Nothing
        Me.MachineListBindingNavigator.MoveLastItem = Nothing
        Me.MachineListBindingNavigator.MoveNextItem = Nothing
        Me.MachineListBindingNavigator.MovePreviousItem = Nothing
        Me.MachineListBindingNavigator.Name = "MachineListBindingNavigator"
        Me.MachineListBindingNavigator.PositionItem = Nothing
        Me.MachineListBindingNavigator.Size = New System.Drawing.Size(1105, 25)
        Me.MachineListBindingNavigator.TabIndex = 0
        Me.MachineListBindingNavigator.Text = "BindingNavigator1"
        '
        'MachineListBindingNavigatorSaveItem
        '
        Me.MachineListBindingNavigatorSaveItem.Image = CType(resources.GetObject("MachineListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MachineListBindingNavigatorSaveItem.Name = "MachineListBindingNavigatorSaveItem"
        Me.MachineListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.MachineListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MachineListGridControl
        '
        Me.MachineListGridControl.DataSource = Me.MachineListBindingSource
        Me.MachineListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.MachineListGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.MachineListGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MachineListGridControl.MainView = Me.GridView1
        Me.MachineListGridControl.Name = "MachineListGridControl"
        Me.MachineListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DepartmentGridLookUpEdit, Me.BranchGridLookUpEdit})
        Me.MachineListGridControl.Size = New System.Drawing.Size(1105, 360)
        Me.MachineListGridControl.TabIndex = 1
        Me.MachineListGridControl.UseEmbeddedNavigator = True
        Me.MachineListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMachineListId, Me.colItemId, Me.colMCType, Me.colAuditAllocationNo, Me.colBranchId, Me.colInternalSerialNo, Me.colMachineSerialNo, Me.colRemarks, Me.colReceiveDate, Me.colDepartmentId, Me.colMachineName, Me.colBrand})
        Me.GridView1.GridControl = Me.MachineListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colMachineListId
        '
        Me.colMachineListId.FieldName = "MachineListId"
        Me.colMachineListId.Name = "colMachineListId"
        Me.colMachineListId.OptionsColumn.ReadOnly = True
        Me.colMachineListId.Width = 84
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item ID"
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 95
        '
        'colMCType
        '
        Me.colMCType.FieldName = "MCType"
        Me.colMCType.Name = "colMCType"
        Me.colMCType.Visible = True
        Me.colMCType.VisibleIndex = 2
        Me.colMCType.Width = 100
        '
        'colAuditAllocationNo
        '
        Me.colAuditAllocationNo.FieldName = "AuditAllocationNo"
        Me.colAuditAllocationNo.Name = "colAuditAllocationNo"
        Me.colAuditAllocationNo.Visible = True
        Me.colAuditAllocationNo.VisibleIndex = 3
        Me.colAuditAllocationNo.Width = 127
        '
        'colBranchId
        '
        Me.colBranchId.Caption = "Branch"
        Me.colBranchId.ColumnEdit = Me.BranchGridLookUpEdit
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 5
        Me.colBranchId.Width = 90
        '
        'BranchGridLookUpEdit
        '
        Me.BranchGridLookUpEdit.AutoHeight = False
        Me.BranchGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchGridLookUpEdit.DataSource = Me.BranchBindingSource
        Me.BranchGridLookUpEdit.DisplayMember = "BranchName"
        Me.BranchGridLookUpEdit.ImmediatePopup = True
        Me.BranchGridLookUpEdit.Name = "BranchGridLookUpEdit"
        Me.BranchGridLookUpEdit.NullText = ""
        Me.BranchGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BranchGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BranchGridLookUpEdit.ValueMember = "BranchId"
        Me.BranchGridLookUpEdit.View = Me.GridView2
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSetBindingSource
        '
        'BranchDataSetBindingSource
        '
        Me.BranchDataSetBindingSource.DataSource = Me.BranchDataSet
        Me.BranchDataSetBindingSource.Position = 0
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'colInternalSerialNo
        '
        Me.colInternalSerialNo.FieldName = "InternalSerialNo"
        Me.colInternalSerialNo.Name = "colInternalSerialNo"
        Me.colInternalSerialNo.Visible = True
        Me.colInternalSerialNo.VisibleIndex = 6
        Me.colInternalSerialNo.Width = 129
        '
        'colMachineSerialNo
        '
        Me.colMachineSerialNo.FieldName = "MachineSerialNo"
        Me.colMachineSerialNo.Name = "colMachineSerialNo"
        Me.colMachineSerialNo.Visible = True
        Me.colMachineSerialNo.VisibleIndex = 7
        Me.colMachineSerialNo.Width = 124
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 10
        Me.colRemarks.Width = 70
        '
        'colReceiveDate
        '
        Me.colReceiveDate.FieldName = "ReceiveDate"
        Me.colReceiveDate.Name = "colReceiveDate"
        Me.colReceiveDate.Visible = True
        Me.colReceiveDate.VisibleIndex = 8
        Me.colReceiveDate.Width = 112
        '
        'colDepartmentId
        '
        Me.colDepartmentId.Caption = "Department"
        Me.colDepartmentId.ColumnEdit = Me.DepartmentGridLookUpEdit
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        Me.colDepartmentId.Visible = True
        Me.colDepartmentId.VisibleIndex = 9
        Me.colDepartmentId.Width = 92
        '
        'DepartmentGridLookUpEdit
        '
        Me.DepartmentGridLookUpEdit.AutoHeight = False
        Me.DepartmentGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentGridLookUpEdit.DataSource = Me.DepartmentBindingSource
        Me.DepartmentGridLookUpEdit.DisplayMember = "DepartmentName"
        Me.DepartmentGridLookUpEdit.ImmediatePopup = True
        Me.DepartmentGridLookUpEdit.Name = "DepartmentGridLookUpEdit"
        Me.DepartmentGridLookUpEdit.NullText = ""
        Me.DepartmentGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DepartmentGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentGridLookUpEdit.ValueMember = "DepartmentId"
        Me.DepartmentGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'colMachineName
        '
        Me.colMachineName.FieldName = "MachineName"
        Me.colMachineName.Name = "colMachineName"
        Me.colMachineName.Visible = True
        Me.colMachineName.VisibleIndex = 1
        Me.colMachineName.Width = 101
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 4
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.BrandDataSet
        '
        'BrandDataSet
        '
        Me.BrandDataSet.DataSetName = "BrandDataSet"
        Me.BrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'frmMachineList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 385)
        Me.Controls.Add(Me.MachineListGridControl)
        Me.Controls.Add(Me.MachineListBindingNavigator)
        Me.Name = "frmMachineList"
        Me.Text = "Machine List"
        CType(Me.MachineListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MachineListBindingNavigator.ResumeLayout(False)
        Me.MachineListBindingNavigator.PerformLayout()
        CType(Me.MachineListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MachineListDataSet As KSoft_Inventory.MachineListDataSet
    Friend WithEvents MachineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineListTableAdapter As KSoft_Inventory.MachineListDataSetTableAdapters.MachineListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.MachineListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MachineListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents MachineListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MachineListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMachineListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuditAllocationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInternalSerialNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineSerialNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BrandDataSet As BrandDataSet
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandTableAdapter As BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents BranchGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents BranchDataSetBindingSource As BindingSource
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
End Class
