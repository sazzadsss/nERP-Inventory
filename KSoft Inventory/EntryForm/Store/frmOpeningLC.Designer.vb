<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpeningLC
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
        Dim LCNoLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim LCDateLabel As System.Windows.Forms.Label
        Dim CompanyIdLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim MasterLCLabel As System.Windows.Forms.Label
        Dim PINoLabel As System.Windows.Forms.Label
        Dim PIDateLabel As System.Windows.Forms.Label
        Dim ItemIdLabel As System.Windows.Forms.Label
        Dim LCQuantityLabel As System.Windows.Forms.Label
        Dim UnitIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel1 As System.Windows.Forms.Label
        Dim LCPriceLabel As System.Windows.Forms.Label
        Dim ETALabel As System.Windows.Forms.Label
        Dim RequisitionIdLabel As System.Windows.Forms.Label
        Me.OpeningLCDataSet = New KSoft_Inventory.OpeningLCDataSet()
        Me.LCListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LCListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager()
        Me.PIListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter()
        Me.LCListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsImported = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterLC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCTypeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequisitionNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RequisitionLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionDataSet = New KSoft_Inventory.RequisitionDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqNoAndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsEditable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.CopyLCDateLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.RequisitionLookupTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.CopyPILinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LCNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CompanyIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CompanyIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsEditableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsImportedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.MasterLCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PINoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsUsedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PIDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UnitIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ETADateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RequisitionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RequisitionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReqNoAndDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RemarksTextEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AddLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Button3 = New System.Windows.Forms.Button()
        LCNoLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        LCDateLabel = New System.Windows.Forms.Label()
        CompanyIdLabel = New System.Windows.Forms.Label()
        BuyerIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        MasterLCLabel = New System.Windows.Forms.Label()
        PINoLabel = New System.Windows.Forms.Label()
        PIDateLabel = New System.Windows.Forms.Label()
        ItemIdLabel = New System.Windows.Forms.Label()
        LCQuantityLabel = New System.Windows.Forms.Label()
        UnitIdLabel = New System.Windows.Forms.Label()
        RemarksLabel1 = New System.Windows.Forms.Label()
        LCPriceLabel = New System.Windows.Forms.Label()
        ETALabel = New System.Windows.Forms.Label()
        RequisitionIdLabel = New System.Windows.Forms.Label()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCTypeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEditableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsImportedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PINoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsUsedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LCNoLabel
        '
        LCNoLabel.AutoSize = True
        LCNoLabel.Location = New System.Drawing.Point(35, 23)
        LCNoLabel.Name = "LCNoLabel"
        LCNoLabel.Size = New System.Drawing.Size(37, 13)
        LCNoLabel.TabIndex = 2
        LCNoLabel.Text = "LCNo:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(35, 49)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(51, 13)
        SupplierIdLabel.TabIndex = 6
        SupplierIdLabel.Text = "Supplier :"
        '
        'LCDateLabel
        '
        LCDateLabel.AutoSize = True
        LCDateLabel.Location = New System.Drawing.Point(356, 23)
        LCDateLabel.Name = "LCDateLabel"
        LCDateLabel.Size = New System.Drawing.Size(46, 13)
        LCDateLabel.TabIndex = 8
        LCDateLabel.Text = "LCDate:"
        '
        'CompanyIdLabel
        '
        CompanyIdLabel.AutoSize = True
        CompanyIdLabel.Location = New System.Drawing.Point(356, 49)
        CompanyIdLabel.Name = "CompanyIdLabel"
        CompanyIdLabel.Size = New System.Drawing.Size(57, 13)
        CompanyIdLabel.TabIndex = 10
        CompanyIdLabel.Text = "Company :"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(35, 75)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(40, 13)
        BuyerIdLabel.TabIndex = 12
        BuyerIdLabel.Text = "Buyer :"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(35, 127)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 14
        RemarksLabel.Text = "Remarks:"
        '
        'MasterLCLabel
        '
        MasterLCLabel.AutoSize = True
        MasterLCLabel.Location = New System.Drawing.Point(35, 101)
        MasterLCLabel.Name = "MasterLCLabel"
        MasterLCLabel.Size = New System.Drawing.Size(58, 13)
        MasterLCLabel.TabIndex = 18
        MasterLCLabel.Text = "Master LC:"
        AddHandler MasterLCLabel.Click, AddressOf Me.MasterLCLabel_Click
        '
        'PINoLabel
        '
        PINoLabel.AutoSize = True
        PINoLabel.Location = New System.Drawing.Point(11, 18)
        PINoLabel.Name = "PINoLabel"
        PINoLabel.Size = New System.Drawing.Size(34, 13)
        PINoLabel.TabIndex = 7
        PINoLabel.Text = "PINo:"
        '
        'PIDateLabel
        '
        PIDateLabel.AutoSize = True
        PIDateLabel.Location = New System.Drawing.Point(11, 40)
        PIDateLabel.Name = "PIDateLabel"
        PIDateLabel.Size = New System.Drawing.Size(43, 13)
        PIDateLabel.TabIndex = 9
        PIDateLabel.Text = "PIDate:"
        '
        'ItemIdLabel
        '
        ItemIdLabel.AutoSize = True
        ItemIdLabel.Location = New System.Drawing.Point(203, 14)
        ItemIdLabel.Name = "ItemIdLabel"
        ItemIdLabel.Size = New System.Drawing.Size(61, 13)
        ItemIdLabel.TabIndex = 13
        ItemIdLabel.Text = "Item Name:"
        '
        'LCQuantityLabel
        '
        LCQuantityLabel.AutoSize = True
        LCQuantityLabel.Location = New System.Drawing.Point(203, 40)
        LCQuantityLabel.Name = "LCQuantityLabel"
        LCQuantityLabel.Size = New System.Drawing.Size(62, 13)
        LCQuantityLabel.TabIndex = 15
        LCQuantityLabel.Text = "LCQuantity:"
        '
        'UnitIdLabel
        '
        UnitIdLabel.AutoSize = True
        UnitIdLabel.Location = New System.Drawing.Point(391, 40)
        UnitIdLabel.Name = "UnitIdLabel"
        UnitIdLabel.Size = New System.Drawing.Size(32, 13)
        UnitIdLabel.TabIndex = 17
        UnitIdLabel.Text = "Unit :"
        '
        'RemarksLabel1
        '
        RemarksLabel1.AutoSize = True
        RemarksLabel1.Location = New System.Drawing.Point(581, 13)
        RemarksLabel1.Name = "RemarksLabel1"
        RemarksLabel1.Size = New System.Drawing.Size(52, 13)
        RemarksLabel1.TabIndex = 19
        RemarksLabel1.Text = "Remarks:"
        '
        'LCPriceLabel
        '
        LCPriceLabel.AutoSize = True
        LCPriceLabel.Location = New System.Drawing.Point(203, 66)
        LCPriceLabel.Name = "LCPriceLabel"
        LCPriceLabel.Size = New System.Drawing.Size(47, 13)
        LCPriceLabel.TabIndex = 23
        LCPriceLabel.Text = "LCPrice:"
        '
        'ETALabel
        '
        ETALabel.AutoSize = True
        ETALabel.Location = New System.Drawing.Point(11, 66)
        ETALabel.Name = "ETALabel"
        ETALabel.Size = New System.Drawing.Size(31, 13)
        ETALabel.TabIndex = 25
        ETALabel.Text = "ETA:"
        '
        'RequisitionIdLabel
        '
        RequisitionIdLabel.AutoSize = True
        RequisitionIdLabel.Location = New System.Drawing.Point(391, 66)
        RequisitionIdLabel.Name = "RequisitionIdLabel"
        RequisitionIdLabel.Size = New System.Drawing.Size(65, 13)
        RequisitionIdLabel.TabIndex = 27
        RequisitionIdLabel.Text = "Requisition :"
        '
        'OpeningLCDataSet
        '
        Me.OpeningLCDataSet.DataSetName = "OpeningLCDataSet"
        Me.OpeningLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LCListBindingSource
        '
        Me.LCListBindingSource.DataMember = "LCList"
        Me.LCListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'LCListTableAdapter
        '
        Me.LCListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LCListTableAdapter = Me.LCListTableAdapter
        Me.TableAdapterManager.PIListTableAdapter = Me.PIListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'LCListGridControl
        '
        Me.LCListGridControl.DataSource = Me.LCListBindingSource
        Me.LCListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LCListGridControl.Location = New System.Drawing.Point(3, 3)
        Me.LCListGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LCListGridControl.MainView = Me.GridView1
        Me.LCListGridControl.Name = "LCListGridControl"
        Me.LCListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.CompanyLookUpEdit, Me.BuyerGridLookUpEdit, Me.LCTypeLookUpEdit})
        Me.LCListGridControl.Size = New System.Drawing.Size(1159, 154)
        Me.LCListGridControl.TabIndex = 1
        Me.LCListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo, Me.colSupplierId, Me.colLCDate, Me.colCompanyId, Me.colBuyerId, Me.colRemarks1, Me.colIsImported, Me.colMasterLC})
        Me.GridView1.GridControl = Me.LCListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.OptionsColumn.AllowEdit = False
        Me.colLCNo.OptionsColumn.ReadOnly = True
        Me.colLCNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 1
        Me.colLCNo.Width = 163
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.AllowEdit = False
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        Me.colSupplierId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 3
        Me.colSupplierId.Width = 241
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierId", "Supplier Id", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Add1", "Add1", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Add2", "Add2", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactPerson", "Contact Person", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactNo", "Contact No", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierType", "Supplier Type", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 29, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "SupplierName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "SupplierId"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        Me.colLCDate.OptionsColumn.AllowEdit = False
        Me.colLCDate.OptionsColumn.ReadOnly = True
        Me.colLCDate.Visible = True
        Me.colLCDate.VisibleIndex = 2
        Me.colLCDate.Width = 98
        '
        'colCompanyId
        '
        Me.colCompanyId.Caption = "Company"
        Me.colCompanyId.ColumnEdit = Me.CompanyLookUpEdit
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.OptionsColumn.AllowEdit = False
        Me.colCompanyId.OptionsColumn.ReadOnly = True
        Me.colCompanyId.Visible = True
        Me.colCompanyId.VisibleIndex = 4
        Me.colCompanyId.Width = 101
        '
        'CompanyLookUpEdit
        '
        Me.CompanyLookUpEdit.AutoHeight = False
        Me.CompanyLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyId", "Company Id", 81, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fax", "Fax", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Website", "Website", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactPerson", "Contact Person", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WeeklyOff", "Weekly Off", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.CompanyLookUpEdit.DataSource = Me.CompanyBindingSource
        Me.CompanyLookUpEdit.DisplayMember = "CompanyCode"
        Me.CompanyLookUpEdit.Name = "CompanyLookUpEdit"
        Me.CompanyLookUpEdit.NullText = ""
        Me.CompanyLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.CompanyLookUpEdit.ValueMember = "CompanyId"
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "For Buyer"
        Me.colBuyerId.ColumnEdit = Me.BuyerGridLookUpEdit
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.AllowEdit = False
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        Me.colBuyerId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 5
        Me.colBuyerId.Width = 90
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "BuyerCode"
        Me.BuyerGridLookUpEdit.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.View = Me.GridView4
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId1, Me.colBuyerCode, Me.colBuyerName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        Me.colBuyerId1.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.OptionsColumn.AllowEdit = False
        Me.colRemarks1.OptionsColumn.ReadOnly = True
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 7
        Me.colRemarks1.Width = 255
        '
        'colIsImported
        '
        Me.colIsImported.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colIsImported.AppearanceCell.Options.UseBackColor = True
        Me.colIsImported.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsImported.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsImported.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsImported.Caption = "Imported"
        Me.colIsImported.FieldName = "IsImported"
        Me.colIsImported.Name = "colIsImported"
        Me.colIsImported.OptionsColumn.AllowEdit = False
        Me.colIsImported.OptionsColumn.ReadOnly = True
        Me.colIsImported.Visible = True
        Me.colIsImported.VisibleIndex = 0
        Me.colIsImported.Width = 95
        '
        'colMasterLC
        '
        Me.colMasterLC.FieldName = "MasterLC"
        Me.colMasterLC.Name = "colMasterLC"
        Me.colMasterLC.OptionsColumn.AllowEdit = False
        Me.colMasterLC.OptionsColumn.ReadOnly = True
        Me.colMasterLC.Visible = True
        Me.colMasterLC.VisibleIndex = 6
        Me.colMasterLC.Width = 97
        '
        'LCTypeLookUpEdit
        '
        Me.LCTypeLookUpEdit.AutoHeight = False
        Me.LCTypeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCTypeLookUpEdit.Name = "LCTypeLookUpEdit"
        '
        'PIListBindingSource
        '
        Me.PIListBindingSource.DataMember = "FK_PIList_LCList"
        Me.PIListBindingSource.DataSource = Me.LCListBindingSource
        '
        'PIListGridControl
        '
        Me.PIListGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PIListGridControl.DataSource = Me.PIListBindingSource
        Me.PIListGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PIListGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PIListGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PIListGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PIListGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PIListGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PIListGridControl.Location = New System.Drawing.Point(3, 102)
        Me.PIListGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PIListGridControl.MainView = Me.GridView2
        Me.PIListGridControl.Name = "PIListGridControl"
        Me.PIListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RequisitionNoGridLookUpEdit, Me.ItemNameGridLookUpEdit})
        Me.PIListGridControl.Size = New System.Drawing.Size(1173, 336)
        Me.PIListGridControl.TabIndex = 2
        Me.PIListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.GreenYellow
        Me.GridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView2.ColumnPanelRowHeight = 35
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIDate, Me.colItemId, Me.colLCQuantity, Me.colUnitId, Me.colRemarks, Me.colLotNo, Me.colPINo, Me.colLCPrice, Me.colRequisitionId, Me.colETA, Me.colIsEditable})
        Me.GridView2.GridControl = Me.PIListGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colPIDate
        '
        Me.colPIDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPIDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPIDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPIDate.FieldName = "PIDate"
        Me.colPIDate.Name = "colPIDate"
        Me.colPIDate.OptionsColumn.AllowEdit = False
        Me.colPIDate.OptionsColumn.ReadOnly = True
        Me.colPIDate.Visible = True
        Me.colPIDate.VisibleIndex = 2
        Me.colPIDate.Width = 127
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.AllowEdit = False
        Me.colItemId.OptionsColumn.ReadOnly = True
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 5
        Me.colItemId.Width = 223
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.NullText = ""
        Me.ItemNameGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.View = Me.GridView3
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId1, Me.GridColumn1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        Me.colItemName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        'colLCQuantity
        '
        Me.colLCQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLCQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colLCQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colLCQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLCQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLCQuantity.FieldName = "LCQuantity"
        Me.colLCQuantity.Name = "colLCQuantity"
        Me.colLCQuantity.OptionsColumn.AllowEdit = False
        Me.colLCQuantity.OptionsColumn.ReadOnly = True
        Me.colLCQuantity.Visible = True
        Me.colLCQuantity.VisibleIndex = 6
        Me.colLCQuantity.Width = 91
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.AllowEdit = False
        Me.colUnitId.OptionsColumn.ReadOnly = True
        Me.colUnitId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 8
        Me.colUnitId.Width = 68
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitId", "Unit Id", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitCode", "Unit Code", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Unit Name", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.UnitBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "UnitCode"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "UnitId"
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.OptionsColumn.ReadOnly = True
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 9
        Me.colRemarks.Width = 70
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.Width = 78
        '
        'colPINo
        '
        Me.colPINo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPINo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPINo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPINo.Caption = "PI No"
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Name = "colPINo"
        Me.colPINo.OptionsColumn.AllowEdit = False
        Me.colPINo.OptionsColumn.ReadOnly = True
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 1
        Me.colPINo.Width = 116
        '
        'colLCPrice
        '
        Me.colLCPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLCPrice.AppearanceCell.Options.UseBackColor = True
        Me.colLCPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colLCPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLCPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLCPrice.FieldName = "LCPrice"
        Me.colLCPrice.Name = "colLCPrice"
        Me.colLCPrice.OptionsColumn.AllowEdit = False
        Me.colLCPrice.OptionsColumn.ReadOnly = True
        Me.colLCPrice.Visible = True
        Me.colLCPrice.VisibleIndex = 7
        Me.colLCPrice.Width = 87
        '
        'colRequisitionId
        '
        Me.colRequisitionId.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequisitionId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequisitionId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequisitionId.Caption = "Requisition No"
        Me.colRequisitionId.ColumnEdit = Me.RequisitionNoGridLookUpEdit
        Me.colRequisitionId.FieldName = "RequisitionId"
        Me.colRequisitionId.Name = "colRequisitionId"
        Me.colRequisitionId.OptionsColumn.AllowEdit = False
        Me.colRequisitionId.OptionsColumn.ReadOnly = True
        Me.colRequisitionId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRequisitionId.Visible = True
        Me.colRequisitionId.VisibleIndex = 3
        Me.colRequisitionId.Width = 134
        '
        'RequisitionNoGridLookUpEdit
        '
        Me.RequisitionNoGridLookUpEdit.AutoHeight = False
        Me.RequisitionNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequisitionNoGridLookUpEdit.DataSource = Me.RequisitionLookupBindingSource
        Me.RequisitionNoGridLookUpEdit.DisplayMember = "ReqNoAndDate"
        Me.RequisitionNoGridLookUpEdit.Name = "RequisitionNoGridLookUpEdit"
        Me.RequisitionNoGridLookUpEdit.NullText = ""
        Me.RequisitionNoGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RequisitionNoGridLookUpEdit.ValueMember = "RequisitionId"
        Me.RequisitionNoGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RequisitionLookupBindingSource
        '
        Me.RequisitionLookupBindingSource.DataMember = "RequisitionLookup"
        Me.RequisitionLookupBindingSource.DataSource = Me.RequisitionDataSet
        '
        'RequisitionDataSet
        '
        Me.RequisitionDataSet.DataSetName = "RequisitionDataSet"
        Me.RequisitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionId1, Me.colRequisitionNo, Me.colRequisitionDate, Me.colDepartmentId, Me.colReqNoAndDate})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRequisitionId1
        '
        Me.colRequisitionId1.FieldName = "RequisitionId"
        Me.colRequisitionId1.Name = "colRequisitionId1"
        Me.colRequisitionId1.OptionsColumn.ReadOnly = True
        '
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.Name = "colRequisitionNo"
        '
        'colRequisitionDate
        '
        Me.colRequisitionDate.FieldName = "RequisitionDate"
        Me.colRequisitionDate.Name = "colRequisitionDate"
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'colReqNoAndDate
        '
        Me.colReqNoAndDate.FieldName = "ReqNoAndDate"
        Me.colReqNoAndDate.Name = "colReqNoAndDate"
        Me.colReqNoAndDate.OptionsColumn.ReadOnly = True
        Me.colReqNoAndDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colReqNoAndDate.Visible = True
        Me.colReqNoAndDate.VisibleIndex = 0
        '
        'colETA
        '
        Me.colETA.AppearanceHeader.Options.UseTextOptions = True
        Me.colETA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colETA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        Me.colETA.OptionsColumn.AllowEdit = False
        Me.colETA.OptionsColumn.ReadOnly = True
        Me.colETA.Visible = True
        Me.colETA.VisibleIndex = 4
        Me.colETA.Width = 90
        '
        'colIsEditable
        '
        Me.colIsEditable.Caption = "Is Used ?"
        Me.colIsEditable.FieldName = "IsUsed"
        Me.colIsEditable.Name = "colIsEditable"
        Me.colIsEditable.OptionsColumn.AllowEdit = False
        Me.colIsEditable.OptionsColumn.ReadOnly = True
        Me.colIsEditable.Visible = True
        Me.colIsEditable.VisibleIndex = 0
        Me.colIsEditable.Width = 77
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemId", "Item Id", 58, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentId", "Department Id", 80, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID-Name", "ID-Name", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ItemListLookupBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "ItemName"
        Me.RepositoryItemLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "ItemId"
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'CopyLCDateLinkLabel
        '
        Me.CopyLCDateLinkLabel.AutoSize = True
        Me.CopyLCDateLinkLabel.Location = New System.Drawing.Point(558, 0)
        Me.CopyLCDateLinkLabel.Name = "CopyLCDateLinkLabel"
        Me.CopyLCDateLinkLabel.Size = New System.Drawing.Size(31, 13)
        Me.CopyLCDateLinkLabel.TabIndex = 3
        Me.CopyLCDateLinkLabel.TabStop = True
        Me.CopyLCDateLinkLabel.Text = "&Copy"
        Me.CopyLCDateLinkLabel.Visible = False
        '
        'LCDateTimePicker
        '
        Me.LCDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LCDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LCDateTimePicker.Location = New System.Drawing.Point(454, 3)
        Me.LCDateTimePicker.Name = "LCDateTimePicker"
        Me.LCDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.LCDateTimePicker.TabIndex = 4
        Me.LCDateTimePicker.Visible = False
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'RequisitionLookupTableAdapter
        '
        Me.RequisitionLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'CopyPILinkLabel
        '
        Me.CopyPILinkLabel.AutoSize = True
        Me.CopyPILinkLabel.Location = New System.Drawing.Point(962, 51)
        Me.CopyPILinkLabel.Name = "CopyPILinkLabel"
        Me.CopyPILinkLabel.Size = New System.Drawing.Size(44, 13)
        Me.CopyPILinkLabel.TabIndex = 5
        Me.CopyPILinkLabel.TabStop = True
        Me.CopyPILinkLabel.Text = "Copy PI"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.DeleteLinkLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditLinkLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddLinkLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PIListGridControl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CopyPILinkLabel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1176, 637)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1173, 186)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(LCNoLabel)
        Me.TabPage1.Controls.Add(Me.LCNoTextEdit)
        Me.TabPage1.Controls.Add(SupplierIdLabel)
        Me.TabPage1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.TabPage1.Controls.Add(LCDateLabel)
        Me.TabPage1.Controls.Add(Me.LCDateDateEdit)
        Me.TabPage1.Controls.Add(CompanyIdLabel)
        Me.TabPage1.Controls.Add(Me.CompanyIdGridLookUpEdit)
        Me.TabPage1.Controls.Add(BuyerIdLabel)
        Me.TabPage1.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.TabPage1.Controls.Add(RemarksLabel)
        Me.TabPage1.Controls.Add(Me.RemarksTextEdit)
        Me.TabPage1.Controls.Add(Me.IsEditableCheckEdit)
        Me.TabPage1.Controls.Add(Me.IsImportedCheckEdit)
        Me.TabPage1.Controls.Add(MasterLCLabel)
        Me.TabPage1.Controls.Add(Me.MasterLCTextEdit)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1165, 160)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LC Modification"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LCNoTextEdit
        '
        Me.LCNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "LCNo", True))
        Me.LCNoTextEdit.Enabled = False
        Me.LCNoTextEdit.Location = New System.Drawing.Point(130, 20)
        Me.LCNoTextEdit.Name = "LCNoTextEdit"
        Me.LCNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.LCNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LCNoTextEdit.Size = New System.Drawing.Size(206, 20)
        Me.LCNoTextEdit.TabIndex = 3
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(130, 46)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 7
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
        '
        'LCDateDateEdit
        '
        Me.LCDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "LCDate", True))
        Me.LCDateDateEdit.EditValue = Nothing
        Me.LCDateDateEdit.Location = New System.Drawing.Point(439, 20)
        Me.LCDateDateEdit.Name = "LCDateDateEdit"
        Me.LCDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCDateDateEdit.Size = New System.Drawing.Size(140, 20)
        Me.LCDateDateEdit.TabIndex = 9
        '
        'CompanyIdGridLookUpEdit
        '
        Me.CompanyIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "CompanyId", True))
        Me.CompanyIdGridLookUpEdit.Location = New System.Drawing.Point(439, 46)
        Me.CompanyIdGridLookUpEdit.Name = "CompanyIdGridLookUpEdit"
        Me.CompanyIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyIdGridLookUpEdit.Properties.DataSource = Me.CompanyBindingSource
        Me.CompanyIdGridLookUpEdit.Properties.DisplayMember = "CompanyName"
        Me.CompanyIdGridLookUpEdit.Properties.NullText = ""
        Me.CompanyIdGridLookUpEdit.Properties.ValueMember = "CompanyId"
        Me.CompanyIdGridLookUpEdit.Properties.View = Me.CompanyIdGridLookUpEditView
        Me.CompanyIdGridLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.CompanyIdGridLookUpEdit.TabIndex = 11
        '
        'CompanyIdGridLookUpEditView
        '
        Me.CompanyIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyCode, Me.colCompanyName})
        Me.CompanyIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CompanyIdGridLookUpEditView.Name = "CompanyIdGridLookUpEditView"
        Me.CompanyIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CompanyIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 0
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        '
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(130, 72)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 13
        '
        'BuyerIdGridLookUpEditView
        '
        Me.BuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName1})
        Me.BuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerIdGridLookUpEditView.Name = "BuyerIdGridLookUpEditView"
        Me.BuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 0
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(130, 124)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(449, 20)
        Me.RemarksTextEdit.TabIndex = 15
        '
        'IsEditableCheckEdit
        '
        Me.IsEditableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "IsUsed", True))
        Me.IsEditableCheckEdit.Location = New System.Drawing.Point(439, 95)
        Me.IsEditableCheckEdit.Name = "IsEditableCheckEdit"
        Me.IsEditableCheckEdit.Properties.Caption = "Is Used ?"
        Me.IsEditableCheckEdit.Properties.ReadOnly = True
        Me.IsEditableCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.IsEditableCheckEdit.TabIndex = 17
        '
        'IsImportedCheckEdit
        '
        Me.IsImportedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "IsImported", True))
        Me.IsImportedCheckEdit.Location = New System.Drawing.Point(439, 73)
        Me.IsImportedCheckEdit.Name = "IsImportedCheckEdit"
        Me.IsImportedCheckEdit.Properties.Caption = "Is Imported ?"
        Me.IsImportedCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.IsImportedCheckEdit.TabIndex = 17
        '
        'MasterLCTextEdit
        '
        Me.MasterLCTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LCListBindingSource, "MasterLC", True))
        Me.MasterLCTextEdit.Location = New System.Drawing.Point(130, 98)
        Me.MasterLCTextEdit.Name = "MasterLCTextEdit"
        Me.MasterLCTextEdit.Size = New System.Drawing.Size(206, 20)
        Me.MasterLCTextEdit.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LCListGridControl)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1165, 160)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LC List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(876, 51)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 33
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PINoLabel)
        Me.Panel1.Controls.Add(Me.PINoTextEdit)
        Me.Panel1.Controls.Add(Me.IsUsedCheckEdit)
        Me.Panel1.Controls.Add(PIDateLabel)
        Me.Panel1.Controls.Add(Me.PIDateDateEdit)
        Me.Panel1.Controls.Add(ItemIdLabel)
        Me.Panel1.Controls.Add(Me.ItemIdGridLookUpEdit)
        Me.Panel1.Controls.Add(LCQuantityLabel)
        Me.Panel1.Controls.Add(Me.LCQuantitySpinEdit)
        Me.Panel1.Controls.Add(UnitIdLabel)
        Me.Panel1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.Panel1.Controls.Add(RemarksLabel1)
        Me.Panel1.Controls.Add(LCPriceLabel)
        Me.Panel1.Controls.Add(Me.LCPriceSpinEdit)
        Me.Panel1.Controls.Add(ETALabel)
        Me.Panel1.Controls.Add(Me.ETADateEdit)
        Me.Panel1.Controls.Add(RequisitionIdLabel)
        Me.Panel1.Controls.Add(Me.RequisitionIdGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.RemarksTextEdit1)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 88)
        Me.Panel1.TabIndex = 32
        '
        'PINoTextEdit
        '
        Me.PINoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "PINo", True))
        Me.PINoTextEdit.Location = New System.Drawing.Point(100, 11)
        Me.PINoTextEdit.Name = "PINoTextEdit"
        Me.PINoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PINoTextEdit.TabIndex = 8
        '
        'IsUsedCheckEdit
        '
        Me.IsUsedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "IsUsed", True))
        Me.IsUsedCheckEdit.Location = New System.Drawing.Point(745, 11)
        Me.IsUsedCheckEdit.Name = "IsUsedCheckEdit"
        Me.IsUsedCheckEdit.Properties.Caption = "Is Used"
        Me.IsUsedCheckEdit.Properties.ReadOnly = True
        Me.IsUsedCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.IsUsedCheckEdit.TabIndex = 30
        '
        'PIDateDateEdit
        '
        Me.PIDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "PIDate", True))
        Me.PIDateDateEdit.EditValue = Nothing
        Me.PIDateDateEdit.Location = New System.Drawing.Point(100, 37)
        Me.PIDateDateEdit.Name = "PIDateDateEdit"
        Me.PIDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.PIDateDateEdit.TabIndex = 10
        '
        'ItemIdGridLookUpEdit
        '
        Me.ItemIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "ItemId", True))
        Me.ItemIdGridLookUpEdit.Location = New System.Drawing.Point(283, 11)
        Me.ItemIdGridLookUpEdit.Name = "ItemIdGridLookUpEdit"
        Me.ItemIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIdGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemIdGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemIdGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemIdGridLookUpEdit.Properties.View = Me.ItemIdGridLookUpEditView
        Me.ItemIdGridLookUpEdit.Size = New System.Drawing.Size(288, 20)
        Me.ItemIdGridLookUpEdit.TabIndex = 14
        '
        'ItemIdGridLookUpEditView
        '
        Me.ItemIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName1})
        Me.ItemIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ItemIdGridLookUpEditView.Name = "ItemIdGridLookUpEditView"
        Me.ItemIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ItemIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'LCQuantitySpinEdit
        '
        Me.LCQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "LCQuantity", True))
        Me.LCQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LCQuantitySpinEdit.Location = New System.Drawing.Point(283, 37)
        Me.LCQuantitySpinEdit.Name = "LCQuantitySpinEdit"
        Me.LCQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCQuantitySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.LCQuantitySpinEdit.TabIndex = 16
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "UnitId", True))
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(471, 37)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitName"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Properties.View = Me.UnitIdGridLookUpEditView
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 18
        '
        'UnitIdGridLookUpEditView
        '
        Me.UnitIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.UnitIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UnitIdGridLookUpEditView.Name = "UnitIdGridLookUpEditView"
        Me.UnitIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UnitIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'LCPriceSpinEdit
        '
        Me.LCPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "LCPrice", True))
        Me.LCPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LCPriceSpinEdit.Location = New System.Drawing.Point(283, 63)
        Me.LCPriceSpinEdit.Name = "LCPriceSpinEdit"
        Me.LCPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCPriceSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.LCPriceSpinEdit.TabIndex = 24
        '
        'ETADateEdit
        '
        Me.ETADateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "ETA", True))
        Me.ETADateEdit.EditValue = Nothing
        Me.ETADateEdit.Location = New System.Drawing.Point(100, 63)
        Me.ETADateEdit.Name = "ETADateEdit"
        Me.ETADateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ETADateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ETADateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ETADateEdit.TabIndex = 26
        '
        'RequisitionIdGridLookUpEdit
        '
        Me.RequisitionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "RequisitionId", True))
        Me.RequisitionIdGridLookUpEdit.Location = New System.Drawing.Point(471, 63)
        Me.RequisitionIdGridLookUpEdit.Name = "RequisitionIdGridLookUpEdit"
        Me.RequisitionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequisitionIdGridLookUpEdit.Properties.DataSource = Me.RequisitionLookupBindingSource
        Me.RequisitionIdGridLookUpEdit.Properties.DisplayMember = "ReqNoAndDate"
        Me.RequisitionIdGridLookUpEdit.Properties.NullText = ""
        Me.RequisitionIdGridLookUpEdit.Properties.ValueMember = "RequisitionId"
        Me.RequisitionIdGridLookUpEdit.Properties.View = Me.RequisitionIdGridLookUpEditView
        Me.RequisitionIdGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.RequisitionIdGridLookUpEdit.TabIndex = 28
        '
        'RequisitionIdGridLookUpEditView
        '
        Me.RequisitionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReqNoAndDate1})
        Me.RequisitionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RequisitionIdGridLookUpEditView.Name = "RequisitionIdGridLookUpEditView"
        Me.RequisitionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RequisitionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colReqNoAndDate1
        '
        Me.colReqNoAndDate1.FieldName = "ReqNoAndDate"
        Me.colReqNoAndDate1.Name = "colReqNoAndDate1"
        Me.colReqNoAndDate1.Visible = True
        Me.colReqNoAndDate1.VisibleIndex = 0
        '
        'RemarksTextEdit1
        '
        Me.RemarksTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PIListBindingSource, "Remarks", True))
        Me.RemarksTextEdit1.Location = New System.Drawing.Point(639, 10)
        Me.RemarksTextEdit1.Name = "RemarksTextEdit1"
        Me.RemarksTextEdit1.Size = New System.Drawing.Size(100, 73)
        Me.RemarksTextEdit1.TabIndex = 20
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Location = New System.Drawing.Point(962, 19)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 31
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'AddLinkLabel
        '
        Me.AddLinkLabel.AutoSize = True
        Me.AddLinkLabel.Location = New System.Drawing.Point(876, 19)
        Me.AddLinkLabel.Name = "AddLinkLabel"
        Me.AddLinkLabel.Size = New System.Drawing.Size(26, 13)
        Me.AddLinkLabel.TabIndex = 31
        Me.AddLinkLabel.TabStop = True
        Me.AddLinkLabel.Text = "Add"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelControl1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LCDateTimePicker)
        Me.FlowLayoutPanel1.Controls.Add(Me.CopyLCDateLinkLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1176, 29)
        Me.FlowLayoutPanel1.TabIndex = 7
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(72, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(141, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 21)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(210, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(279, 7)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Save F12"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(330, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 21)
        Me.Button3.TabIndex = 12
        Me.Button3.Tag = "NR"
        Me.Button3.Text = "&Refresh"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmOpeningLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 671)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "frmOpeningLC"
        Me.Text = "Opening LC"
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCTypeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.LCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEditableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsImportedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PINoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsUsedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpeningLCDataSet As KSoft_Inventory.OpeningLCDataSet
    Friend WithEvents LCListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PIListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents LCListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CopyLCDateLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LCDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RequisitionLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionDataSet As KSoft_Inventory.RequisitionDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqNoAndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionLookupTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CopyPILinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colIsImported As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LCTypeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colMasterLC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button3 As Button
    Friend WithEvents LCNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CompanyIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CompanyIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsImportedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MasterLCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsEditable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsEditableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PINoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PIDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents UnitIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ETADateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequisitionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RequisitionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IsUsedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RemarksTextEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AddLinkLabel As LinkLabel
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqNoAndDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents EditLinkLabel As LinkLabel
End Class
