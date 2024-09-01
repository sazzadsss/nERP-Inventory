<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIssuetofloor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ReceiveQuantityLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim BranchIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim PrintingMediaIdLabel As System.Windows.Forms.Label
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim TotalReceiveQuantityLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim IssueTypeLabel As System.Windows.Forms.Label
        Dim LotNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim CompanyIdLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim YDOrderIdLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim PKTLabel As System.Windows.Forms.Label
        Dim CTNLabel As System.Windows.Forms.Label
        Dim BAGLabel As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Dim ManufactureDateLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ActUnitGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource()
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActIssueQtyTextBox = New System.Windows.Forms.TextBox()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource()
        Me.IssueDataSet = New KSoft_Inventory.IssueDataSet()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.YTRNoTextBox = New System.Windows.Forms.TextBox()
        Me.YarnAllocationLabel = New System.Windows.Forms.Label()
        Me.ReturnLabel = New System.Windows.Forms.Label()
        Me.TransProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.TransBookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IssueQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.IsLeftOverCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LeftOverQtyTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ManufactureDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BAGTextBox = New System.Windows.Forms.TextBox()
        Me.CTNTextBox = New System.Windows.Forms.TextBox()
        Me.PKTTextBox = New System.Windows.Forms.TextBox()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequisitionNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.YarnBalanceLabel = New System.Windows.Forms.Label()
        Me.YarnIssuedLabel = New System.Windows.Forms.Label()
        Me.YarnRquireLabel = New System.Windows.Forms.Label()
        Me.ReceiveBalanceLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReferenceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotwiseHistoryBindingSource = New System.Windows.Forms.BindingSource()
        Me.LotwiseHistoryDataSet = New KSoft_Inventory.LotwiseHistoryDataSet()
        Me.TotalIssueQuantityLabel = New System.Windows.Forms.Label()
        Me.TotalIssueQuantityBindingSource = New System.Windows.Forms.BindingSource()
        Me.ChallanLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.YDOrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YDOrderBindingSource = New System.Windows.Forms.BindingSource()
        Me.YDOrderLookupDataSet = New KSoft_Inventory.YDOrderLookupDataSet()
        Me.YDOrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYDOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.IsAllocatedIssueCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PIIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PIAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource()
        Me.PIAnditemwiseBalanceDataSet = New KSoft_Inventory.PIAnditemwiseBalanceDataSet()
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
        Me.SupplierLabel = New System.Windows.Forms.Label()
        Me.KnittingOrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.KWOrderLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.KWOrderLookupDataSet = New KSoft_Inventory.KWOrderLookupDataSet()
        Me.KnittingOrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource()
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.ItemIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDevelopment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReceiveIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ReceivedMRNoLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.ReceiveDataSet = New KSoft_Inventory.ReceiveDataSet()
        Me.ReceiveIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LotAndItemwiseBalanceNewBindingSource = New System.Windows.Forms.BindingSource()
        Me.LotAndItemwiseBalanceNewDataSet = New KSoft_Inventory.LotAndItemwiseBalanceNewDataSet()
        Me.LotNoGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLIssue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhysicalStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource()
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IssueTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueReceiveTypeBindingSource = New System.Windows.Forms.BindingSource()
        Me.IssueReceiveTypeDataSet = New KSoft_Inventory.IssueReceiveTypeDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemBalanceLabel = New System.Windows.Forms.Label()
        Me.AIssuedLabel = New System.Windows.Forms.Label()
        Me.MediaComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintingMediaBindingSource = New System.Windows.Forms.BindingSource()
        Me.MediaDataSet = New KSoft_Inventory.MediaDataSet()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource()
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.RequistionNoTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CopyCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LotAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource()
        Me.LotAndItemBalanceDataSet = New KSoft_Inventory.LotAndItemBalanceDataSet()
        Me.ReceiveBindingSource = New System.Windows.Forms.BindingSource()
        Me.YBGenerationBindingSource = New System.Windows.Forms.BindingSource()
        Me.YarnBookingDataSet = New KSoft_Inventory.YarnBookingDataSet()
        Me.VBookingLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.BookingDataSet = New KSoft_Inventory.BookingDataSet()
        Me.LotWiseReceivedIssuedBindingSource = New System.Windows.Forms.BindingSource()
        Me.YarnLotNoLookupDataSet = New KSoft_Inventory.YarnLotNoLookupDataSet()
        Me.YarnLotNoLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.VItemListBindingSource = New System.Windows.Forms.BindingSource()
        Me.ItemNameDataSet = New KSoft_Inventory.ItemNameDataSet()
        Me.IssueTableAdapter = New KSoft_Inventory.IssueDataSetTableAdapters.IssueTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.IssueDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource()
        Me.VItemListTableAdapter = New KSoft_Inventory.ItemNameDataSetTableAdapters.vItemListTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager()
        Me.PrintingMediaTableAdapter = New KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.ReceiveTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListLookupBindingSource1 = New System.Windows.Forms.BindingSource()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityPerPacket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreviousPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReorderLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpireLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByItemButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RqNoTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VBookingLookupTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.vBookingLookupTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.TotalIssueQuantityTableAdapter = New KSoft_Inventory.IssueDataSetTableAdapters.TotalIssueQuantityTableAdapter()
        Me.IssueReceiveTypeTableAdapter = New KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.YarnLotNoLookupTableAdapter = New KSoft_Inventory.YarnLotNoLookupDataSetTableAdapters.YarnLotNoLookupTableAdapter()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.LotWiseReceivedIssuedTableAdapter = New KSoft_Inventory.YarnLotNoLookupDataSetTableAdapters.LotWiseReceivedIssuedTableAdapter()
        Me.LotAndItemwiseBalanceTableAdapter = New KSoft_Inventory.LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter()
        Me.PIAndItemwiseBalanceTableAdapter = New KSoft_Inventory.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter()
        Me.IssueGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssueId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWebsite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeeklyOff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequistionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintingMediaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueReceiveTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IssueReceiveTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssueReceiveTypeId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemLookUpGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PINoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PILookUpBindingSource = New System.Windows.Forms.BindingSource()
        Me.PILookUpDataSet = New KSoft_Inventory.PILookUpDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPINo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAllocatedIssue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingOrderGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYDOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YDOrGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colManufactureDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpiryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricBookingId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftOverQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsLeftOver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBAG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCTN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPKT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.LCNoLookUpFromPIIdBindingSource = New System.Windows.Forms.BindingSource()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYTRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PIGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookingDetailsLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricBookingId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDevelopment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LCNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCNoNewLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.MenufactureLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colManufactureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExpiryDateLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource()
        Me.PiListDataSet = New KSoft_Inventory.PiListDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ExportLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AccessoriesListLookupTableAdapter1 = New KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter()
        Me.PIListTableAdapter = New KSoft_Inventory.PiListDataSetTableAdapters.PIListTableAdapter()
        Me.TableAdapterManager3 = New KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager()
        Me.ReceivedMRNoLookupTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter()
        Me.KWOrderLookupTableAdapter = New KSoft_Inventory.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter()
        Me.PILookUpTableAdapter = New KSoft_Inventory.PILookUpDataSetTableAdapters.PILookUpTableAdapter()
        Me.colLCNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YDOrderTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter()
        Me.colYDOrderNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingWorkOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotwiseHistoryTableAdapter = New KSoft_Inventory.LotwiseHistoryDataSetTableAdapters.LotwiseHistoryTableAdapter()
        Me.YBGenerationTableAdapter = New KSoft_Inventory.YarnBookingDataSetTableAdapters.YBGenerationTableAdapter()
        Me.YDOrderDetailsBindingSource = New System.Windows.Forms.BindingSource()
        Me.YDOrderDetailsTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter()
        Me.LCNoLookUpFromPIIdTableAdapter = New KSoft_Inventory.PILookUpDataSetTableAdapters.LCNoLookUpFromPIIdTableAdapter()
        Me.VBookingLookup1BindingSource = New System.Windows.Forms.BindingSource()
        Me.VBookingLookup1TableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.vBookingLookup1TableAdapter()
        Me.LotAndItemwiseBalanceNewTableAdapter = New KSoft_Inventory.LotAndItemwiseBalanceNewDataSetTableAdapters.LotAndItemwiseBalanceNewTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        PriceLabel = New System.Windows.Forms.Label()
        ReceiveQuantityLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        BranchIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        PrintingMediaIdLabel = New System.Windows.Forms.Label()
        ProgramNoLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        TotalReceiveQuantityLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        IssueTypeLabel = New System.Windows.Forms.Label()
        LotNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CompanyIdLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        YDOrderIdLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        PKTLabel = New System.Windows.Forms.Label()
        CTNLabel = New System.Windows.Forms.Label()
        BAGLabel = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        ManufactureDateLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ActUnitGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLeftOverCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotwiseHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotwiseHistoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalIssueQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAllocatedIssueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemwiseBalanceNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemwiseBalanceNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YBGenerationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnBookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotWiseReceivedIssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnLotNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnLotNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookUpGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PINoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingOrderGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCNoLookUpFromPIIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCNoNewLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenufactureLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpiryDateLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PiListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBookingLookup1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(491, 204)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 33
        PriceLabel.Text = "Price:"
        '
        'ReceiveQuantityLabel
        '
        ReceiveQuantityLabel.AutoSize = True
        ReceiveQuantityLabel.Location = New System.Drawing.Point(273, 202)
        ReceiveQuantityLabel.Name = "ReceiveQuantityLabel"
        ReceiveQuantityLabel.Size = New System.Drawing.Size(83, 13)
        ReceiveQuantityLabel.TabIndex = 24
        ReceiveQuantityLabel.Text = "Issued Quantity:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(27, 47)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(61, 13)
        IssueDateLabel.TabIndex = 14
        IssueDateLabel.Text = "Issue Date:"
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(26, 152)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(47, 13)
        BranchIdLabel.TabIndex = 16
        BranchIdLabel.Text = "Branch :"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(273, 252)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 25
        RemarksLabel.Text = "Remarks:"
        '
        'PrintingMediaIdLabel
        '
        PrintingMediaIdLabel.AutoSize = True
        PrintingMediaIdLabel.Location = New System.Drawing.Point(26, 176)
        PrintingMediaIdLabel.Name = "PrintingMediaIdLabel"
        PrintingMediaIdLabel.Size = New System.Drawing.Size(50, 13)
        PrintingMediaIdLabel.TabIndex = 17
        PrintingMediaIdLabel.Text = "Issue to :"
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(271, 46)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(66, 13)
        ProgramNoLabel.TabIndex = 20
        ProgramNoLabel.Text = "Program No:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(482, 94)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(52, 13)
        Label5.TabIndex = 27
        Label5.Text = "Balance :"
        '
        'TotalReceiveQuantityLabel
        '
        TotalReceiveQuantityLabel.AutoSize = True
        TotalReceiveQuantityLabel.Location = New System.Drawing.Point(273, 93)
        TotalReceiveQuantityLabel.Name = "TotalReceiveQuantityLabel"
        TotalReceiveQuantityLabel.Size = New System.Drawing.Size(82, 13)
        TotalReceiveQuantityLabel.TabIndex = 21
        TotalReceiveQuantityLabel.Text = "Already Issued :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(651, 95)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 29
        Label6.Text = "Re. Balance :"
        '
        'IssueTypeLabel
        '
        IssueTypeLabel.AutoSize = True
        IssueTypeLabel.Location = New System.Drawing.Point(26, 203)
        IssueTypeLabel.Name = "IssueTypeLabel"
        IssueTypeLabel.Size = New System.Drawing.Size(62, 13)
        IssueTypeLabel.TabIndex = 18
        IssueTypeLabel.Text = "Issue Type:"
        '
        'LotNoLabel
        '
        LotNoLabel.AutoSize = True
        LotNoLabel.Location = New System.Drawing.Point(643, 124)
        LotNoLabel.Name = "LotNoLabel"
        LotNoLabel.Size = New System.Drawing.Size(45, 13)
        LotNoLabel.TabIndex = 0
        LotNoLabel.Text = "Lot No :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(273, 150)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 13)
        Label2.TabIndex = 101
        Label2.Text = "MR NO :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(271, 22)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(93, 13)
        Label8.TabIndex = 103
        Label8.Text = "Fab. Booking No :"
        '
        'CompanyIdLabel
        '
        CompanyIdLabel.AutoSize = True
        CompanyIdLabel.Location = New System.Drawing.Point(27, 23)
        CompanyIdLabel.Name = "CompanyIdLabel"
        CompanyIdLabel.Size = New System.Drawing.Size(54, 13)
        CompanyIdLabel.TabIndex = 104
        CompanyIdLabel.Text = "Company:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(643, 149)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(43, 13)
        Label10.TabIndex = 101
        Label10.Text = "LC No :"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(482, 21)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(94, 13)
        Label11.TabIndex = 110
        Label11.Text = "Knitting Order No :"
        '
        'YDOrderIdLabel
        '
        YDOrderIdLabel.AutoSize = True
        YDOrderIdLabel.Location = New System.Drawing.Point(690, 22)
        YDOrderIdLabel.Name = "YDOrderIdLabel"
        YDOrderIdLabel.Size = New System.Drawing.Size(71, 13)
        YDOrderIdLabel.TabIndex = 114
        YDOrderIdLabel.Text = "YD Order No:"
        '
        'Label13
        '
        Label13.Location = New System.Drawing.Point(0, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(100, 23)
        Label13.TabIndex = 121
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(841, 249)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(46, 13)
        Label14.TabIndex = 119
        Label14.Text = "Balance"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(779, 204)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(38, 13)
        Label15.TabIndex = 119
        Label15.Text = "Issued"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(690, 204)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(69, 13)
        Label16.TabIndex = 122
        Label16.Text = "Yarn Require"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(26, 251)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 0
        AttentionLabel.Text = "Attention:"
        '
        'PKTLabel
        '
        PKTLabel.AutoSize = True
        PKTLabel.Location = New System.Drawing.Point(273, 227)
        PKTLabel.Name = "PKTLabel"
        PKTLabel.Size = New System.Drawing.Size(31, 13)
        PKTLabel.TabIndex = 0
        PKTLabel.Text = "PKT:"
        '
        'CTNLabel
        '
        CTNLabel.AutoSize = True
        CTNLabel.Location = New System.Drawing.Point(443, 227)
        CTNLabel.Name = "CTNLabel"
        CTNLabel.Size = New System.Drawing.Size(32, 13)
        CTNLabel.TabIndex = 0
        CTNLabel.Text = "CTN:"
        '
        'BAGLabel
        '
        BAGLabel.AutoSize = True
        BAGLabel.Location = New System.Drawing.Point(543, 228)
        BAGLabel.Name = "BAGLabel"
        BAGLabel.Size = New System.Drawing.Size(32, 13)
        BAGLabel.TabIndex = 0
        BAGLabel.Text = "BAG:"
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.AutoSize = True
        ExpiryDateLabel.Location = New System.Drawing.Point(272, 275)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(64, 13)
        ExpiryDateLabel.TabIndex = 126
        ExpiryDateLabel.Text = "Expiry Date:"
        '
        'ManufactureDateLabel
        '
        ManufactureDateLabel.AutoSize = True
        ManufactureDateLabel.Location = New System.Drawing.Point(26, 276)
        ManufactureDateLabel.Name = "ManufactureDateLabel"
        ManufactureDateLabel.Size = New System.Drawing.Size(96, 13)
        ManufactureDateLabel.TabIndex = 124
        ManufactureDateLabel.Text = "Manufacture Date:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(271, 69)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(99, 13)
        Label17.TabIndex = 20
        Label17.Text = "Trans. Program No:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(841, 204)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(39, 13)
        Label18.TabIndex = 119
        Label18.Text = "Return"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(690, 249)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(78, 13)
        Label19.TabIndex = 122
        Label19.Text = "Yarn Allocation"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(273, 301)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(82, 13)
        Label20.TabIndex = 24
        Label20.Text = "Act. Issued Qty:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.ActUnitGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ActIssueQtyTextBox)
        Me.GroupBox1.Controls.Add(Label20)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.YTRNoTextBox)
        Me.GroupBox1.Controls.Add(Me.YarnAllocationLabel)
        Me.GroupBox1.Controls.Add(Label19)
        Me.GroupBox1.Controls.Add(Me.ReturnLabel)
        Me.GroupBox1.Controls.Add(Label18)
        Me.GroupBox1.Controls.Add(Me.TransProgramNoTextBox)
        Me.GroupBox1.Controls.Add(Label17)
        Me.GroupBox1.Controls.Add(Me.TransBookingDetailsIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.IssueQuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.IsLeftOverCheckEdit)
        Me.GroupBox1.Controls.Add(Me.LeftOverQtyTextBox)
        Me.GroupBox1.Controls.Add(ExpiryDateLabel)
        Me.GroupBox1.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ManufactureDateLabel)
        Me.GroupBox1.Controls.Add(Me.ManufactureDateDateTimePicker)
        Me.GroupBox1.Controls.Add(BAGLabel)
        Me.GroupBox1.Controls.Add(Me.BAGTextBox)
        Me.GroupBox1.Controls.Add(CTNLabel)
        Me.GroupBox1.Controls.Add(Me.CTNTextBox)
        Me.GroupBox1.Controls.Add(PKTLabel)
        Me.GroupBox1.Controls.Add(Me.PKTTextBox)
        Me.GroupBox1.Controls.Add(AttentionLabel)
        Me.GroupBox1.Controls.Add(Me.AttentionTextEdit)
        Me.GroupBox1.Controls.Add(Me.RequisitionNoLinkLabel)
        Me.GroupBox1.Controls.Add(Label16)
        Me.GroupBox1.Controls.Add(Me.YarnBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.YarnIssuedLabel)
        Me.GroupBox1.Controls.Add(Label15)
        Me.GroupBox1.Controls.Add(Label14)
        Me.GroupBox1.Controls.Add(Me.YarnRquireLabel)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.ReceiveBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TotalIssueQuantityLabel)
        Me.GroupBox1.Controls.Add(YDOrderIdLabel)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.ChallanLinkLabel)
        Me.GroupBox1.Controls.Add(Me.BalanceLabel)
        Me.GroupBox1.Controls.Add(TotalReceiveQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.YDOrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.BookingDetailsIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ProgramNoTextBox)
        Me.GroupBox1.Controls.Add(Me.IsAllocatedIssueCheckEdit)
        Me.GroupBox1.Controls.Add(ProgramNoLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.PIIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.SupplierLabel)
        Me.GroupBox1.Controls.Add(Me.KnittingOrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ChallanNoTextEdit)
        Me.GroupBox1.Controls.Add(CompanyIdLabel)
        Me.GroupBox1.Controls.Add(Me.CompanyIdComboBox)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.ItemIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ReceiveIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(LotNoLabel)
        Me.GroupBox1.Controls.Add(Me.LotNoGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(IssueTypeLabel)
        Me.GroupBox1.Controls.Add(Me.IssueTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ItemBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.AIssuedLabel)
        Me.GroupBox1.Controls.Add(Me.MediaComboBox)
        Me.GroupBox1.Controls.Add(PrintingMediaIdLabel)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.Controls.Add(Me.BranchComboBox)
        Me.GroupBox1.Controls.Add(BranchIdLabel)
        Me.GroupBox1.Controls.Add(Me.RequistionNoTextBox)
        Me.GroupBox1.Controls.Add(IssueDateLabel)
        Me.GroupBox1.Controls.Add(Me.IssueDateDateTimePicker)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.CopyCheckBox)
        Me.GroupBox1.Controls.Add(ReceiveQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1167, 332)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Issue Information"
        '
        'ActUnitGridLookUpEdit
        '
        Me.ActUnitGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UnitBindingSource, "UnitId", True))
        Me.ActUnitGridLookUpEdit.Location = New System.Drawing.Point(490, 298)
        Me.ActUnitGridLookUpEdit.Name = "ActUnitGridLookUpEdit"
        Me.ActUnitGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ActUnitGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActUnitGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.ActUnitGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ActUnitGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ActUnitGridLookUpEdit.Properties.NullText = ""
        Me.ActUnitGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActUnitGridLookUpEdit.Properties.PopupView = Me.GridView18
        Me.ActUnitGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActUnitGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ActUnitGridLookUpEdit.Size = New System.Drawing.Size(85, 20)
        Me.ActUnitGridLookUpEdit.TabIndex = 8
        Me.ActUnitGridLookUpEdit.Tag = "XTRAEDITOR"
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
        'GridView18
        '
        Me.GridView18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
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
        'ActIssueQtyTextBox
        '
        Me.ActIssueQtyTextBox.BackColor = System.Drawing.Color.Yellow
        Me.ActIssueQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "ActIssueQuantity", True))
        Me.ActIssueQtyTextBox.Location = New System.Drawing.Point(372, 298)
        Me.ActIssueQtyTextBox.Name = "ActIssueQtyTextBox"
        Me.ActIssueQtyTextBox.Size = New System.Drawing.Size(112, 20)
        Me.ActIssueQtyTextBox.TabIndex = 10
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "Issue"
        Me.IssueBindingSource.DataSource = Me.IssueDataSet
        '
        'IssueDataSet
        '
        Me.IssueDataSet.DataSetName = "IssueDataSet"
        Me.IssueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(27, 124)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel1.TabIndex = 123
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "YT Req. No"
        '
        'YTRNoTextBox
        '
        Me.YTRNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "YTRNo", True))
        Me.YTRNoTextBox.Location = New System.Drawing.Point(129, 120)
        Me.YTRNoTextBox.Name = "YTRNoTextBox"
        Me.YTRNoTextBox.ReadOnly = True
        Me.YTRNoTextBox.Size = New System.Drawing.Size(132, 20)
        Me.YTRNoTextBox.TabIndex = 1
        Me.YTRNoTextBox.Tag = "NR"
        '
        'YarnAllocationLabel
        '
        Me.YarnAllocationLabel.AutoSize = True
        Me.YarnAllocationLabel.Location = New System.Drawing.Point(690, 274)
        Me.YarnAllocationLabel.Name = "YarnAllocationLabel"
        Me.YarnAllocationLabel.Size = New System.Drawing.Size(10, 13)
        Me.YarnAllocationLabel.TabIndex = 128
        Me.YarnAllocationLabel.Text = "-"
        '
        'ReturnLabel
        '
        Me.ReturnLabel.AutoSize = True
        Me.ReturnLabel.Location = New System.Drawing.Point(841, 227)
        Me.ReturnLabel.Name = "ReturnLabel"
        Me.ReturnLabel.Size = New System.Drawing.Size(10, 13)
        Me.ReturnLabel.TabIndex = 120
        Me.ReturnLabel.Text = "-"
        '
        'TransProgramNoTextBox
        '
        Me.TransProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "TransProgramNo", True))
        Me.TransProgramNoTextBox.Location = New System.Drawing.Point(373, 67)
        Me.TransProgramNoTextBox.Name = "TransProgramNoTextBox"
        Me.TransProgramNoTextBox.Size = New System.Drawing.Size(107, 20)
        Me.TransProgramNoTextBox.TabIndex = 6
        '
        'TransBookingDetailsIdGridLookUpEdit
        '
        Me.TransBookingDetailsIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "TransBookingDetailsId", True))
        Me.TransBookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(482, 67)
        Me.TransBookingDetailsIdGridLookUpEdit.Name = "TransBookingDetailsIdGridLookUpEdit"
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.PopupView = Me.GridView17
        Me.TransBookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TransBookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(401, 20)
        Me.TransBookingDetailsIdGridLookUpEdit.TabIndex = 7
        Me.TransBookingDetailsIdGridLookUpEdit.Tag = "XTRAEDITOR"
        '
        'GridView17
        '
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'IssueQuantityTextBox
        '
        Me.IssueQuantityTextBox.BackColor = System.Drawing.Color.Yellow
        Me.IssueQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "IssueQuantity", True))
        Me.IssueQuantityTextBox.Location = New System.Drawing.Point(372, 199)
        Me.IssueQuantityTextBox.Name = "IssueQuantityTextBox"
        Me.IssueQuantityTextBox.Size = New System.Drawing.Size(112, 20)
        Me.IssueQuantityTextBox.TabIndex = 10
        '
        'IsLeftOverCheckEdit
        '
        Me.IsLeftOverCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "IsLeftOver", True))
        Me.IsLeftOverCheckEdit.Location = New System.Drawing.Point(505, 273)
        Me.IsLeftOverCheckEdit.Name = "IsLeftOverCheckEdit"
        Me.IsLeftOverCheckEdit.Properties.Caption = "Is LeftOver"
        Me.IsLeftOverCheckEdit.Size = New System.Drawing.Size(76, 19)
        Me.IsLeftOverCheckEdit.TabIndex = 113
        '
        'LeftOverQtyTextBox
        '
        Me.LeftOverQtyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LeftOverQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "LeftOverQuantity", True))
        Me.LeftOverQtyTextBox.Location = New System.Drawing.Point(372, 199)
        Me.LeftOverQtyTextBox.Name = "LeftOverQtyTextBox"
        Me.LeftOverQtyTextBox.Size = New System.Drawing.Size(112, 20)
        Me.LeftOverQtyTextBox.TabIndex = 10
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Enabled = False
        Me.ExpiryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(372, 272)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(112, 20)
        Me.ExpiryDateDateTimePicker.TabIndex = 127
        '
        'ManufactureDateDateTimePicker
        '
        Me.ManufactureDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ManufactureDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueBindingSource, "ManufactureDate", True))
        Me.ManufactureDateDateTimePicker.Enabled = False
        Me.ManufactureDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ManufactureDateDateTimePicker.Location = New System.Drawing.Point(128, 272)
        Me.ManufactureDateDateTimePicker.Name = "ManufactureDateDateTimePicker"
        Me.ManufactureDateDateTimePicker.Size = New System.Drawing.Size(132, 20)
        Me.ManufactureDateDateTimePicker.TabIndex = 125
        '
        'BAGTextBox
        '
        Me.BAGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "BAG", True))
        Me.BAGTextBox.Location = New System.Drawing.Point(581, 225)
        Me.BAGTextBox.Name = "BAGTextBox"
        Me.BAGTextBox.Size = New System.Drawing.Size(56, 20)
        Me.BAGTextBox.TabIndex = 1
        '
        'CTNTextBox
        '
        Me.CTNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "CTN", True))
        Me.CTNTextBox.Location = New System.Drawing.Point(481, 224)
        Me.CTNTextBox.Name = "CTNTextBox"
        Me.CTNTextBox.Size = New System.Drawing.Size(56, 20)
        Me.CTNTextBox.TabIndex = 1
        '
        'PKTTextBox
        '
        Me.PKTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "PKT", True))
        Me.PKTTextBox.Location = New System.Drawing.Point(372, 224)
        Me.PKTTextBox.Name = "PKTTextBox"
        Me.PKTTextBox.Size = New System.Drawing.Size(65, 20)
        Me.PKTTextBox.TabIndex = 1
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(128, 246)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.AttentionTextEdit.TabIndex = 1
        '
        'RequisitionNoLinkLabel
        '
        Me.RequisitionNoLinkLabel.AutoSize = True
        Me.RequisitionNoLinkLabel.Location = New System.Drawing.Point(26, 98)
        Me.RequisitionNoLinkLabel.Name = "RequisitionNoLinkLabel"
        Me.RequisitionNoLinkLabel.Size = New System.Drawing.Size(76, 13)
        Me.RequisitionNoLinkLabel.TabIndex = 123
        Me.RequisitionNoLinkLabel.TabStop = True
        Me.RequisitionNoLinkLabel.Text = "Requisition No"
        '
        'YarnBalanceLabel
        '
        Me.YarnBalanceLabel.AutoSize = True
        Me.YarnBalanceLabel.Location = New System.Drawing.Point(841, 274)
        Me.YarnBalanceLabel.Name = "YarnBalanceLabel"
        Me.YarnBalanceLabel.Size = New System.Drawing.Size(10, 13)
        Me.YarnBalanceLabel.TabIndex = 120
        Me.YarnBalanceLabel.Text = "-"
        '
        'YarnIssuedLabel
        '
        Me.YarnIssuedLabel.AutoSize = True
        Me.YarnIssuedLabel.Location = New System.Drawing.Point(779, 227)
        Me.YarnIssuedLabel.Name = "YarnIssuedLabel"
        Me.YarnIssuedLabel.Size = New System.Drawing.Size(10, 13)
        Me.YarnIssuedLabel.TabIndex = 120
        Me.YarnIssuedLabel.Text = "-"
        '
        'YarnRquireLabel
        '
        Me.YarnRquireLabel.AutoSize = True
        Me.YarnRquireLabel.Location = New System.Drawing.Point(690, 227)
        Me.YarnRquireLabel.Name = "YarnRquireLabel"
        Me.YarnRquireLabel.Size = New System.Drawing.Size(10, 13)
        Me.YarnRquireLabel.TabIndex = 120
        Me.YarnRquireLabel.Text = "-"
        '
        'ReceiveBalanceLabel
        '
        Me.ReceiveBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiveBalanceLabel.Location = New System.Drawing.Point(729, 92)
        Me.ReceiveBalanceLabel.Name = "ReceiveBalanceLabel"
        Me.ReceiveBalanceLabel.Size = New System.Drawing.Size(155, 18)
        Me.ReceiveBalanceLabel.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReferenceNoDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LotwiseHistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(905, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(255, 296)
        Me.DataGridView1.TabIndex = 117
        '
        'ReferenceNoDataGridViewTextBoxColumn
        '
        Me.ReferenceNoDataGridViewTextBoxColumn.DataPropertyName = "ReferenceNo"
        Me.ReferenceNoDataGridViewTextBoxColumn.HeaderText = "Ref. No"
        Me.ReferenceNoDataGridViewTextBoxColumn.Name = "ReferenceNoDataGridViewTextBoxColumn"
        Me.ReferenceNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "Transaction"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        Me.TransactionTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionTypeDataGridViewTextBoxColumn.Width = 75
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 75
        '
        'LotwiseHistoryBindingSource
        '
        Me.LotwiseHistoryBindingSource.DataMember = "LotwiseHistory"
        Me.LotwiseHistoryBindingSource.DataSource = Me.LotwiseHistoryDataSet
        '
        'LotwiseHistoryDataSet
        '
        Me.LotwiseHistoryDataSet.DataSetName = "LotwiseHistoryDataSet"
        Me.LotwiseHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalIssueQuantityLabel
        '
        Me.TotalIssueQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalIssueQuantityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalIssueQuantityBindingSource, "TotalIssueQuantity", True))
        Me.TotalIssueQuantityLabel.Location = New System.Drawing.Point(375, 93)
        Me.TotalIssueQuantityLabel.Name = "TotalIssueQuantityLabel"
        Me.TotalIssueQuantityLabel.Size = New System.Drawing.Size(107, 17)
        Me.TotalIssueQuantityLabel.TabIndex = 26
        '
        'TotalIssueQuantityBindingSource
        '
        Me.TotalIssueQuantityBindingSource.DataMember = "TotalIssueQuantity"
        Me.TotalIssueQuantityBindingSource.DataSource = Me.IssueDataSet
        '
        'ChallanLinkLabel
        '
        Me.ChallanLinkLabel.AutoSize = True
        Me.ChallanLinkLabel.Location = New System.Drawing.Point(27, 73)
        Me.ChallanLinkLabel.Name = "ChallanLinkLabel"
        Me.ChallanLinkLabel.Size = New System.Drawing.Size(65, 13)
        Me.ChallanLinkLabel.TabIndex = 116
        Me.ChallanLinkLabel.TabStop = True
        Me.ChallanLinkLabel.Text = "Challan No :"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BalanceLabel.Location = New System.Drawing.Point(536, 92)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(100, 18)
        Me.BalanceLabel.TabIndex = 28
        '
        'YDOrderIdGridLookUpEdit
        '
        Me.YDOrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "YDOrderId", True))
        Me.YDOrderIdGridLookUpEdit.Location = New System.Drawing.Point(766, 19)
        Me.YDOrderIdGridLookUpEdit.Name = "YDOrderIdGridLookUpEdit"
        Me.YDOrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YDOrderIdGridLookUpEdit.Properties.DataSource = Me.YDOrderBindingSource
        Me.YDOrderIdGridLookUpEdit.Properties.DisplayMember = "YDOrderNo"
        Me.YDOrderIdGridLookUpEdit.Properties.NullText = ""
        Me.YDOrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YDOrderIdGridLookUpEdit.Properties.PopupView = Me.YDOrderIdGridLookUpEditView
        Me.YDOrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YDOrderIdGridLookUpEdit.Properties.ValueMember = "YDOrderId"
        Me.YDOrderIdGridLookUpEdit.Size = New System.Drawing.Size(116, 20)
        Me.YDOrderIdGridLookUpEdit.TabIndex = 115
        '
        'YDOrderBindingSource
        '
        Me.YDOrderBindingSource.DataMember = "YDOrder"
        Me.YDOrderBindingSource.DataSource = Me.YDOrderLookupDataSet
        '
        'YDOrderLookupDataSet
        '
        Me.YDOrderLookupDataSet.DataSetName = "YDOrderLookupDataSet"
        Me.YDOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YDOrderIdGridLookUpEditView
        '
        Me.YDOrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYDOrderNo})
        Me.YDOrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YDOrderIdGridLookUpEditView.Name = "YDOrderIdGridLookUpEditView"
        Me.YDOrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YDOrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colYDOrderNo
        '
        Me.colYDOrderNo.FieldName = "YDOrderNo"
        Me.colYDOrderNo.Name = "colYDOrderNo"
        Me.colYDOrderNo.Visible = True
        Me.colYDOrderNo.VisibleIndex = 0
        '
        'BookingDetailsIdGridLookUpEdit
        '
        Me.BookingDetailsIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "BookingDetailsId", True))
        Me.BookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(481, 44)
        Me.BookingDetailsIdGridLookUpEdit.Name = "BookingDetailsIdGridLookUpEdit"
        Me.BookingDetailsIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.BookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.BookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(401, 20)
        Me.BookingDetailsIdGridLookUpEdit.TabIndex = 7
        Me.BookingDetailsIdGridLookUpEdit.Tag = "XTRAEDITOR"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(373, 44)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(107, 20)
        Me.ProgramNoTextBox.TabIndex = 6
        '
        'IsAllocatedIssueCheckEdit
        '
        Me.IsAllocatedIssueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "IsAllocatedIssue", True))
        Me.IsAllocatedIssueCheckEdit.Location = New System.Drawing.Point(375, 273)
        Me.IsAllocatedIssueCheckEdit.Name = "IsAllocatedIssueCheckEdit"
        Me.IsAllocatedIssueCheckEdit.Properties.Caption = "Is Allocated issue"
        Me.IsAllocatedIssueCheckEdit.Size = New System.Drawing.Size(124, 19)
        Me.IsAllocatedIssueCheckEdit.TabIndex = 113
        Me.IsAllocatedIssueCheckEdit.Visible = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.Color.Yellow
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(549, 199)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(88, 20)
        Me.PriceTextBox.TabIndex = 112
        Me.PriceTextBox.Tag = "NR"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(690, 169)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(191, 23)
        Me.RefreshButton.TabIndex = 109
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'PIIdGridLookUpEdit
        '
        Me.PIIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "PIId", True))
        Me.PIIdGridLookUpEdit.Location = New System.Drawing.Point(692, 146)
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
        Me.PIIdGridLookUpEdit.Size = New System.Drawing.Size(189, 20)
        Me.PIIdGridLookUpEdit.TabIndex = 108
        '
        'PIAndItemwiseBalanceBindingSource
        '
        Me.PIAndItemwiseBalanceBindingSource.DataMember = "PIAndItemwiseBalance"
        Me.PIAndItemwiseBalanceBindingSource.DataSource = Me.PIAnditemwiseBalanceDataSet
        '
        'PIAnditemwiseBalanceDataSet
        '
        Me.PIAnditemwiseBalanceDataSet.DataSetName = "PIAnditemwiseBalanceDataSet"
        Me.PIAnditemwiseBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SupplierLabel
        '
        Me.SupplierLabel.AutoSize = True
        Me.SupplierLabel.Location = New System.Drawing.Point(26, 228)
        Me.SupplierLabel.Name = "SupplierLabel"
        Me.SupplierLabel.Size = New System.Drawing.Size(45, 13)
        Me.SupplierLabel.TabIndex = 107
        Me.SupplierLabel.Text = "Supplier"
        '
        'KnittingOrderIdGridLookUpEdit
        '
        Me.KnittingOrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "KnittingOrderId", True))
        Me.KnittingOrderIdGridLookUpEdit.Location = New System.Drawing.Point(578, 18)
        Me.KnittingOrderIdGridLookUpEdit.Name = "KnittingOrderIdGridLookUpEdit"
        Me.KnittingOrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingOrderIdGridLookUpEdit.Properties.DataSource = Me.KWOrderLookupBindingSource
        Me.KnittingOrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.KnittingOrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.KnittingOrderIdGridLookUpEdit.Properties.NullText = ""
        Me.KnittingOrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KnittingOrderIdGridLookUpEdit.Properties.PopupView = Me.KnittingOrderIdGridLookUpEditView
        Me.KnittingOrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingOrderIdGridLookUpEdit.Properties.ValueMember = "KnittingOrderId"
        Me.KnittingOrderIdGridLookUpEdit.Size = New System.Drawing.Size(111, 20)
        Me.KnittingOrderIdGridLookUpEdit.TabIndex = 111
        '
        'KWOrderLookupBindingSource
        '
        Me.KWOrderLookupBindingSource.DataMember = "KWOrderLookup"
        Me.KWOrderLookupBindingSource.DataSource = Me.KWOrderLookupDataSet
        '
        'KWOrderLookupDataSet
        '
        Me.KWOrderLookupDataSet.DataSetName = "KWOrderLookupDataSet"
        Me.KWOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingOrderIdGridLookUpEditView
        '
        Me.KnittingOrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails3, Me.colSupplierName3})
        Me.KnittingOrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.KnittingOrderIdGridLookUpEditView.Name = "KnittingOrderIdGridLookUpEditView"
        Me.KnittingOrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.KnittingOrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails3
        '
        Me.colDetails3.FieldName = "Details"
        Me.colDetails3.Name = "colDetails3"
        Me.colDetails3.OptionsColumn.ReadOnly = True
        Me.colDetails3.Visible = True
        Me.colDetails3.VisibleIndex = 0
        '
        'colSupplierName3
        '
        Me.colSupplierName3.FieldName = "SupplierName"
        Me.colSupplierName3.Name = "colSupplierName3"
        Me.colSupplierName3.Visible = True
        Me.colSupplierName3.VisibleIndex = 1
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "ChallanNo", True))
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(129, 71)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Properties.ReadOnly = True
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.ChallanNoTextEdit.TabIndex = 106
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssueBindingSource, "CompanyId", True))
        Me.CompanyIdComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyIdComboBox.DisplayMember = "CompanyCode"
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(129, 20)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(76, 21)
        Me.CompanyIdComboBox.TabIndex = 105
        Me.CompanyIdComboBox.ValueMember = "CompanyId"
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
        'ItemIdGridLookUpEdit
        '
        Me.ItemIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "ItemId", True))
        Me.ItemIdGridLookUpEdit.Location = New System.Drawing.Point(372, 121)
        Me.ItemIdGridLookUpEdit.Name = "ItemIdGridLookUpEdit"
        Me.ItemIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ItemIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIdGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemIdGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ItemIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemIdGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ItemIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemIdGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemIdGridLookUpEdit.Size = New System.Drawing.Size(262, 20)
        Me.ItemIdGridLookUpEdit.TabIndex = 8
        Me.ItemIdGridLookUpEdit.Tag = "XTRAEDITOR"
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "FinishFabricBookingId", True))
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(373, 19)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupView = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingId"
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(107, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 104
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
        'FinishFabricBookingIdGridLookUpEditView
        '
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo1, Me.colAmendmentNo, Me.colFinishFabricBookingId, Me.colDetails, Me.colIsDevelopment})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        '
        'colFinishFabricBookingId
        '
        Me.colFinishFabricBookingId.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId.Name = "colFinishFabricBookingId"
        Me.colFinishFabricBookingId.OptionsColumn.ReadOnly = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'colIsDevelopment
        '
        Me.colIsDevelopment.FieldName = "IsDevelopment"
        Me.colIsDevelopment.Name = "colIsDevelopment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Item Name"
        '
        'ReceiveIdGridLookUpEdit
        '
        Me.ReceiveIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "ReceiveId", True))
        Me.ReceiveIdGridLookUpEdit.Location = New System.Drawing.Point(372, 146)
        Me.ReceiveIdGridLookUpEdit.Name = "ReceiveIdGridLookUpEdit"
        Me.ReceiveIdGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReceiveIdGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ReceiveIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReceiveIdGridLookUpEdit.Properties.DataSource = Me.ReceivedMRNoLookupBindingSource
        Me.ReceiveIdGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ReceiveIdGridLookUpEdit.Properties.NullText = ""
        Me.ReceiveIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ReceiveIdGridLookUpEdit.Properties.PopupView = Me.ReceiveIdGridLookUpEditView
        Me.ReceiveIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ReceiveIdGridLookUpEdit.Properties.ValueMember = "MRNo"
        Me.ReceiveIdGridLookUpEdit.Size = New System.Drawing.Size(262, 20)
        Me.ReceiveIdGridLookUpEdit.TabIndex = 14
        '
        'ReceivedMRNoLookupBindingSource
        '
        Me.ReceivedMRNoLookupBindingSource.DataMember = "ReceivedMRNoLookup"
        Me.ReceivedMRNoLookupBindingSource.DataSource = Me.ReceiveDataSet
        '
        'ReceiveDataSet
        '
        Me.ReceiveDataSet.DataSetName = "ReceiveDataSet"
        Me.ReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiveIdGridLookUpEditView
        '
        Me.ReceiveIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo1, Me.colReceiveDate})
        Me.ReceiveIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ReceiveIdGridLookUpEditView.Name = "ReceiveIdGridLookUpEditView"
        Me.ReceiveIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ReceiveIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo1
        '
        Me.colChallanNo1.FieldName = "ChallanNo"
        Me.colChallanNo1.Name = "colChallanNo1"
        Me.colChallanNo1.Visible = True
        Me.colChallanNo1.VisibleIndex = 0
        '
        'colReceiveDate
        '
        Me.colReceiveDate.FieldName = "ReceiveDate"
        Me.colReceiveDate.Name = "colReceiveDate"
        Me.colReceiveDate.OptionsColumn.ReadOnly = True
        Me.colReceiveDate.Visible = True
        Me.colReceiveDate.VisibleIndex = 1
        '
        'LotNoGridLookUpEdit
        '
        Me.LotNoGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "LotNo", True))
        Me.LotNoGridLookUpEdit.EditValue = "[Type Lot Nol]"
        Me.LotNoGridLookUpEdit.Location = New System.Drawing.Point(692, 120)
        Me.LotNoGridLookUpEdit.Name = "LotNoGridLookUpEdit"
        Me.LotNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LotNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LotNoGridLookUpEdit.Properties.DataSource = Me.LotAndItemwiseBalanceNewBindingSource
        Me.LotNoGridLookUpEdit.Properties.DisplayMember = "YarnLotNo"
        Me.LotNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.LotNoGridLookUpEdit.Properties.NullText = "[Type Lot No]"
        Me.LotNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LotNoGridLookUpEdit.Properties.PopupView = Me.LotNoGridLookUpEditView
        Me.LotNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LotNoGridLookUpEdit.Properties.ValueMember = "YarnLotNo"
        Me.LotNoGridLookUpEdit.Size = New System.Drawing.Size(189, 20)
        Me.LotNoGridLookUpEdit.TabIndex = 13
        '
        'LotAndItemwiseBalanceNewBindingSource
        '
        Me.LotAndItemwiseBalanceNewBindingSource.DataMember = "LotAndItemwiseBalanceNew"
        Me.LotAndItemwiseBalanceNewBindingSource.DataSource = Me.LotAndItemwiseBalanceNewDataSet
        '
        'LotAndItemwiseBalanceNewDataSet
        '
        Me.LotAndItemwiseBalanceNewDataSet.DataSetName = "LotAndItemwiseBalanceNewDataSet"
        Me.LotAndItemwiseBalanceNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LotNoGridLookUpEditView
        '
        Me.LotNoGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYarnLotNo, Me.colSupplier, Me.colTTLReceive, Me.colTTLIssue, Me.colPhysicalStock, Me.colAllocateQuantity, Me.colAllocateBalance, Me.colRealStock})
        Me.LotNoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LotNoGridLookUpEditView.Name = "LotNoGridLookUpEditView"
        Me.LotNoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LotNoGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        Me.colYarnLotNo.Visible = True
        Me.colYarnLotNo.VisibleIndex = 0
        '
        'colSupplier
        '
        Me.colSupplier.FieldName = "Supplier"
        Me.colSupplier.Name = "colSupplier"
        Me.colSupplier.Visible = True
        Me.colSupplier.VisibleIndex = 1
        '
        'colTTLReceive
        '
        Me.colTTLReceive.FieldName = "TTLReceive"
        Me.colTTLReceive.Name = "colTTLReceive"
        Me.colTTLReceive.Visible = True
        Me.colTTLReceive.VisibleIndex = 2
        '
        'colTTLIssue
        '
        Me.colTTLIssue.FieldName = "TTLIssue"
        Me.colTTLIssue.Name = "colTTLIssue"
        Me.colTTLIssue.Visible = True
        Me.colTTLIssue.VisibleIndex = 3
        '
        'colPhysicalStock
        '
        Me.colPhysicalStock.FieldName = "PhysicalStock"
        Me.colPhysicalStock.Name = "colPhysicalStock"
        Me.colPhysicalStock.Visible = True
        Me.colPhysicalStock.VisibleIndex = 4
        '
        'colAllocateQuantity
        '
        Me.colAllocateQuantity.FieldName = "AllocateQuantity"
        Me.colAllocateQuantity.Name = "colAllocateQuantity"
        Me.colAllocateQuantity.Visible = True
        Me.colAllocateQuantity.VisibleIndex = 5
        '
        'colAllocateBalance
        '
        Me.colAllocateBalance.FieldName = "AllocateBalance"
        Me.colAllocateBalance.Name = "colAllocateBalance"
        Me.colAllocateBalance.Visible = True
        Me.colAllocateBalance.VisibleIndex = 6
        '
        'colRealStock
        '
        Me.colRealStock.FieldName = "RealStock"
        Me.colRealStock.Name = "colRealStock"
        Me.colRealStock.Visible = True
        Me.colRealStock.VisibleIndex = 7
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssueBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.EditValue = "[Select Supplier]"
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(128, 222)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(132, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 5
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
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
        '
        'colAdd1
        '
        Me.colAdd1.FieldName = "Add1"
        Me.colAdd1.Name = "colAdd1"
        '
        'colAdd2
        '
        Me.colAdd2.FieldName = "Add2"
        Me.colAdd2.Name = "colAdd2"
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        '
        'IssueTypeComboBox
        '
        Me.IssueTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssueBindingSource, "IssueReceiveTypeId", True))
        Me.IssueTypeComboBox.DataSource = Me.IssueReceiveTypeBindingSource
        Me.IssueTypeComboBox.DisplayMember = "IssueTypeName"
        Me.IssueTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IssueTypeComboBox.FormattingEnabled = True
        Me.IssueTypeComboBox.Location = New System.Drawing.Point(128, 197)
        Me.IssueTypeComboBox.Name = "IssueTypeComboBox"
        Me.IssueTypeComboBox.Size = New System.Drawing.Size(132, 21)
        Me.IssueTypeComboBox.TabIndex = 4
        Me.IssueTypeComboBox.ValueMember = "IssueReceiveTypeId"
        '
        'IssueReceiveTypeBindingSource
        '
        Me.IssueReceiveTypeBindingSource.DataMember = "IssueReceiveType"
        Me.IssueReceiveTypeBindingSource.DataSource = Me.IssueReceiveTypeDataSet
        '
        'IssueReceiveTypeDataSet
        '
        Me.IssueReceiveTypeDataSet.DataSetName = "IssueReceiveTypeDataSet"
        Me.IssueReceiveTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Already Issued"
        '
        'ItemBalanceLabel
        '
        Me.ItemBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemBalanceLabel.Location = New System.Drawing.Point(549, 173)
        Me.ItemBalanceLabel.Name = "ItemBalanceLabel"
        Me.ItemBalanceLabel.Size = New System.Drawing.Size(88, 20)
        Me.ItemBalanceLabel.TabIndex = 100
        '
        'AIssuedLabel
        '
        Me.AIssuedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AIssuedLabel.Location = New System.Drawing.Point(372, 173)
        Me.AIssuedLabel.Name = "AIssuedLabel"
        Me.AIssuedLabel.Size = New System.Drawing.Size(112, 20)
        Me.AIssuedLabel.TabIndex = 100
        '
        'MediaComboBox
        '
        Me.MediaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssueBindingSource, "PrintingMediaId", True))
        Me.MediaComboBox.DataSource = Me.PrintingMediaBindingSource
        Me.MediaComboBox.DisplayMember = "MediaName"
        Me.MediaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MediaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MediaComboBox.FormattingEnabled = True
        Me.MediaComboBox.Location = New System.Drawing.Point(128, 172)
        Me.MediaComboBox.Name = "MediaComboBox"
        Me.MediaComboBox.Size = New System.Drawing.Size(132, 21)
        Me.MediaComboBox.TabIndex = 3
        Me.MediaComboBox.ValueMember = "PrintingMediaId"
        '
        'PrintingMediaBindingSource
        '
        Me.PrintingMediaBindingSource.DataMember = "PrintingMedia"
        Me.PrintingMediaBindingSource.DataSource = Me.MediaDataSet
        '
        'MediaDataSet
        '
        Me.MediaDataSet.DataSetName = "MediaDataSet"
        Me.MediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(372, 249)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(265, 20)
        Me.RemarksTextBox.TabIndex = 12
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssueBindingSource, "BranchId", True))
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(128, 147)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(132, 21)
        Me.BranchComboBox.TabIndex = 2
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequistionNoTextBox
        '
        Me.RequistionNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssueBindingSource, "RequistionNo", True))
        Me.RequistionNoTextBox.Location = New System.Drawing.Point(129, 95)
        Me.RequistionNoTextBox.Name = "RequistionNoTextBox"
        Me.RequistionNoTextBox.Size = New System.Drawing.Size(132, 20)
        Me.RequistionNoTextBox.TabIndex = 1
        Me.RequistionNoTextBox.Tag = "NR"
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssueBindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(129, 45)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(132, 20)
        Me.IssueDateDateTimePicker.TabIndex = 0
        '
        'CopyCheckBox
        '
        Me.CopyCheckBox.AutoSize = True
        Me.CopyCheckBox.Location = New System.Drawing.Point(211, 23)
        Me.CopyCheckBox.Name = "CopyCheckBox"
        Me.CopyCheckBox.Size = New System.Drawing.Size(50, 17)
        Me.CopyCheckBox.TabIndex = 13
        Me.CopyCheckBox.Text = "&Copy"
        Me.CopyCheckBox.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.AutoScroll = True
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1161, 313)
        Me.ShapeContainer1.TabIndex = 118
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 269
        Me.LineShape1.X2 = 878
        Me.LineShape1.Y1 = 99
        Me.LineShape1.Y2 = 99
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
        'ReceiveBindingSource
        '
        Me.ReceiveBindingSource.DataMember = "Receive"
        Me.ReceiveBindingSource.DataSource = Me.ReceiveDataSet
        '
        'YBGenerationBindingSource
        '
        Me.YBGenerationBindingSource.DataMember = "YBGeneration"
        Me.YBGenerationBindingSource.DataSource = Me.YarnBookingDataSet
        '
        'YarnBookingDataSet
        '
        Me.YarnBookingDataSet.DataSetName = "YarnBookingDataSet"
        Me.YarnBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VBookingLookupBindingSource
        '
        Me.VBookingLookupBindingSource.DataMember = "vBookingLookup"
        Me.VBookingLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LotWiseReceivedIssuedBindingSource
        '
        Me.LotWiseReceivedIssuedBindingSource.DataMember = "LotWiseReceivedIssued"
        Me.LotWiseReceivedIssuedBindingSource.DataSource = Me.YarnLotNoLookupDataSet
        '
        'YarnLotNoLookupDataSet
        '
        Me.YarnLotNoLookupDataSet.DataSetName = "YarnLotNoLookupDataSet"
        Me.YarnLotNoLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnLotNoLookupBindingSource
        '
        Me.YarnLotNoLookupBindingSource.DataMember = "YarnLotNoLookup"
        Me.YarnLotNoLookupBindingSource.DataSource = Me.YarnLotNoLookupDataSet
        '
        'VItemListBindingSource
        '
        Me.VItemListBindingSource.DataMember = "vItemList"
        Me.VItemListBindingSource.DataSource = Me.ItemNameDataSet
        '
        'ItemNameDataSet
        '
        Me.ItemNameDataSet.DataSetName = "ItemNameDataSet"
        Me.ItemNameDataSet.EnforceConstraints = False
        Me.ItemNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IssueTableAdapter = Me.IssueTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.IssueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataSource = Me.IssueBindingSource
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'VItemListTableAdapter
        '
        Me.VItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintingMediaTableAdapter
        '
        Me.PrintingMediaTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.EnforceConstraints = False
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiveTableAdapter
        '
        Me.ReceiveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.MRNoLookUpTableAdapter = Nothing
        Me.TableAdapterManager2.ReceiveTableAdapter = Me.ReceiveTableAdapter
        Me.TableAdapterManager2.UpdateOrder = KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowByItemButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.RqNoTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ClearButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1214, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(72, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(141, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 21)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(210, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(279, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Save F12"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search By Item Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(478, 4)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(1, 4, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.ItemListLookupBindingSource1
        Me.GridLookUpEdit1.Properties.DisplayMember = "ID-Name"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type or Select  Item Name]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView2
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ItemId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(182, 20)
        Me.GridLookUpEdit1.TabIndex = 5
        '
        'ItemListLookupBindingSource1
        '
        Me.ItemListLookupBindingSource1.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource1.DataSource = Me.ItemListDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colItemDescription, Me.colOriginId, Me.colBrandId, Me.colCategoryId, Me.colSubCategoryId, Me.colUnitId, Me.colQuantityPerPacket, Me.colPreviousPrice, Me.colCurrentPrice, Me.colDepartmentId, Me.colReorderLabel, Me.colExpireLabel})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colItemDescription
        '
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        '
        'colOriginId
        '
        Me.colOriginId.FieldName = "OriginId"
        Me.colOriginId.Name = "colOriginId"
        '
        'colBrandId
        '
        Me.colBrandId.FieldName = "BrandId"
        Me.colBrandId.Name = "colBrandId"
        '
        'colCategoryId
        '
        Me.colCategoryId.FieldName = "CategoryId"
        Me.colCategoryId.Name = "colCategoryId"
        '
        'colSubCategoryId
        '
        Me.colSubCategoryId.FieldName = "SubCategoryId"
        Me.colSubCategoryId.Name = "colSubCategoryId"
        '
        'colUnitId
        '
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        '
        'colQuantityPerPacket
        '
        Me.colQuantityPerPacket.FieldName = "QuantityPerPacket"
        Me.colQuantityPerPacket.Name = "colQuantityPerPacket"
        '
        'colPreviousPrice
        '
        Me.colPreviousPrice.FieldName = "PreviousPrice"
        Me.colPreviousPrice.Name = "colPreviousPrice"
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'colReorderLabel
        '
        Me.colReorderLabel.FieldName = "ReorderLabel"
        Me.colReorderLabel.Name = "colReorderLabel"
        '
        'colExpireLabel
        '
        Me.colExpireLabel.FieldName = "ExpireLabel"
        Me.colExpireLabel.Name = "colExpireLabel"
        '
        'ShowByItemButton
        '
        Me.ShowByItemButton.Location = New System.Drawing.Point(666, 3)
        Me.ShowByItemButton.Name = "ShowByItemButton"
        Me.ShowByItemButton.Size = New System.Drawing.Size(69, 24)
        Me.ShowByItemButton.TabIndex = 13
        Me.ShowByItemButton.Text = "&Show"
        Me.ShowByItemButton.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(741, 3)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Rq. No :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RqNoTextBox
        '
        Me.RqNoTextBox.Location = New System.Drawing.Point(809, 4)
        Me.RqNoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.RqNoTextBox.Name = "RqNoTextBox"
        Me.RqNoTextBox.Size = New System.Drawing.Size(130, 20)
        Me.RqNoTextBox.TabIndex = 11
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(945, 2)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(80, 23)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Show All"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1031, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Tag = "NR"
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VBookingLookupTableAdapter
        '
        Me.VBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'TotalIssueQuantityTableAdapter
        '
        Me.TotalIssueQuantityTableAdapter.ClearBeforeFill = True
        '
        'IssueReceiveTypeTableAdapter
        '
        Me.IssueReceiveTypeTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'YarnLotNoLookupTableAdapter
        '
        Me.YarnLotNoLookupTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'LotWiseReceivedIssuedTableAdapter
        '
        Me.LotWiseReceivedIssuedTableAdapter.ClearBeforeFill = True
        '
        'LotAndItemwiseBalanceTableAdapter
        '
        Me.LotAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'PIAndItemwiseBalanceTableAdapter
        '
        Me.PIAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'IssueGridControl
        '
        Me.IssueGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IssueGridControl.DataSource = Me.IssueBindingSource
        Me.IssueGridControl.Location = New System.Drawing.Point(3, 20)
        Me.IssueGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.IssueGridControl.MainView = Me.GridView3
        Me.IssueGridControl.Name = "IssueGridControl"
        Me.IssueGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemLookUpGridLookUpEdit, Me.SupplierLookupGridLookUpEdit, Me.IssueReceiveTypeGridLookUpEdit, Me.CompanyLookupGridLookUpEdit, Me.PIGridLookUpEdit, Me.BookingDetailsLookupGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.PINoGridLookUpEdit, Me.LCNoGridLookUpEdit, Me.KnittingOrderGridLookUpEdit, Me.YDOrGridLookUpEdit, Me.LCNoNewLookUpEdit, Me.RepositoryItemDateEdit1, Me.MenufactureLookUpEdit, Me.ExpiryDateLookUpEdit, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3})
        Me.IssueGridControl.Size = New System.Drawing.Size(1153, 170)
        Me.IssueGridControl.TabIndex = 3
        Me.IssueGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssueId, Me.colIssueDate, Me.colChallanNo, Me.colCompanyId, Me.colRequistionNo, Me.colIssueQuantity, Me.colBranchId1, Me.colPrice, Me.colPrintingMediaId, Me.colRemarks1, Me.colDepartmentId4, Me.colReceiveId, Me.colProgramNo2, Me.colBookingDetailsId1, Me.colSupplierId2, Me.colIssueReceiveTypeId1, Me.colItemId4, Me.colBrandId1, Me.colLotNo, Me.colPIId1, Me.colIsAllocatedIssue, Me.colKnittingOrderId, Me.colYDOrderId, Me.colManufactureDate1, Me.colExpiryDate, Me.colFinishFabricBookingId1, Me.colLeftOverQuantity, Me.colIsLeftOver, Me.colBAG, Me.colCTN, Me.colPKT, Me.colTransProgramNo, Me.colPIId21, Me.colYTRNo})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(839, 438, 216, 199)
        Me.GridView3.GridControl = Me.IssueGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFooter = True
        '
        'colIssueId
        '
        Me.colIssueId.FieldName = "IssueId"
        Me.colIssueId.Name = "colIssueId"
        Me.colIssueId.OptionsColumn.ReadOnly = True
        '
        'colIssueDate
        '
        Me.colIssueDate.FieldName = "IssueDate"
        Me.colIssueDate.Name = "colIssueDate"
        Me.colIssueDate.Visible = True
        Me.colIssueDate.VisibleIndex = 0
        Me.colIssueDate.Width = 94
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 1
        '
        'colCompanyId
        '
        Me.colCompanyId.Caption = "Company"
        Me.colCompanyId.ColumnEdit = Me.CompanyLookupGridLookUpEdit
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.Visible = True
        Me.colCompanyId.VisibleIndex = 2
        Me.colCompanyId.Width = 104
        '
        'CompanyLookupGridLookUpEdit
        '
        Me.CompanyLookupGridLookUpEdit.AutoHeight = False
        Me.CompanyLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyLookupGridLookUpEdit.DataSource = Me.CompanyBindingSource
        Me.CompanyLookupGridLookUpEdit.DisplayMember = "CompanyCode"
        Me.CompanyLookupGridLookUpEdit.Name = "CompanyLookupGridLookUpEdit"
        Me.CompanyLookupGridLookUpEdit.NullText = ""
        Me.CompanyLookupGridLookUpEdit.PopupView = Me.GridView6
        Me.CompanyLookupGridLookUpEdit.ValueMember = "CompanyId"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyId1, Me.colCompanyCode, Me.colCompanyName, Me.colFax, Me.colWebsite, Me.colContactPerson2, Me.colWeeklyOff})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colCompanyId1
        '
        Me.colCompanyId1.FieldName = "CompanyId"
        Me.colCompanyId1.Name = "colCompanyId1"
        Me.colCompanyId1.OptionsColumn.ReadOnly = True
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
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        '
        'colWebsite
        '
        Me.colWebsite.FieldName = "Website"
        Me.colWebsite.Name = "colWebsite"
        '
        'colContactPerson2
        '
        Me.colContactPerson2.FieldName = "ContactPerson"
        Me.colContactPerson2.Name = "colContactPerson2"
        '
        'colWeeklyOff
        '
        Me.colWeeklyOff.FieldName = "WeeklyOff"
        Me.colWeeklyOff.Name = "colWeeklyOff"
        '
        'colRequistionNo
        '
        Me.colRequistionNo.FieldName = "RequistionNo"
        Me.colRequistionNo.Name = "colRequistionNo"
        Me.colRequistionNo.Visible = True
        Me.colRequistionNo.VisibleIndex = 5
        Me.colRequistionNo.Width = 107
        '
        'colIssueQuantity
        '
        Me.colIssueQuantity.FieldName = "IssueQuantity"
        Me.colIssueQuantity.Name = "colIssueQuantity"
        Me.colIssueQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colIssueQuantity.Visible = True
        Me.colIssueQuantity.VisibleIndex = 7
        Me.colIssueQuantity.Width = 106
        '
        'colBranchId1
        '
        Me.colBranchId1.FieldName = "BranchId"
        Me.colBranchId1.Name = "colBranchId1"
        Me.colBranchId1.Width = 78
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 10
        '
        'colPrintingMediaId
        '
        Me.colPrintingMediaId.FieldName = "PrintingMediaId"
        Me.colPrintingMediaId.Name = "colPrintingMediaId"
        Me.colPrintingMediaId.Width = 106
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 21
        Me.colRemarks1.Width = 109
        '
        'colDepartmentId4
        '
        Me.colDepartmentId4.FieldName = "DepartmentId"
        Me.colDepartmentId4.Name = "colDepartmentId4"
        Me.colDepartmentId4.Width = 119
        '
        'colReceiveId
        '
        Me.colReceiveId.FieldName = "ReceiveId"
        Me.colReceiveId.Name = "colReceiveId"
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        Me.colProgramNo2.Visible = True
        Me.colProgramNo2.VisibleIndex = 12
        Me.colProgramNo2.Width = 101
        '
        'colBookingDetailsId1
        '
        Me.colBookingDetailsId1.FieldName = "BookingDetailsId"
        Me.colBookingDetailsId1.Name = "colBookingDetailsId1"
        Me.colBookingDetailsId1.Width = 119
        '
        'colSupplierId2
        '
        Me.colSupplierId2.Caption = "Supplier"
        Me.colSupplierId2.ColumnEdit = Me.SupplierLookupGridLookUpEdit
        Me.colSupplierId2.FieldName = "SupplierId"
        Me.colSupplierId2.Name = "colSupplierId2"
        Me.colSupplierId2.Visible = True
        Me.colSupplierId2.VisibleIndex = 3
        Me.colSupplierId2.Width = 118
        '
        'SupplierLookupGridLookUpEdit
        '
        Me.SupplierLookupGridLookUpEdit.AutoHeight = False
        Me.SupplierLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookupGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierLookupGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierLookupGridLookUpEdit.Name = "SupplierLookupGridLookUpEdit"
        Me.SupplierLookupGridLookUpEdit.NullText = ""
        Me.SupplierLookupGridLookUpEdit.PopupView = Me.GridView4
        Me.SupplierLookupGridLookUpEdit.ValueMember = "SupplierId"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId3, Me.colSupplierName1, Me.colAdd11, Me.colAdd21, Me.colContactPerson1, Me.colContactNo1, Me.colSupplierType1, Me.colSupplierCode1, Me.colCity1, Me.colCountry1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        Me.colSupplierId3.OptionsColumn.ReadOnly = True
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 0
        '
        'colAdd11
        '
        Me.colAdd11.FieldName = "Add1"
        Me.colAdd11.Name = "colAdd11"
        '
        'colAdd21
        '
        Me.colAdd21.FieldName = "Add2"
        Me.colAdd21.Name = "colAdd21"
        '
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        '
        'colContactNo1
        '
        Me.colContactNo1.FieldName = "ContactNo"
        Me.colContactNo1.Name = "colContactNo1"
        '
        'colSupplierType1
        '
        Me.colSupplierType1.FieldName = "SupplierType"
        Me.colSupplierType1.Name = "colSupplierType1"
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 1
        '
        'colCity1
        '
        Me.colCity1.FieldName = "City"
        Me.colCity1.Name = "colCity1"
        '
        'colCountry1
        '
        Me.colCountry1.FieldName = "Country"
        Me.colCountry1.Name = "colCountry1"
        '
        'colIssueReceiveTypeId1
        '
        Me.colIssueReceiveTypeId1.Caption = "Issue Receive Type"
        Me.colIssueReceiveTypeId1.ColumnEdit = Me.IssueReceiveTypeGridLookUpEdit
        Me.colIssueReceiveTypeId1.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId1.Name = "colIssueReceiveTypeId1"
        Me.colIssueReceiveTypeId1.Visible = True
        Me.colIssueReceiveTypeId1.VisibleIndex = 9
        Me.colIssueReceiveTypeId1.Width = 110
        '
        'IssueReceiveTypeGridLookUpEdit
        '
        Me.IssueReceiveTypeGridLookUpEdit.AutoHeight = False
        Me.IssueReceiveTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssueReceiveTypeGridLookUpEdit.DataSource = Me.IssueReceiveTypeBindingSource
        Me.IssueReceiveTypeGridLookUpEdit.DisplayMember = "IssueTypeName"
        Me.IssueReceiveTypeGridLookUpEdit.Name = "IssueReceiveTypeGridLookUpEdit"
        Me.IssueReceiveTypeGridLookUpEdit.NullText = ""
        Me.IssueReceiveTypeGridLookUpEdit.PopupView = Me.GridView5
        Me.IssueReceiveTypeGridLookUpEdit.ValueMember = "IssueReceiveTypeId"
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssueReceiveTypeId2, Me.colIssueTypeName, Me.colDescription})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colIssueReceiveTypeId2
        '
        Me.colIssueReceiveTypeId2.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId2.Name = "colIssueReceiveTypeId2"
        Me.colIssueReceiveTypeId2.OptionsColumn.ReadOnly = True
        '
        'colIssueTypeName
        '
        Me.colIssueTypeName.FieldName = "IssueTypeName"
        Me.colIssueTypeName.Name = "colIssueTypeName"
        Me.colIssueTypeName.Visible = True
        Me.colIssueTypeName.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colItemId4
        '
        Me.colItemId4.Caption = "Item Name"
        Me.colItemId4.ColumnEdit = Me.ItemLookUpGridLookUpEdit
        Me.colItemId4.FieldName = "ItemId"
        Me.colItemId4.Name = "colItemId4"
        Me.colItemId4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colItemId4.Visible = True
        Me.colItemId4.VisibleIndex = 4
        Me.colItemId4.Width = 178
        '
        'ItemLookUpGridLookUpEdit
        '
        Me.ItemLookUpGridLookUpEdit.AutoHeight = False
        Me.ItemLookUpGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookUpGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookUpGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemLookUpGridLookUpEdit.Name = "ItemLookUpGridLookUpEdit"
        Me.ItemLookUpGridLookUpEdit.NullText = ""
        Me.ItemLookUpGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.ItemLookUpGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemLookUpGridLookUpEdit.ValueMember = "ItemId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId5, Me.colItemName1, Me.colDepartmentId5, Me.GridColumn2})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemId5
        '
        Me.colItemId5.FieldName = "ItemId"
        Me.colItemId5.Name = "colItemId5"
        Me.colItemId5.OptionsColumn.ReadOnly = True
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'colDepartmentId5
        '
        Me.colDepartmentId5.FieldName = "DepartmentId"
        Me.colDepartmentId5.Name = "colDepartmentId5"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ID-Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'colBrandId1
        '
        Me.colBrandId1.FieldName = "BrandId"
        Me.colBrandId1.Name = "colBrandId1"
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 17
        '
        'colPIId1
        '
        Me.colPIId1.Caption = "PI No"
        Me.colPIId1.ColumnEdit = Me.PINoGridLookUpEdit
        Me.colPIId1.FieldName = "PIId"
        Me.colPIId1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPIId1.Name = "colPIId1"
        Me.colPIId1.Visible = True
        Me.colPIId1.VisibleIndex = 16
        Me.colPIId1.Width = 86
        '
        'PINoGridLookUpEdit
        '
        Me.PINoGridLookUpEdit.AutoHeight = False
        Me.PINoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PINoGridLookUpEdit.DataSource = Me.PILookUpBindingSource
        Me.PINoGridLookUpEdit.DisplayMember = "PINo"
        Me.PINoGridLookUpEdit.Name = "PINoGridLookUpEdit"
        Me.PINoGridLookUpEdit.NullText = ""
        Me.PINoGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.PINoGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PINoGridLookUpEdit.ValueMember = "PIId"
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPINo2})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colPINo2
        '
        Me.colPINo2.FieldName = "PINo"
        Me.colPINo2.Name = "colPINo2"
        Me.colPINo2.Visible = True
        Me.colPINo2.VisibleIndex = 0
        '
        'colIsAllocatedIssue
        '
        Me.colIsAllocatedIssue.FieldName = "IsAllocatedIssue"
        Me.colIsAllocatedIssue.Name = "colIsAllocatedIssue"
        Me.colIsAllocatedIssue.Width = 117
        '
        'colKnittingOrderId
        '
        Me.colKnittingOrderId.Caption = "Knitting Order"
        Me.colKnittingOrderId.ColumnEdit = Me.KnittingOrderGridLookUpEdit
        Me.colKnittingOrderId.FieldName = "KnittingOrderId"
        Me.colKnittingOrderId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colKnittingOrderId.Name = "colKnittingOrderId"
        Me.colKnittingOrderId.Visible = True
        Me.colKnittingOrderId.VisibleIndex = 13
        Me.colKnittingOrderId.Width = 97
        '
        'KnittingOrderGridLookUpEdit
        '
        Me.KnittingOrderGridLookUpEdit.AutoHeight = False
        Me.KnittingOrderGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingOrderGridLookUpEdit.DataSource = Me.KWOrderLookupBindingSource
        Me.KnittingOrderGridLookUpEdit.DisplayMember = "KnittingWorkOrderNo"
        Me.KnittingOrderGridLookUpEdit.Name = "KnittingOrderGridLookUpEdit"
        Me.KnittingOrderGridLookUpEdit.NullText = ""
        Me.KnittingOrderGridLookUpEdit.PopupView = Me.GridView11
        Me.KnittingOrderGridLookUpEdit.ValueMember = "KnittingOrderId"
        '
        'GridView11
        '
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colYDOrderId
        '
        Me.colYDOrderId.Caption = "YD Order"
        Me.colYDOrderId.ColumnEdit = Me.YDOrGridLookUpEdit
        Me.colYDOrderId.FieldName = "YDOrderId"
        Me.colYDOrderId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colYDOrderId.Name = "colYDOrderId"
        Me.colYDOrderId.Visible = True
        Me.colYDOrderId.VisibleIndex = 14
        Me.colYDOrderId.Width = 94
        '
        'YDOrGridLookUpEdit
        '
        Me.YDOrGridLookUpEdit.AutoHeight = False
        Me.YDOrGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YDOrGridLookUpEdit.DataSource = Me.YDOrderBindingSource
        Me.YDOrGridLookUpEdit.DisplayMember = "YDOrderNo"
        Me.YDOrGridLookUpEdit.Name = "YDOrGridLookUpEdit"
        Me.YDOrGridLookUpEdit.PopupView = Me.GridView12
        Me.YDOrGridLookUpEdit.ValueMember = "YDOrderId"
        '
        'GridView12
        '
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colManufactureDate1
        '
        Me.colManufactureDate1.FieldName = "ManufactureDate"
        Me.colManufactureDate1.Name = "colManufactureDate1"
        Me.colManufactureDate1.Visible = True
        Me.colManufactureDate1.VisibleIndex = 23
        '
        'colExpiryDate
        '
        Me.colExpiryDate.FieldName = "ExpiryDate"
        Me.colExpiryDate.Name = "colExpiryDate"
        Me.colExpiryDate.Visible = True
        Me.colExpiryDate.VisibleIndex = 24
        '
        'colFinishFabricBookingId1
        '
        Me.colFinishFabricBookingId1.Caption = "Program No :: Style :: Buyer"
        Me.colFinishFabricBookingId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colFinishFabricBookingId1.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId1.Name = "colFinishFabricBookingId1"
        Me.colFinishFabricBookingId1.Visible = True
        Me.colFinishFabricBookingId1.VisibleIndex = 11
        Me.colFinishFabricBookingId1.Width = 162
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Details"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.GridView16
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "FinishFabricBookingId"
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails2})
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'colLeftOverQuantity
        '
        Me.colLeftOverQuantity.FieldName = "LeftOverQuantity"
        Me.colLeftOverQuantity.Name = "colLeftOverQuantity"
        Me.colLeftOverQuantity.Visible = True
        Me.colLeftOverQuantity.VisibleIndex = 8
        Me.colLeftOverQuantity.Width = 117
        '
        'colIsLeftOver
        '
        Me.colIsLeftOver.FieldName = "IsLeftOver"
        Me.colIsLeftOver.Name = "colIsLeftOver"
        Me.colIsLeftOver.Visible = True
        Me.colIsLeftOver.VisibleIndex = 25
        '
        'colBAG
        '
        Me.colBAG.FieldName = "BAG"
        Me.colBAG.Name = "colBAG"
        Me.colBAG.Visible = True
        Me.colBAG.VisibleIndex = 18
        '
        'colCTN
        '
        Me.colCTN.FieldName = "CTN"
        Me.colCTN.Name = "colCTN"
        Me.colCTN.Visible = True
        Me.colCTN.VisibleIndex = 19
        '
        'colPKT
        '
        Me.colPKT.FieldName = "PKT"
        Me.colPKT.Name = "colPKT"
        Me.colPKT.Visible = True
        Me.colPKT.VisibleIndex = 20
        '
        'colTransProgramNo
        '
        Me.colTransProgramNo.FieldName = "TransProgramNo"
        Me.colTransProgramNo.Name = "colTransProgramNo"
        Me.colTransProgramNo.Visible = True
        Me.colTransProgramNo.VisibleIndex = 22
        '
        'colPIId21
        '
        Me.colPIId21.Caption = "LC No"
        Me.colPIId21.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colPIId21.FieldName = "PIId2"
        Me.colPIId21.Name = "colPIId21"
        Me.colPIId21.Visible = True
        Me.colPIId21.VisibleIndex = 15
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.LCNoLookUpFromPIIdBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "LCNo"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.RepositoryItemGridLookUpEdit3View
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "PIId"
        '
        'LCNoLookUpFromPIIdBindingSource
        '
        Me.LCNoLookUpFromPIIdBindingSource.DataMember = "LCNoLookUpFromPIId"
        Me.LCNoLookUpFromPIIdBindingSource.DataSource = Me.PILookUpDataSet
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 0
        '
        'colYTRNo
        '
        Me.colYTRNo.FieldName = "YTRNo"
        Me.colYTRNo.Name = "colYTRNo"
        Me.colYTRNo.Visible = True
        Me.colYTRNo.VisibleIndex = 6
        '
        'PIGridLookUpEdit
        '
        Me.PIGridLookUpEdit.AutoHeight = False
        Me.PIGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIGridLookUpEdit.DataSource = Me.PILookUpBindingSource
        Me.PIGridLookUpEdit.DisplayMember = "PINo"
        Me.PIGridLookUpEdit.Name = "PIGridLookUpEdit"
        Me.PIGridLookUpEdit.NullText = ""
        Me.PIGridLookUpEdit.PopupView = Me.GridView7
        Me.PIGridLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.PIGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PIGridLookUpEdit.ValueMember = "PIId"
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId2, Me.colPINo1})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colPIId2
        '
        Me.colPIId2.FieldName = "PIId"
        Me.colPIId2.Name = "colPIId2"
        Me.colPIId2.Visible = True
        Me.colPIId2.VisibleIndex = 0
        '
        'colPINo1
        '
        Me.colPINo1.FieldName = "PINo"
        Me.colPINo1.Name = "colPINo1"
        Me.colPINo1.Visible = True
        Me.colPINo1.VisibleIndex = 1
        '
        'BookingDetailsLookupGridLookUpEdit
        '
        Me.BookingDetailsLookupGridLookUpEdit.AutoHeight = False
        Me.BookingDetailsLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDetailsLookupGridLookUpEdit.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.BookingDetailsLookupGridLookUpEdit.DisplayMember = "Details"
        Me.BookingDetailsLookupGridLookUpEdit.Name = "BookingDetailsLookupGridLookUpEdit"
        Me.BookingDetailsLookupGridLookUpEdit.NullText = ""
        Me.BookingDetailsLookupGridLookUpEdit.PopupView = Me.GridView8
        Me.BookingDetailsLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo3, Me.colAmendmentNo1, Me.colFinishFabricBookingId2, Me.colDetails1, Me.colIsDevelopment1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo3
        '
        Me.colProgramNo3.FieldName = "ProgramNo"
        Me.colProgramNo3.Name = "colProgramNo3"
        '
        'colAmendmentNo1
        '
        Me.colAmendmentNo1.FieldName = "AmendmentNo"
        Me.colAmendmentNo1.Name = "colAmendmentNo1"
        '
        'colFinishFabricBookingId2
        '
        Me.colFinishFabricBookingId2.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId2.Name = "colFinishFabricBookingId2"
        Me.colFinishFabricBookingId2.OptionsColumn.ReadOnly = True
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.OptionsColumn.ReadOnly = True
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'colIsDevelopment1
        '
        Me.colIsDevelopment1.FieldName = "IsDevelopment"
        Me.colIsDevelopment1.Name = "colIsDevelopment1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'LCNoGridLookUpEdit
        '
        Me.LCNoGridLookUpEdit.AutoHeight = False
        Me.LCNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCNoGridLookUpEdit.DataSource = Me.LCNoLookUpFromPIIdBindingSource
        Me.LCNoGridLookUpEdit.DisplayMember = "LCNo"
        Me.LCNoGridLookUpEdit.Name = "LCNoGridLookUpEdit"
        Me.LCNoGridLookUpEdit.NullText = ""
        Me.LCNoGridLookUpEdit.PopupView = Me.GridView10
        Me.LCNoGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LCNoGridLookUpEdit.ValueMember = "PIId"
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo3})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colLCNo3
        '
        Me.colLCNo3.FieldName = "LCNo"
        Me.colLCNo3.Name = "colLCNo3"
        Me.colLCNo3.Visible = True
        Me.colLCNo3.VisibleIndex = 0
        '
        'LCNoNewLookUpEdit
        '
        Me.LCNoNewLookUpEdit.AutoHeight = False
        Me.LCNoNewLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCNoNewLookUpEdit.DataSource = Me.LCNoLookUpFromPIIdBindingSource
        Me.LCNoNewLookUpEdit.DisplayMember = "LCNo"
        Me.LCNoNewLookUpEdit.ImmediatePopup = True
        Me.LCNoNewLookUpEdit.Name = "LCNoNewLookUpEdit"
        Me.LCNoNewLookUpEdit.NullText = ""
        Me.LCNoNewLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LCNoNewLookUpEdit.PopupView = Me.GridView13
        Me.LCNoNewLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LCNoNewLookUpEdit.ValueMember = "PIId"
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo4})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'colLCNo4
        '
        Me.colLCNo4.FieldName = "LCNo"
        Me.colLCNo4.Name = "colLCNo4"
        Me.colLCNo4.Visible = True
        Me.colLCNo4.VisibleIndex = 0
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'MenufactureLookUpEdit
        '
        Me.MenufactureLookUpEdit.AutoHeight = False
        Me.MenufactureLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MenufactureLookUpEdit.DataSource = Me.ReceiveBindingSource
        Me.MenufactureLookUpEdit.DisplayMember = "ReceiveQuantity"
        Me.MenufactureLookUpEdit.ImmediatePopup = True
        Me.MenufactureLookUpEdit.Name = "MenufactureLookUpEdit"
        Me.MenufactureLookUpEdit.NullText = ""
        Me.MenufactureLookUpEdit.PopupView = Me.GridView14
        Me.MenufactureLookUpEdit.ValueMember = "ItemId"
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colManufactureDate, Me.colItemId2})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colManufactureDate
        '
        Me.colManufactureDate.FieldName = "ManufactureDate"
        Me.colManufactureDate.Name = "colManufactureDate"
        Me.colManufactureDate.Visible = True
        Me.colManufactureDate.VisibleIndex = 0
        '
        'colItemId2
        '
        Me.colItemId2.FieldName = "ItemId"
        Me.colItemId2.Name = "colItemId2"
        Me.colItemId2.Visible = True
        Me.colItemId2.VisibleIndex = 1
        '
        'ExpiryDateLookUpEdit
        '
        Me.ExpiryDateLookUpEdit.AutoHeight = False
        Me.ExpiryDateLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpiryDateLookUpEdit.DataSource = Me.ReceiveBindingSource
        Me.ExpiryDateLookUpEdit.DisplayMember = "ExpiryDate"
        Me.ExpiryDateLookUpEdit.Name = "ExpiryDateLookUpEdit"
        Me.ExpiryDateLookUpEdit.NullText = ""
        Me.ExpiryDateLookUpEdit.PopupView = Me.GridView15
        Me.ExpiryDateLookUpEdit.ReadOnly = True
        Me.ExpiryDateLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.ExpiryDateLookUpEdit.ValueMember = "ItemId"
        '
        'GridView15
        '
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'PIListBindingSource
        '
        Me.PIListBindingSource.DataMember = "PIList"
        Me.PIListBindingSource.DataSource = Me.PiListDataSet
        '
        'PiListDataSet
        '
        Me.PiListDataSet.DataSetName = "PiListDataSet"
        Me.PiListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(25, 372)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1167, 219)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ExportLinkLabel)
        Me.TabPage2.Controls.Add(Me.IssueGridControl)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1159, 193)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ExportLinkLabel
        '
        Me.ExportLinkLabel.AutoSize = True
        Me.ExportLinkLabel.Location = New System.Drawing.Point(7, 3)
        Me.ExportLinkLabel.Name = "ExportLinkLabel"
        Me.ExportLinkLabel.Size = New System.Drawing.Size(70, 13)
        Me.ExportLinkLabel.TabIndex = 4
        Me.ExportLinkLabel.TabStop = True
        Me.ExportLinkLabel.Text = "Export to files"
        '
        'AccessoriesListLookupTableAdapter1
        '
        Me.AccessoriesListLookupTableAdapter1.ClearBeforeFill = True
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PIListTableAdapter = Me.PIListTableAdapter
        Me.TableAdapterManager3.UpdateOrder = KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceivedMRNoLookupTableAdapter
        '
        Me.ReceivedMRNoLookupTableAdapter.ClearBeforeFill = True
        '
        'KWOrderLookupTableAdapter
        '
        Me.KWOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'PILookUpTableAdapter
        '
        Me.PILookUpTableAdapter.ClearBeforeFill = True
        '
        'colLCNo2
        '
        Me.colLCNo2.FieldName = "LCNo"
        Me.colLCNo2.Name = "colLCNo2"
        Me.colLCNo2.Visible = True
        Me.colLCNo2.VisibleIndex = 0
        '
        'YDOrderTableAdapter
        '
        Me.YDOrderTableAdapter.ClearBeforeFill = True
        '
        'colYDOrderNo1
        '
        Me.colYDOrderNo1.FieldName = "YDOrderNo"
        Me.colYDOrderNo1.Name = "colYDOrderNo1"
        Me.colYDOrderNo1.Visible = True
        Me.colYDOrderNo1.VisibleIndex = 0
        '
        'colKnittingWorkOrderNo
        '
        Me.colKnittingWorkOrderNo.FieldName = "KnittingWorkOrderNo"
        Me.colKnittingWorkOrderNo.Name = "colKnittingWorkOrderNo"
        Me.colKnittingWorkOrderNo.Visible = True
        Me.colKnittingWorkOrderNo.VisibleIndex = 0
        '
        'LotwiseHistoryTableAdapter
        '
        Me.LotwiseHistoryTableAdapter.ClearBeforeFill = True
        '
        'YBGenerationTableAdapter
        '
        Me.YBGenerationTableAdapter.ClearBeforeFill = True
        '
        'YDOrderDetailsBindingSource
        '
        Me.YDOrderDetailsBindingSource.DataMember = "YDOrderDetails"
        Me.YDOrderDetailsBindingSource.DataSource = Me.YDOrderLookupDataSet
        '
        'YDOrderDetailsTableAdapter
        '
        Me.YDOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'LCNoLookUpFromPIIdTableAdapter
        '
        Me.LCNoLookUpFromPIIdTableAdapter.ClearBeforeFill = True
        '
        'VBookingLookup1BindingSource
        '
        Me.VBookingLookup1BindingSource.DataMember = "vBookingLookup1"
        Me.VBookingLookup1BindingSource.DataSource = Me.BookingDataSet
        '
        'VBookingLookup1TableAdapter
        '
        Me.VBookingLookup1TableAdapter.ClearBeforeFill = True
        '
        'LotAndItemwiseBalanceNewTableAdapter
        '
        Me.LotAndItemwiseBalanceNewTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'frmIssuetofloor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 597)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmIssuetofloor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ActUnitGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLeftOverCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotwiseHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotwiseHistoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalIssueQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAllocatedIssueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemwiseBalanceNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemwiseBalanceNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YBGenerationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnBookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotWiseReceivedIssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnLotNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnLotNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookUpGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PINoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingOrderGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCNoLookUpFromPIIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCNoNewLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenufactureLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpiryDateLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PiListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBookingLookup1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CopyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IssueDataSet As KSoft_Inventory.IssueDataSet
    Friend WithEvents IssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueTableAdapter As KSoft_Inventory.IssueDataSetTableAdapters.IssueTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.IssueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequistionNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IssueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IssueQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchDataSet As KSoft_Inventory.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemNameDataSet As KSoft_Inventory.ItemNameDataSet
    Friend WithEvents VItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VItemListTableAdapter As KSoft_Inventory.ItemNameDataSetTableAdapters.vItemListTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MediaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MediaDataSet As KSoft_Inventory.MediaDataSet
    Friend WithEvents PrintingMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintingMediaTableAdapter As KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents ReceiveDataSet As KSoft_Inventory.ReceiveDataSet
    Friend WithEvents ReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiveTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter
    Friend WithEvents TableAdapterManager2 As KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents VBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingDataSet As KSoft_Inventory.BookingDataSet
    Friend WithEvents VBookingLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.vBookingLookupTableAdapter
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityPerPacket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreviousPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReorderLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpireLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceLabel As System.Windows.Forms.Label
    Friend WithEvents TotalIssueQuantityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalIssueQuantityTableAdapter As KSoft_Inventory.IssueDataSetTableAdapters.TotalIssueQuantityTableAdapter
    Friend WithEvents TotalIssueQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ItemBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents AIssuedLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReceiveBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents IssueTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IssueReceiveTypeDataSet As KSoft_Inventory.IssueReceiveTypeDataSet
    Friend WithEvents IssueReceiveTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueReceiveTypeTableAdapter As KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LotNoGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YarnLotNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnLotNoLookupDataSet As KSoft_Inventory.YarnLotNoLookupDataSet
    Friend WithEvents YarnLotNoLookupTableAdapter As KSoft_Inventory.YarnLotNoLookupDataSetTableAdapters.YarnLotNoLookupTableAdapter
    Friend WithEvents ReceiveIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ReceiveIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LotWiseReceivedIssuedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotWiseReceivedIssuedTableAdapter As KSoft_Inventory.YarnLotNoLookupDataSetTableAdapters.LotWiseReceivedIssuedTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SupplierLabel As System.Windows.Forms.Label
    Friend WithEvents LotAndItemwiseBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotAndItemBalanceDataSet As KSoft_Inventory.LotAndItemBalanceDataSet
    Friend WithEvents LotAndItemwiseBalanceTableAdapter As KSoft_Inventory.LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter
    Friend WithEvents PIAndItemwiseBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIAnditemwiseBalanceDataSet As KSoft_Inventory.PIAnditemwiseBalanceDataSet
    Friend WithEvents PIAndItemwiseBalanceTableAdapter As KSoft_Inventory.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter
    Friend WithEvents IssueGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIssueId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequistionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintingMediaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SupplierLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IssueReceiveTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemLookUpGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookingDetailsLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompanyId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWebsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeeklyOff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExportLinkLabel As System.Windows.Forms.LinkLabel
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
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents AccessoriesListLookupTableAdapter1 As KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
    Friend WithEvents KnittingOrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents KnittingOrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PiListDataSet As KSoft_Inventory.PiListDataSet
    Friend WithEvents PIListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListTableAdapter As KSoft_Inventory.PiListDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents TableAdapterManager3 As KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceivedMRNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceivedMRNoLookupTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter
    Friend WithEvents colChallanNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KWOrderLookupDataSet As KSoft_Inventory.KWOrderLookupDataSet
    Friend WithEvents KWOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KWOrderLookupTableAdapter As KSoft_Inventory.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter
    Friend WithEvents colSupplierName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsAllocatedIssueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PILookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PILookUpDataSet As KSoft_Inventory.PILookUpDataSet
    Friend WithEvents PILookUpTableAdapter As KSoft_Inventory.PILookUpDataSetTableAdapters.PILookUpTableAdapter
    Friend WithEvents colPIId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PINoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAllocatedIssue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YDOrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YDOrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYDOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnittingOrderGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYDOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YDOrGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YDOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderLookupDataSet As KSoft_Inventory.YDOrderLookupDataSet
    Friend WithEvents YDOrderTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter
    Friend WithEvents colYDOrderNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingWorkOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LotwiseHistoryDataSet As KSoft_Inventory.LotwiseHistoryDataSet
    Friend WithEvents LotwiseHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotwiseHistoryTableAdapter As KSoft_Inventory.LotwiseHistoryDataSetTableAdapters.LotwiseHistoryTableAdapter
    Friend WithEvents ReferenceNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RqNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YarnBookingDataSet As KSoft_Inventory.YarnBookingDataSet
    Friend WithEvents YBGenerationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YBGenerationTableAdapter As KSoft_Inventory.YarnBookingDataSetTableAdapters.YBGenerationTableAdapter
    Friend WithEvents YarnRquireLabel As System.Windows.Forms.Label
    Friend WithEvents YarnIssuedLabel As System.Windows.Forms.Label
    Friend WithEvents YarnBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents YDOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderDetailsTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter
    Friend WithEvents RequisitionNoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colLCNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LCNoLookUpFromPIIdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCNoLookUpFromPIIdTableAdapter As KSoft_Inventory.PILookUpDataSetTableAdapters.LCNoLookUpFromPIIdTableAdapter
    Friend WithEvents LCNoNewLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PKTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BAGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CTNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colLCNo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenufactureLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExpiryDateLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colManufactureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpiryDateDateTimePicker As DateTimePicker
    Friend WithEvents ManufactureDateDateTimePicker As DateTimePicker
    Friend WithEvents colManufactureDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpiryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsLeftOverCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LeftOverQtyTextBox As TextBox
    Friend WithEvents colLeftOverQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLeftOver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TransProgramNoTextBox As TextBox
    Friend WithEvents TransBookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBAG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCTN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPKT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VBookingLookup1BindingSource As BindingSource
    Friend WithEvents VBookingLookup1TableAdapter As BookingDataSetTableAdapters.vBookingLookup1TableAdapter
    Friend WithEvents ReturnLabel As Label
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnAllocationLabel As Label
    Friend WithEvents colCompanyCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByItemButton As Button
    Friend WithEvents colPINo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents YTRNoTextBox As TextBox
    Friend WithEvents colYTRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotAndItemwiseBalanceNewBindingSource As BindingSource
    Friend WithEvents LotAndItemwiseBalanceNewDataSet As LotAndItemwiseBalanceNewDataSet
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLIssue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhysicalStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotAndItemwiseBalanceNewTableAdapter As LotAndItemwiseBalanceNewDataSetTableAdapters.LotAndItemwiseBalanceNewTableAdapter
    Friend WithEvents ActIssueQtyTextBox As TextBox
    Friend WithEvents ActUnitGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As UnitDataSet
    Friend WithEvents UnitBindingSource As BindingSource
    Friend WithEvents UnitTableAdapter As UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
End Class
