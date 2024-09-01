<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhysicalInventory))
        Me.PhysicalInventoryDataSet = New KSoft_Inventory.PhysicalInventoryDataSet
        Me.PhysicalInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhysicalInventoryTableAdapter = New KSoft_Inventory.PhysicalInventoryDataSetTableAdapters.PhysicalInventoryTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.PhysicalInventoryDataSetTableAdapters.TableAdapterManager
        Me.PhysicalInventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.PhysicalInventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.PhysicalInventoryGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPhysicalInventoryId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInventoryDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInventoryQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        CType(Me.PhysicalInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhysicalInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhysicalInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhysicalInventoryBindingNavigator.SuspendLayout()
        CType(Me.PhysicalInventoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhysicalInventoryDataSet
        '
        Me.PhysicalInventoryDataSet.DataSetName = "PhysicalInventoryDataSet"
        Me.PhysicalInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhysicalInventoryBindingSource
        '
        Me.PhysicalInventoryBindingSource.DataMember = "PhysicalInventory"
        Me.PhysicalInventoryBindingSource.DataSource = Me.PhysicalInventoryDataSet
        '
        'PhysicalInventoryTableAdapter
        '
        Me.PhysicalInventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PhysicalInventoryTableAdapter = Me.PhysicalInventoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.PhysicalInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhysicalInventoryBindingNavigator
        '
        Me.PhysicalInventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PhysicalInventoryBindingNavigator.BindingSource = Me.PhysicalInventoryBindingSource
        Me.PhysicalInventoryBindingNavigator.CountItem = Nothing
        Me.PhysicalInventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PhysicalInventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.BindingNavigatorAddNewItem, Me.PhysicalInventoryBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.PhysicalInventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PhysicalInventoryBindingNavigator.MoveFirstItem = Nothing
        Me.PhysicalInventoryBindingNavigator.MoveLastItem = Nothing
        Me.PhysicalInventoryBindingNavigator.MoveNextItem = Nothing
        Me.PhysicalInventoryBindingNavigator.MovePreviousItem = Nothing
        Me.PhysicalInventoryBindingNavigator.Name = "PhysicalInventoryBindingNavigator"
        Me.PhysicalInventoryBindingNavigator.PositionItem = Nothing
        Me.PhysicalInventoryBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.PhysicalInventoryBindingNavigator.TabIndex = 0
        Me.PhysicalInventoryBindingNavigator.Text = "BindingNavigator1"
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
        'PhysicalInventoryBindingNavigatorSaveItem
        '
        Me.PhysicalInventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("PhysicalInventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PhysicalInventoryBindingNavigatorSaveItem.Name = "PhysicalInventoryBindingNavigatorSaveItem"
        Me.PhysicalInventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PhysicalInventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel1.Text = "         > Filter by Date"
        '
        'PhysicalInventoryGridControl
        '
        Me.PhysicalInventoryGridControl.DataSource = Me.PhysicalInventoryBindingSource
        Me.PhysicalInventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhysicalInventoryGridControl.Location = New System.Drawing.Point(0, 25)
        Me.PhysicalInventoryGridControl.MainView = Me.GridView1
        Me.PhysicalInventoryGridControl.Name = "PhysicalInventoryGridControl"
        Me.PhysicalInventoryGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemNameGridLookUpEdit})
        Me.PhysicalInventoryGridControl.Size = New System.Drawing.Size(896, 394)
        Me.PhysicalInventoryGridControl.TabIndex = 1
        Me.PhysicalInventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPhysicalInventoryId, Me.colItemId, Me.colInventoryDate, Me.colInventoryQuantity, Me.colRemarks, Me.colDepartmentId})
        Me.GridView1.GridControl = Me.PhysicalInventoryGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPhysicalInventoryId
        '
        Me.colPhysicalInventoryId.FieldName = "PhysicalInventoryId"
        Me.colPhysicalInventoryId.Name = "colPhysicalInventoryId"
        Me.colPhysicalInventoryId.OptionsColumn.ReadOnly = True
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 1
        Me.colItemId.Width = 221
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId1, Me.GridColumn1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        Me.colItemId1.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colInventoryDate
        '
        Me.colInventoryDate.FieldName = "InventoryDate"
        Me.colInventoryDate.Name = "colInventoryDate"
        Me.colInventoryDate.Visible = True
        Me.colInventoryDate.VisibleIndex = 0
        Me.colInventoryDate.Width = 116
        '
        'colInventoryQuantity
        '
        Me.colInventoryQuantity.FieldName = "InventoryQuantity"
        Me.colInventoryQuantity.Name = "colInventoryQuantity"
        Me.colInventoryQuantity.Visible = True
        Me.colInventoryQuantity.VisibleIndex = 2
        Me.colInventoryQuantity.Width = 123
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 415
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(338, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'frmPhysicalInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 419)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PhysicalInventoryGridControl)
        Me.Controls.Add(Me.PhysicalInventoryBindingNavigator)
        Me.Name = "frmPhysicalInventory"
        Me.Text = "Physical Inventory"
        CType(Me.PhysicalInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhysicalInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhysicalInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhysicalInventoryBindingNavigator.ResumeLayout(False)
        Me.PhysicalInventoryBindingNavigator.PerformLayout()
        CType(Me.PhysicalInventoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PhysicalInventoryDataSet As KSoft_Inventory.PhysicalInventoryDataSet
    Friend WithEvents PhysicalInventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PhysicalInventoryTableAdapter As KSoft_Inventory.PhysicalInventoryDataSetTableAdapters.PhysicalInventoryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.PhysicalInventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhysicalInventoryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PhysicalInventoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PhysicalInventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPhysicalInventoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
