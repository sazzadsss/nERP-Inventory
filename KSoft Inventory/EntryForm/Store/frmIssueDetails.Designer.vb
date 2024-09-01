<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueDetails
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
        Dim IssuetoDateLabel As System.Windows.Forms.Label
        Dim ItemIdLabel As System.Windows.Forms.Label
        Dim IssuetoQuantityLabel As System.Windows.Forms.Label
        Dim PrintingmediaIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim ShiftIdLabel As System.Windows.Forms.Label
        Dim BatchNoLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ProductionTypeLabel1 As System.Windows.Forms.Label
        Dim ProductionQuantityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim MachineListIdLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.IssueReceiveTypeIdLabel = New System.Windows.Forms.Label()
        Me.SupplierIdLabel = New System.Windows.Forms.Label()
        Me.IssuetoDataSet = New KSoft_Inventory.IssuetoDataSet()
        Me.IssuetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssuetoTableAdapter = New KSoft_Inventory.IssuetoDataSetTableAdapters.IssuetoTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.IssuetoDataSetTableAdapters.TableAdapterManager()
        Me.IssuetoDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ItemNameSrchGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BatchLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BatchLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchLookupDataSet = New KSoft_Inventory.BatchLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBatchInformationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.FinishingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.PrintingMediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataSet = New KSoft_Inventory.MediaDataSet()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Inventory.OrderLookupDataSet()
        Me.ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftDataSet = New KSoft_Inventory.ShiftDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RequisitionNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RecipeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GetRecipeButton = New System.Windows.Forms.Button()
        Me.BalanceQtyLabel = New System.Windows.Forms.Label()
        Me.MachineListIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MachineListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachineListDataSet = New KSoft_Inventory.MachineListDataSet()
        Me.MachineListIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMachineListId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMCType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditAllocationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInternalSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineSerialNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.BatchInformationLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchInformationLookupDataSet = New KSoft_Inventory.BatchInformationLookupDataSet()
        Me.rowBatchNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMachineNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProgramNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBuyer = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFabricColorName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStyleNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowELDNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBatchQuantity = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBatchQuantityYrds = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDia = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDiaType = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFinishUnit = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComposition = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKnittingType = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBatchInformationId = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.UpdateBatchCommentsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BatchCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.IssuetoQuantityTextBox = New DevExpress.XtraEditors.SpinEdit()
        Me.BatchInformationIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BatchInformationIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBatchInformationId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsReady = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDevelopment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitIdComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.GetPriceButton = New System.Windows.Forms.Button()
        Me.PriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AutoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabStopCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItemIdCopyCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CopyCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequisitionNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IssueReceiveTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueReceiveTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueReceiveTypeDataSet = New KSoft_Inventory.IssueReceiveTypeDataSet()
        Me.ProgramNoComboBox = New System.Windows.Forms.ComboBox()
        Me.IssuetoComboBox = New System.Windows.Forms.ComboBox()
        Me.ShiftComboBox = New System.Windows.Forms.ComboBox()
        Me.PIAndItemwiseBalanceSubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIAndItemwiseBalanceSubDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIAndItemwiseBalanceSubDataSet = New KSoft_Inventory.PIAndItemwiseBalanceSubDataSet()
        Me.ReceivedMRNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDataSet = New KSoft_Inventory.ReceiveDataSet()
        Me.PILookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PILookUpDataSet = New KSoft_Inventory.PILookUpDataSet()
        Me.ProductionQuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BatchButton = New System.Windows.Forms.Button()
        Me.ProductionDateUpdateButton = New System.Windows.Forms.Button()
        Me.ProductionTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.ShiftTableAdapter = New KSoft_Inventory.ShiftDataSetTableAdapters.ShiftTableAdapter()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.PrintingMediaTableAdapter = New KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.IssueReceiveTypeTableAdapter = New KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BatchLookupTableAdapter = New KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.BatchInformationLookupTableAdapter = New KSoft_Inventory.BatchInformationLookupDataSetTableAdapters.BatchInformationLookupTableAdapter()
        Me.MachineListTableAdapter = New KSoft_Inventory.MachineListDataSetTableAdapters.MachineListTableAdapter()
        Me.IssuetoGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIssuetoId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuetoDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssuetoQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintingmediaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IssuetoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintingMediaId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMediaName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ProgramNoWithStyleBuyerLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgramNoWithStyleBuyerDataSet = New KSoft_Inventory.ProgramNoWithStyleBuyerDataSet()
        Me.RepositoryItemGridLookUpEdit11View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShiftId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShiftGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShiftId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit9View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueReceiveTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IssueTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchInformationId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit8View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Inventory.UserDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASSWORD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_LEVEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpdateOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineListId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BatchNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBatchNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELDNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchQuantityYrds = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchInformationId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCPrice2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PiListDataSet = New KSoft_Inventory.PiListDataSet()
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPIId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPINo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCPrice3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBatchNo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit10View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UserTableAdapter = New KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter()
        Me.PILookUpTableAdapter = New KSoft_Inventory.PILookUpDataSetTableAdapters.PILookUpTableAdapter()
        Me.PIAndItemwiseBalanceSubTableAdapter = New KSoft_Inventory.PIAndItemwiseBalanceSubDataSetTableAdapters.PIAndItemwiseBalanceSubTableAdapter()
        Me.PIListTableAdapter = New KSoft_Inventory.PiListDataSetTableAdapters.PIListTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ReceivedMRNoLookupTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter()
        Me.colBatchNo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramNoWithStyleBuyerLookUpTableAdapter = New KSoft_Inventory.ProgramNoWithStyleBuyerDataSetTableAdapters.ProgramNoWithStyleBuyerLookUpTableAdapter()
        IssuetoDateLabel = New System.Windows.Forms.Label()
        ItemIdLabel = New System.Windows.Forms.Label()
        IssuetoQuantityLabel = New System.Windows.Forms.Label()
        PrintingmediaIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        OrderIdLabel = New System.Windows.Forms.Label()
        ShiftIdLabel = New System.Windows.Forms.Label()
        BatchNoLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ProductionTypeLabel1 = New System.Windows.Forms.Label()
        ProductionQuantityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        MachineListIdLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.IssuetoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuetoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ItemNameSrchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MachineListIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineListIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuetoQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdCopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceSubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceSubDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceSubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuetoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuetoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoWithStyleBuyerLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoWithStyleBuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PiListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IssuetoDateLabel
        '
        IssuetoDateLabel.AutoSize = True
        IssuetoDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        IssuetoDateLabel.Location = New System.Drawing.Point(30, 37)
        IssuetoDateLabel.Name = "IssuetoDateLabel"
        IssuetoDateLabel.Size = New System.Drawing.Size(61, 13)
        IssuetoDateLabel.TabIndex = 14
        IssuetoDateLabel.Text = "Issue Date:"
        '
        'ItemIdLabel
        '
        ItemIdLabel.AutoSize = True
        ItemIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemIdLabel.Location = New System.Drawing.Point(337, 169)
        ItemIdLabel.Name = "ItemIdLabel"
        ItemIdLabel.Size = New System.Drawing.Size(71, 13)
        ItemIdLabel.TabIndex = 22
        ItemIdLabel.Text = "Item Name:"
        '
        'IssuetoQuantityLabel
        '
        IssuetoQuantityLabel.AutoSize = True
        IssuetoQuantityLabel.Location = New System.Drawing.Point(337, 194)
        IssuetoQuantityLabel.Name = "IssuetoQuantityLabel"
        IssuetoQuantityLabel.Size = New System.Drawing.Size(86, 13)
        IssuetoQuantityLabel.TabIndex = 24
        IssuetoQuantityLabel.Text = "Issueto Quantity:"
        '
        'PrintingmediaIdLabel
        '
        PrintingmediaIdLabel.AutoSize = True
        PrintingmediaIdLabel.Location = New System.Drawing.Point(31, 135)
        PrintingmediaIdLabel.Name = "PrintingmediaIdLabel"
        PrintingmediaIdLabel.Size = New System.Drawing.Size(50, 13)
        PrintingmediaIdLabel.TabIndex = 23
        PrintingmediaIdLabel.Text = "Issue to :"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(337, 224)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 25
        RemarksLabel.Text = "Remarks:"
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        OrderIdLabel.Location = New System.Drawing.Point(340, 33)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(69, 13)
        OrderIdLabel.TabIndex = 16
        OrderIdLabel.Text = "Program No :"
        '
        'ShiftIdLabel
        '
        ShiftIdLabel.AutoSize = True
        ShiftIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShiftIdLabel.Location = New System.Drawing.Point(30, 61)
        ShiftIdLabel.Name = "ShiftIdLabel"
        ShiftIdLabel.Size = New System.Drawing.Size(41, 13)
        ShiftIdLabel.TabIndex = 21
        ShiftIdLabel.Text = "Shift :"
        '
        'BatchNoLabel
        '
        BatchNoLabel.AutoSize = True
        BatchNoLabel.Location = New System.Drawing.Point(340, 61)
        BatchNoLabel.Name = "BatchNoLabel"
        BatchNoLabel.Size = New System.Drawing.Size(55, 13)
        BatchNoLabel.TabIndex = 0
        BatchNoLabel.Text = "Batch No:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(628, 194)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 15
        PriceLabel.Text = "Price:"
        '
        'ProductionTypeLabel1
        '
        ProductionTypeLabel1.AutoSize = True
        ProductionTypeLabel1.Location = New System.Drawing.Point(739, 336)
        ProductionTypeLabel1.Name = "ProductionTypeLabel1"
        ProductionTypeLabel1.Size = New System.Drawing.Size(88, 13)
        ProductionTypeLabel1.TabIndex = 1
        ProductionTypeLabel1.Text = "Production Type:"
        ProductionTypeLabel1.UseWaitCursor = True
        ProductionTypeLabel1.Visible = False
        '
        'ProductionQuantityLabel
        '
        ProductionQuantityLabel.AutoSize = True
        ProductionQuantityLabel.Location = New System.Drawing.Point(497, 335)
        ProductionQuantityLabel.Name = "ProductionQuantityLabel"
        ProductionQuantityLabel.Size = New System.Drawing.Size(103, 13)
        ProductionQuantityLabel.TabIndex = 0
        ProductionQuantityLabel.Text = "Production Quantity:"
        ProductionQuantityLabel.UseWaitCursor = True
        ProductionQuantityLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(338, 86)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 13)
        Label1.TabIndex = 30
        Label1.Text = "Batch Comments:"
        '
        'MachineListIdLabel
        '
        MachineListIdLabel.AutoSize = True
        MachineListIdLabel.Location = New System.Drawing.Point(31, 162)
        MachineListIdLabel.Name = "MachineListIdLabel"
        MachineListIdLabel.Size = New System.Drawing.Size(51, 13)
        MachineListIdLabel.TabIndex = 38
        MachineListIdLabel.Text = "Machine:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(628, 224)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 39
        Label3.Text = "Balance :"
        '
        'IssueReceiveTypeIdLabel
        '
        Me.IssueReceiveTypeIdLabel.AutoSize = True
        Me.IssueReceiveTypeIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IssueReceiveTypeIdLabel.Location = New System.Drawing.Point(337, 139)
        Me.IssueReceiveTypeIdLabel.Name = "IssueReceiveTypeIdLabel"
        Me.IssueReceiveTypeIdLabel.Size = New System.Drawing.Size(62, 13)
        Me.IssueReceiveTypeIdLabel.TabIndex = 19
        Me.IssueReceiveTypeIdLabel.Text = "Issue Type:"
        '
        'SupplierIdLabel
        '
        Me.SupplierIdLabel.AutoSize = True
        Me.SupplierIdLabel.Location = New System.Drawing.Point(31, 220)
        Me.SupplierIdLabel.Name = "SupplierIdLabel"
        Me.SupplierIdLabel.Size = New System.Drawing.Size(51, 13)
        Me.SupplierIdLabel.TabIndex = 20
        Me.SupplierIdLabel.Text = "Supplier :"
        '
        'IssuetoDataSet
        '
        Me.IssuetoDataSet.DataSetName = "IssuetoDataSet"
        Me.IssuetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssuetoBindingSource
        '
        Me.IssuetoBindingSource.DataMember = "Issueto"
        Me.IssuetoBindingSource.DataSource = Me.IssuetoDataSet
        '
        'IssuetoTableAdapter
        '
        Me.IssuetoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IssuetoTableAdapter = Me.IssuetoTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.IssuetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IssuetoDateDateTimePicker
        '
        Me.IssuetoDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.IssuetoDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssuetoBindingSource, "IssuetoDate", True))
        Me.IssuetoDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IssuetoDateDateTimePicker.Location = New System.Drawing.Point(122, 33)
        Me.IssuetoDateDateTimePicker.Name = "IssuetoDateDateTimePicker"
        Me.IssuetoDateDateTimePicker.Size = New System.Drawing.Size(143, 20)
        Me.IssuetoDateDateTimePicker.TabIndex = 0
        Me.IssuetoDateDateTimePicker.TabStop = False
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuetoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(431, 218)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(182, 22)
        Me.RemarksTextBox.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelControl1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ItemNameSrchGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelControl2)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelControl3)
        Me.FlowLayoutPanel1.Controls.Add(Me.BatchLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.FinishingCheckBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1151, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(50, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(66, 3)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(50, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(139, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(50, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(195, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(50, 21)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(251, 7)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Search by :  Item Name"
        '
        'ItemNameSrchGridLookUpEdit
        '
        Me.ItemNameSrchGridLookUpEdit.Location = New System.Drawing.Point(370, 3)
        Me.ItemNameSrchGridLookUpEdit.Name = "ItemNameSrchGridLookUpEdit"
        Me.ItemNameSrchGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameSrchGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameSrchGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ItemNameSrchGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemNameSrchGridLookUpEdit.Properties.NullText = "[Type an item name]"
        Me.ItemNameSrchGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameSrchGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameSrchGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemNameSrchGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ItemNameSrchGridLookUpEdit.Size = New System.Drawing.Size(146, 20)
        Me.ItemNameSrchGridLookUpEdit.TabIndex = 0
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName1, Me.colDepartmentId1, Me.GridColumn2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        Me.colItemId1.OptionsColumn.ReadOnly = True
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id-Name"
        Me.GridColumn2.FieldName = "ID-Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(522, 7)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Supplier"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(566, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SupplierBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "SupplierName"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type a supplier name]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "SupplierId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView1
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(137, 20)
        Me.GridLookUpEdit1.TabIndex = 1
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId, Me.colSupplierCode, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
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
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(709, 7)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Batch"
        '
        'BatchLookupGridLookUpEdit
        '
        Me.BatchLookupGridLookUpEdit.Location = New System.Drawing.Point(742, 3)
        Me.BatchLookupGridLookUpEdit.Name = "BatchLookupGridLookUpEdit"
        Me.BatchLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BatchLookupGridLookUpEdit.Properties.DataSource = Me.BatchLookupBindingSource
        Me.BatchLookupGridLookUpEdit.Properties.DisplayMember = "BatchNo"
        Me.BatchLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BatchLookupGridLookUpEdit.Properties.NullText = "[Type a Batch No]"
        Me.BatchLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BatchLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BatchLookupGridLookUpEdit.Properties.ValueMember = "BatchInformationId"
        Me.BatchLookupGridLookUpEdit.Properties.View = Me.GridView3
        Me.BatchLookupGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.BatchLookupGridLookUpEdit.TabIndex = 2
        '
        'BatchLookupBindingSource
        '
        Me.BatchLookupBindingSource.DataMember = "BatchLookup"
        Me.BatchLookupBindingSource.DataSource = Me.BatchLookupDataSet
        '
        'BatchLookupDataSet
        '
        Me.BatchLookupDataSet.DataSetName = "BatchLookupDataSet"
        Me.BatchLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchInformationId, Me.colBatchNo, Me.colProgramNo})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colBatchInformationId
        '
        Me.colBatchInformationId.FieldName = "BatchInformationId"
        Me.colBatchInformationId.Name = "colBatchInformationId"
        Me.colBatchInformationId.OptionsColumn.ReadOnly = True
        '
        'colBatchNo
        '
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 0
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(866, 2)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(56, 23)
        Me.RefreshButton.TabIndex = 3
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'FinishingCheckBox
        '
        Me.FinishingCheckBox.AutoSize = True
        Me.FinishingCheckBox.Location = New System.Drawing.Point(928, 6)
        Me.FinishingCheckBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.FinishingCheckBox.Name = "FinishingCheckBox"
        Me.FinishingCheckBox.Size = New System.Drawing.Size(67, 17)
        Me.FinishingCheckBox.TabIndex = 12
        Me.FinishingCheckBox.Text = "Finishing"
        Me.FinishingCheckBox.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(1001, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(46, 21)
        Me.ShowButton.TabIndex = 4
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(1053, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.EnforceConstraints = False
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShiftBindingSource
        '
        Me.ShiftBindingSource.DataMember = "Shift"
        Me.ShiftBindingSource.DataSource = Me.ShiftDataSet
        '
        'ShiftDataSet
        '
        Me.ShiftDataSet.DataSetName = "ShiftDataSet"
        Me.ShiftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.RequisitionNoLinkLabel)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RecipeDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.GetRecipeButton)
        Me.GroupBox1.Controls.Add(Me.BalanceQtyLabel)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(MachineListIdLabel)
        Me.GroupBox1.Controls.Add(Me.MachineListIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.VGridControl1)
        Me.GroupBox1.Controls.Add(Me.UpdateBatchCommentsLinkLabel)
        Me.GroupBox1.Controls.Add(Me.BatchCommentsTextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.IssuetoQuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.BatchInformationIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.UnitIdComboBox)
        Me.GroupBox1.Controls.Add(Me.GetPriceButton)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextEdit)
        Me.GroupBox1.Controls.Add(Me.AutoCheckEdit)
        Me.GroupBox1.Controls.Add(BatchNoLabel)
        Me.GroupBox1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.TabStopCheckBox)
        Me.GroupBox1.Controls.Add(Me.ItemIdCopyCheckEdit)
        Me.GroupBox1.Controls.Add(Me.CopyCheckEdit)
        Me.GroupBox1.Controls.Add(Me.ItemNameGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.SupplierIdLabel)
        Me.GroupBox1.Controls.Add(Me.RequisitionNoTextEdit)
        Me.GroupBox1.Controls.Add(Me.IssueReceiveTypeIdLabel)
        Me.GroupBox1.Controls.Add(Me.IssueReceiveTypeIdComboBox)
        Me.GroupBox1.Controls.Add(Me.ProgramNoComboBox)
        Me.GroupBox1.Controls.Add(Me.IssuetoComboBox)
        Me.GroupBox1.Controls.Add(Me.ShiftComboBox)
        Me.GroupBox1.Controls.Add(IssuetoDateLabel)
        Me.GroupBox1.Controls.Add(Me.IssuetoDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ItemIdLabel)
        Me.GroupBox1.Controls.Add(IssuetoQuantityLabel)
        Me.GroupBox1.Controls.Add(PrintingmediaIdLabel)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.Controls.Add(OrderIdLabel)
        Me.GroupBox1.Controls.Add(ShiftIdLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Issue Details"
        '
        'RequisitionNoLinkLabel
        '
        Me.RequisitionNoLinkLabel.AutoSize = True
        Me.RequisitionNoLinkLabel.Location = New System.Drawing.Point(31, 87)
        Me.RequisitionNoLinkLabel.Name = "RequisitionNoLinkLabel"
        Me.RequisitionNoLinkLabel.Size = New System.Drawing.Size(76, 13)
        Me.RequisitionNoLinkLabel.TabIndex = 124
        Me.RequisitionNoLinkLabel.TabStop = True
        Me.RequisitionNoLinkLabel.Text = "Requisition No"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.Yellow
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(849, 157)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(246, 82)
        Me.ListBox1.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(584, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Recipe Date :"
        '
        'RecipeDateTimePicker
        '
        Me.RecipeDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.RecipeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RecipeDateTimePicker.Location = New System.Drawing.Point(660, 57)
        Me.RecipeDateTimePicker.Name = "RecipeDateTimePicker"
        Me.RecipeDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.RecipeDateTimePicker.TabIndex = 42
        '
        'GetRecipeButton
        '
        Me.GetRecipeButton.Location = New System.Drawing.Point(766, 56)
        Me.GetRecipeButton.Name = "GetRecipeButton"
        Me.GetRecipeButton.Size = New System.Drawing.Size(73, 23)
        Me.GetRecipeButton.TabIndex = 41
        Me.GetRecipeButton.Text = "Get Recipe"
        Me.GetRecipeButton.UseVisualStyleBackColor = True
        '
        'BalanceQtyLabel
        '
        Me.BalanceQtyLabel.BackColor = System.Drawing.Color.Yellow
        Me.BalanceQtyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BalanceQtyLabel.Location = New System.Drawing.Point(682, 218)
        Me.BalanceQtyLabel.Name = "BalanceQtyLabel"
        Me.BalanceQtyLabel.Size = New System.Drawing.Size(94, 21)
        Me.BalanceQtyLabel.TabIndex = 40
        Me.BalanceQtyLabel.Text = "0"
        Me.BalanceQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MachineListIdGridLookUpEdit
        '
        Me.MachineListIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "MachineListId", True))
        Me.MachineListIdGridLookUpEdit.Location = New System.Drawing.Point(122, 158)
        Me.MachineListIdGridLookUpEdit.Name = "MachineListIdGridLookUpEdit"
        Me.MachineListIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MachineListIdGridLookUpEdit.Properties.DataSource = Me.MachineListBindingSource
        Me.MachineListIdGridLookUpEdit.Properties.DisplayMember = "MachineName"
        Me.MachineListIdGridLookUpEdit.Properties.NullText = ""
        Me.MachineListIdGridLookUpEdit.Properties.ValueMember = "MachineListId"
        Me.MachineListIdGridLookUpEdit.Properties.View = Me.MachineListIdGridLookUpEditView
        Me.MachineListIdGridLookUpEdit.Size = New System.Drawing.Size(143, 20)
        Me.MachineListIdGridLookUpEdit.TabIndex = 4
        '
        'MachineListBindingSource
        '
        Me.MachineListBindingSource.DataMember = "MachineList"
        Me.MachineListBindingSource.DataSource = Me.MachineListDataSet
        '
        'MachineListDataSet
        '
        Me.MachineListDataSet.DataSetName = "MachineListDataSet"
        Me.MachineListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachineListIdGridLookUpEditView
        '
        Me.MachineListIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMachineListId, Me.colItemId2, Me.colMCType, Me.colAuditAllocationNo, Me.colBrandId, Me.colBranchId, Me.colInternalSerialNo, Me.colMachineSerialNo, Me.colRemarks, Me.colReceiveDate, Me.colDepartmentId2, Me.colMachineName})
        Me.MachineListIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.MachineListIdGridLookUpEditView.Name = "MachineListIdGridLookUpEditView"
        Me.MachineListIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.MachineListIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colMachineListId
        '
        Me.colMachineListId.FieldName = "MachineListId"
        Me.colMachineListId.Name = "colMachineListId"
        Me.colMachineListId.OptionsColumn.ReadOnly = True
        '
        'colItemId2
        '
        Me.colItemId2.FieldName = "ItemId"
        Me.colItemId2.Name = "colItemId2"
        '
        'colMCType
        '
        Me.colMCType.FieldName = "MCType"
        Me.colMCType.Name = "colMCType"
        '
        'colAuditAllocationNo
        '
        Me.colAuditAllocationNo.FieldName = "AuditAllocationNo"
        Me.colAuditAllocationNo.Name = "colAuditAllocationNo"
        '
        'colBrandId
        '
        Me.colBrandId.FieldName = "BrandId"
        Me.colBrandId.Name = "colBrandId"
        '
        'colBranchId
        '
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        '
        'colInternalSerialNo
        '
        Me.colInternalSerialNo.FieldName = "InternalSerialNo"
        Me.colInternalSerialNo.Name = "colInternalSerialNo"
        '
        'colMachineSerialNo
        '
        Me.colMachineSerialNo.FieldName = "MachineSerialNo"
        Me.colMachineSerialNo.Name = "colMachineSerialNo"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'colReceiveDate
        '
        Me.colReceiveDate.FieldName = "ReceiveDate"
        Me.colReceiveDate.Name = "colReceiveDate"
        '
        'colDepartmentId2
        '
        Me.colDepartmentId2.FieldName = "DepartmentId"
        Me.colDepartmentId2.Name = "colDepartmentId2"
        '
        'colMachineName
        '
        Me.colMachineName.FieldName = "MachineName"
        Me.colMachineName.Name = "colMachineName"
        Me.colMachineName.Visible = True
        Me.colMachineName.VisibleIndex = 0
        '
        'VGridControl1
        '
        Me.VGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.VGridControl1.DataSource = Me.BatchInformationLookupBindingSource
        Me.VGridControl1.Location = New System.Drawing.Point(849, 21)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowBatchNo, Me.rowMachineNo, Me.rowProgramNo, Me.rowBuyer, Me.rowFabricColorName, Me.rowStyleNo, Me.rowELDNo, Me.rowBatchQuantity, Me.rowBatchQuantityYrds, Me.rowDia, Me.rowDiaType, Me.rowFinishUnit, Me.rowComposition, Me.rowName, Me.rowKnittingType, Me.rowBatchInformationId})
        Me.VGridControl1.Size = New System.Drawing.Size(246, 127)
        Me.VGridControl1.TabIndex = 34
        '
        'BatchInformationLookupBindingSource
        '
        Me.BatchInformationLookupBindingSource.DataMember = "BatchInformationLookup"
        Me.BatchInformationLookupBindingSource.DataSource = Me.BatchInformationLookupDataSet
        '
        'BatchInformationLookupDataSet
        '
        Me.BatchInformationLookupDataSet.DataSetName = "BatchInformationLookupDataSet"
        Me.BatchInformationLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rowBatchNo
        '
        Me.rowBatchNo.Name = "rowBatchNo"
        Me.rowBatchNo.Properties.Caption = "Batch No"
        Me.rowBatchNo.Properties.FieldName = "BatchNo"
        '
        'rowMachineNo
        '
        Me.rowMachineNo.Name = "rowMachineNo"
        Me.rowMachineNo.Properties.Caption = "Machine No"
        Me.rowMachineNo.Properties.FieldName = "MachineNo"
        '
        'rowProgramNo
        '
        Me.rowProgramNo.Name = "rowProgramNo"
        Me.rowProgramNo.Properties.Caption = "Program No"
        Me.rowProgramNo.Properties.FieldName = "ProgramNo"
        '
        'rowBuyer
        '
        Me.rowBuyer.Name = "rowBuyer"
        Me.rowBuyer.Properties.Caption = "Buyer"
        Me.rowBuyer.Properties.FieldName = "Buyer"
        '
        'rowFabricColorName
        '
        Me.rowFabricColorName.Name = "rowFabricColorName"
        Me.rowFabricColorName.Properties.Caption = "Fabric Color Name"
        Me.rowFabricColorName.Properties.FieldName = "FabricColorName"
        '
        'rowStyleNo
        '
        Me.rowStyleNo.Name = "rowStyleNo"
        Me.rowStyleNo.Properties.Caption = "Style No"
        Me.rowStyleNo.Properties.FieldName = "StyleNo"
        '
        'rowELDNo
        '
        Me.rowELDNo.Name = "rowELDNo"
        Me.rowELDNo.Properties.Caption = "ELDNo"
        Me.rowELDNo.Properties.FieldName = "ELDNo"
        '
        'rowBatchQuantity
        '
        Me.rowBatchQuantity.Name = "rowBatchQuantity"
        Me.rowBatchQuantity.Properties.Caption = "Batch Quantity"
        Me.rowBatchQuantity.Properties.FieldName = "BatchQuantity"
        '
        'rowBatchQuantityYrds
        '
        Me.rowBatchQuantityYrds.Name = "rowBatchQuantityYrds"
        Me.rowBatchQuantityYrds.Properties.Caption = "Batch Quantity Yrds"
        Me.rowBatchQuantityYrds.Properties.FieldName = "BatchQuantityYrds"
        '
        'rowDia
        '
        Me.rowDia.Name = "rowDia"
        Me.rowDia.Properties.Caption = "Dia"
        Me.rowDia.Properties.FieldName = "Dia"
        '
        'rowDiaType
        '
        Me.rowDiaType.Name = "rowDiaType"
        Me.rowDiaType.Properties.Caption = "Dia Type"
        Me.rowDiaType.Properties.FieldName = "DiaType"
        '
        'rowFinishUnit
        '
        Me.rowFinishUnit.Name = "rowFinishUnit"
        Me.rowFinishUnit.Properties.Caption = "Finish Unit"
        Me.rowFinishUnit.Properties.FieldName = "FinishUnit"
        '
        'rowComposition
        '
        Me.rowComposition.Name = "rowComposition"
        Me.rowComposition.Properties.Caption = "Composition"
        Me.rowComposition.Properties.FieldName = "Composition"
        '
        'rowName
        '
        Me.rowName.Name = "rowName"
        Me.rowName.Properties.Caption = "Name"
        Me.rowName.Properties.FieldName = "Name"
        '
        'rowKnittingType
        '
        Me.rowKnittingType.Name = "rowKnittingType"
        Me.rowKnittingType.Properties.Caption = "Knitting Type"
        Me.rowKnittingType.Properties.FieldName = "KnittingType"
        '
        'rowBatchInformationId
        '
        Me.rowBatchInformationId.Name = "rowBatchInformationId"
        Me.rowBatchInformationId.Properties.Caption = "Batch Information Id"
        Me.rowBatchInformationId.Properties.FieldName = "BatchInformationId"
        Me.rowBatchInformationId.Properties.ReadOnly = True
        '
        'UpdateBatchCommentsLinkLabel
        '
        Me.UpdateBatchCommentsLinkLabel.AutoSize = True
        Me.UpdateBatchCommentsLinkLabel.Location = New System.Drawing.Point(714, 114)
        Me.UpdateBatchCommentsLinkLabel.Name = "UpdateBatchCommentsLinkLabel"
        Me.UpdateBatchCommentsLinkLabel.Size = New System.Drawing.Size(125, 13)
        Me.UpdateBatchCommentsLinkLabel.TabIndex = 11
        Me.UpdateBatchCommentsLinkLabel.TabStop = True
        Me.UpdateBatchCommentsLinkLabel.Text = "Update Batch Comments"
        '
        'BatchCommentsTextBox
        '
        Me.BatchCommentsTextBox.Location = New System.Drawing.Point(432, 84)
        Me.BatchCommentsTextBox.Name = "BatchCommentsTextBox"
        Me.BatchCommentsTextBox.Size = New System.Drawing.Size(411, 20)
        Me.BatchCommentsTextBox.TabIndex = 8
        '
        'IssuetoQuantityTextBox
        '
        Me.IssuetoQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "IssuetoQuantity", True))
        Me.IssuetoQuantityTextBox.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IssuetoQuantityTextBox.Location = New System.Drawing.Point(432, 190)
        Me.IssuetoQuantityTextBox.Name = "IssuetoQuantityTextBox"
        Me.IssuetoQuantityTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatString = "n3"
        Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatString = "n3"
        Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.IssuetoQuantityTextBox.Size = New System.Drawing.Size(115, 20)
        Me.IssuetoQuantityTextBox.TabIndex = 14
        '
        'BatchInformationIdGridLookUpEdit
        '
        Me.BatchInformationIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "BatchInformationId", True))
        Me.BatchInformationIdGridLookUpEdit.Location = New System.Drawing.Point(432, 57)
        Me.BatchInformationIdGridLookUpEdit.Name = "BatchInformationIdGridLookUpEdit"
        Me.BatchInformationIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BatchInformationIdGridLookUpEdit.Properties.DataSource = Me.BatchLookupBindingSource
        Me.BatchInformationIdGridLookUpEdit.Properties.DisplayMember = "BatchNo"
        Me.BatchInformationIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BatchInformationIdGridLookUpEdit.Properties.NullText = ""
        Me.BatchInformationIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BatchInformationIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BatchInformationIdGridLookUpEdit.Properties.ValueMember = "BatchInformationId"
        Me.BatchInformationIdGridLookUpEdit.Properties.View = Me.BatchInformationIdGridLookUpEditView
        Me.BatchInformationIdGridLookUpEdit.Size = New System.Drawing.Size(149, 20)
        Me.BatchInformationIdGridLookUpEdit.TabIndex = 7
        '
        'BatchInformationIdGridLookUpEditView
        '
        Me.BatchInformationIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchInformationId1, Me.colBatchNo1, Me.colProgramNo1, Me.colIsReady, Me.colIsDevelopment})
        Me.BatchInformationIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BatchInformationIdGridLookUpEditView.Name = "BatchInformationIdGridLookUpEditView"
        Me.BatchInformationIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BatchInformationIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBatchInformationId1
        '
        Me.colBatchInformationId1.FieldName = "BatchInformationId"
        Me.colBatchInformationId1.Name = "colBatchInformationId1"
        Me.colBatchInformationId1.OptionsColumn.ReadOnly = True
        '
        'colBatchNo1
        '
        Me.colBatchNo1.FieldName = "BatchNo"
        Me.colBatchNo1.Name = "colBatchNo1"
        Me.colBatchNo1.Visible = True
        Me.colBatchNo1.VisibleIndex = 0
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        '
        'colIsReady
        '
        Me.colIsReady.FieldName = "IsReady"
        Me.colIsReady.Name = "colIsReady"
        '
        'colIsDevelopment
        '
        Me.colIsDevelopment.FieldName = "IsDevelopment"
        Me.colIsDevelopment.Name = "colIsDevelopment"
        '
        'UnitIdComboBox
        '
        Me.UnitIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssuetoBindingSource, "UnitId", True))
        Me.UnitIdComboBox.DataSource = Me.UnitBindingSource
        Me.UnitIdComboBox.DisplayMember = "UnitCode"
        Me.UnitIdComboBox.FormattingEnabled = True
        Me.UnitIdComboBox.Location = New System.Drawing.Point(553, 190)
        Me.UnitIdComboBox.Name = "UnitIdComboBox"
        Me.UnitIdComboBox.Size = New System.Drawing.Size(60, 21)
        Me.UnitIdComboBox.TabIndex = 15
        Me.UnitIdComboBox.ValueMember = "UnitId"
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
        'GetPriceButton
        '
        Me.GetPriceButton.Location = New System.Drawing.Point(782, 190)
        Me.GetPriceButton.Name = "GetPriceButton"
        Me.GetPriceButton.Size = New System.Drawing.Size(60, 50)
        Me.GetPriceButton.TabIndex = 16
        Me.GetPriceButton.Text = "&Get Price"
        Me.GetPriceButton.UseVisualStyleBackColor = True
        '
        'PriceTextEdit
        '
        Me.PriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "Price", True))
        Me.PriceTextEdit.Location = New System.Drawing.Point(682, 190)
        Me.PriceTextEdit.Name = "PriceTextEdit"
        Me.PriceTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.PriceTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PriceTextEdit.Size = New System.Drawing.Size(94, 20)
        Me.PriceTextEdit.TabIndex = 17
        '
        'AutoCheckEdit
        '
        Me.AutoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "Auto", True))
        Me.AutoCheckEdit.Location = New System.Drawing.Point(431, 112)
        Me.AutoCheckEdit.Name = "AutoCheckEdit"
        Me.AutoCheckEdit.Properties.Caption = "Auto Feeded Chemical"
        Me.AutoCheckEdit.Size = New System.Drawing.Size(137, 19)
        Me.AutoCheckEdit.TabIndex = 9
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(122, 215)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = "[Type Supplier]"
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(143, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 5
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId1, Me.colSupplierName1, Me.colAdd11, Me.colAdd21, Me.colContactPerson1, Me.colContactNo1, Me.colSupplierType1, Me.colSupplierCode1, Me.colCity, Me.colCountry})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId1
        '
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        Me.colSupplierId1.OptionsColumn.ReadOnly = True
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 1
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
        'TabStopCheckBox
        '
        Me.TabStopCheckBox.AutoSize = True
        Me.TabStopCheckBox.Location = New System.Drawing.Point(271, 134)
        Me.TabStopCheckBox.Name = "TabStopCheckBox"
        Me.TabStopCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.TabStopCheckBox.TabIndex = 10
        Me.TabStopCheckBox.TabStop = False
        Me.TabStopCheckBox.UseVisualStyleBackColor = True
        '
        'ItemIdCopyCheckEdit
        '
        Me.ItemIdCopyCheckEdit.Location = New System.Drawing.Point(823, 164)
        Me.ItemIdCopyCheckEdit.Name = "ItemIdCopyCheckEdit"
        Me.ItemIdCopyCheckEdit.Properties.Caption = ""
        Me.ItemIdCopyCheckEdit.Size = New System.Drawing.Size(18, 19)
        Me.ItemIdCopyCheckEdit.TabIndex = 28
        '
        'CopyCheckEdit
        '
        Me.CopyCheckEdit.Location = New System.Drawing.Point(271, 33)
        Me.CopyCheckEdit.Name = "CopyCheckEdit"
        Me.CopyCheckEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.CopyCheckEdit.Properties.Appearance.Options.UseForeColor = True
        Me.CopyCheckEdit.Properties.Caption = "Copy"
        Me.CopyCheckEdit.Size = New System.Drawing.Size(60, 19)
        Me.CopyCheckEdit.TabIndex = 20
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "ItemId", True))
        Me.ItemNameGridLookUpEdit.Location = New System.Drawing.Point(431, 163)
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemNameGridLookUpEdit.Properties.DisplayMember = "ID-Name"
        Me.ItemNameGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Properties.NullText = "[Type an item name]"
        Me.ItemNameGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.Properties.View = Me.GridView2
        Me.ItemNameGridLookUpEdit.Size = New System.Drawing.Size(386, 20)
        Me.ItemNameGridLookUpEdit.TabIndex = 13
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
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
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id-Name"
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RequisitionNoTextEdit
        '
        Me.RequisitionNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "RequisitionNo", True))
        Me.RequisitionNoTextEdit.Location = New System.Drawing.Point(122, 84)
        Me.RequisitionNoTextEdit.Name = "RequisitionNoTextEdit"
        Me.RequisitionNoTextEdit.Size = New System.Drawing.Size(143, 20)
        Me.RequisitionNoTextEdit.TabIndex = 2
        '
        'IssueReceiveTypeIdComboBox
        '
        Me.IssueReceiveTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssuetoBindingSource, "IssueReceiveTypeId", True))
        Me.IssueReceiveTypeIdComboBox.DataSource = Me.IssueReceiveTypeBindingSource
        Me.IssueReceiveTypeIdComboBox.DisplayMember = "IssueTypeName"
        Me.IssueReceiveTypeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IssueReceiveTypeIdComboBox.FormattingEnabled = True
        Me.IssueReceiveTypeIdComboBox.Location = New System.Drawing.Point(431, 136)
        Me.IssueReceiveTypeIdComboBox.Name = "IssueReceiveTypeIdComboBox"
        Me.IssueReceiveTypeIdComboBox.Size = New System.Drawing.Size(182, 21)
        Me.IssueReceiveTypeIdComboBox.TabIndex = 12
        Me.IssueReceiveTypeIdComboBox.ValueMember = "IssueReceiveTypeId"
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
        'ProgramNoComboBox
        '
        Me.ProgramNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssuetoBindingSource, "OrderId", True))
        Me.ProgramNoComboBox.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoComboBox.DisplayMember = "PrgAndStyle"
        Me.ProgramNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramNoComboBox.FormattingEnabled = True
        Me.ProgramNoComboBox.Location = New System.Drawing.Point(431, 30)
        Me.ProgramNoComboBox.Name = "ProgramNoComboBox"
        Me.ProgramNoComboBox.Size = New System.Drawing.Size(150, 21)
        Me.ProgramNoComboBox.TabIndex = 6
        Me.ProgramNoComboBox.ValueMember = "OrderId"
        '
        'IssuetoComboBox
        '
        Me.IssuetoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssuetoBindingSource, "PrintingmediaId", True))
        Me.IssuetoComboBox.DataSource = Me.PrintingMediaBindingSource
        Me.IssuetoComboBox.DisplayMember = "MediaName"
        Me.IssuetoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IssuetoComboBox.FormattingEnabled = True
        Me.IssuetoComboBox.Location = New System.Drawing.Point(122, 131)
        Me.IssuetoComboBox.Name = "IssuetoComboBox"
        Me.IssuetoComboBox.Size = New System.Drawing.Size(143, 21)
        Me.IssuetoComboBox.TabIndex = 3
        Me.IssuetoComboBox.ValueMember = "PrintingMediaId"
        '
        'ShiftComboBox
        '
        Me.ShiftComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IssuetoBindingSource, "ShiftId", True))
        Me.ShiftComboBox.DataSource = Me.ShiftBindingSource
        Me.ShiftComboBox.DisplayMember = "Name"
        Me.ShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShiftComboBox.FormattingEnabled = True
        Me.ShiftComboBox.Location = New System.Drawing.Point(122, 57)
        Me.ShiftComboBox.Name = "ShiftComboBox"
        Me.ShiftComboBox.Size = New System.Drawing.Size(143, 21)
        Me.ShiftComboBox.TabIndex = 1
        Me.ShiftComboBox.ValueMember = "ShiftId"
        '
        'PIAndItemwiseBalanceSubBindingSource
        '
        Me.PIAndItemwiseBalanceSubBindingSource.DataMember = "PIAndItemwiseBalanceSub"
        Me.PIAndItemwiseBalanceSubBindingSource.DataSource = Me.PIAndItemwiseBalanceSubDataSetBindingSource
        '
        'PIAndItemwiseBalanceSubDataSetBindingSource
        '
        Me.PIAndItemwiseBalanceSubDataSetBindingSource.DataSource = Me.PIAndItemwiseBalanceSubDataSet
        Me.PIAndItemwiseBalanceSubDataSetBindingSource.Position = 0
        '
        'PIAndItemwiseBalanceSubDataSet
        '
        Me.PIAndItemwiseBalanceSubDataSet.DataSetName = "PIAndItemwiseBalanceSubDataSet"
        Me.PIAndItemwiseBalanceSubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProductionQuantityTextEdit
        '
        Me.ProductionQuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IssuetoBindingSource, "ProductionQuantity", True))
        Me.ProductionQuantityTextEdit.Location = New System.Drawing.Point(606, 332)
        Me.ProductionQuantityTextEdit.Name = "ProductionQuantityTextEdit"
        Me.ProductionQuantityTextEdit.Size = New System.Drawing.Size(115, 20)
        Me.ProductionQuantityTextEdit.TabIndex = 0
        Me.ProductionQuantityTextEdit.UseWaitCursor = True
        '
        'BatchButton
        '
        Me.BatchButton.Enabled = False
        Me.BatchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchButton.Location = New System.Drawing.Point(1013, 328)
        Me.BatchButton.Name = "BatchButton"
        Me.BatchButton.Size = New System.Drawing.Size(60, 23)
        Me.BatchButton.TabIndex = 6
        Me.BatchButton.Text = "*  [F10]"
        Me.BatchButton.UseVisualStyleBackColor = True
        '
        'ProductionDateUpdateButton
        '
        Me.ProductionDateUpdateButton.Location = New System.Drawing.Point(947, 329)
        Me.ProductionDateUpdateButton.Name = "ProductionDateUpdateButton"
        Me.ProductionDateUpdateButton.Size = New System.Drawing.Size(60, 23)
        Me.ProductionDateUpdateButton.TabIndex = 5
        Me.ProductionDateUpdateButton.Text = "&Update"
        Me.ProductionDateUpdateButton.UseVisualStyleBackColor = True
        Me.ProductionDateUpdateButton.UseWaitCursor = True
        '
        'ProductionTypeComboBox
        '
        Me.ProductionTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuetoBindingSource, "ProductionType", True))
        Me.ProductionTypeComboBox.FormattingEnabled = True
        Me.ProductionTypeComboBox.Items.AddRange(New Object() {"--Select--", "Bulk", "Repeat", "Sample"})
        Me.ProductionTypeComboBox.Location = New System.Drawing.Point(826, 331)
        Me.ProductionTypeComboBox.Name = "ProductionTypeComboBox"
        Me.ProductionTypeComboBox.Size = New System.Drawing.Size(115, 21)
        Me.ProductionTypeComboBox.TabIndex = 2
        Me.ProductionTypeComboBox.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(18, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Press F12 For New/Save"
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ShiftTableAdapter
        '
        Me.ShiftTableAdapter.ClearBeforeFill = True
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'PrintingMediaTableAdapter
        '
        Me.PrintingMediaTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'IssueReceiveTypeTableAdapter
        '
        Me.IssueReceiveTypeTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BatchLookupTableAdapter
        '
        Me.BatchLookupTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'BatchInformationLookupTableAdapter
        '
        Me.BatchInformationLookupTableAdapter.ClearBeforeFill = True
        '
        'MachineListTableAdapter
        '
        Me.MachineListTableAdapter.ClearBeforeFill = True
        '
        'IssuetoGridControl
        '
        Me.IssuetoGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IssuetoGridControl.DataSource = Me.IssuetoBindingSource
        Me.IssuetoGridControl.Location = New System.Drawing.Point(19, 315)
        Me.IssuetoGridControl.MainView = Me.GridView4
        Me.IssuetoGridControl.Name = "IssuetoGridControl"
        Me.IssuetoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IssuetoGridLookUpEdit, Me.ItemGridLookUpEdit, Me.ShiftGridLookUpEdit, Me.IssueTypeGridLookUpEdit, Me.UnitGridLookUpEdit, Me.BatchNoGridLookUpEdit, Me.UserGridLookUpEdit, Me.SupplierGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemGridLookUpEdit7, Me.RepositoryItemGridLookUpEdit8, Me.RepositoryItemGridLookUpEdit9, Me.RepositoryItemGridLookUpEdit10, Me.ProgramNoGridLookUpEdit})
        Me.IssuetoGridControl.Size = New System.Drawing.Size(1111, 274)
        Me.IssuetoGridControl.TabIndex = 2
        Me.IssuetoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView4.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView4.ColumnPanelRowHeight = 40
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssuetoId, Me.colIssuetoDate, Me.colItemId3, Me.colIssuetoQuantity, Me.colPrintingmediaId, Me.colRemarks1, Me.colOrderId, Me.colShiftId, Me.colCompanyId, Me.colBranchId1, Me.colDepartmentId3, Me.colIssueReceiveTypeId, Me.colSupplierId2, Me.colRequisitionNo, Me.colAuto, Me.colProductionType, Me.colBatchNo2, Me.colPrice, Me.colProductionDate, Me.colBatchInformationId2, Me.colProductionQuantity, Me.colUnitId, Me.colUserId, Me.colUpdateOn, Me.colMachineListId1})
        Me.GridView4.GridControl = Me.IssuetoGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowFooter = True
        '
        'colIssuetoId
        '
        Me.colIssuetoId.FieldName = "IssuetoId"
        Me.colIssuetoId.Name = "colIssuetoId"
        Me.colIssuetoId.OptionsColumn.AllowEdit = False
        Me.colIssuetoId.OptionsColumn.ReadOnly = True
        '
        'colIssuetoDate
        '
        Me.colIssuetoDate.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colIssuetoDate.AppearanceCell.Options.UseBackColor = True
        Me.colIssuetoDate.FieldName = "IssuetoDate"
        Me.colIssuetoDate.Name = "colIssuetoDate"
        Me.colIssuetoDate.OptionsColumn.AllowEdit = False
        Me.colIssuetoDate.OptionsColumn.ReadOnly = True
        Me.colIssuetoDate.Visible = True
        Me.colIssuetoDate.VisibleIndex = 0
        Me.colIssuetoDate.Width = 78
        '
        'colItemId3
        '
        Me.colItemId3.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colItemId3.AppearanceCell.Options.UseBackColor = True
        Me.colItemId3.Caption = "Item Name"
        Me.colItemId3.ColumnEdit = Me.ItemGridLookUpEdit
        Me.colItemId3.FieldName = "ItemId"
        Me.colItemId3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId3.Name = "colItemId3"
        Me.colItemId3.OptionsColumn.AllowEdit = False
        Me.colItemId3.OptionsColumn.ReadOnly = True
        Me.colItemId3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colItemId3.Visible = True
        Me.colItemId3.VisibleIndex = 6
        Me.colItemId3.Width = 243
        '
        'ItemGridLookUpEdit
        '
        Me.ItemGridLookUpEdit.AutoHeight = False
        Me.ItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemGridLookUpEdit.Name = "ItemGridLookUpEdit"
        Me.ItemGridLookUpEdit.NullText = ""
        Me.ItemGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemGridLookUpEdit.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId4, Me.colItemName2, Me.colDepartmentId4, Me.GridColumn3})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colItemId4
        '
        Me.colItemId4.FieldName = "ItemId"
        Me.colItemId4.Name = "colItemId4"
        Me.colItemId4.OptionsColumn.ReadOnly = True
        '
        'colItemName2
        '
        Me.colItemName2.FieldName = "ItemName"
        Me.colItemName2.Name = "colItemName2"
        Me.colItemName2.Visible = True
        Me.colItemName2.VisibleIndex = 0
        '
        'colDepartmentId4
        '
        Me.colDepartmentId4.FieldName = "DepartmentId"
        Me.colDepartmentId4.Name = "colDepartmentId4"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ID-Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'colIssuetoQuantity
        '
        Me.colIssuetoQuantity.FieldName = "IssuetoQuantity"
        Me.colIssuetoQuantity.Name = "colIssuetoQuantity"
        Me.colIssuetoQuantity.OptionsColumn.AllowEdit = False
        Me.colIssuetoQuantity.OptionsColumn.ReadOnly = True
        Me.colIssuetoQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colIssuetoQuantity.Visible = True
        Me.colIssuetoQuantity.VisibleIndex = 7
        Me.colIssuetoQuantity.Width = 107
        '
        'colPrintingmediaId
        '
        Me.colPrintingmediaId.Caption = "Issue to"
        Me.colPrintingmediaId.ColumnEdit = Me.IssuetoGridLookUpEdit
        Me.colPrintingmediaId.FieldName = "PrintingmediaId"
        Me.colPrintingmediaId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPrintingmediaId.Name = "colPrintingmediaId"
        Me.colPrintingmediaId.OptionsColumn.AllowEdit = False
        Me.colPrintingmediaId.OptionsColumn.ReadOnly = True
        Me.colPrintingmediaId.Visible = True
        Me.colPrintingmediaId.VisibleIndex = 2
        Me.colPrintingmediaId.Width = 88
        '
        'IssuetoGridLookUpEdit
        '
        Me.IssuetoGridLookUpEdit.AutoHeight = False
        Me.IssuetoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssuetoGridLookUpEdit.DataSource = Me.PrintingMediaBindingSource
        Me.IssuetoGridLookUpEdit.DisplayMember = "MediaName"
        Me.IssuetoGridLookUpEdit.Name = "IssuetoGridLookUpEdit"
        Me.IssuetoGridLookUpEdit.NullText = ""
        Me.IssuetoGridLookUpEdit.ValueMember = "PrintingMediaId"
        Me.IssuetoGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintingMediaId1, Me.colMediaName, Me.colDescription, Me.colDepartmentId5})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPrintingMediaId1
        '
        Me.colPrintingMediaId1.FieldName = "PrintingMediaId"
        Me.colPrintingMediaId1.Name = "colPrintingMediaId1"
        Me.colPrintingMediaId1.OptionsColumn.ReadOnly = True
        '
        'colMediaName
        '
        Me.colMediaName.FieldName = "MediaName"
        Me.colMediaName.Name = "colMediaName"
        Me.colMediaName.Visible = True
        Me.colMediaName.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colDepartmentId5
        '
        Me.colDepartmentId5.FieldName = "DepartmentId"
        Me.colDepartmentId5.Name = "colDepartmentId5"
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.OptionsColumn.AllowEdit = False
        Me.colRemarks1.OptionsColumn.ReadOnly = True
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 10
        '
        'colOrderId
        '
        Me.colOrderId.Caption = "Program No :: Style :: Buyer"
        Me.colOrderId.ColumnEdit = Me.ProgramNoGridLookUpEdit
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.AllowEdit = False
        Me.colOrderId.OptionsColumn.ReadOnly = True
        Me.colOrderId.Visible = True
        Me.colOrderId.VisibleIndex = 4
        Me.colOrderId.Width = 140
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.AutoHeight = False
        Me.ProgramNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.DataSource = Me.ProgramNoWithStyleBuyerLookUpBindingSource
        Me.ProgramNoGridLookUpEdit.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.NullText = ""
        Me.ProgramNoGridLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.ProgramNoGridLookUpEdit.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit11View
        '
        'ProgramNoWithStyleBuyerLookUpBindingSource
        '
        Me.ProgramNoWithStyleBuyerLookUpBindingSource.DataMember = "ProgramNoWithStyleBuyerLookUp"
        Me.ProgramNoWithStyleBuyerLookUpBindingSource.DataSource = Me.ProgramNoWithStyleBuyerDataSet
        '
        'ProgramNoWithStyleBuyerDataSet
        '
        Me.ProgramNoWithStyleBuyerDataSet.DataSetName = "ProgramNoWithStyleBuyerDataSet"
        Me.ProgramNoWithStyleBuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit11View
        '
        Me.RepositoryItemGridLookUpEdit11View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit11View.Name = "RepositoryItemGridLookUpEdit11View"
        Me.RepositoryItemGridLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit11View.OptionsView.ShowGroupPanel = False
        '
        'colShiftId
        '
        Me.colShiftId.Caption = "Shift"
        Me.colShiftId.ColumnEdit = Me.ShiftGridLookUpEdit
        Me.colShiftId.FieldName = "ShiftId"
        Me.colShiftId.Name = "colShiftId"
        Me.colShiftId.OptionsColumn.AllowEdit = False
        Me.colShiftId.OptionsColumn.ReadOnly = True
        Me.colShiftId.Visible = True
        Me.colShiftId.VisibleIndex = 1
        Me.colShiftId.Width = 61
        '
        'ShiftGridLookUpEdit
        '
        Me.ShiftGridLookUpEdit.AutoHeight = False
        Me.ShiftGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShiftGridLookUpEdit.DataSource = Me.ShiftBindingSource
        Me.ShiftGridLookUpEdit.DisplayMember = "Name"
        Me.ShiftGridLookUpEdit.Name = "ShiftGridLookUpEdit"
        Me.ShiftGridLookUpEdit.NullText = ""
        Me.ShiftGridLookUpEdit.ValueMember = "ShiftId"
        Me.ShiftGridLookUpEdit.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShiftId1, Me.colName, Me.colRemarks2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colShiftId1
        '
        Me.colShiftId1.FieldName = "ShiftId"
        Me.colShiftId1.Name = "colShiftId1"
        Me.colShiftId1.OptionsColumn.ReadOnly = True
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        '
        'colCompanyId
        '
        Me.colCompanyId.Caption = "Company"
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.OptionsColumn.AllowEdit = False
        Me.colCompanyId.OptionsColumn.ReadOnly = True
        Me.colCompanyId.Width = 101
        '
        'colBranchId1
        '
        Me.colBranchId1.Caption = "Branch"
        Me.colBranchId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit9
        Me.colBranchId1.FieldName = "BranchId"
        Me.colBranchId1.Name = "colBranchId1"
        Me.colBranchId1.OptionsColumn.AllowEdit = False
        Me.colBranchId1.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemGridLookUpEdit9
        '
        Me.RepositoryItemGridLookUpEdit9.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit9.Name = "RepositoryItemGridLookUpEdit9"
        Me.RepositoryItemGridLookUpEdit9.View = Me.RepositoryItemGridLookUpEdit9View
        '
        'RepositoryItemGridLookUpEdit9View
        '
        Me.RepositoryItemGridLookUpEdit9View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit9View.Name = "RepositoryItemGridLookUpEdit9View"
        Me.RepositoryItemGridLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit9View.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentId3
        '
        Me.colDepartmentId3.Caption = "Issue Receive Type"
        Me.colDepartmentId3.FieldName = "DepartmentId"
        Me.colDepartmentId3.Name = "colDepartmentId3"
        Me.colDepartmentId3.OptionsColumn.AllowEdit = False
        Me.colDepartmentId3.OptionsColumn.ReadOnly = True
        Me.colDepartmentId3.Width = 100
        '
        'colIssueReceiveTypeId
        '
        Me.colIssueReceiveTypeId.Caption = "Issue Type"
        Me.colIssueReceiveTypeId.ColumnEdit = Me.IssueTypeGridLookUpEdit
        Me.colIssueReceiveTypeId.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colIssueReceiveTypeId.Name = "colIssueReceiveTypeId"
        Me.colIssueReceiveTypeId.OptionsColumn.AllowEdit = False
        Me.colIssueReceiveTypeId.OptionsColumn.ReadOnly = True
        Me.colIssueReceiveTypeId.Visible = True
        Me.colIssueReceiveTypeId.VisibleIndex = 8
        Me.colIssueReceiveTypeId.Width = 125
        '
        'IssueTypeGridLookUpEdit
        '
        Me.IssueTypeGridLookUpEdit.AutoHeight = False
        Me.IssueTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssueTypeGridLookUpEdit.DataSource = Me.IssueReceiveTypeBindingSource
        Me.IssueTypeGridLookUpEdit.DisplayMember = "IssueTypeName"
        Me.IssueTypeGridLookUpEdit.Name = "IssueTypeGridLookUpEdit"
        Me.IssueTypeGridLookUpEdit.ValueMember = "IssueReceiveTypeId"
        Me.IssueTypeGridLookUpEdit.View = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId2
        '
        Me.colSupplierId2.Caption = "Supplier"
        Me.colSupplierId2.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId2.FieldName = "SupplierId"
        Me.colSupplierId2.Name = "colSupplierId2"
        Me.colSupplierId2.OptionsColumn.AllowEdit = False
        Me.colSupplierId2.OptionsColumn.ReadOnly = True
        Me.colSupplierId2.Visible = True
        Me.colSupplierId2.VisibleIndex = 9
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.NullText = ""
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        Me.SupplierGridLookUpEdit.View = Me.GridView11
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId3, Me.colSupplierName2, Me.colAdd12, Me.colAdd22, Me.colContactPerson2, Me.colContactNo2, Me.colSupplierType2, Me.colSupplierCode2, Me.colCity1, Me.colCountry1})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        Me.colSupplierId3.OptionsColumn.ReadOnly = True
        '
        'colSupplierName2
        '
        Me.colSupplierName2.FieldName = "SupplierName"
        Me.colSupplierName2.Name = "colSupplierName2"
        Me.colSupplierName2.Visible = True
        Me.colSupplierName2.VisibleIndex = 0
        '
        'colAdd12
        '
        Me.colAdd12.FieldName = "Add1"
        Me.colAdd12.Name = "colAdd12"
        '
        'colAdd22
        '
        Me.colAdd22.FieldName = "Add2"
        Me.colAdd22.Name = "colAdd22"
        '
        'colContactPerson2
        '
        Me.colContactPerson2.FieldName = "ContactPerson"
        Me.colContactPerson2.Name = "colContactPerson2"
        '
        'colContactNo2
        '
        Me.colContactNo2.FieldName = "ContactNo"
        Me.colContactNo2.Name = "colContactNo2"
        '
        'colSupplierType2
        '
        Me.colSupplierType2.FieldName = "SupplierType"
        Me.colSupplierType2.Name = "colSupplierType2"
        '
        'colSupplierCode2
        '
        Me.colSupplierCode2.FieldName = "SupplierCode"
        Me.colSupplierCode2.Name = "colSupplierCode2"
        Me.colSupplierCode2.Visible = True
        Me.colSupplierCode2.VisibleIndex = 1
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
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.Name = "colRequisitionNo"
        Me.colRequisitionNo.OptionsColumn.AllowEdit = False
        Me.colRequisitionNo.OptionsColumn.ReadOnly = True
        Me.colRequisitionNo.Visible = True
        Me.colRequisitionNo.VisibleIndex = 3
        Me.colRequisitionNo.Width = 93
        '
        'colAuto
        '
        Me.colAuto.FieldName = "Auto"
        Me.colAuto.Name = "colAuto"
        Me.colAuto.OptionsColumn.AllowEdit = False
        Me.colAuto.OptionsColumn.ReadOnly = True
        Me.colAuto.Visible = True
        Me.colAuto.VisibleIndex = 11
        '
        'colProductionType
        '
        Me.colProductionType.FieldName = "ProductionType"
        Me.colProductionType.Name = "colProductionType"
        Me.colProductionType.OptionsColumn.AllowEdit = False
        Me.colProductionType.OptionsColumn.ReadOnly = True
        Me.colProductionType.Visible = True
        Me.colProductionType.VisibleIndex = 12
        Me.colProductionType.Width = 102
        '
        'colBatchNo2
        '
        Me.colBatchNo2.FieldName = "BatchNo"
        Me.colBatchNo2.Name = "colBatchNo2"
        Me.colBatchNo2.OptionsColumn.AllowEdit = False
        Me.colBatchNo2.OptionsColumn.ReadOnly = True
        Me.colBatchNo2.Visible = True
        Me.colBatchNo2.VisibleIndex = 13
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.OptionsColumn.ReadOnly = True
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 14
        '
        'colProductionDate
        '
        Me.colProductionDate.FieldName = "ProductionDate"
        Me.colProductionDate.Name = "colProductionDate"
        Me.colProductionDate.OptionsColumn.AllowEdit = False
        Me.colProductionDate.OptionsColumn.ReadOnly = True
        Me.colProductionDate.Visible = True
        Me.colProductionDate.VisibleIndex = 15
        Me.colProductionDate.Width = 108
        '
        'colBatchInformationId2
        '
        Me.colBatchInformationId2.Caption = "Batch No"
        Me.colBatchInformationId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colBatchInformationId2.FieldName = "BatchInformationId"
        Me.colBatchInformationId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colBatchInformationId2.Name = "colBatchInformationId2"
        Me.colBatchInformationId2.OptionsColumn.AllowEdit = False
        Me.colBatchInformationId2.OptionsColumn.ReadOnly = True
        Me.colBatchInformationId2.Visible = True
        Me.colBatchInformationId2.VisibleIndex = 5
        Me.colBatchInformationId2.Width = 109
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.BatchLookupBindingSource
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "BatchNo"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.NullText = ""
        Me.RepositoryItemGridLookUpEdit8.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit8.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "BatchInformationId"
        Me.RepositoryItemGridLookUpEdit8.View = Me.RepositoryItemGridLookUpEdit8View
        '
        'RepositoryItemGridLookUpEdit8View
        '
        Me.RepositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit8View.Name = "RepositoryItemGridLookUpEdit8View"
        Me.RepositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = False
        '
        'colProductionQuantity
        '
        Me.colProductionQuantity.FieldName = "ProductionQuantity"
        Me.colProductionQuantity.Name = "colProductionQuantity"
        Me.colProductionQuantity.OptionsColumn.AllowEdit = False
        Me.colProductionQuantity.OptionsColumn.ReadOnly = True
        Me.colProductionQuantity.Visible = True
        Me.colProductionQuantity.VisibleIndex = 16
        Me.colProductionQuantity.Width = 117
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.AllowEdit = False
        Me.colUnitId.OptionsColumn.ReadOnly = True
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 17
        '
        'UnitGridLookUpEdit
        '
        Me.UnitGridLookUpEdit.AutoHeight = False
        Me.UnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitGridLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitGridLookUpEdit.Name = "UnitGridLookUpEdit"
        Me.UnitGridLookUpEdit.ValueMember = "UnitId"
        Me.UnitGridLookUpEdit.View = Me.GridView8
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colUnitId1
        '
        Me.colUnitId1.FieldName = "UnitId"
        Me.colUnitId1.Name = "colUnitId1"
        Me.colUnitId1.OptionsColumn.ReadOnly = True
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
        'colUserId
        '
        Me.colUserId.Caption = "User"
        Me.colUserId.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.OptionsColumn.AllowEdit = False
        Me.colUserId.OptionsColumn.ReadOnly = True
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 18
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.View = Me.GridView10
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_ID, Me.colUSER_NAME, Me.colPASSWORD, Me.colUSER_LEVEL, Me.colACTIVE, Me.colDepartmentId6})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colUSER_ID
        '
        Me.colUSER_ID.FieldName = "USER_ID"
        Me.colUSER_ID.Name = "colUSER_ID"
        Me.colUSER_ID.OptionsColumn.ReadOnly = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colPASSWORD
        '
        Me.colPASSWORD.FieldName = "PASSWORD"
        Me.colPASSWORD.Name = "colPASSWORD"
        '
        'colUSER_LEVEL
        '
        Me.colUSER_LEVEL.FieldName = "USER_LEVEL"
        Me.colUSER_LEVEL.Name = "colUSER_LEVEL"
        '
        'colACTIVE
        '
        Me.colACTIVE.FieldName = "ACTIVE"
        Me.colACTIVE.Name = "colACTIVE"
        '
        'colDepartmentId6
        '
        Me.colDepartmentId6.FieldName = "DepartmentId"
        Me.colDepartmentId6.Name = "colDepartmentId6"
        '
        'colUpdateOn
        '
        Me.colUpdateOn.FieldName = "UpdateOn"
        Me.colUpdateOn.Name = "colUpdateOn"
        Me.colUpdateOn.OptionsColumn.AllowEdit = False
        Me.colUpdateOn.OptionsColumn.ReadOnly = True
        Me.colUpdateOn.Visible = True
        Me.colUpdateOn.VisibleIndex = 19
        '
        'colMachineListId1
        '
        Me.colMachineListId1.FieldName = "MachineListId"
        Me.colMachineListId1.Name = "colMachineListId1"
        Me.colMachineListId1.OptionsColumn.AllowEdit = False
        Me.colMachineListId1.OptionsColumn.ReadOnly = True
        Me.colMachineListId1.Width = 94
        '
        'BatchNoGridLookUpEdit
        '
        Me.BatchNoGridLookUpEdit.AutoHeight = False
        Me.BatchNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BatchNoGridLookUpEdit.DataSource = Me.BatchInformationLookupBindingSource
        Me.BatchNoGridLookUpEdit.DisplayMember = "BatchNo"
        Me.BatchNoGridLookUpEdit.Name = "BatchNoGridLookUpEdit"
        Me.BatchNoGridLookUpEdit.NullText = ""
        Me.BatchNoGridLookUpEdit.ValueMember = "BatchInformationId"
        Me.BatchNoGridLookUpEdit.View = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchNo3, Me.colMachineNo, Me.colProgramNo2, Me.colBuyer, Me.colFabricColorName, Me.colStyleNo, Me.colELDNo, Me.colBatchQuantity, Me.colBatchQuantityYrds, Me.colDia, Me.colDiaType, Me.colFinishUnit, Me.colComposition, Me.colName1, Me.colKnittingType, Me.colBatchInformationId3})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colBatchNo3
        '
        Me.colBatchNo3.FieldName = "BatchNo"
        Me.colBatchNo3.Name = "colBatchNo3"
        Me.colBatchNo3.Visible = True
        Me.colBatchNo3.VisibleIndex = 0
        '
        'colMachineNo
        '
        Me.colMachineNo.FieldName = "MachineNo"
        Me.colMachineNo.Name = "colMachineNo"
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        '
        'colBuyer
        '
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.Name = "colBuyer"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        '
        'colStyleNo
        '
        Me.colStyleNo.FieldName = "StyleNo"
        Me.colStyleNo.Name = "colStyleNo"
        '
        'colELDNo
        '
        Me.colELDNo.FieldName = "ELDNo"
        Me.colELDNo.Name = "colELDNo"
        '
        'colBatchQuantity
        '
        Me.colBatchQuantity.FieldName = "BatchQuantity"
        Me.colBatchQuantity.Name = "colBatchQuantity"
        '
        'colBatchQuantityYrds
        '
        Me.colBatchQuantityYrds.FieldName = "BatchQuantityYrds"
        Me.colBatchQuantityYrds.Name = "colBatchQuantityYrds"
        '
        'colDia
        '
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        '
        'colDiaType
        '
        Me.colDiaType.FieldName = "DiaType"
        Me.colDiaType.Name = "colDiaType"
        '
        'colFinishUnit
        '
        Me.colFinishUnit.FieldName = "FinishUnit"
        Me.colFinishUnit.Name = "colFinishUnit"
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        '
        'colName1
        '
        Me.colName1.FieldName = "Name"
        Me.colName1.Name = "colName1"
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        '
        'colBatchInformationId3
        '
        Me.colBatchInformationId3.FieldName = "BatchInformationId"
        Me.colBatchInformationId3.Name = "colBatchInformationId3"
        Me.colBatchInformationId3.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.PILookUpBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView12
        '
        'GridView12
        '
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.PILookUpBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId2, Me.colLCNo1, Me.colPINo1, Me.colLCPrice, Me.colLCDate, Me.colItemId6})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colPIId2
        '
        Me.colPIId2.FieldName = "PIId"
        Me.colPIId2.Name = "colPIId2"
        '
        'colLCNo1
        '
        Me.colLCNo1.FieldName = "LCNo"
        Me.colLCNo1.Name = "colLCNo1"
        '
        'colPINo1
        '
        Me.colPINo1.FieldName = "PINo"
        Me.colPINo1.Name = "colPINo1"
        Me.colPINo1.Visible = True
        Me.colPINo1.VisibleIndex = 0
        '
        'colLCPrice
        '
        Me.colLCPrice.FieldName = "LCPrice"
        Me.colLCPrice.Name = "colLCPrice"
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        '
        'colItemId6
        '
        Me.colItemId6.FieldName = "ItemId"
        Me.colItemId6.Name = "colItemId6"
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.PILookUpBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit4.View = Me.RepositoryItemGridLookUpEdit4View
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId3, Me.colLCNo2, Me.colPINo2, Me.colLCPrice1, Me.colLCDate1, Me.colItemId7})
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colPIId3
        '
        Me.colPIId3.FieldName = "PIId"
        Me.colPIId3.Name = "colPIId3"
        Me.colPIId3.Visible = True
        Me.colPIId3.VisibleIndex = 0
        '
        'colLCNo2
        '
        Me.colLCNo2.FieldName = "LCNo"
        Me.colLCNo2.Name = "colLCNo2"
        '
        'colPINo2
        '
        Me.colPINo2.FieldName = "PINo"
        Me.colPINo2.Name = "colPINo2"
        '
        'colLCPrice1
        '
        Me.colLCPrice1.FieldName = "LCPrice"
        Me.colLCPrice1.Name = "colLCPrice1"
        '
        'colLCDate1
        '
        Me.colLCDate1.FieldName = "LCDate"
        Me.colLCDate1.Name = "colLCDate1"
        '
        'colItemId7
        '
        Me.colItemId7.FieldName = "ItemId"
        Me.colItemId7.Name = "colItemId7"
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.PILookUpBindingSource
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit5.View = Me.RepositoryItemGridLookUpEdit5View
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId1, Me.colLCNo3, Me.colPINo3, Me.colLCPrice2, Me.colLCDate2, Me.colItemId8})
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'colPIId1
        '
        Me.colPIId1.FieldName = "PIId"
        Me.colPIId1.Name = "colPIId1"
        '
        'colLCNo3
        '
        Me.colLCNo3.FieldName = "LCNo"
        Me.colLCNo3.Name = "colLCNo3"
        '
        'colPINo3
        '
        Me.colPINo3.FieldName = "PINo"
        Me.colPINo3.Name = "colPINo3"
        Me.colPINo3.Visible = True
        Me.colPINo3.VisibleIndex = 0
        '
        'colLCPrice2
        '
        Me.colLCPrice2.FieldName = "LCPrice"
        Me.colLCPrice2.Name = "colLCPrice2"
        '
        'colLCDate2
        '
        Me.colLCDate2.FieldName = "LCDate"
        Me.colLCDate2.Name = "colLCDate2"
        '
        'colItemId8
        '
        Me.colItemId8.FieldName = "ItemId"
        Me.colItemId8.Name = "colItemId8"
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.PIListBindingSource
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = "Null"
        Me.RepositoryItemGridLookUpEdit6.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.RepositoryItemGridLookUpEdit6.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit6.View = Me.RepositoryItemGridLookUpEdit6View
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
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId5, Me.colPINo4, Me.colPIDate, Me.colLCId1, Me.colItemId9, Me.colLCQuantity, Me.colUnitId2, Me.colRemarks3, Me.colLotNo, Me.colLCPrice3, Me.colETA, Me.colRequisitionId})
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = False
        '
        'colPIId5
        '
        Me.colPIId5.FieldName = "PIId"
        Me.colPIId5.Name = "colPIId5"
        Me.colPIId5.OptionsColumn.ReadOnly = True
        '
        'colPINo4
        '
        Me.colPINo4.FieldName = "PINo"
        Me.colPINo4.Name = "colPINo4"
        Me.colPINo4.Visible = True
        Me.colPINo4.VisibleIndex = 0
        '
        'colPIDate
        '
        Me.colPIDate.FieldName = "PIDate"
        Me.colPIDate.Name = "colPIDate"
        '
        'colLCId1
        '
        Me.colLCId1.FieldName = "LCId"
        Me.colLCId1.Name = "colLCId1"
        '
        'colItemId9
        '
        Me.colItemId9.FieldName = "ItemId"
        Me.colItemId9.Name = "colItemId9"
        '
        'colLCQuantity
        '
        Me.colLCQuantity.FieldName = "LCQuantity"
        Me.colLCQuantity.Name = "colLCQuantity"
        '
        'colUnitId2
        '
        Me.colUnitId2.FieldName = "UnitId"
        Me.colUnitId2.Name = "colUnitId2"
        '
        'colRemarks3
        '
        Me.colRemarks3.FieldName = "Remarks"
        Me.colRemarks3.Name = "colRemarks3"
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        '
        'colLCPrice3
        '
        Me.colLCPrice3.FieldName = "LCPrice"
        Me.colLCPrice3.Name = "colLCPrice3"
        '
        'colETA
        '
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        '
        'colRequisitionId
        '
        Me.colRequisitionId.FieldName = "RequisitionId"
        Me.colRequisitionId.Name = "colRequisitionId"
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.BatchInformationLookupBindingSource
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "BatchNo"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.NullText = ""
        Me.RepositoryItemGridLookUpEdit7.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "BatchInformationId"
        Me.RepositoryItemGridLookUpEdit7.View = Me.RepositoryItemGridLookUpEdit7View
        '
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchNo4})
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'colBatchNo4
        '
        Me.colBatchNo4.FieldName = "BatchNo"
        Me.colBatchNo4.Name = "colBatchNo4"
        Me.colBatchNo4.Visible = True
        Me.colBatchNo4.VisibleIndex = 0
        '
        'RepositoryItemGridLookUpEdit10
        '
        Me.RepositoryItemGridLookUpEdit10.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit10.Name = "RepositoryItemGridLookUpEdit10"
        Me.RepositoryItemGridLookUpEdit10.View = Me.RepositoryItemGridLookUpEdit10View
        '
        'RepositoryItemGridLookUpEdit10View
        '
        Me.RepositoryItemGridLookUpEdit10View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit10View.Name = "RepositoryItemGridLookUpEdit10View"
        Me.RepositoryItemGridLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit10View.OptionsView.ShowGroupPanel = False
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'PILookUpTableAdapter
        '
        Me.PILookUpTableAdapter.ClearBeforeFill = True
        '
        'PIAndItemwiseBalanceSubTableAdapter
        '
        Me.PIAndItemwiseBalanceSubTableAdapter.ClearBeforeFill = True
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PIListTableAdapter = Me.PIListTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(18, 299)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(65, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Export to file"
        '
        'ReceivedMRNoLookupTableAdapter
        '
        Me.ReceivedMRNoLookupTableAdapter.ClearBeforeFill = True
        '
        'colBatchNo5
        '
        Me.colBatchNo5.FieldName = "BatchNo"
        Me.colBatchNo5.Name = "colBatchNo5"
        Me.colBatchNo5.Visible = True
        Me.colBatchNo5.VisibleIndex = 0
        '
        'ProgramNoWithStyleBuyerLookUpTableAdapter
        '
        Me.ProgramNoWithStyleBuyerLookUpTableAdapter.ClearBeforeFill = True
        '
        'frmIssueDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 595)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.IssuetoGridControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BatchButton)
        Me.Controls.Add(Me.ProductionDateUpdateButton)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ProductionQuantityTextEdit)
        Me.Controls.Add(ProductionQuantityLabel)
        Me.Controls.Add(Me.ProductionTypeComboBox)
        Me.Controls.Add(ProductionTypeLabel1)
        Me.KeyPreview = True
        Me.Name = "frmIssueDetails"
        Me.Text = "Issue Details"
        CType(Me.IssuetoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuetoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ItemNameSrchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MachineListIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineListIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuetoQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdCopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceSubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceSubDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceSubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivedMRNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PILookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuetoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuetoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoWithStyleBuyerLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoWithStyleBuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PiListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IssuetoDataSet As KSoft_Inventory.IssuetoDataSet
    Friend WithEvents IssuetoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssuetoTableAdapter As KSoft_Inventory.IssuetoDataSetTableAdapters.IssuetoTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.IssuetoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IssuetoDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Inventory.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents ShiftDataSet As KSoft_Inventory.ShiftDataSet
    Friend WithEvents ShiftBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShiftTableAdapter As KSoft_Inventory.ShiftDataSetTableAdapters.ShiftTableAdapter
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents BranchDataSet As KSoft_Inventory.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ShiftComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IssuetoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrintingMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediaDataSet As KSoft_Inventory.MediaDataSet
    Friend WithEvents PrintingMediaTableAdapter As KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter
    Friend WithEvents IssueReceiveTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItemNameSrchGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RequisitionNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssueReceiveTypeIdLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierIdLabel As System.Windows.Forms.Label
    Friend WithEvents CopyCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents IssueReceiveTypeDataSet As KSoft_Inventory.IssueReceiveTypeDataSet
    Friend WithEvents IssueReceiveTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueReceiveTypeTableAdapter As KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ItemIdCopyCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabStopCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AutoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GetPriceButton As System.Windows.Forms.Button
    Friend WithEvents ProductionTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BatchLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductionDateUpdateButton As System.Windows.Forms.Button
    Friend WithEvents BatchButton As System.Windows.Forms.Button
    Friend WithEvents BatchLookupDataSet As KSoft_Inventory.BatchLookupDataSet
    Friend WithEvents BatchLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchLookupTableAdapter As KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
    Friend WithEvents colBatchInformationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductionQuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents BatchInformationIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BatchInformationIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents IssuetoQuantityTextBox As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BatchCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateBatchCommentsLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colBatchInformationId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsReady As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents BatchInformationLookupDataSet As KSoft_Inventory.BatchInformationLookupDataSet
    Friend WithEvents BatchInformationLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchInformationLookupTableAdapter As KSoft_Inventory.BatchInformationLookupDataSetTableAdapters.BatchInformationLookupTableAdapter
    Friend WithEvents rowBatchNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMachineNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProgramNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBuyer As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFabricColorName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStyleNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowELDNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBatchQuantity As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBatchQuantityYrds As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDia As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDiaType As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFinishUnit As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComposition As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKnittingType As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBatchInformationId As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents MachineListIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents MachineListIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MachineListDataSet As KSoft_Inventory.MachineListDataSet
    Friend WithEvents MachineListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachineListTableAdapter As KSoft_Inventory.MachineListDataSetTableAdapters.MachineListTableAdapter
    Friend WithEvents colMachineListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuditAllocationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInternalSerialNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineSerialNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IssuetoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIssuetoId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuetoDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssuetoQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintingmediaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchInformationId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpdateOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineListId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssuetoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShiftGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssueTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BatchNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDataSet As KSoft_Inventory.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintingMediaId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMediaName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELDNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchQuantityYrds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchInformationId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASSWORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_LEVEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReceiveDataSet As KSoft_Inventory.ReceiveDataSet
    Friend WithEvents PILookUpDataSet As KSoft_Inventory.PILookUpDataSet
    Friend WithEvents PILookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PILookUpTableAdapter As KSoft_Inventory.PILookUpDataSetTableAdapters.PILookUpTableAdapter
    Friend WithEvents PIAndItemwiseBalanceSubBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIAndItemwiseBalanceSubDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIAndItemwiseBalanceSubDataSet As KSoft_Inventory.PIAndItemwiseBalanceSubDataSet
    Friend WithEvents PIAndItemwiseBalanceSubTableAdapter As KSoft_Inventory.PIAndItemwiseBalanceSubDataSetTableAdapters.PIAndItemwiseBalanceSubTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPIId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPIId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPIId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PiListDataSet As KSoft_Inventory.PiListDataSet
    Friend WithEvents PIListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListTableAdapter As KSoft_Inventory.PiListDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Inventory.PiListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPIId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents ReceivedMRNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceivedMRNoLookupTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceivedMRNoLookupTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBatchNo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit8View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBatchNo5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit9View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit10View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BalanceQtyLabel As System.Windows.Forms.Label
    Friend WithEvents GetRecipeButton As System.Windows.Forms.Button
    Friend WithEvents RecipeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit11View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgramNoWithStyleBuyerDataSet As ProgramNoWithStyleBuyerDataSet
    Friend WithEvents ProgramNoWithStyleBuyerLookUpBindingSource As BindingSource
    Friend WithEvents ProgramNoWithStyleBuyerLookUpTableAdapter As ProgramNoWithStyleBuyerDataSetTableAdapters.ProgramNoWithStyleBuyerLookUpTableAdapter
    Friend WithEvents RequisitionNoLinkLabel As LinkLabel
End Class
