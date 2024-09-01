<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvanceYarnLotAllocation
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
        Dim Label10 As System.Windows.Forms.Label
        Dim LotNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvanceYarnLotAllocation))
        Me.AdvanceYarnLotAllocationDataSet = New KSoft_Inventory.AdvanceYarnLotAllocationDataSet()
        Me.AdvanceYarnLotAllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvanceYarnLotAllocationTableAdapter = New KSoft_Inventory.AdvanceYarnLotAllocationDataSetTableAdapters.AdvanceYarnLotAllocationTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.AdvanceYarnLotAllocationDataSetTableAdapters.TableAdapterManager()
        Me.AdvanceYarnLotAllocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdvanceYarnLotAllocationGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStockInHand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdvanceYarnLotAllocationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PIListLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PILookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PILookUpDataSet = New KSoft_Inventory.PILookUpDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PILookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCNoLookUpFromPIIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.ItemIdLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ProgramNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AddButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ShowAllButton = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TransShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TransferButton = New DevExpress.XtraEditors.SimpleButton()
        Me.TransLotNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TransYarnNameLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TransBrandLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.AllocateQuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LotAndItemwiseBalanceTableAdapter = New KSoft_Inventory.LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter()
        Me.LotAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotAndItemBalanceDataSet = New KSoft_Inventory.LotAndItemBalanceDataSet()
        Me.PIAnditemwiseBalanceDataSet = New KSoft_Inventory.PIAnditemwiseBalanceDataSet()
        Me.PIAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIAndItemwiseBalanceTableAdapter = New KSoft_Inventory.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter()
        Me.PIIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PIIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnLotNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLReceive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLIssue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LotNoGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLIssue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCNoLookUpFromPIIdTableAdapter = New KSoft_Inventory.PILookUpDataSetTableAdapters.LCNoLookUpFromPIIdTableAdapter()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ReceiveQtyLabel = New DevExpress.XtraEditors.LabelControl()
        Me.IssueQtyLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.TTLAllocateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PILookUpTableAdapter = New KSoft_Inventory.PILookUpDataSetTableAdapters.PILookUpTableAdapter()
        Me.ShowUpButton = New DevExpress.XtraEditors.SimpleButton()
        Label10 = New System.Windows.Forms.Label()
        LotNoLabel = New System.Windows.Forms.Label()
        CType(Me.AdvanceYarnLotAllocationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvanceYarnLotAllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvanceYarnLotAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvanceYarnLotAllocationBindingNavigator.SuspendLayout()
        CType(Me.AdvanceYarnLotAllocationGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCNoLookUpFromPIIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TransLotNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransYarnNameLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBrandLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllocateQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(360, 61)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(43, 13)
        Label10.TabIndex = 111
        Label10.Text = "LC No :"
        '
        'LotNoLabel
        '
        LotNoLabel.AutoSize = True
        LotNoLabel.Location = New System.Drawing.Point(360, 35)
        LotNoLabel.Name = "LotNoLabel"
        LotNoLabel.Size = New System.Drawing.Size(45, 13)
        LotNoLabel.TabIndex = 109
        LotNoLabel.Text = "Lot No :"
        '
        'AdvanceYarnLotAllocationDataSet
        '
        Me.AdvanceYarnLotAllocationDataSet.DataSetName = "AdvanceYarnLotAllocationDataSet"
        Me.AdvanceYarnLotAllocationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdvanceYarnLotAllocationBindingSource
        '
        Me.AdvanceYarnLotAllocationBindingSource.DataMember = "AdvanceYarnLotAllocation"
        Me.AdvanceYarnLotAllocationBindingSource.DataSource = Me.AdvanceYarnLotAllocationDataSet
        '
        'AdvanceYarnLotAllocationTableAdapter
        '
        Me.AdvanceYarnLotAllocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdvanceYarnLotAllocationTableAdapter = Me.AdvanceYarnLotAllocationTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.AdvanceYarnLotAllocationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdvanceYarnLotAllocationBindingNavigator
        '
        Me.AdvanceYarnLotAllocationBindingNavigator.AddNewItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.BindingSource = Me.AdvanceYarnLotAllocationBindingSource
        Me.AdvanceYarnLotAllocationBindingNavigator.CountItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.DeleteItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem, Me.BindingNavigatorSeparator2})
        Me.AdvanceYarnLotAllocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdvanceYarnLotAllocationBindingNavigator.MoveFirstItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.MoveLastItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.MoveNextItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.MovePreviousItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.Name = "AdvanceYarnLotAllocationBindingNavigator"
        Me.AdvanceYarnLotAllocationBindingNavigator.PositionItem = Nothing
        Me.AdvanceYarnLotAllocationBindingNavigator.Size = New System.Drawing.Size(1138, 25)
        Me.AdvanceYarnLotAllocationBindingNavigator.TabIndex = 0
        Me.AdvanceYarnLotAllocationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'AdvanceYarnLotAllocationBindingNavigatorSaveItem
        '
        Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdvanceYarnLotAllocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem.Name = "AdvanceYarnLotAllocationBindingNavigatorSaveItem"
        Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.AdvanceYarnLotAllocationBindingNavigatorSaveItem.Text = "Save"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AdvanceYarnLotAllocationGridControl
        '
        Me.AdvanceYarnLotAllocationGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvanceYarnLotAllocationGridControl.DataSource = Me.AdvanceYarnLotAllocationBindingSource
        Me.AdvanceYarnLotAllocationGridControl.Location = New System.Drawing.Point(0, 133)
        Me.AdvanceYarnLotAllocationGridControl.MainView = Me.GridView1
        Me.AdvanceYarnLotAllocationGridControl.Name = "AdvanceYarnLotAllocationGridControl"
        Me.AdvanceYarnLotAllocationGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.YarnItemGridLookUpEdit, Me.SupplierGridLookUpEdit, Me.ProgramNoGridLookUpEdit, Me.PIListLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.PILookupGridLookUpEdit})
        Me.AdvanceYarnLotAllocationGridControl.Size = New System.Drawing.Size(1138, 225)
        Me.AdvanceYarnLotAllocationGridControl.TabIndex = 1
        Me.AdvanceYarnLotAllocationGridControl.UseEmbeddedNavigator = True
        Me.AdvanceYarnLotAllocationGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colLotNo, Me.colFinishFabricBookingId, Me.colRemarks, Me.colAllocateQty, Me.colIssueQty, Me.colStockInHand, Me.colSupplierId, Me.colAdvanceYarnLotAllocationId, Me.colPIId1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(803, 441, 210, 172)
        Me.GridView1.GridControl = Me.AdvanceYarnLotAllocationGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.Caption = "Yarn Name"
        Me.colItemId.ColumnEdit = Me.YarnItemGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.AllowEdit = False
        Me.colItemId.OptionsColumn.ReadOnly = True
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 227
        '
        'YarnItemGridLookUpEdit
        '
        Me.YarnItemGridLookUpEdit.AutoHeight = False
        Me.YarnItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnItemGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.YarnItemGridLookUpEdit.DisplayMember = "ItemName"
        Me.YarnItemGridLookUpEdit.Name = "YarnItemGridLookUpEdit"
        Me.YarnItemGridLookUpEdit.NullText = ""
        Me.YarnItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnItemGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.YarnItemGridLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.YarnItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnItemGridLookUpEdit.ValueMember = "ItemId"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.OptionsColumn.ReadOnly = True
        Me.colLotNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 3
        Me.colLotNo.Width = 116
        '
        'colFinishFabricBookingId
        '
        Me.colFinishFabricBookingId.Caption = "Program No :: Style :: Buyer"
        Me.colFinishFabricBookingId.ColumnEdit = Me.ProgramNoGridLookUpEdit
        Me.colFinishFabricBookingId.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFinishFabricBookingId.Name = "colFinishFabricBookingId"
        Me.colFinishFabricBookingId.OptionsColumn.AllowEdit = False
        Me.colFinishFabricBookingId.OptionsColumn.ReadOnly = True
        Me.colFinishFabricBookingId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFinishFabricBookingId.Visible = True
        Me.colFinishFabricBookingId.VisibleIndex = 4
        Me.colFinishFabricBookingId.Width = 266
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.AutoHeight = False
        Me.ProgramNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.NullText = ""
        Me.ProgramNoGridLookUpEdit.PopupView = Me.GridView3
        Me.ProgramNoGridLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.ProgramNoGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.ValueMember = "FinishFabricBookingId"
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 83
        '
        'colAllocateQty
        '
        Me.colAllocateQty.FieldName = "AllocateQty"
        Me.colAllocateQty.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colAllocateQty.Name = "colAllocateQty"
        Me.colAllocateQty.OptionsColumn.ReadOnly = True
        Me.colAllocateQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AllocateQty", "{0:0.##}")})
        Me.colAllocateQty.Visible = True
        Me.colAllocateQty.VisibleIndex = 5
        Me.colAllocateQty.Width = 114
        '
        'colIssueQty
        '
        Me.colIssueQty.FieldName = "IssueQty"
        Me.colIssueQty.Name = "colIssueQty"
        Me.colIssueQty.Width = 71
        '
        'colStockInHand
        '
        Me.colStockInHand.FieldName = "StockInHand"
        Me.colStockInHand.Name = "colStockInHand"
        Me.colStockInHand.Width = 76
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 2
        Me.colSupplierId.Width = 108
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.NullText = ""
        Me.SupplierGridLookUpEdit.PopupView = Me.GridView2
        Me.SupplierGridLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colAdvanceYarnLotAllocationId
        '
        Me.colAdvanceYarnLotAllocationId.FieldName = "AdvanceYarnLotAllocationId"
        Me.colAdvanceYarnLotAllocationId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colAdvanceYarnLotAllocationId.Name = "colAdvanceYarnLotAllocationId"
        Me.colAdvanceYarnLotAllocationId.OptionsColumn.ReadOnly = True
        Me.colAdvanceYarnLotAllocationId.Visible = True
        Me.colAdvanceYarnLotAllocationId.VisibleIndex = 7
        '
        'colPIId1
        '
        Me.colPIId1.Caption = "LC No :: PI No"
        Me.colPIId1.ColumnEdit = Me.PIListLookUpEdit
        Me.colPIId1.FieldName = "PIId"
        Me.colPIId1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPIId1.Name = "colPIId1"
        Me.colPIId1.OptionsColumn.ReadOnly = True
        Me.colPIId1.Visible = True
        Me.colPIId1.VisibleIndex = 1
        Me.colPIId1.Width = 131
        '
        'PIListLookUpEdit
        '
        Me.PIListLookUpEdit.AutoHeight = False
        Me.PIListLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIListLookUpEdit.DataSource = Me.PILookUpBindingSource
        Me.PIListLookUpEdit.DisplayMember = "Details"
        Me.PIListLookUpEdit.Name = "PIListLookUpEdit"
        Me.PIListLookUpEdit.PopupView = Me.GridView4
        Me.PIListLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PIListLookUpEdit.ValueMember = "PIId"
        '
        'PILookUpBindingSource
        '
        Me.PILookUpBindingSource.DataMember = "PILookUp"
        Me.PILookUpBindingSource.DataSource = Me.PILookUpDataSet
        '
        'PILookUpDataSet
        '
        Me.PILookUpDataSet.DataSetName = "PILookUpDataSet"
        Me.PILookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails2})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView8
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'PILookupGridLookUpEdit
        '
        Me.PILookupGridLookUpEdit.AutoHeight = False
        Me.PILookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PILookupGridLookUpEdit.DataSource = Me.PILookUpBindingSource
        Me.PILookupGridLookUpEdit.DisplayMember = "Details"
        Me.PILookupGridLookUpEdit.Name = "PILookupGridLookUpEdit"
        Me.PILookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.PILookupGridLookUpEdit.ValueMember = "PIId"
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails3})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails3
        '
        Me.colDetails3.FieldName = "Details"
        Me.colDetails3.Name = "colDetails3"
        Me.colDetails3.Visible = True
        Me.colDetails3.VisibleIndex = 0
        '
        'LCNoLookUpFromPIIdBindingSource
        '
        Me.LCNoLookUpFromPIIdBindingSource.DataMember = "LCNoLookUpFromPIId"
        Me.LCNoLookUpFromPIIdBindingSource.DataSource = Me.PILookUpDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemIdLookUpEdit
        '
        Me.ItemIdLookUpEdit.EditValue = ""
        Me.ItemIdLookUpEdit.Location = New System.Drawing.Point(106, 32)
        Me.ItemIdLookUpEdit.Name = "ItemIdLookUpEdit"
        Me.ItemIdLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIdLookUpEdit.Properties.DataSource = Me.ItemListBindingSource
        Me.ItemIdLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemIdLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemIdLookUpEdit.Properties.NullText = ""
        Me.ItemIdLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemIdLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ItemIdLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemIdLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemIdLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.ItemIdLookUpEdit.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Yarn Name :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 98)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Program No :"
        '
        'ProgramNoLookUpEdit
        '
        Me.ProgramNoLookUpEdit.EditValue = ""
        Me.ProgramNoLookUpEdit.Location = New System.Drawing.Point(105, 95)
        Me.ProgramNoLookUpEdit.Name = "ProgramNoLookUpEdit"
        Me.ProgramNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.ProgramNoLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoLookUpEdit.Properties.NullText = ""
        Me.ProgramNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoLookUpEdit.Properties.PopupView = Me.GridView5
        Me.ProgramNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoLookUpEdit.Properties.ValueMember = "FinishFabricBookingId"
        Me.ProgramNoLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.ProgramNoLookUpEdit.TabIndex = 8
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(646, 93)
        Me.AddButton.LookAndFeel.SkinName = "VS2010"
        Me.AddButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "&Add"
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(647, 31)
        Me.ShowButton.LookAndFeel.SkinName = "VS2010"
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 48)
        Me.ShowButton.TabIndex = 11
        Me.ShowButton.Text = "&Show"
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(728, 31)
        Me.ShowAllButton.LookAndFeel.SkinName = "VS2010"
        Me.ShowAllButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 48)
        Me.ShowAllButton.TabIndex = 12
        Me.ShowAllButton.Text = "&Show All"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.TransShowButton)
        Me.GroupControl1.Controls.Add(Me.TransferButton)
        Me.GroupControl1.Controls.Add(Me.TransLotNoTextEdit)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.TransYarnNameLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.TransBrandLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 376)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1114, 72)
        Me.GroupControl1.TabIndex = 13
        Me.GroupControl1.Text = "Transfer"
        '
        'TransShowButton
        '
        Me.TransShowButton.Location = New System.Drawing.Point(870, 33)
        Me.TransShowButton.LookAndFeel.SkinName = "VS2010"
        Me.TransShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TransShowButton.Name = "TransShowButton"
        Me.TransShowButton.Size = New System.Drawing.Size(75, 23)
        Me.TransShowButton.TabIndex = 14
        Me.TransShowButton.Text = "&Show"
        '
        'TransferButton
        '
        Me.TransferButton.Location = New System.Drawing.Point(774, 33)
        Me.TransferButton.LookAndFeel.SkinName = "VS2010"
        Me.TransferButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TransferButton.Name = "TransferButton"
        Me.TransferButton.Size = New System.Drawing.Size(90, 23)
        Me.TransferButton.TabIndex = 14
        Me.TransferButton.Text = "&Transfer"
        '
        'TransLotNoTextEdit
        '
        Me.TransLotNoTextEdit.Location = New System.Drawing.Point(648, 35)
        Me.TransLotNoTextEdit.Name = "TransLotNoTextEdit"
        Me.TransLotNoTextEdit.Size = New System.Drawing.Size(120, 20)
        Me.TransLotNoTextEdit.TabIndex = 19
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(10, 38)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Yarn Name :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(607, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Lot No:"
        '
        'TransYarnNameLookUpEdit
        '
        Me.TransYarnNameLookUpEdit.EditValue = ""
        Me.TransYarnNameLookUpEdit.Location = New System.Drawing.Point(75, 35)
        Me.TransYarnNameLookUpEdit.Name = "TransYarnNameLookUpEdit"
        Me.TransYarnNameLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransYarnNameLookUpEdit.Properties.DataSource = Me.ItemListBindingSource
        Me.TransYarnNameLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.TransYarnNameLookUpEdit.Properties.ImmediatePopup = True
        Me.TransYarnNameLookUpEdit.Properties.NullText = ""
        Me.TransYarnNameLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.TransYarnNameLookUpEdit.Properties.PopupView = Me.GridView7
        Me.TransYarnNameLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TransYarnNameLookUpEdit.Properties.ValueMember = "ItemId"
        Me.TransYarnNameLookUpEdit.Size = New System.Drawing.Size(261, 20)
        Me.TransYarnNameLookUpEdit.TabIndex = 14
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ItemName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'TransBrandLookUpEdit
        '
        Me.TransBrandLookUpEdit.EditValue = ""
        Me.TransBrandLookUpEdit.Location = New System.Drawing.Point(403, 35)
        Me.TransBrandLookUpEdit.Name = "TransBrandLookUpEdit"
        Me.TransBrandLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransBrandLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.TransBrandLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.TransBrandLookUpEdit.Properties.ImmediatePopup = True
        Me.TransBrandLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.TransBrandLookUpEdit.Properties.PopupView = Me.GridView6
        Me.TransBrandLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TransBrandLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.TransBrandLookUpEdit.Size = New System.Drawing.Size(183, 20)
        Me.TransBrandLookUpEdit.TabIndex = 17
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "SupplierName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "SupplierCode"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(362, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Brand :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(363, 98)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Allocate Quantity :"
        '
        'AllocateQuantityTextEdit
        '
        Me.AllocateQuantityTextEdit.Location = New System.Drawing.Point(462, 95)
        Me.AllocateQuantityTextEdit.Name = "AllocateQuantityTextEdit"
        Me.AllocateQuantityTextEdit.Size = New System.Drawing.Size(178, 20)
        Me.AllocateQuantityTextEdit.TabIndex = 7
        '
        'LotAndItemwiseBalanceTableAdapter
        '
        Me.LotAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'LotAndItemwiseBalanceBindingSource
        '
        Me.LotAndItemwiseBalanceBindingSource.DataMember = "LotAndItemwiseBalance"
        Me.LotAndItemwiseBalanceBindingSource.DataSource = Me.LotAndItemBalanceDataSet
        '
        'LotAndItemBalanceDataSet
        '
        Me.LotAndItemBalanceDataSet.DataSetName = "LotAndItemBalanceDataSet"
        Me.LotAndItemBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PIAnditemwiseBalanceDataSet
        '
        Me.PIAnditemwiseBalanceDataSet.DataSetName = "PIAnditemwiseBalanceDataSet"
        Me.PIAnditemwiseBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PIAndItemwiseBalanceBindingSource
        '
        Me.PIAndItemwiseBalanceBindingSource.DataMember = "PIAndItemwiseBalance"
        Me.PIAndItemwiseBalanceBindingSource.DataSource = Me.PIAnditemwiseBalanceDataSet
        '
        'PIAndItemwiseBalanceTableAdapter
        '
        Me.PIAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'PIIdGridLookUpEdit
        '
        Me.PIIdGridLookUpEdit.Location = New System.Drawing.Point(462, 59)
        Me.PIIdGridLookUpEdit.Name = "PIIdGridLookUpEdit"
        Me.PIIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PIIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIIdGridLookUpEdit.Properties.DataSource = Me.PIAndItemwiseBalanceBindingSource
        Me.PIIdGridLookUpEdit.Properties.DisplayMember = "LCNo"
        Me.PIIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PIIdGridLookUpEdit.Properties.NullText = ""
        Me.PIIdGridLookUpEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.PIIdGridLookUpEdit.Properties.PopupView = Me.PIIdGridLookUpEditView
        Me.PIIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PIIdGridLookUpEdit.Properties.ValueMember = "PIId"
        Me.PIIdGridLookUpEdit.Size = New System.Drawing.Size(178, 20)
        Me.PIIdGridLookUpEdit.TabIndex = 112
        '
        'PIIdGridLookUpEditView
        '
        Me.PIIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId3, Me.colYarnLotNo2, Me.colLCNo1, Me.colDepartmentId3, Me.colPIId, Me.colTTLReceive1, Me.colTTLIssue1, Me.colBalance1, Me.colLCId, Me.colPINo, Me.colCompanyCode1})
        Me.PIIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PIIdGridLookUpEditView.Name = "PIIdGridLookUpEditView"
        Me.PIIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PIIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colItemId3
        '
        Me.colItemId3.FieldName = "ItemId"
        Me.colItemId3.Name = "colItemId3"
        '
        'colYarnLotNo2
        '
        Me.colYarnLotNo2.FieldName = "YarnLotNo"
        Me.colYarnLotNo2.Name = "colYarnLotNo2"
        Me.colYarnLotNo2.Visible = True
        Me.colYarnLotNo2.VisibleIndex = 0
        Me.colYarnLotNo2.Width = 20
        '
        'colLCNo1
        '
        Me.colLCNo1.FieldName = "LCNo"
        Me.colLCNo1.Name = "colLCNo1"
        Me.colLCNo1.Visible = True
        Me.colLCNo1.VisibleIndex = 1
        Me.colLCNo1.Width = 20
        '
        'colDepartmentId3
        '
        Me.colDepartmentId3.FieldName = "DepartmentId"
        Me.colDepartmentId3.Name = "colDepartmentId3"
        '
        'colPIId
        '
        Me.colPIId.FieldName = "PIId"
        Me.colPIId.Name = "colPIId"
        Me.colPIId.OptionsColumn.ReadOnly = True
        '
        'colTTLReceive1
        '
        Me.colTTLReceive1.FieldName = "TTLReceive"
        Me.colTTLReceive1.Name = "colTTLReceive1"
        Me.colTTLReceive1.OptionsColumn.ReadOnly = True
        Me.colTTLReceive1.Visible = True
        Me.colTTLReceive1.VisibleIndex = 4
        Me.colTTLReceive1.Width = 20
        '
        'colTTLIssue1
        '
        Me.colTTLIssue1.FieldName = "TTLIssue"
        Me.colTTLIssue1.Name = "colTTLIssue1"
        Me.colTTLIssue1.OptionsColumn.ReadOnly = True
        Me.colTTLIssue1.Visible = True
        Me.colTTLIssue1.VisibleIndex = 5
        Me.colTTLIssue1.Width = 20
        '
        'colBalance1
        '
        Me.colBalance1.FieldName = "Balance"
        Me.colBalance1.Name = "colBalance1"
        Me.colBalance1.OptionsColumn.ReadOnly = True
        Me.colBalance1.Visible = True
        Me.colBalance1.VisibleIndex = 6
        Me.colBalance1.Width = 57
        '
        'colLCId
        '
        Me.colLCId.FieldName = "LCId"
        Me.colLCId.Name = "colLCId"
        '
        'colPINo
        '
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Name = "colPINo"
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 3
        Me.colPINo.Width = 139
        '
        'colCompanyCode1
        '
        Me.colCompanyCode1.Caption = "Account"
        Me.colCompanyCode1.FieldName = "CompanyCode"
        Me.colCompanyCode1.Name = "colCompanyCode1"
        Me.colCompanyCode1.Visible = True
        Me.colCompanyCode1.VisibleIndex = 2
        Me.colCompanyCode1.Width = 108
        '
        'LotNoGridLookUpEdit
        '
        Me.LotNoGridLookUpEdit.EditValue = "[Type Lot Nol]"
        Me.LotNoGridLookUpEdit.Location = New System.Drawing.Point(462, 32)
        Me.LotNoGridLookUpEdit.Name = "LotNoGridLookUpEdit"
        Me.LotNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LotNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LotNoGridLookUpEdit.Properties.DataSource = Me.LotAndItemwiseBalanceBindingSource
        Me.LotNoGridLookUpEdit.Properties.DisplayMember = "YarnLotNo"
        Me.LotNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.LotNoGridLookUpEdit.Properties.NullText = "[Type Lot No]"
        Me.LotNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LotNoGridLookUpEdit.Properties.PopupView = Me.LotNoGridLookUpEditView
        Me.LotNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LotNoGridLookUpEdit.Properties.ValueMember = "YarnLotNo"
        Me.LotNoGridLookUpEdit.Size = New System.Drawing.Size(178, 20)
        Me.LotNoGridLookUpEdit.TabIndex = 110
        '
        'LotNoGridLookUpEditView
        '
        Me.LotNoGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colYarnLotNo, Me.colTTLReceive, Me.colDepartmentId2, Me.colTTLIssue, Me.colBalance, Me.colRealStock, Me.colAllocateBalance})
        Me.LotNoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LotNoGridLookUpEditView.Name = "LotNoGridLookUpEditView"
        Me.LotNoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LotNoGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        Me.colYarnLotNo.Visible = True
        Me.colYarnLotNo.VisibleIndex = 0
        Me.colYarnLotNo.Width = 53
        '
        'colTTLReceive
        '
        Me.colTTLReceive.FieldName = "TTLReceive"
        Me.colTTLReceive.Name = "colTTLReceive"
        Me.colTTLReceive.OptionsColumn.ReadOnly = True
        Me.colTTLReceive.Visible = True
        Me.colTTLReceive.VisibleIndex = 1
        Me.colTTLReceive.Width = 52
        '
        'colDepartmentId2
        '
        Me.colDepartmentId2.FieldName = "DepartmentId"
        Me.colDepartmentId2.Name = "colDepartmentId2"
        '
        'colTTLIssue
        '
        Me.colTTLIssue.FieldName = "TTLIssue"
        Me.colTTLIssue.Name = "colTTLIssue"
        Me.colTTLIssue.OptionsColumn.ReadOnly = True
        Me.colTTLIssue.Visible = True
        Me.colTTLIssue.VisibleIndex = 2
        Me.colTTLIssue.Width = 51
        '
        'colBalance
        '
        Me.colBalance.Caption = "Physical Stock"
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.OptionsColumn.ReadOnly = True
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 62
        '
        'colRealStock
        '
        Me.colRealStock.FieldName = "RealStock"
        Me.colRealStock.Name = "colRealStock"
        Me.colRealStock.Visible = True
        Me.colRealStock.VisibleIndex = 5
        Me.colRealStock.Width = 40
        '
        'colAllocateBalance
        '
        Me.colAllocateBalance.FieldName = "AllocateBalance"
        Me.colAllocateBalance.Name = "colAllocateBalance"
        Me.colAllocateBalance.Visible = True
        Me.colAllocateBalance.VisibleIndex = 4
        Me.colAllocateBalance.Width = 126
        '
        'LCNoLookUpFromPIIdTableAdapter
        '
        Me.LCNoLookUpFromPIIdTableAdapter.ClearBeforeFill = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(841, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "TTL Receive Quantity :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(841, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "TTL Issue Quantity  :"
        '
        'ReceiveQtyLabel
        '
        Me.ReceiveQtyLabel.Location = New System.Drawing.Point(967, 35)
        Me.ReceiveQtyLabel.Name = "ReceiveQtyLabel"
        Me.ReceiveQtyLabel.Size = New System.Drawing.Size(6, 13)
        Me.ReceiveQtyLabel.TabIndex = 3
        Me.ReceiveQtyLabel.Text = "0"
        '
        'IssueQtyLabel
        '
        Me.IssueQtyLabel.Location = New System.Drawing.Point(967, 66)
        Me.IssueQtyLabel.Name = "IssueQtyLabel"
        Me.IssueQtyLabel.Size = New System.Drawing.Size(6, 13)
        Me.IssueQtyLabel.TabIndex = 3
        Me.IssueQtyLabel.Text = "0"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(841, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl9.TabIndex = 113
        Me.LabelControl9.Text = "TTL Allocate Quantity :"
        '
        'TTLAllocateLabel
        '
        Me.TTLAllocateLabel.Location = New System.Drawing.Point(967, 95)
        Me.TTLAllocateLabel.Name = "TTLAllocateLabel"
        Me.TTLAllocateLabel.Size = New System.Drawing.Size(6, 13)
        Me.TTLAllocateLabel.TabIndex = 3
        Me.TTLAllocateLabel.Text = "0"
        '
        'PILookUpTableAdapter
        '
        Me.PILookUpTableAdapter.ClearBeforeFill = True
        '
        'ShowUpButton
        '
        Me.ShowUpButton.Location = New System.Drawing.Point(728, 93)
        Me.ShowUpButton.LookAndFeel.SkinName = "VS2010"
        Me.ShowUpButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowUpButton.Name = "ShowUpButton"
        Me.ShowUpButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowUpButton.TabIndex = 10
        Me.ShowUpButton.Text = "&Show Up"
        '
        'frmAdvanceYarnLotAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 460)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PIIdGridLookUpEdit)
        Me.Controls.Add(Label10)
        Me.Controls.Add(LotNoLabel)
        Me.Controls.Add(Me.LotNoGridLookUpEdit)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ShowAllButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.ShowUpButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ProgramNoLookUpEdit)
        Me.Controls.Add(Me.AllocateQuantityTextEdit)
        Me.Controls.Add(Me.TTLAllocateLabel)
        Me.Controls.Add(Me.IssueQtyLabel)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ReceiveQtyLabel)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ItemIdLookUpEdit)
        Me.Controls.Add(Me.AdvanceYarnLotAllocationGridControl)
        Me.Controls.Add(Me.AdvanceYarnLotAllocationBindingNavigator)
        Me.Name = "frmAdvanceYarnLotAllocation"
        Me.Text = "Advance Yarn Lot Allocation"
        CType(Me.AdvanceYarnLotAllocationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvanceYarnLotAllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvanceYarnLotAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvanceYarnLotAllocationBindingNavigator.ResumeLayout(False)
        Me.AdvanceYarnLotAllocationBindingNavigator.PerformLayout()
        CType(Me.AdvanceYarnLotAllocationGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCNoLookUpFromPIIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TransLotNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransYarnNameLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBrandLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllocateQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdvanceYarnLotAllocationDataSet As AdvanceYarnLotAllocationDataSet
    Friend WithEvents AdvanceYarnLotAllocationBindingSource As BindingSource
    Friend WithEvents AdvanceYarnLotAllocationTableAdapter As AdvanceYarnLotAllocationDataSetTableAdapters.AdvanceYarnLotAllocationTableAdapter
    Friend WithEvents TableAdapterManager As AdvanceYarnLotAllocationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdvanceYarnLotAllocationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AdvanceYarnLotAllocationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AdvanceYarnLotAllocationGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricOrderLookupDataSet As FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemIdLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProgramNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListBindingSource As BindingSource
    Friend WithEvents ItemListTableAdapter As ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShowAllButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TransferButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TransLotNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransYarnNameLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TransBrandLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colAllocateQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStockInHand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AllocateQuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LotAndItemwiseBalanceTableAdapter As LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter
    Friend WithEvents LotAndItemwiseBalanceBindingSource As BindingSource
    Friend WithEvents LotAndItemBalanceDataSet As LotAndItemBalanceDataSet
    Friend WithEvents PIAnditemwiseBalanceDataSet As PIAnditemwiseBalanceDataSet
    Friend WithEvents PIAndItemwiseBalanceBindingSource As BindingSource
    Friend WithEvents PIAndItemwiseBalanceTableAdapter As PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter
    Friend WithEvents PIIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PIIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLReceive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLIssue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LotNoGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLIssue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIListLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PILookUpDataSet As PILookUpDataSet
    Friend WithEvents LCNoLookUpFromPIIdBindingSource As BindingSource
    Friend WithEvents LCNoLookUpFromPIIdTableAdapter As PILookUpDataSetTableAdapters.LCNoLookUpFromPIIdTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReceiveQtyLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IssueQtyLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TTLAllocateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAdvanceYarnLotAllocationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PILookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents PILookUpBindingSource As BindingSource
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PILookUpTableAdapter As PILookUpDataSetTableAdapters.PILookUpTableAdapter
    Friend WithEvents colDetails3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowUpButton As DevExpress.XtraEditors.SimpleButton
End Class
