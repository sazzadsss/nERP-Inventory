<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesMapping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessoriesMapping))
        Me.AccessoriesMappingDataSet = New KSoft_Inventory.AccessoriesMappingDataSet
        Me.AccessoriesMappingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesMappingTableAdapter = New KSoft_Inventory.AccessoriesMappingDataSetTableAdapters.AccessoriesMappingTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.AccessoriesMappingDataSetTableAdapters.TableAdapterManager
        Me.AccessoriesMappingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.AccessoriesMappingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.AccessoriesMappingGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAccessoriesMappingId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccessoriesId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AccessoriesItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.AccessoriesListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListDataSet = New KSoft_Inventory.AccessoriesListDataSet
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        Me.AccessoriesListLookupTableAdapter = New KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
        CType(Me.AccessoriesMappingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesMappingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesMappingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessoriesMappingBindingNavigator.SuspendLayout()
        CType(Me.AccessoriesMappingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccessoriesMappingDataSet
        '
        Me.AccessoriesMappingDataSet.DataSetName = "AccessoriesMappingDataSet"
        Me.AccessoriesMappingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoriesMappingBindingSource
        '
        Me.AccessoriesMappingBindingSource.DataMember = "AccessoriesMapping"
        Me.AccessoriesMappingBindingSource.DataSource = Me.AccessoriesMappingDataSet
        '
        'AccessoriesMappingTableAdapter
        '
        Me.AccessoriesMappingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesMappingTableAdapter = Me.AccessoriesMappingTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.AccessoriesMappingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoriesMappingBindingNavigator
        '
        Me.AccessoriesMappingBindingNavigator.AddNewItem = Nothing
        Me.AccessoriesMappingBindingNavigator.BindingSource = Me.AccessoriesMappingBindingSource
        Me.AccessoriesMappingBindingNavigator.CountItem = Nothing
        Me.AccessoriesMappingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AccessoriesMappingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.AccessoriesMappingBindingNavigatorSaveItem})
        Me.AccessoriesMappingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccessoriesMappingBindingNavigator.MoveFirstItem = Nothing
        Me.AccessoriesMappingBindingNavigator.MoveLastItem = Nothing
        Me.AccessoriesMappingBindingNavigator.MoveNextItem = Nothing
        Me.AccessoriesMappingBindingNavigator.MovePreviousItem = Nothing
        Me.AccessoriesMappingBindingNavigator.Name = "AccessoriesMappingBindingNavigator"
        Me.AccessoriesMappingBindingNavigator.PositionItem = Nothing
        Me.AccessoriesMappingBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.AccessoriesMappingBindingNavigator.TabIndex = 0
        Me.AccessoriesMappingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AccessoriesMappingBindingNavigatorSaveItem
        '
        Me.AccessoriesMappingBindingNavigatorSaveItem.Image = CType(resources.GetObject("AccessoriesMappingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AccessoriesMappingBindingNavigatorSaveItem.Name = "AccessoriesMappingBindingNavigatorSaveItem"
        Me.AccessoriesMappingBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.AccessoriesMappingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccessoriesMappingGridControl
        '
        Me.AccessoriesMappingGridControl.DataSource = Me.AccessoriesMappingBindingSource
        Me.AccessoriesMappingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessoriesMappingGridControl.Location = New System.Drawing.Point(0, 25)
        Me.AccessoriesMappingGridControl.MainView = Me.GridView1
        Me.AccessoriesMappingGridControl.Name = "AccessoriesMappingGridControl"
        Me.AccessoriesMappingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemNameGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.AccessoriesItemLookUpEdit})
        Me.AccessoriesMappingGridControl.Size = New System.Drawing.Size(773, 360)
        Me.AccessoriesMappingGridControl.TabIndex = 1
        Me.AccessoriesMappingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesMappingId, Me.colItemId, Me.colAccessoriesId, Me.colRemarks, Me.colDepartmentId})
        Me.GridView1.GridControl = Me.AccessoriesMappingGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRemarks, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colAccessoriesMappingId
        '
        Me.colAccessoriesMappingId.FieldName = "AccessoriesMappingId"
        Me.colAccessoriesMappingId.Name = "colAccessoriesMappingId"
        Me.colAccessoriesMappingId.OptionsColumn.ReadOnly = True
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 198
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "ID-Name"
        Me.ItemNameGridLookUpEdit.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.NullText = ""
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
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colAccessoriesId
        '
        Me.colAccessoriesId.Caption = "Accessories Name"
        Me.colAccessoriesId.ColumnEdit = Me.AccessoriesItemLookUpEdit
        Me.colAccessoriesId.FieldName = "AccessoriesId"
        Me.colAccessoriesId.Name = "colAccessoriesId"
        Me.colAccessoriesId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAccessoriesId.Visible = True
        Me.colAccessoriesId.VisibleIndex = 1
        Me.colAccessoriesId.Width = 233
        '
        'AccessoriesItemLookUpEdit
        '
        Me.AccessoriesItemLookUpEdit.AutoHeight = False
        Me.AccessoriesItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccessoriesItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccessoriesId", "Accessories Id", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccessoriesName", "Accessories Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStyle", "Item Style", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemDetails", "Item Details", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.AccessoriesItemLookUpEdit.DataSource = Me.AccessoriesListLookupBindingSource
        Me.AccessoriesItemLookUpEdit.DisplayMember = "ItemDetails"
        Me.AccessoriesItemLookUpEdit.Name = "AccessoriesItemLookUpEdit"
        Me.AccessoriesItemLookUpEdit.NullText = ""
        Me.AccessoriesItemLookUpEdit.ValueMember = "AccessoriesId"
        '
        'AccessoriesListLookupBindingSource
        '
        Me.AccessoriesListLookupBindingSource.DataMember = "AccessoriesListLookup"
        Me.AccessoriesListLookupBindingSource.DataSource = Me.AccessoriesListDataSet
        '
        'AccessoriesListDataSet
        '
        Me.AccessoriesListDataSet.DataSetName = "AccessoriesListDataSet"
        Me.AccessoriesListDataSet.EnforceConstraints = False
        Me.AccessoriesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        Me.colRemarks.Width = 458
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesListLookupTableAdapter
        '
        Me.AccessoriesListLookupTableAdapter.ClearBeforeFill = True
        '
        'frmAccessoriesMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 385)
        Me.Controls.Add(Me.AccessoriesMappingGridControl)
        Me.Controls.Add(Me.AccessoriesMappingBindingNavigator)
        Me.Name = "frmAccessoriesMapping"
        Me.Text = "Accessories Mapping"
        CType(Me.AccessoriesMappingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesMappingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesMappingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessoriesMappingBindingNavigator.ResumeLayout(False)
        Me.AccessoriesMappingBindingNavigator.PerformLayout()
        CType(Me.AccessoriesMappingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccessoriesMappingDataSet As KSoft_Inventory.AccessoriesMappingDataSet
    Friend WithEvents AccessoriesMappingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesMappingTableAdapter As KSoft_Inventory.AccessoriesMappingDataSetTableAdapters.AccessoriesMappingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.AccessoriesMappingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoriesMappingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccessoriesMappingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccessoriesMappingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesMappingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessoriesItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccessoriesListDataSet As KSoft_Inventory.AccessoriesListDataSet
    Friend WithEvents AccessoriesListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListLookupTableAdapter As KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
End Class
