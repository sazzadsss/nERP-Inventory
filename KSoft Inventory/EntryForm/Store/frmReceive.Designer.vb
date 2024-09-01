<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceive
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
        Dim ReceiveQuantityLabel As System.Windows.Forms.Label
        Dim BranchIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim ReceiveDateLabel As System.Windows.Forms.Label
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim TotalReceiveQuantityLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim ReceiveTypeLabel As System.Windows.Forms.Label
        Dim YarnLotNoLabel As System.Windows.Forms.Label
        Dim RequisitionIdLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim LocationIdLabel As System.Windows.Forms.Label
        Dim ForShadeLabel As System.Windows.Forms.Label
        Dim PIDateLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim FinishFabricBookingIdLabel As System.Windows.Forms.Label
        Dim KnittingOrderIdLabel As System.Windows.Forms.Label
        Dim YDOrderIdLabel As System.Windows.Forms.Label
        Dim PacketQuantityLabel As System.Windows.Forms.Label
        Dim QtyPerPacketLabel As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim ManufactureDateLabel As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DollarValueTextBox = New System.Windows.Forms.TextBox()
        Me.ReceiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDataSet = New KSoft_Inventory.ReceiveDataSet()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReceiveQuantity2TextBox = New System.Windows.Forms.TextBox()
        Me.ActUnitGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LotNoWOLCTextBox = New System.Windows.Forms.TextBox()
        Me.ReceiveQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.LeftoverQtyTextBox = New System.Windows.Forms.TextBox()
        Me.IsLeftOverCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ManufactureDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.MRRDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PacketQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QtyPerPacketTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.IsAlreadyIssuedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.MRRNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MRRNoTextBox = New System.Windows.Forms.TextBox()
        Me.YDOrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YDOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YDOrderLookupDataSet = New KSoft_Inventory.YDOrderLookupDataSet()
        Me.YDOrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYDOrderNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingOrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.KWOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KWOrderLookupDataSet = New KSoft_Inventory.KWOrderLookupDataSet()
        Me.KnittingOrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PIGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PIListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningLCDataSet = New KSoft_Inventory.OpeningLCDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LCListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TTLReceivedLabel = New System.Windows.Forms.Label()
        Me.ForShadeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpeningLCButton = New System.Windows.Forms.Button()
        Me.LocationIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemLocationDataSet = New KSoft_Inventory.ItemLocationDataSet()
        Me.LocationIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStepA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStepB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStepC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.RequisitionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RequisitionLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionDataSet = New KSoft_Inventory.RequisitionDataSet()
        Me.RequisitionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqNoAndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.YarnLotNoTextBox = New System.Windows.Forms.TextBox()
        Me.ImportedCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReceiveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueReceiveTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueReceiveTypeDataSet = New KSoft_Inventory.IssueReceiveTypeDataSet()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.TotalReceiveQuantityLabel2 = New System.Windows.Forms.Label()
        Me.TotalReceiveQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CopyCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChallanNoTextBox = New System.Windows.Forms.TextBox()
        Me.ReceiveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.VBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Inventory.BookingDataSet()
        Me.PIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PIAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIAnditemwiseBalanceDataSet = New KSoft_Inventory.PIAnditemwiseBalanceDataSet()
        Me.ReceivedMRNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New KSoft_Inventory.BrandDataSet()
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ItemNameSrchGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BookingProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.StartWithCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItemNameSearchTextBox = New System.Windows.Forms.TextBox()
        Me.ItemListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VBookingLookupTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.vBookingLookupTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ItemNameDataSet = New KSoft_Inventory.ItemNameDataSet()
        Me.VItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VItemListTableAdapter = New KSoft_Inventory.ItemNameDataSetTableAdapters.vItemListTableAdapter()
        Me.ItemNameTableAdapterManager = New KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager()
        Me.ItemListTableAdapter1 = New KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.BookingProgramNoLookupTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter()
        Me.TotalReceiveQuantityTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.TotalReceiveQuantityTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.IssueReceiveTypeTableAdapter = New KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter()
        Me.BrandTableAdapter = New KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.RequisitionLookupTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.ItemLocationTableAdapter = New KSoft_Inventory.ItemLocationDataSetTableAdapters.ItemLocationTableAdapter()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShowByItemButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ReceiveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChallanTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LCListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter()
        Me.PIListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter()
        Me.PIListLookupTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListLookupTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceiveId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImported = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueReceiveTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.IssueReceiveTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssueReceiveTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KOGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingWorkOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYDOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YDOrLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMRRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManufactureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpiryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricBookingGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftOverQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDollarValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReceivedMRNoLookupTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter()
        Me.PIAndItemwiseBalanceTableAdapter = New KSoft_Inventory.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter()
        Me.KWOrderLookupTableAdapter = New KSoft_Inventory.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter()
        Me.colSupplierName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YDOrderTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter()
        Me.colYDOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YDOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YDOrderDetailsTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        ReceiveQuantityLabel = New System.Windows.Forms.Label()
        BranchIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        ReceiveDateLabel = New System.Windows.Forms.Label()
        ChallanNoLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ProgramNoLabel = New System.Windows.Forms.Label()
        TotalReceiveQuantityLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        ReceiveTypeLabel = New System.Windows.Forms.Label()
        YarnLotNoLabel = New System.Windows.Forms.Label()
        RequisitionIdLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        LocationIdLabel = New System.Windows.Forms.Label()
        ForShadeLabel = New System.Windows.Forms.Label()
        PIDateLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        FinishFabricBookingIdLabel = New System.Windows.Forms.Label()
        KnittingOrderIdLabel = New System.Windows.Forms.Label()
        YDOrderIdLabel = New System.Windows.Forms.Label()
        PacketQuantityLabel = New System.Windows.Forms.Label()
        QtyPerPacketLabel = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        ManufactureDateLabel = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActUnitGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsLeftOverCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAlreadyIssuedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForShadeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLocationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalReceiveQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ItemNameSrchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReceiveQuantityLabel
        '
        ReceiveQuantityLabel.BackColor = System.Drawing.Color.Transparent
        ReceiveQuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReceiveQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ReceiveQuantityLabel.Location = New System.Drawing.Point(319, 189)
        ReceiveQuantityLabel.Name = "ReceiveQuantityLabel"
        ReceiveQuantityLabel.Size = New System.Drawing.Size(92, 20)
        ReceiveQuantityLabel.TabIndex = 23
        ReceiveQuantityLabel.Text = "On Date Receive :"
        ReceiveQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchIdLabel
        '
        BranchIdLabel.BackColor = System.Drawing.Color.Transparent
        BranchIdLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        BranchIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        BranchIdLabel.Location = New System.Drawing.Point(13, 47)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(80, 20)
        BranchIdLabel.TabIndex = 18
        BranchIdLabel.Text = "Branch :"
        BranchIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RemarksLabel
        '
        RemarksLabel.BackColor = System.Drawing.Color.Transparent
        RemarksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarksLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        RemarksLabel.Location = New System.Drawing.Point(319, 236)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(77, 20)
        RemarksLabel.TabIndex = 24
        RemarksLabel.Text = "Remarks:"
        RemarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReceiveDateLabel
        '
        ReceiveDateLabel.BackColor = System.Drawing.Color.Transparent
        ReceiveDateLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        ReceiveDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ReceiveDateLabel.Location = New System.Drawing.Point(13, 72)
        ReceiveDateLabel.Name = "ReceiveDateLabel"
        ReceiveDateLabel.Size = New System.Drawing.Size(80, 20)
        ReceiveDateLabel.TabIndex = 13
        ReceiveDateLabel.Text = "Receive Date:"
        ReceiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.BackColor = System.Drawing.Color.Transparent
        ChallanNoLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        ChallanNoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ChallanNoLabel.Location = New System.Drawing.Point(13, 98)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(80, 20)
        ChallanNoLabel.TabIndex = 14
        ChallanNoLabel.Text = "Challan No:"
        ChallanNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriceLabel
        '
        PriceLabel.BackColor = System.Drawing.Color.Transparent
        PriceLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        PriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PriceLabel.Location = New System.Drawing.Point(548, 161)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(38, 20)
        PriceLabel.TabIndex = 28
        PriceLabel.Text = "Price :"
        PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.BackColor = System.Drawing.Color.Transparent
        ProgramNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProgramNoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ProgramNoLabel.Location = New System.Drawing.Point(319, 43)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(92, 20)
        ProgramNoLabel.TabIndex = 20
        ProgramNoLabel.Text = "Prg / AWS No:"
        ProgramNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalReceiveQuantityLabel
        '
        TotalReceiveQuantityLabel.BackColor = System.Drawing.Color.Transparent
        TotalReceiveQuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalReceiveQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TotalReceiveQuantityLabel.Location = New System.Drawing.Point(319, 73)
        TotalReceiveQuantityLabel.Name = "TotalReceiveQuantityLabel"
        TotalReceiveQuantityLabel.Size = New System.Drawing.Size(92, 18)
        TotalReceiveQuantityLabel.TabIndex = 21
        TotalReceiveQuantityLabel.Text = "Already Receive :"
        TotalReceiveQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Arial", 8.0!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label5.Location = New System.Drawing.Point(555, 71)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(52, 20)
        Label5.TabIndex = 26
        Label5.Text = "Balance :"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.BackColor = System.Drawing.Color.Transparent
        SupplierIdLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        SupplierIdLabel.ForeColor = System.Drawing.Color.Maroon
        SupplierIdLabel.Location = New System.Drawing.Point(13, 173)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(80, 20)
        SupplierIdLabel.TabIndex = 17
        SupplierIdLabel.Text = "Supplier:"
        SupplierIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReceiveTypeLabel
        '
        ReceiveTypeLabel.BackColor = System.Drawing.Color.Transparent
        ReceiveTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReceiveTypeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ReceiveTypeLabel.Location = New System.Drawing.Point(319, 109)
        ReceiveTypeLabel.Name = "ReceiveTypeLabel"
        ReceiveTypeLabel.Size = New System.Drawing.Size(80, 20)
        ReceiveTypeLabel.TabIndex = 19
        ReceiveTypeLabel.Text = "Receive Type:"
        ReceiveTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YarnLotNoLabel
        '
        YarnLotNoLabel.BackColor = System.Drawing.Color.Transparent
        YarnLotNoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        YarnLotNoLabel.Location = New System.Drawing.Point(720, 136)
        YarnLotNoLabel.Name = "YarnLotNoLabel"
        YarnLotNoLabel.Size = New System.Drawing.Size(84, 20)
        YarnLotNoLabel.TabIndex = 0
        YarnLotNoLabel.Text = "LC No :: Lot No:"
        YarnLotNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RequisitionIdLabel
        '
        RequisitionIdLabel.BackColor = System.Drawing.Color.Transparent
        RequisitionIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RequisitionIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        RequisitionIdLabel.Location = New System.Drawing.Point(13, 121)
        RequisitionIdLabel.Name = "RequisitionIdLabel"
        RequisitionIdLabel.Size = New System.Drawing.Size(76, 20)
        RequisitionIdLabel.TabIndex = 0
        RequisitionIdLabel.Text = "Requisition:"
        RequisitionIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Arial", 8.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label4.Location = New System.Drawing.Point(13, 22)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(80, 20)
        Label4.TabIndex = 32
        Label4.Text = "Company:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocationIdLabel
        '
        LocationIdLabel.AutoSize = True
        LocationIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationIdLabel.Location = New System.Drawing.Point(720, 227)
        LocationIdLabel.Name = "LocationIdLabel"
        LocationIdLabel.Size = New System.Drawing.Size(54, 13)
        LocationIdLabel.TabIndex = 0
        LocationIdLabel.Text = "Location :"
        LocationIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ForShadeLabel
        '
        ForShadeLabel.AutoSize = True
        ForShadeLabel.Location = New System.Drawing.Point(720, 251)
        ForShadeLabel.Name = "ForShadeLabel"
        ForShadeLabel.Size = New System.Drawing.Size(59, 13)
        ForShadeLabel.TabIndex = 0
        ForShadeLabel.Text = "For Shade:"
        ForShadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PIDateLabel
        '
        PIDateLabel.AutoSize = True
        PIDateLabel.Location = New System.Drawing.Point(45, 446)
        PIDateLabel.Name = "PIDateLabel"
        PIDateLabel.Size = New System.Drawing.Size(46, 13)
        PIDateLabel.TabIndex = 0
        PIDateLabel.Text = "PI Date:"
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Arial", 8.0!)
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label8.Location = New System.Drawing.Point(13, 197)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(80, 20)
        Label8.TabIndex = 18
        Label8.Text = "LC No  :"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Arial", 8.0!)
        Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label10.Location = New System.Drawing.Point(13, 221)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(80, 20)
        Label10.TabIndex = 18
        Label10.Text = "PI No  :"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinishFabricBookingIdLabel
        '
        FinishFabricBookingIdLabel.AutoSize = True
        FinishFabricBookingIdLabel.Location = New System.Drawing.Point(319, 22)
        FinishFabricBookingIdLabel.Name = "FinishFabricBookingIdLabel"
        FinishFabricBookingIdLabel.Size = New System.Drawing.Size(90, 13)
        FinishFabricBookingIdLabel.TabIndex = 0
        FinishFabricBookingIdLabel.Text = "Fab. Booking No:"
        FinishFabricBookingIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KnittingOrderIdLabel
        '
        KnittingOrderIdLabel.AutoSize = True
        KnittingOrderIdLabel.Location = New System.Drawing.Point(556, 22)
        KnittingOrderIdLabel.Name = "KnittingOrderIdLabel"
        KnittingOrderIdLabel.Size = New System.Drawing.Size(77, 13)
        KnittingOrderIdLabel.TabIndex = 0
        KnittingOrderIdLabel.Text = "Knitting Order :"
        KnittingOrderIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'YDOrderIdLabel
        '
        YDOrderIdLabel.AutoSize = True
        YDOrderIdLabel.Location = New System.Drawing.Point(759, 23)
        YDOrderIdLabel.Name = "YDOrderIdLabel"
        YDOrderIdLabel.Size = New System.Drawing.Size(71, 13)
        YDOrderIdLabel.TabIndex = 0
        YDOrderIdLabel.Text = "YD Order No:"
        YDOrderIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PacketQuantityLabel
        '
        PacketQuantityLabel.AutoSize = True
        PacketQuantityLabel.Location = New System.Drawing.Point(549, 212)
        PacketQuantityLabel.Name = "PacketQuantityLabel"
        PacketQuantityLabel.Size = New System.Drawing.Size(86, 13)
        PacketQuantityLabel.TabIndex = 43
        PacketQuantityLabel.Text = "Packet Quantity:"
        '
        'QtyPerPacketLabel
        '
        QtyPerPacketLabel.AutoSize = True
        QtyPerPacketLabel.Location = New System.Drawing.Point(319, 212)
        QtyPerPacketLabel.Name = "QtyPerPacketLabel"
        QtyPerPacketLabel.Size = New System.Drawing.Size(82, 13)
        QtyPerPacketLabel.TabIndex = 44
        QtyPerPacketLabel.Text = "Qty Per Packet:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Location = New System.Drawing.Point(720, 275)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(60, 13)
        ReferenceLabel.TabIndex = 51
        ReferenceLabel.Text = "Reference:"
        '
        'ManufactureDateLabel
        '
        ManufactureDateLabel.AutoSize = True
        ManufactureDateLabel.Location = New System.Drawing.Point(13, 251)
        ManufactureDateLabel.Name = "ManufactureDateLabel"
        ManufactureDateLabel.Size = New System.Drawing.Size(96, 13)
        ManufactureDateLabel.TabIndex = 0
        ManufactureDateLabel.Text = "Manufacture Date:"
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.AutoSize = True
        ExpiryDateLabel.Location = New System.Drawing.Point(13, 276)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(64, 13)
        ExpiryDateLabel.TabIndex = 2
        ExpiryDateLabel.Text = "Expiry Date:"
        AddHandler ExpiryDateLabel.Click, AddressOf Me.ExpiryDateLabel_Click
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label11.Location = New System.Drawing.Point(720, 109)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(56, 20)
        Label11.TabIndex = 0
        Label11.Text = "Lot No:"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Me.DollarValueTextBox)
        Me.GroupBox1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ReceiveQuantity2TextBox)
        Me.GroupBox1.Controls.Add(Me.ActUnitGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.LotNoWOLCTextBox)
        Me.GroupBox1.Controls.Add(Me.ReceiveQuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.LeftoverQtyTextBox)
        Me.GroupBox1.Controls.Add(Me.IsLeftOverCheckEdit)
        Me.GroupBox1.Controls.Add(ExpiryDateLabel)
        Me.GroupBox1.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ManufactureDateLabel)
        Me.GroupBox1.Controls.Add(Me.ManufactureDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ReferenceLabel)
        Me.GroupBox1.Controls.Add(Me.ReferenceTextBox)
        Me.GroupBox1.Controls.Add(Me.MRRDateDateEdit)
        Me.GroupBox1.Controls.Add(PacketQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.PacketQuantityTextBox)
        Me.GroupBox1.Controls.Add(QtyPerPacketLabel)
        Me.GroupBox1.Controls.Add(Me.QtyPerPacketTextBox)
        Me.GroupBox1.Controls.Add(Me.GenerateButton)
        Me.GroupBox1.Controls.Add(Me.IsAlreadyIssuedCheckEdit)
        Me.GroupBox1.Controls.Add(Me.MRRNoLinkLabel)
        Me.GroupBox1.Controls.Add(Me.MRRNoTextBox)
        Me.GroupBox1.Controls.Add(YDOrderIdLabel)
        Me.GroupBox1.Controls.Add(Me.YDOrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(KnittingOrderIdLabel)
        Me.GroupBox1.Controls.Add(Me.KnittingOrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(FinishFabricBookingIdLabel)
        Me.GroupBox1.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.PIGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.LCIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TTLReceivedLabel)
        Me.GroupBox1.Controls.Add(ForShadeLabel)
        Me.GroupBox1.Controls.Add(Me.ForShadeComboBoxEdit)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.OpeningLCButton)
        Me.GroupBox1.Controls.Add(LocationIdLabel)
        Me.GroupBox1.Controls.Add(Me.LocationIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.CompanyIdComboBox)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(RequisitionIdLabel)
        Me.GroupBox1.Controls.Add(Me.RequisitionIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(YarnLotNoLabel)
        Me.GroupBox1.Controls.Add(Me.YarnLotNoTextBox)
        Me.GroupBox1.Controls.Add(Me.ImportedCheckBox)
        Me.GroupBox1.Controls.Add(ReceiveTypeLabel)
        Me.GroupBox1.Controls.Add(Me.ReceiveTypeComboBox)
        Me.GroupBox1.Controls.Add(SupplierIdLabel)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.BalanceLabel)
        Me.GroupBox1.Controls.Add(Me.TotalReceiveQuantityLabel2)
        Me.GroupBox1.Controls.Add(TotalReceiveQuantityLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ItemIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(ProgramNoLabel)
        Me.GroupBox1.Controls.Add(Me.BookingDetailsIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ProgramNoTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.CopyCheckBox)
        Me.GroupBox1.Controls.Add(ChallanNoLabel)
        Me.GroupBox1.Controls.Add(Me.ChallanNoTextBox)
        Me.GroupBox1.Controls.Add(ReceiveDateLabel)
        Me.GroupBox1.Controls.Add(Me.ReceiveDateDateTimePicker)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.Controls.Add(Me.BranchComboBox)
        Me.GroupBox1.Controls.Add(ReceiveQuantityLabel)
        Me.GroupBox1.Controls.Add(BranchIdLabel)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1162, 331)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receive Information"
        '
        'DollarValueTextBox
        '
        Me.DollarValueTextBox.BackColor = System.Drawing.Color.Yellow
        Me.DollarValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DollarValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "DollarValue", True))
        Me.DollarValueTextBox.Location = New System.Drawing.Point(637, 185)
        Me.DollarValueTextBox.Name = "DollarValueTextBox"
        Me.DollarValueTextBox.Size = New System.Drawing.Size(70, 20)
        Me.DollarValueTextBox.TabIndex = 11
        Me.DollarValueTextBox.Tag = "NR"
        '
        'ReceiveBindingSource
        '
        Me.ReceiveBindingSource.DataMember = "Receive"
        Me.ReceiveBindingSource.DataSource = Me.ReceiveDataSet
        '
        'ReceiveDataSet
        '
        Me.ReceiveDataSet.DataSetName = "ReceiveDataSet"
        Me.ReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "UnitId", True))
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(553, 185)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.UnitIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UnitIdGridLookUpEdit.Properties.PopupView = Me.GridView9
        Me.UnitIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(80, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 9
        Me.UnitIdGridLookUpEdit.Tag = "XTRAEDITOR"
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
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
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
        'ReceiveQuantity2TextBox
        '
        Me.ReceiveQuantity2TextBox.BackColor = System.Drawing.Color.Yellow
        Me.ReceiveQuantity2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiveQuantity2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "ActReceiveQuantity", True))
        Me.ReceiveQuantity2TextBox.Location = New System.Drawing.Point(415, 297)
        Me.ReceiveQuantity2TextBox.Name = "ReceiveQuantity2TextBox"
        Me.ReceiveQuantity2TextBox.Size = New System.Drawing.Size(132, 20)
        Me.ReceiveQuantity2TextBox.TabIndex = 10
        '
        'ActUnitGridLookUpEdit
        '
        Me.ActUnitGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "ActUnitId", True))
        Me.ActUnitGridLookUpEdit.Location = New System.Drawing.Point(551, 297)
        Me.ActUnitGridLookUpEdit.Name = "ActUnitGridLookUpEdit"
        Me.ActUnitGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActUnitGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.ActUnitGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ActUnitGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ActUnitGridLookUpEdit.Properties.NullText = ""
        Me.ActUnitGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActUnitGridLookUpEdit.Properties.PopupView = Me.GridView8
        Me.ActUnitGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActUnitGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ActUnitGridLookUpEdit.Size = New System.Drawing.Size(86, 20)
        Me.ActUnitGridLookUpEdit.TabIndex = 9
        Me.ActUnitGridLookUpEdit.Tag = "XTRAEDITOR"
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode1, Me.colUnitName1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 0
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        Me.colUnitName1.Visible = True
        Me.colUnitName1.VisibleIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(320, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 20)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Act. Received ."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LotNoWOLCTextBox
        '
        Me.LotNoWOLCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "LotNoWOLC", True))
        Me.LotNoWOLCTextBox.Location = New System.Drawing.Point(812, 110)
        Me.LotNoWOLCTextBox.Name = "LotNoWOLCTextBox"
        Me.LotNoWOLCTextBox.Size = New System.Drawing.Size(147, 20)
        Me.LotNoWOLCTextBox.TabIndex = 13
        '
        'ReceiveQuantityTextBox
        '
        Me.ReceiveQuantityTextBox.BackColor = System.Drawing.Color.Yellow
        Me.ReceiveQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiveQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "ReceiveQuantity", True))
        Me.ReceiveQuantityTextBox.Location = New System.Drawing.Point(415, 185)
        Me.ReceiveQuantityTextBox.Name = "ReceiveQuantityTextBox"
        Me.ReceiveQuantityTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ReceiveQuantityTextBox.TabIndex = 10
        '
        'LeftoverQtyTextBox
        '
        Me.LeftoverQtyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LeftoverQtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeftoverQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "LeftOverQuantity", True))
        Me.LeftoverQtyTextBox.Location = New System.Drawing.Point(416, 185)
        Me.LeftoverQtyTextBox.Name = "LeftoverQtyTextBox"
        Me.LeftoverQtyTextBox.Size = New System.Drawing.Size(131, 20)
        Me.LeftoverQtyTextBox.TabIndex = 53
        '
        'IsLeftOverCheckEdit
        '
        Me.IsLeftOverCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "IsLeftOver", True))
        Me.IsLeftOverCheckEdit.Location = New System.Drawing.Point(553, 110)
        Me.IsLeftOverCheckEdit.Name = "IsLeftOverCheckEdit"
        Me.IsLeftOverCheckEdit.Properties.Caption = "&Left Over"
        Me.IsLeftOverCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsLeftOverCheckEdit.TabIndex = 1
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiveBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(115, 273)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(177, 20)
        Me.ExpiryDateDateTimePicker.TabIndex = 3
        '
        'ManufactureDateDateTimePicker
        '
        Me.ManufactureDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ManufactureDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiveBindingSource, "ManufactureDate", True))
        Me.ManufactureDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ManufactureDateDateTimePicker.Location = New System.Drawing.Point(115, 247)
        Me.ManufactureDateDateTimePicker.Name = "ManufactureDateDateTimePicker"
        Me.ManufactureDateDateTimePicker.Size = New System.Drawing.Size(177, 20)
        Me.ManufactureDateDateTimePicker.TabIndex = 1
        '
        'ReferenceTextBox
        '
        Me.ReferenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "Reference", True))
        Me.ReferenceTextBox.Location = New System.Drawing.Point(812, 272)
        Me.ReferenceTextBox.Name = "ReferenceTextBox"
        Me.ReferenceTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ReferenceTextBox.TabIndex = 52
        '
        'MRRDateDateEdit
        '
        Me.MRRDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "MRRDate", True))
        Me.MRRDateDateEdit.EditValue = Nothing
        Me.MRRDateDateEdit.Location = New System.Drawing.Point(551, 272)
        Me.MRRDateDateEdit.Name = "MRRDateDateEdit"
        Me.MRRDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRRDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MRRDateDateEdit.Size = New System.Drawing.Size(86, 20)
        Me.MRRDateDateEdit.TabIndex = 48
        '
        'PacketQuantityTextBox
        '
        Me.PacketQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "PacketQuantity", True))
        Me.PacketQuantityTextBox.Location = New System.Drawing.Point(637, 209)
        Me.PacketQuantityTextBox.Name = "PacketQuantityTextBox"
        Me.PacketQuantityTextBox.Size = New System.Drawing.Size(70, 20)
        Me.PacketQuantityTextBox.TabIndex = 49
        '
        'QtyPerPacketTextBox
        '
        Me.QtyPerPacketTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "QtyPerPacket", True))
        Me.QtyPerPacketTextBox.Location = New System.Drawing.Point(415, 209)
        Me.QtyPerPacketTextBox.Name = "QtyPerPacketTextBox"
        Me.QtyPerPacketTextBox.Size = New System.Drawing.Size(132, 20)
        Me.QtyPerPacketTextBox.TabIndex = 45
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(643, 271)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(61, 23)
        Me.GenerateButton.TabIndex = 50
        Me.GenerateButton.Text = "Get"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'IsAlreadyIssuedCheckEdit
        '
        Me.IsAlreadyIssuedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "MRRDate", True))
        Me.IsAlreadyIssuedCheckEdit.Location = New System.Drawing.Point(812, 194)
        Me.IsAlreadyIssuedCheckEdit.Name = "IsAlreadyIssuedCheckEdit"
        Me.IsAlreadyIssuedCheckEdit.Properties.Caption = "Is Already Issued"
        Me.IsAlreadyIssuedCheckEdit.Size = New System.Drawing.Size(107, 19)
        Me.IsAlreadyIssuedCheckEdit.TabIndex = 47
        Me.IsAlreadyIssuedCheckEdit.Visible = False
        '
        'MRRNoLinkLabel
        '
        Me.MRRNoLinkLabel.AutoSize = True
        Me.MRRNoLinkLabel.Location = New System.Drawing.Point(318, 277)
        Me.MRRNoLinkLabel.Name = "MRRNoLinkLabel"
        Me.MRRNoLinkLabel.Size = New System.Drawing.Size(90, 13)
        Me.MRRNoLinkLabel.TabIndex = 42
        Me.MRRNoLinkLabel.TabStop = True
        Me.MRRNoLinkLabel.Text = "MRR No :: Date :"
        '
        'MRRNoTextBox
        '
        Me.MRRNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "MRRNo", True))
        Me.MRRNoTextBox.Enabled = False
        Me.MRRNoTextBox.Location = New System.Drawing.Point(415, 272)
        Me.MRRNoTextBox.Name = "MRRNoTextBox"
        Me.MRRNoTextBox.Size = New System.Drawing.Size(131, 20)
        Me.MRRNoTextBox.TabIndex = 41
        '
        'YDOrderIdGridLookUpEdit
        '
        Me.YDOrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "YDOrderId", True))
        Me.YDOrderIdGridLookUpEdit.Location = New System.Drawing.Point(839, 19)
        Me.YDOrderIdGridLookUpEdit.Name = "YDOrderIdGridLookUpEdit"
        Me.YDOrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YDOrderIdGridLookUpEdit.Properties.DataSource = Me.YDOrderBindingSource
        Me.YDOrderIdGridLookUpEdit.Properties.DisplayMember = "YDOrderNo"
        Me.YDOrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.YDOrderIdGridLookUpEdit.Properties.NullText = ""
        Me.YDOrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YDOrderIdGridLookUpEdit.Properties.PopupView = Me.YDOrderIdGridLookUpEditView
        Me.YDOrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YDOrderIdGridLookUpEdit.Properties.ValueMember = "YDOrderId"
        Me.YDOrderIdGridLookUpEdit.Size = New System.Drawing.Size(120, 20)
        Me.YDOrderIdGridLookUpEdit.TabIndex = 1
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
        Me.YDOrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYDOrderNo1})
        Me.YDOrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YDOrderIdGridLookUpEditView.Name = "YDOrderIdGridLookUpEditView"
        Me.YDOrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YDOrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colYDOrderNo1
        '
        Me.colYDOrderNo1.FieldName = "YDOrderNo"
        Me.colYDOrderNo1.Name = "colYDOrderNo1"
        Me.colYDOrderNo1.Visible = True
        Me.colYDOrderNo1.VisibleIndex = 0
        '
        'KnittingOrderIdGridLookUpEdit
        '
        Me.KnittingOrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "KnittingOrderId", True))
        Me.KnittingOrderIdGridLookUpEdit.Location = New System.Drawing.Point(634, 18)
        Me.KnittingOrderIdGridLookUpEdit.Name = "KnittingOrderIdGridLookUpEdit"
        Me.KnittingOrderIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.KnittingOrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingOrderIdGridLookUpEdit.Properties.DataSource = Me.KWOrderLookupBindingSource
        Me.KnittingOrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.KnittingOrderIdGridLookUpEdit.Properties.NullText = ""
        Me.KnittingOrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KnittingOrderIdGridLookUpEdit.Properties.PopupView = Me.KnittingOrderIdGridLookUpEditView
        Me.KnittingOrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingOrderIdGridLookUpEdit.Properties.ValueMember = "KnittingOrderId"
        Me.KnittingOrderIdGridLookUpEdit.Size = New System.Drawing.Size(119, 20)
        Me.KnittingOrderIdGridLookUpEdit.TabIndex = 1
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
        Me.KnittingOrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails6, Me.colSupplierName4})
        Me.KnittingOrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.KnittingOrderIdGridLookUpEditView.Name = "KnittingOrderIdGridLookUpEditView"
        Me.KnittingOrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.KnittingOrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails6
        '
        Me.colDetails6.FieldName = "Details"
        Me.colDetails6.Name = "colDetails6"
        Me.colDetails6.Visible = True
        Me.colDetails6.VisibleIndex = 0
        '
        'colSupplierName4
        '
        Me.colSupplierName4.FieldName = "SupplierName"
        Me.colSupplierName4.Name = "colSupplierName4"
        Me.colSupplierName4.Visible = True
        Me.colSupplierName4.VisibleIndex = 1
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "FinishFabricBookingId", True))
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(415, 18)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupView = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingId"
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(134, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 1
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
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails5})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails5
        '
        Me.colDetails5.FieldName = "Details"
        Me.colDetails5.Name = "colDetails5"
        Me.colDetails5.Visible = True
        Me.colDetails5.VisibleIndex = 0
        '
        'PIGridLookUpEdit
        '
        Me.PIGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "PIId", True))
        Me.PIGridLookUpEdit.Location = New System.Drawing.Point(115, 222)
        Me.PIGridLookUpEdit.Name = "PIGridLookUpEdit"
        Me.PIGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PIGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIGridLookUpEdit.Properties.DataSource = Me.PIListLookupBindingSource
        Me.PIGridLookUpEdit.Properties.DisplayMember = "PINo"
        Me.PIGridLookUpEdit.Properties.NullText = ""
        Me.PIGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.PIGridLookUpEdit.Properties.ReadOnly = True
        Me.PIGridLookUpEdit.Properties.ValueMember = "PIId"
        Me.PIGridLookUpEdit.Size = New System.Drawing.Size(177, 20)
        Me.PIGridLookUpEdit.TabIndex = 39
        '
        'PIListLookupBindingSource
        '
        Me.PIListLookupBindingSource.DataMember = "PIListLookup"
        Me.PIListLookupBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'OpeningLCDataSet
        '
        Me.OpeningLCDataSet.DataSetName = "OpeningLCDataSet"
        Me.OpeningLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId1, Me.colLCNo1, Me.colPIId, Me.colPINo, Me.colDepartmentId5, Me.colItemName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colLCId1
        '
        Me.colLCId1.FieldName = "LCId"
        Me.colLCId1.Name = "colLCId1"
        Me.colLCId1.OptionsColumn.ReadOnly = True
        '
        'colLCNo1
        '
        Me.colLCNo1.FieldName = "LCNo"
        Me.colLCNo1.Name = "colLCNo1"
        Me.colLCNo1.Visible = True
        Me.colLCNo1.VisibleIndex = 0
        '
        'colPIId
        '
        Me.colPIId.FieldName = "PIId"
        Me.colPIId.Name = "colPIId"
        Me.colPIId.OptionsColumn.ReadOnly = True
        '
        'colPINo
        '
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Name = "colPINo"
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 1
        '
        'colDepartmentId5
        '
        Me.colDepartmentId5.FieldName = "DepartmentId"
        Me.colDepartmentId5.Name = "colDepartmentId5"
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 2
        '
        'LCIdGridLookUpEdit
        '
        Me.LCIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "LCId", True))
        Me.LCIdGridLookUpEdit.Location = New System.Drawing.Point(115, 198)
        Me.LCIdGridLookUpEdit.Name = "LCIdGridLookUpEdit"
        Me.LCIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCIdGridLookUpEdit.Properties.DataSource = Me.LCListBindingSource
        Me.LCIdGridLookUpEdit.Properties.DisplayMember = "LCNo"
        Me.LCIdGridLookUpEdit.Properties.NullText = ""
        Me.LCIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LCIdGridLookUpEdit.Properties.PopupView = Me.GridView3
        Me.LCIdGridLookUpEdit.Properties.ReadOnly = True
        Me.LCIdGridLookUpEdit.Properties.ValueMember = "LCId"
        Me.LCIdGridLookUpEdit.Size = New System.Drawing.Size(177, 20)
        Me.LCIdGridLookUpEdit.TabIndex = 38
        '
        'LCListBindingSource
        '
        Me.LCListBindingSource.DataMember = "LCList"
        Me.LCListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId, Me.colLCNo, Me.colDepartmentId4, Me.colSupplierId1, Me.colLCDate, Me.colCompanyId, Me.colBuyerId, Me.colRemarks})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colLCId
        '
        Me.colLCId.FieldName = "LCId"
        Me.colLCId.Name = "colLCId"
        Me.colLCId.OptionsColumn.ReadOnly = True
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 0
        '
        'colDepartmentId4
        '
        Me.colDepartmentId4.FieldName = "DepartmentId"
        Me.colDepartmentId4.Name = "colDepartmentId4"
        '
        'colSupplierId1
        '
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        '
        'colCompanyId
        '
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(319, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "TTL Received."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTLReceivedLabel
        '
        Me.TTLReceivedLabel.BackColor = System.Drawing.Color.Transparent
        Me.TTLReceivedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTLReceivedLabel.Location = New System.Drawing.Point(415, 159)
        Me.TTLReceivedLabel.Name = "TTLReceivedLabel"
        Me.TTLReceivedLabel.Size = New System.Drawing.Size(131, 23)
        Me.TTLReceivedLabel.TabIndex = 36
        Me.TTLReceivedLabel.Text = "0"
        Me.TTLReceivedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ForShadeComboBoxEdit
        '
        Me.ForShadeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "ForShade", True))
        Me.ForShadeComboBoxEdit.Location = New System.Drawing.Point(812, 246)
        Me.ForShadeComboBoxEdit.Name = "ForShadeComboBoxEdit"
        Me.ForShadeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ForShadeComboBoxEdit.Properties.Items.AddRange(New Object() {"", "Dark", "Light", "Both"})
        Me.ForShadeComboBoxEdit.Size = New System.Drawing.Size(147, 20)
        Me.ForShadeComboBoxEdit.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(812, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpeningLCButton
        '
        Me.OpeningLCButton.Location = New System.Drawing.Point(230, 147)
        Me.OpeningLCButton.Name = "OpeningLCButton"
        Me.OpeningLCButton.Size = New System.Drawing.Size(62, 23)
        Me.OpeningLCButton.TabIndex = 33
        Me.OpeningLCButton.Text = "O/LC"
        Me.OpeningLCButton.UseVisualStyleBackColor = True
        '
        'LocationIdGridLookUpEdit
        '
        Me.LocationIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "LocationId", True))
        Me.LocationIdGridLookUpEdit.Location = New System.Drawing.Point(812, 221)
        Me.LocationIdGridLookUpEdit.Name = "LocationIdGridLookUpEdit"
        Me.LocationIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LocationIdGridLookUpEdit.Properties.DataSource = Me.ItemLocationBindingSource
        Me.LocationIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.LocationIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.LocationIdGridLookUpEdit.Properties.NullText = ""
        Me.LocationIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LocationIdGridLookUpEdit.Properties.PopupView = Me.LocationIdGridLookUpEditView
        Me.LocationIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LocationIdGridLookUpEdit.Properties.ValueMember = "LocationId"
        Me.LocationIdGridLookUpEdit.Size = New System.Drawing.Size(147, 20)
        Me.LocationIdGridLookUpEdit.TabIndex = 1
        Me.LocationIdGridLookUpEdit.ToolTip = "Where u want to keep your goods.."
        '
        'ItemLocationBindingSource
        '
        Me.ItemLocationBindingSource.DataMember = "ItemLocation"
        Me.ItemLocationBindingSource.DataSource = Me.ItemLocationDataSet
        '
        'ItemLocationDataSet
        '
        Me.ItemLocationDataSet.DataSetName = "ItemLocationDataSet"
        Me.ItemLocationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationIdGridLookUpEditView
        '
        Me.LocationIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStepA, Me.colStepB, Me.colStepC, Me.colDepartmentId, Me.colDetails, Me.colLocationId})
        Me.LocationIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LocationIdGridLookUpEditView.Name = "LocationIdGridLookUpEditView"
        Me.LocationIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LocationIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStepA
        '
        Me.colStepA.FieldName = "StepA"
        Me.colStepA.Name = "colStepA"
        Me.colStepA.Visible = True
        Me.colStepA.VisibleIndex = 0
        '
        'colStepB
        '
        Me.colStepB.FieldName = "StepB"
        Me.colStepB.Name = "colStepB"
        Me.colStepB.Visible = True
        Me.colStepB.VisibleIndex = 1
        '
        'colStepC
        '
        Me.colStepC.FieldName = "StepC"
        Me.colStepC.Name = "colStepC"
        Me.colStepC.Visible = True
        Me.colStepC.VisibleIndex = 2
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        '
        'colLocationId
        '
        Me.colLocationId.FieldName = "LocationId"
        Me.colLocationId.Name = "colLocationId"
        Me.colLocationId.OptionsColumn.ReadOnly = True
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.BackColor = System.Drawing.Color.Yellow
        Me.CompanyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceiveBindingSource, "CompanyId", True))
        Me.CompanyIdComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyIdComboBox.DisplayMember = "CompanyCode"
        Me.CompanyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(115, 22)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(120, 21)
        Me.CompanyIdComboBox.TabIndex = 1
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
        'RequisitionIdGridLookUpEdit
        '
        Me.RequisitionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "RequisitionId", True))
        Me.RequisitionIdGridLookUpEdit.Location = New System.Drawing.Point(115, 123)
        Me.RequisitionIdGridLookUpEdit.Name = "RequisitionIdGridLookUpEdit"
        Me.RequisitionIdGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.Cyan
        Me.RequisitionIdGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RequisitionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequisitionIdGridLookUpEdit.Properties.DataSource = Me.RequisitionLookupBindingSource
        Me.RequisitionIdGridLookUpEdit.Properties.DisplayMember = "ReqNoAndDate"
        Me.RequisitionIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.RequisitionIdGridLookUpEdit.Properties.NullText = ""
        Me.RequisitionIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RequisitionIdGridLookUpEdit.Properties.PopupView = Me.RequisitionIdGridLookUpEditView
        Me.RequisitionIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RequisitionIdGridLookUpEdit.Properties.ValueMember = "RequisitionId"
        Me.RequisitionIdGridLookUpEdit.Size = New System.Drawing.Size(177, 20)
        Me.RequisitionIdGridLookUpEdit.TabIndex = 1
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
        'RequisitionIdGridLookUpEditView
        '
        Me.RequisitionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionId, Me.colRequisitionNo, Me.colRequisitionDate, Me.colDepartmentId3, Me.colReqNoAndDate})
        Me.RequisitionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RequisitionIdGridLookUpEditView.Name = "RequisitionIdGridLookUpEditView"
        Me.RequisitionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RequisitionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colRequisitionId
        '
        Me.colRequisitionId.FieldName = "RequisitionId"
        Me.colRequisitionId.Name = "colRequisitionId"
        Me.colRequisitionId.OptionsColumn.ReadOnly = True
        '
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.Name = "colRequisitionNo"
        Me.colRequisitionNo.Visible = True
        Me.colRequisitionNo.VisibleIndex = 0
        '
        'colRequisitionDate
        '
        Me.colRequisitionDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.colRequisitionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colRequisitionDate.FieldName = "RequisitionDate"
        Me.colRequisitionDate.Name = "colRequisitionDate"
        Me.colRequisitionDate.Visible = True
        Me.colRequisitionDate.VisibleIndex = 1
        '
        'colDepartmentId3
        '
        Me.colDepartmentId3.FieldName = "DepartmentId"
        Me.colDepartmentId3.Name = "colDepartmentId3"
        '
        'colReqNoAndDate
        '
        Me.colReqNoAndDate.FieldName = "ReqNoAndDate"
        Me.colReqNoAndDate.Name = "colReqNoAndDate"
        Me.colReqNoAndDate.OptionsColumn.ReadOnly = True
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(115, 174)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(177, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 4
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
        'YarnLotNoTextBox
        '
        Me.YarnLotNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "YarnLotNo", True))
        Me.YarnLotNoTextBox.Location = New System.Drawing.Point(723, 162)
        Me.YarnLotNoTextBox.Name = "YarnLotNoTextBox"
        Me.YarnLotNoTextBox.ReadOnly = True
        Me.YarnLotNoTextBox.Size = New System.Drawing.Size(236, 20)
        Me.YarnLotNoTextBox.TabIndex = 13
        '
        'ImportedCheckBox
        '
        Me.ImportedCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.ImportedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ReceiveBindingSource, "Imported", True))
        Me.ImportedCheckBox.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ImportedCheckBox.ForeColor = System.Drawing.Color.Maroon
        Me.ImportedCheckBox.Location = New System.Drawing.Point(115, 148)
        Me.ImportedCheckBox.Name = "ImportedCheckBox"
        Me.ImportedCheckBox.Size = New System.Drawing.Size(80, 20)
        Me.ImportedCheckBox.TabIndex = 15
        Me.ImportedCheckBox.Text = "Imported"
        Me.ImportedCheckBox.UseVisualStyleBackColor = False
        '
        'ReceiveTypeComboBox
        '
        Me.ReceiveTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceiveBindingSource, "IssueReceiveTypeId", True))
        Me.ReceiveTypeComboBox.DataSource = Me.IssueReceiveTypeBindingSource
        Me.ReceiveTypeComboBox.DisplayMember = "IssueTypeName"
        Me.ReceiveTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReceiveTypeComboBox.FormattingEnabled = True
        Me.ReceiveTypeComboBox.Location = New System.Drawing.Point(415, 110)
        Me.ReceiveTypeComboBox.Name = "ReceiveTypeComboBox"
        Me.ReceiveTypeComboBox.Size = New System.Drawing.Size(131, 21)
        Me.ReceiveTypeComboBox.TabIndex = 6
        Me.ReceiveTypeComboBox.ValueMember = "IssueReceiveTypeId"
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
        'BalanceLabel
        '
        Me.BalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BalanceLabel.Location = New System.Drawing.Point(613, 70)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(109, 22)
        Me.BalanceLabel.TabIndex = 27
        '
        'TotalReceiveQuantityLabel2
        '
        Me.TotalReceiveQuantityLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalReceiveQuantityLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalReceiveQuantityBindingSource, "TotalReceiveQuantity", True))
        Me.TotalReceiveQuantityLabel2.Location = New System.Drawing.Point(415, 71)
        Me.TotalReceiveQuantityLabel2.Name = "TotalReceiveQuantityLabel2"
        Me.TotalReceiveQuantityLabel2.Size = New System.Drawing.Size(131, 21)
        Me.TotalReceiveQuantityLabel2.TabIndex = 25
        '
        'TotalReceiveQuantityBindingSource
        '
        Me.TotalReceiveQuantityBindingSource.DataMember = "TotalReceiveQuantity"
        Me.TotalReceiveQuantityBindingSource.DataSource = Me.ReceiveDataSet
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(319, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Item ID/&Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ItemIdGridLookUpEdit
        '
        Me.ItemIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "ItemId", True))
        Me.ItemIdGridLookUpEdit.Location = New System.Drawing.Point(415, 135)
        Me.ItemIdGridLookUpEdit.Name = "ItemIdGridLookUpEdit"
        Me.ItemIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIdGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemIdGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ItemIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemIdGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ItemIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemIdGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemIdGridLookUpEdit.Size = New System.Drawing.Size(292, 20)
        Me.ItemIdGridLookUpEdit.TabIndex = 9
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.ReadOnly = True
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 50
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 1
        '
        'BookingDetailsIdGridLookUpEdit
        '
        Me.BookingDetailsIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceiveBindingSource, "BookingDetailsId", True))
        Me.BookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(555, 44)
        Me.BookingDetailsIdGridLookUpEdit.Name = "BookingDetailsIdGridLookUpEdit"
        Me.BookingDetailsIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.BookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDetailsIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.BookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(404, 20)
        Me.BookingDetailsIdGridLookUpEdit.TabIndex = 8
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
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(415, 44)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ProgramNoTextBox.TabIndex = 7
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.Color.Yellow
        Me.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(637, 161)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(70, 20)
        Me.PriceTextBox.TabIndex = 11
        Me.PriceTextBox.Tag = "NR"
        '
        'CopyCheckBox
        '
        Me.CopyCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.CopyCheckBox.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CopyCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CopyCheckBox.Location = New System.Drawing.Point(241, 22)
        Me.CopyCheckBox.Name = "CopyCheckBox"
        Me.CopyCheckBox.Size = New System.Drawing.Size(51, 20)
        Me.CopyCheckBox.TabIndex = 30
        Me.CopyCheckBox.Text = "&Copy"
        Me.CopyCheckBox.UseVisualStyleBackColor = False
        '
        'ChallanNoTextBox
        '
        Me.ChallanNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "ChallanNo", True))
        Me.ChallanNoTextBox.Location = New System.Drawing.Point(115, 98)
        Me.ChallanNoTextBox.Name = "ChallanNoTextBox"
        Me.ChallanNoTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ChallanNoTextBox.TabIndex = 1
        '
        'ReceiveDateDateTimePicker
        '
        Me.ReceiveDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ReceiveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiveBindingSource, "ReceiveDate", True))
        Me.ReceiveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiveDateDateTimePicker.Location = New System.Drawing.Point(115, 74)
        Me.ReceiveDateDateTimePicker.Name = "ReceiveDateDateTimePicker"
        Me.ReceiveDateDateTimePicker.Size = New System.Drawing.Size(177, 20)
        Me.ReceiveDateDateTimePicker.TabIndex = 0
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(415, 235)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(292, 21)
        Me.RemarksTextBox.TabIndex = 12
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceiveBindingSource, "BranchId", True))
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(115, 47)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(177, 21)
        Me.BranchComboBox.TabIndex = 5
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.AutoScroll = True
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1156, 312)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 322
        Me.LineShape1.X2 = 955
        Me.LineShape1.Y1 = 86
        Me.LineShape1.Y2 = 86
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
        'PIDateTimePicker
        '
        Me.PIDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.PIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiveBindingSource, "PIDate", True))
        Me.PIDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PIDateTimePicker.Location = New System.Drawing.Point(127, 443)
        Me.PIDateTimePicker.Name = "PIDateTimePicker"
        Me.PIDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.PIDateTimePicker.TabIndex = 35
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
        'ReceivedMRNoLookupBindingSource
        '
        Me.ReceivedMRNoLookupBindingSource.DataMember = "ReceivedMRNoLookup"
        Me.ReceivedMRNoLookupBindingSource.DataSource = Me.ReceiveDataSet
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
        'PIListBindingSource
        '
        Me.PIListBindingSource.DataMember = "PIList"
        Me.PIListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'ReceiveTableAdapter
        '
        Me.ReceiveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MRNoLookUpTableAdapter = Nothing
        Me.TableAdapterManager.ReceiveTableAdapter = Me.ReceiveTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'PIListBindingSource1
        '
        Me.PIListBindingSource1.DataMember = "PIList"
        Me.PIListBindingSource1.DataSource = Me.OpeningLCDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.EnforceConstraints = False
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search By Item Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1186, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
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
        Me.NewButton.Tag = ""
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
        'ItemNameSrchGridLookUpEdit
        '
        Me.ItemNameSrchGridLookUpEdit.Location = New System.Drawing.Point(142, 3)
        Me.ItemNameSrchGridLookUpEdit.Name = "ItemNameSrchGridLookUpEdit"
        Me.ItemNameSrchGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameSrchGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameSrchGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ItemNameSrchGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemNameSrchGridLookUpEdit.Properties.NullText = "[Type an item name]"
        Me.ItemNameSrchGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameSrchGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.ItemNameSrchGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameSrchGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemNameSrchGridLookUpEdit.Size = New System.Drawing.Size(146, 20)
        Me.ItemNameSrchGridLookUpEdit.TabIndex = 12
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID :: Item Name"
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(345, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Program No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(424, 4)
        Me.ProgramNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.BookingProgramNoLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Type Program No]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "AWSNo"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(116, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 7
        '
        'BookingProgramNoLookupBindingSource
        '
        Me.BookingProgramNoLookupBindingSource.DataMember = "BookingProgramNoLookup"
        Me.BookingProgramNoLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails7})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails7
        '
        Me.colDetails7.FieldName = "Details"
        Me.colDetails7.Name = "colDetails7"
        Me.colDetails7.Visible = True
        Me.colDetails7.VisibleIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(968, 2)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(71, 22)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Show All"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StartWithCheckBox
        '
        Me.StartWithCheckBox.Checked = True
        Me.StartWithCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartWithCheckBox.ForeColor = System.Drawing.Color.Black
        Me.StartWithCheckBox.Location = New System.Drawing.Point(190, 61)
        Me.StartWithCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.StartWithCheckBox.Name = "StartWithCheckBox"
        Me.StartWithCheckBox.Size = New System.Drawing.Size(83, 20)
        Me.StartWithCheckBox.TabIndex = 10
        Me.StartWithCheckBox.Text = "StartWith"
        Me.StartWithCheckBox.UseVisualStyleBackColor = False
        '
        'ItemNameSearchTextBox
        '
        Me.ItemNameSearchTextBox.Location = New System.Drawing.Point(21, 61)
        Me.ItemNameSearchTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.ItemNameSearchTextBox.Name = "ItemNameSearchTextBox"
        Me.ItemNameSearchTextBox.Size = New System.Drawing.Size(163, 20)
        Me.ItemNameSearchTextBox.TabIndex = 9
        '
        'ItemListBindingSource1
        '
        Me.ItemListBindingSource1.DataMember = "ItemList"
        Me.ItemListBindingSource1.DataSource = Me.ItemListLookupDataSet
        '
        'VBookingLookupTableAdapter
        '
        Me.VBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemNameDataSet
        '
        Me.ItemNameDataSet.DataSetName = "ItemNameDataSet"
        Me.ItemNameDataSet.EnforceConstraints = False
        Me.ItemNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VItemListBindingSource
        '
        Me.VItemListBindingSource.DataMember = "vItemList"
        Me.VItemListBindingSource.DataSource = Me.ItemNameDataSet
        '
        'VItemListTableAdapter
        '
        Me.VItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemNameTableAdapterManager
        '
        Me.ItemNameTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.ItemNameTableAdapterManager.Connection = Nothing
        Me.ItemNameTableAdapterManager.UpdateOrder = KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemListTableAdapter1
        '
        Me.ItemListTableAdapter1.ClearBeforeFill = True
        '
        'BookingProgramNoLookupTableAdapter
        '
        Me.BookingProgramNoLookupTableAdapter.ClearBeforeFill = True
        '
        'TotalReceiveQuantityTableAdapter
        '
        Me.TotalReceiveQuantityTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'IssueReceiveTypeTableAdapter
        '
        Me.IssueReceiveTypeTableAdapter.ClearBeforeFill = True
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'RequisitionLookupTableAdapter
        '
        Me.RequisitionLookupTableAdapter.ClearBeforeFill = True
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'ItemLocationTableAdapter
        '
        Me.ItemLocationTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ItemNameSrchGridLookUpEdit)
        Me.FlowLayoutPanel2.Controls.Add(Me.ShowByItemButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReceiveDateTimePicker)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.ChallanTextBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ClearButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 29)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1186, 26)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'ShowByItemButton
        '
        Me.ShowByItemButton.Location = New System.Drawing.Point(294, 2)
        Me.ShowByItemButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.ShowByItemButton.Name = "ShowByItemButton"
        Me.ShowByItemButton.Size = New System.Drawing.Size(45, 23)
        Me.ShowByItemButton.TabIndex = 17
        Me.ShowByItemButton.Text = "Show"
        Me.ShowByItemButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(546, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Received Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReceiveDateTimePicker
        '
        Me.ReceiveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiveDateTimePicker.Location = New System.Drawing.Point(612, 3)
        Me.ReceiveDateTimePicker.Name = "ReceiveDateTimePicker"
        Me.ReceiveDateTimePicker.Size = New System.Drawing.Size(107, 20)
        Me.ReceiveDateTimePicker.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(725, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Challan No"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChallanTextBox
        '
        Me.ChallanTextBox.Location = New System.Drawing.Point(791, 3)
        Me.ChallanTextBox.Name = "ChallanTextBox"
        Me.ChallanTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ChallanTextBox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(917, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LCListTableAdapter
        '
        Me.LCListTableAdapter.ClearBeforeFill = True
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'PIListLookupTableAdapter
        '
        Me.PIListLookupTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 398)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1162, 269)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.GridControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1154, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Received Item"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(4, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(65, 13)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Export to file"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ReceiveBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(6, 23)
        Me.GridControl1.MainView = Me.GridView5
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.KOGridLookUpEdit, Me.YDOrLookUpEdit, Me.FinishFabricBookingGridLookUpEdit})
        Me.GridControl1.Size = New System.Drawing.Size(1142, 219)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceiveId, Me.colReceiveDate, Me.colChallanNo, Me.colReceiveQuantity, Me.colBranchId, Me.colRemarks1, Me.colPrice, Me.colProgramNo1, Me.colSupplierId2, Me.colImported, Me.colIssueReceiveTypeId, Me.colItemId2, Me.colYarnLotNo, Me.colLCId3, Me.colPIId1, Me.colKnittingOrderId, Me.colYDOrderId, Me.colMRRNo, Me.colManufactureDate, Me.colExpiryDate, Me.colFinishFabricBookingId, Me.colLeftOverQuantity, Me.colDollarValue})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(1005, 394, 216, 199)
        Me.GridView5.GridControl = Me.GridControl1
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colReceiveId
        '
        Me.colReceiveId.FieldName = "ReceiveId"
        Me.colReceiveId.Name = "colReceiveId"
        Me.colReceiveId.OptionsColumn.AllowEdit = False
        Me.colReceiveId.OptionsColumn.ReadOnly = True
        Me.colReceiveId.Width = 63
        '
        'colReceiveDate
        '
        Me.colReceiveDate.FieldName = "ReceiveDate"
        Me.colReceiveDate.Name = "colReceiveDate"
        Me.colReceiveDate.OptionsColumn.AllowEdit = False
        Me.colReceiveDate.OptionsColumn.ReadOnly = True
        Me.colReceiveDate.Visible = True
        Me.colReceiveDate.VisibleIndex = 1
        Me.colReceiveDate.Width = 84
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.OptionsColumn.AllowEdit = False
        Me.colChallanNo.OptionsColumn.ReadOnly = True
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 2
        '
        'colReceiveQuantity
        '
        Me.colReceiveQuantity.FieldName = "ReceiveQuantity"
        Me.colReceiveQuantity.Name = "colReceiveQuantity"
        Me.colReceiveQuantity.OptionsColumn.AllowEdit = False
        Me.colReceiveQuantity.OptionsColumn.ReadOnly = True
        Me.colReceiveQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colReceiveQuantity.Visible = True
        Me.colReceiveQuantity.VisibleIndex = 12
        Me.colReceiveQuantity.Width = 105
        '
        'colBranchId
        '
        Me.colBranchId.Caption = "Branch"
        Me.colBranchId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.OptionsColumn.AllowEdit = False
        Me.colBranchId.OptionsColumn.ReadOnly = True
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 0
        Me.colBranchId.Width = 65
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.BranchBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "BranchName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "BranchId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchId1, Me.colBranchCode, Me.colBranchName, Me.colBranchDescription, Me.colBranchType})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBranchId1
        '
        Me.colBranchId1.FieldName = "BranchId"
        Me.colBranchId1.Name = "colBranchId1"
        Me.colBranchId1.OptionsColumn.ReadOnly = True
        '
        'colBranchCode
        '
        Me.colBranchCode.FieldName = "BranchCode"
        Me.colBranchCode.Name = "colBranchCode"
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'colBranchDescription
        '
        Me.colBranchDescription.FieldName = "BranchDescription"
        Me.colBranchDescription.Name = "colBranchDescription"
        '
        'colBranchType
        '
        Me.colBranchType.FieldName = "BranchType"
        Me.colBranchType.Name = "colBranchType"
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.OptionsColumn.AllowEdit = False
        Me.colRemarks1.OptionsColumn.ReadOnly = True
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 19
        Me.colRemarks1.Width = 81
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.OptionsColumn.ReadOnly = True
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 9
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.OptionsColumn.AllowEdit = False
        Me.colProgramNo1.OptionsColumn.ReadOnly = True
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 5
        Me.colProgramNo1.Width = 78
        '
        'colSupplierId2
        '
        Me.colSupplierId2.Caption = "Supplier"
        Me.colSupplierId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit5
        Me.colSupplierId2.FieldName = "SupplierId"
        Me.colSupplierId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSupplierId2.Name = "colSupplierId2"
        Me.colSupplierId2.OptionsColumn.AllowEdit = False
        Me.colSupplierId2.OptionsColumn.ReadOnly = True
        Me.colSupplierId2.Visible = True
        Me.colSupplierId2.VisibleIndex = 17
        Me.colSupplierId2.Width = 104
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit5.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit5.PopupView = Me.RepositoryItemGridLookUpEdit5View
        Me.RepositoryItemGridLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "SupplierId"
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId4, Me.colSupplierName1, Me.colAdd11, Me.colAdd21, Me.colContactPerson1, Me.colContactNo1, Me.colSupplierType1, Me.colSupplierCode1, Me.colCity1, Me.colCountry1})
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId4
        '
        Me.colSupplierId4.FieldName = "SupplierId"
        Me.colSupplierId4.Name = "colSupplierId4"
        Me.colSupplierId4.OptionsColumn.ReadOnly = True
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
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
        Me.colSupplierCode1.VisibleIndex = 0
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
        'colImported
        '
        Me.colImported.FieldName = "Imported"
        Me.colImported.Name = "colImported"
        Me.colImported.OptionsColumn.AllowEdit = False
        Me.colImported.OptionsColumn.ReadOnly = True
        Me.colImported.Visible = True
        Me.colImported.VisibleIndex = 18
        Me.colImported.Width = 66
        '
        'colIssueReceiveTypeId
        '
        Me.colIssueReceiveTypeId.Caption = "Receive Type"
        Me.colIssueReceiveTypeId.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colIssueReceiveTypeId.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colIssueReceiveTypeId.Name = "colIssueReceiveTypeId"
        Me.colIssueReceiveTypeId.OptionsColumn.AllowEdit = False
        Me.colIssueReceiveTypeId.OptionsColumn.ReadOnly = True
        Me.colIssueReceiveTypeId.Visible = True
        Me.colIssueReceiveTypeId.VisibleIndex = 14
        Me.colIssueReceiveTypeId.Width = 100
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.IssueReceiveTypeBindingSource1
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "IssueTypeName"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit6.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit6.PopupView = Me.RepositoryItemGridLookUpEdit6View
        Me.RepositoryItemGridLookUpEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "IssueReceiveTypeId"
        '
        'IssueReceiveTypeBindingSource1
        '
        Me.IssueReceiveTypeBindingSource1.DataMember = "IssueReceiveType"
        Me.IssueReceiveTypeBindingSource1.DataSource = Me.IssueReceiveTypeDataSet
        '
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssueReceiveTypeId1, Me.colIssueTypeName, Me.colDescription})
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = False
        '
        'colIssueReceiveTypeId1
        '
        Me.colIssueReceiveTypeId1.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId1.Name = "colIssueReceiveTypeId1"
        Me.colIssueReceiveTypeId1.OptionsColumn.ReadOnly = True
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
        'colItemId2
        '
        Me.colItemId2.Caption = "Item Name"
        Me.colItemId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colItemId2.FieldName = "ItemId"
        Me.colItemId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId2.Name = "colItemId2"
        Me.colItemId2.OptionsColumn.AllowEdit = False
        Me.colItemId2.OptionsColumn.ReadOnly = True
        Me.colItemId2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colItemId2.Visible = True
        Me.colItemId2.VisibleIndex = 8
        Me.colItemId2.Width = 263
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.ItemListLookupBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ItemId"
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId3, Me.colItemName2, Me.colDepartmentId6, Me.GridColumn4})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colItemId3
        '
        Me.colItemId3.FieldName = "ItemId"
        Me.colItemId3.Name = "colItemId3"
        Me.colItemId3.OptionsColumn.ReadOnly = True
        '
        'colItemName2
        '
        Me.colItemName2.FieldName = "ItemName"
        Me.colItemName2.Name = "colItemName2"
        Me.colItemName2.Visible = True
        Me.colItemName2.VisibleIndex = 0
        '
        'colDepartmentId6
        '
        Me.colDepartmentId6.FieldName = "DepartmentId"
        Me.colDepartmentId6.Name = "colDepartmentId6"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "ID-Name"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        Me.colYarnLotNo.OptionsColumn.AllowEdit = False
        Me.colYarnLotNo.OptionsColumn.ReadOnly = True
        Me.colYarnLotNo.Visible = True
        Me.colYarnLotNo.VisibleIndex = 11
        Me.colYarnLotNo.Width = 77
        '
        'colLCId3
        '
        Me.colLCId3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLCId3.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLCId3.AppearanceCell.Options.UseBackColor = True
        Me.colLCId3.Caption = "LC No"
        Me.colLCId3.ColumnEdit = Me.RepositoryItemGridLookUpEdit4
        Me.colLCId3.FieldName = "LCId"
        Me.colLCId3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLCId3.Name = "colLCId3"
        Me.colLCId3.OptionsColumn.AllowEdit = False
        Me.colLCId3.OptionsColumn.ReadOnly = True
        Me.colLCId3.Visible = True
        Me.colLCId3.VisibleIndex = 15
        Me.colLCId3.Width = 74
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.LCListBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "LCNo"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit4.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit4.PopupView = Me.RepositoryItemGridLookUpEdit4View
        Me.RepositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "LCId"
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId2, Me.colLCNo3, Me.colDepartmentId7, Me.colSupplierId3, Me.colLCDate2, Me.colCompanyId1, Me.colBuyerId1, Me.colRemarks2})
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colLCId2
        '
        Me.colLCId2.FieldName = "LCId"
        Me.colLCId2.Name = "colLCId2"
        Me.colLCId2.OptionsColumn.ReadOnly = True
        '
        'colLCNo3
        '
        Me.colLCNo3.FieldName = "LCNo"
        Me.colLCNo3.Name = "colLCNo3"
        Me.colLCNo3.Visible = True
        Me.colLCNo3.VisibleIndex = 0
        '
        'colDepartmentId7
        '
        Me.colDepartmentId7.FieldName = "DepartmentId"
        Me.colDepartmentId7.Name = "colDepartmentId7"
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        '
        'colLCDate2
        '
        Me.colLCDate2.FieldName = "LCDate"
        Me.colLCDate2.Name = "colLCDate2"
        '
        'colCompanyId1
        '
        Me.colCompanyId1.FieldName = "CompanyId"
        Me.colCompanyId1.Name = "colCompanyId1"
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        '
        'colPIId1
        '
        Me.colPIId1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPIId1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPIId1.AppearanceCell.Options.UseBackColor = True
        Me.colPIId1.Caption = "PI No"
        Me.colPIId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colPIId1.FieldName = "PIId"
        Me.colPIId1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPIId1.Name = "colPIId1"
        Me.colPIId1.OptionsColumn.AllowEdit = False
        Me.colPIId1.OptionsColumn.ReadOnly = True
        Me.colPIId1.Visible = True
        Me.colPIId1.VisibleIndex = 16
        Me.colPIId1.Width = 74
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepositoryItemGridLookUpEdit3.AppearanceReadOnly.Options.UseBackColor = True
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.PIListBindingSource1
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit3.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.RepositoryItemGridLookUpEdit3View
        Me.RepositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "PIId"
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId4, Me.colLCNo4, Me.colPIId2, Me.colPINo1, Me.colDepartmentId8, Me.colItemName3, Me.colItemId4})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colLCId4
        '
        Me.colLCId4.FieldName = "LCId"
        Me.colLCId4.Name = "colLCId4"
        Me.colLCId4.OptionsColumn.ReadOnly = True
        '
        'colLCNo4
        '
        Me.colLCNo4.FieldName = "LCNo"
        Me.colLCNo4.Name = "colLCNo4"
        '
        'colPIId2
        '
        Me.colPIId2.FieldName = "PIId"
        Me.colPIId2.Name = "colPIId2"
        Me.colPIId2.OptionsColumn.ReadOnly = True
        '
        'colPINo1
        '
        Me.colPINo1.FieldName = "PINo"
        Me.colPINo1.Name = "colPINo1"
        Me.colPINo1.Visible = True
        Me.colPINo1.VisibleIndex = 0
        '
        'colDepartmentId8
        '
        Me.colDepartmentId8.FieldName = "DepartmentId"
        Me.colDepartmentId8.Name = "colDepartmentId8"
        '
        'colItemName3
        '
        Me.colItemName3.FieldName = "ItemName"
        Me.colItemName3.Name = "colItemName3"
        '
        'colItemId4
        '
        Me.colItemId4.FieldName = "ItemId"
        Me.colItemId4.Name = "colItemId4"
        Me.colItemId4.OptionsColumn.ReadOnly = True
        '
        'colKnittingOrderId
        '
        Me.colKnittingOrderId.Caption = "Knitting Order"
        Me.colKnittingOrderId.ColumnEdit = Me.KOGridLookUpEdit
        Me.colKnittingOrderId.FieldName = "KnittingOrderId"
        Me.colKnittingOrderId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colKnittingOrderId.Name = "colKnittingOrderId"
        Me.colKnittingOrderId.OptionsColumn.AllowEdit = False
        Me.colKnittingOrderId.OptionsColumn.ReadOnly = True
        Me.colKnittingOrderId.Visible = True
        Me.colKnittingOrderId.VisibleIndex = 6
        Me.colKnittingOrderId.Width = 95
        '
        'KOGridLookUpEdit
        '
        Me.KOGridLookUpEdit.AutoHeight = False
        Me.KOGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KOGridLookUpEdit.DataSource = Me.KWOrderLookupBindingSource
        Me.KOGridLookUpEdit.DisplayMember = "KnittingWorkOrderNo"
        Me.KOGridLookUpEdit.Name = "KOGridLookUpEdit"
        Me.KOGridLookUpEdit.NullText = ""
        Me.KOGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KOGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit7View
        Me.KOGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KOGridLookUpEdit.ValueMember = "KnittingOrderId"
        '
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingWorkOrderNo})
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingWorkOrderNo
        '
        Me.colKnittingWorkOrderNo.FieldName = "KnittingWorkOrderNo"
        Me.colKnittingWorkOrderNo.Name = "colKnittingWorkOrderNo"
        Me.colKnittingWorkOrderNo.Visible = True
        Me.colKnittingWorkOrderNo.VisibleIndex = 0
        '
        'colYDOrderId
        '
        Me.colYDOrderId.Caption = "YD Order"
        Me.colYDOrderId.ColumnEdit = Me.YDOrLookUpEdit
        Me.colYDOrderId.FieldName = "YDOrderId"
        Me.colYDOrderId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colYDOrderId.Name = "colYDOrderId"
        Me.colYDOrderId.OptionsColumn.AllowEdit = False
        Me.colYDOrderId.OptionsColumn.ReadOnly = True
        Me.colYDOrderId.Visible = True
        Me.colYDOrderId.VisibleIndex = 7
        Me.colYDOrderId.Width = 99
        '
        'YDOrLookUpEdit
        '
        Me.YDOrLookUpEdit.AutoHeight = False
        Me.YDOrLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YDOrLookUpEdit.DataSource = Me.YDOrderBindingSource
        Me.YDOrLookUpEdit.DisplayMember = "YDOrderNo"
        Me.YDOrLookUpEdit.Name = "YDOrLookUpEdit"
        Me.YDOrLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YDOrLookUpEdit.PopupView = Me.GridView6
        Me.YDOrLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YDOrLookUpEdit.ValueMember = "YDOrderId"
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colMRRNo
        '
        Me.colMRRNo.FieldName = "MRRNo"
        Me.colMRRNo.Name = "colMRRNo"
        Me.colMRRNo.OptionsColumn.AllowEdit = False
        Me.colMRRNo.OptionsColumn.ReadOnly = True
        Me.colMRRNo.Visible = True
        Me.colMRRNo.VisibleIndex = 3
        '
        'colManufactureDate
        '
        Me.colManufactureDate.FieldName = "ManufactureDate"
        Me.colManufactureDate.Name = "colManufactureDate"
        Me.colManufactureDate.OptionsColumn.AllowEdit = False
        Me.colManufactureDate.OptionsColumn.ReadOnly = True
        Me.colManufactureDate.Visible = True
        Me.colManufactureDate.VisibleIndex = 20
        '
        'colExpiryDate
        '
        Me.colExpiryDate.FieldName = "ExpiryDate"
        Me.colExpiryDate.Name = "colExpiryDate"
        Me.colExpiryDate.OptionsColumn.AllowEdit = False
        Me.colExpiryDate.OptionsColumn.ReadOnly = True
        Me.colExpiryDate.Visible = True
        Me.colExpiryDate.VisibleIndex = 21
        '
        'colFinishFabricBookingId
        '
        Me.colFinishFabricBookingId.Caption = "Program No :: Style :: Buyer"
        Me.colFinishFabricBookingId.ColumnEdit = Me.FinishFabricBookingGridLookUpEdit
        Me.colFinishFabricBookingId.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId.Name = "colFinishFabricBookingId"
        Me.colFinishFabricBookingId.OptionsColumn.AllowEdit = False
        Me.colFinishFabricBookingId.OptionsColumn.ReadOnly = True
        Me.colFinishFabricBookingId.Visible = True
        Me.colFinishFabricBookingId.VisibleIndex = 4
        Me.colFinishFabricBookingId.Width = 170
        '
        'FinishFabricBookingGridLookUpEdit
        '
        Me.FinishFabricBookingGridLookUpEdit.AutoHeight = False
        Me.FinishFabricBookingGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingGridLookUpEdit.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.FinishFabricBookingGridLookUpEdit.DisplayMember = "Details"
        Me.FinishFabricBookingGridLookUpEdit.Name = "FinishFabricBookingGridLookUpEdit"
        Me.FinishFabricBookingGridLookUpEdit.NullText = ""
        Me.FinishFabricBookingGridLookUpEdit.PopupView = Me.GridView7
        Me.FinishFabricBookingGridLookUpEdit.ValueMember = "FinishFabricBookingId"
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails8})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colDetails8
        '
        Me.colDetails8.FieldName = "Details"
        Me.colDetails8.Name = "colDetails8"
        Me.colDetails8.Visible = True
        Me.colDetails8.VisibleIndex = 0
        '
        'colLeftOverQuantity
        '
        Me.colLeftOverQuantity.FieldName = "LeftOverQuantity"
        Me.colLeftOverQuantity.Name = "colLeftOverQuantity"
        Me.colLeftOverQuantity.OptionsColumn.AllowEdit = False
        Me.colLeftOverQuantity.OptionsColumn.ReadOnly = True
        Me.colLeftOverQuantity.Visible = True
        Me.colLeftOverQuantity.VisibleIndex = 13
        Me.colLeftOverQuantity.Width = 113
        '
        'colDollarValue
        '
        Me.colDollarValue.FieldName = "DollarValue"
        Me.colDollarValue.Name = "colDollarValue"
        Me.colDollarValue.Visible = True
        Me.colDollarValue.VisibleIndex = 10
        '
        'ReceivedMRNoLookupTableAdapter
        '
        Me.ReceivedMRNoLookupTableAdapter.ClearBeforeFill = True
        '
        'PIAndItemwiseBalanceTableAdapter
        '
        Me.PIAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'KWOrderLookupTableAdapter
        '
        Me.KWOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'colSupplierName2
        '
        Me.colSupplierName2.FieldName = "SupplierName"
        Me.colSupplierName2.Name = "colSupplierName2"
        Me.colSupplierName2.Visible = True
        Me.colSupplierName2.VisibleIndex = 0
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 1
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'colDetails3
        '
        Me.colDetails3.FieldName = "Details"
        Me.colDetails3.Name = "colDetails3"
        Me.colDetails3.Visible = True
        Me.colDetails3.VisibleIndex = 0
        '
        'colDetails4
        '
        Me.colDetails4.FieldName = "Details"
        Me.colDetails4.Name = "colDetails4"
        Me.colDetails4.Visible = True
        Me.colDetails4.VisibleIndex = 0
        '
        'colSupplierName3
        '
        Me.colSupplierName3.FieldName = "SupplierName"
        Me.colSupplierName3.Name = "colSupplierName3"
        Me.colSupplierName3.Visible = True
        Me.colSupplierName3.VisibleIndex = 1
        '
        'YDOrderTableAdapter
        '
        Me.YDOrderTableAdapter.ClearBeforeFill = True
        '
        'colYDOrderNo
        '
        Me.colYDOrderNo.FieldName = "YDOrderNo"
        Me.colYDOrderNo.Name = "colYDOrderNo"
        Me.colYDOrderNo.Visible = True
        Me.colYDOrderNo.VisibleIndex = 0
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
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(721, 188)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(81, 13)
        Label12.TabIndex = 54
        Label12.Text = "Dollar Value TK"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 671)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StartWithCheckBox)
        Me.Controls.Add(Me.ItemNameSearchTextBox)
        Me.Controls.Add(PIDateLabel)
        Me.Controls.Add(Me.PIDateTimePicker)
        Me.KeyPreview = True
        Me.Name = "frmReceive"
        Me.Text = "Receive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActUnitGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsLeftOverCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAlreadyIssuedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingOrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KWOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingOrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForShadeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLocationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalReceiveQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ItemNameSrchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ReceiveDataSet As KSoft_Inventory.ReceiveDataSet
    Friend WithEvents ReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiveTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchDataSet As KSoft_Inventory.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ChallanNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceiveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceiveQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents CopyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents ItemIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingDataSet As KSoft_Inventory.BookingDataSet
    Friend WithEvents VBookingLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.vBookingLookupTableAdapter
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemNameDataSet As KSoft_Inventory.ItemNameDataSet
    Friend WithEvents VItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VItemListTableAdapter As KSoft_Inventory.ItemNameDataSetTableAdapters.vItemListTableAdapter
    Friend WithEvents ItemNameTableAdapterManager As KSoft_Inventory.ItemNameDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ItemListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter1 As KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents BookingProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingProgramNoLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter
    Friend WithEvents TotalReceiveQuantityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalReceiveQuantityTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.TotalReceiveQuantityTableAdapter
    Friend WithEvents TotalReceiveQuantityLabel2 As System.Windows.Forms.Label
    Friend WithEvents BalanceLabel As System.Windows.Forms.Label
    Friend WithEvents ReceiveTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents IssueReceiveTypeDataSet As KSoft_Inventory.IssueReceiveTypeDataSet
    Friend WithEvents IssueReceiveTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueReceiveTypeTableAdapter As KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
    Friend WithEvents ImportedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents YarnLotNoTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents BrandDataSet As KSoft_Inventory.BrandDataSet
    Friend WithEvents BrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandTableAdapter As KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents RequisitionDataSet As KSoft_Inventory.RequisitionDataSet
    Friend WithEvents RequisitionLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionLookupTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter
    Friend WithEvents RequisitionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RequisitionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqNoAndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemNameSearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartWithCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CompanyIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents LocationIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LocationIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemLocationDataSet As KSoft_Inventory.ItemLocationDataSet
    Friend WithEvents ItemLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemLocationTableAdapter As KSoft_Inventory.ItemLocationDataSetTableAdapters.ItemLocationTableAdapter
    Friend WithEvents colStepA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStepB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStepC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpeningLCButton As System.Windows.Forms.Button
    Friend WithEvents ForShadeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItemNameSrchGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ReceiveDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChallanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PIDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TTLReceivedLabel As System.Windows.Forms.Label
    Friend WithEvents PIGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpeningLCDataSet As KSoft_Inventory.OpeningLCDataSet
    Friend WithEvents LCListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter
    Friend WithEvents PIListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents colLCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListLookupTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListLookupTableAdapter
    Friend WithEvents colLCId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReceiveId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImported As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBranchId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReceivedMRNoLookupTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter
    Friend WithEvents ReceivedMRNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PIAndItemwiseBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIAnditemwiseBalanceDataSet As KSoft_Inventory.PIAnditemwiseBalanceDataSet
    Friend WithEvents PIAndItemwiseBalanceTableAdapter As KSoft_Inventory.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter
    Friend WithEvents IssueReceiveTypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnittingOrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents KnittingOrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KWOrderLookupTableAdapter As KSoft_Inventory.KWOrderLookupDataSetTableAdapters.KWOrderLookupTableAdapter
    Friend WithEvents KWOrderLookupDataSet As KSoft_Inventory.KWOrderLookupDataSet
    Friend WithEvents KWOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSupplierName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YDOrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YDOrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YDOrderLookupDataSet As KSoft_Inventory.YDOrderLookupDataSet
    Friend WithEvents YDOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter
    Friend WithEvents colYDOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYDOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KOGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YDOrLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYDOrderNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRRNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRRNoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colMRRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YDOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderDetailsTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter
    Friend WithEvents MRRDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PacketQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyPerPacketTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents IsAlreadyIssuedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ReferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colKnittingWorkOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpiryDateDateTimePicker As DateTimePicker
    Friend WithEvents ManufactureDateDateTimePicker As DateTimePicker
    Friend WithEvents colManufactureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpiryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsLeftOverCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ShowByItemButton As Button
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricBookingGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LeftoverQtyTextBox As TextBox
    Friend WithEvents colLeftOverQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotNoWOLCTextBox As TextBox
    Friend WithEvents ReceiveQuantity2TextBox As TextBox
    Friend WithEvents ActUnitGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label13 As Label
    Friend WithEvents UnitDataSet As UnitDataSet
    Friend WithEvents UnitBindingSource As BindingSource
    Friend WithEvents UnitTableAdapter As UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DollarValueTextBox As TextBox
    Friend WithEvents colDollarValue As DevExpress.XtraGrid.Columns.GridColumn
End Class
