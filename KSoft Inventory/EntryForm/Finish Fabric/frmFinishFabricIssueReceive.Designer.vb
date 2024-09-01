<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishFabricIssueReceive
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
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim FinishFabricBookingIdLabel As System.Windows.Forms.Label
        Dim ReceiveQuantityLabel As System.Windows.Forms.Label
        Dim IssueQuantityLabel As System.Windows.Forms.Label
        Dim BatchNoLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim LCNoLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim LocationReferenceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim BranchIdLabel1 As System.Windows.Forms.Label
        Dim LCDateLabel As System.Windows.Forms.Label
        Dim RollQuantityLabel As System.Windows.Forms.Label
        Dim GatePassNoLabel As System.Windows.Forms.Label
        Dim VehicleNoLabel As System.Windows.Forms.Label
        Dim IssueReceiveTypeIdLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ReceiveQuantity_YrdsLabel As System.Windows.Forms.Label
        Dim ReceiveQuantity_PcsLabel As System.Windows.Forms.Label
        Dim IssueQuantity_YrdsLabel As System.Windows.Forms.Label
        Dim IssueQuantity_PcsLabel As System.Windows.Forms.Label
        Dim RollQuantity_IssueLabel As System.Windows.Forms.Label
        Dim BatchNoLabel1 As System.Windows.Forms.Label
        Dim BranchIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinishFabricIssueReceive))
        Me.FinishFabricReceiveIssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricReceiveIssueDataSet = New KSoft_Inventory.FinishFabricReceiveIssueDataSet
        Me.ChallanNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ChallanDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ReceiveQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.IssueQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LCNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FinishFabricReceiveIssueTableAdapter = New KSoft_Inventory.FinishFabricReceiveIssueDataSetTableAdapters.FinishFabricReceiveIssueTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.FinishFabricReceiveIssueDataSetTableAdapters.TableAdapterManager
        Me.IsImportedCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.FinishFabricReceiveIssueGridControl = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colChallanDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colChallanNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIssueReceiveTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.IssueReceiveTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueReceiveTypeDataSet = New KSoft_Inventory.IssueReceiveTypeDataSet
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBatchNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBatchInformationId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.BatchLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchLookupDataSet = New KSoft_Inventory.BatchLookupDataSet
        Me.colFinishFabricBookingDetailsId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FinishFabricLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet
        Me.colIsClose = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colReceiveQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colReceiveQuantity_Yrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colReceiveQuantity_Pcs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRollQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colIssueQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIssueQuantity_Cutting_Pcs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIssueQuantity_Yrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIssueQuantity_Cutting_Yrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIssueQuantity_Pcs = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRollQuantity_Issue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFFReceiveIssueId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDyeingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLCNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLCDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSupplierId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet
        Me.colLocationReference = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIsImported = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colGatePassNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colVehicleNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCompanyId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet
        Me.colIssueQuantity_Cutting = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBranchId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colUnitId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.FinishFabricLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.IssueReceiveTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.IssueReceiveTypeTableAdapter = New KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
        Me.LCDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CopyCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.RollQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.GatePassNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.VehicleNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FinishFabricLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupTableAdapter
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.FinishFabricOrderLookupBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAmendmentNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishFabricBookingId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsDevelopment1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ShowAllButton = New System.Windows.Forms.Button
        Me.FinishFabricBookingDetailsIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPart1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishFabricBookingDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishFabricBookingId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FinishFabricBookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.IssueReceiveTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIssueReceiveTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIssueTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IssueReceiveTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.NewButton = New System.Windows.Forms.Button
        Me.BatchInformationIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBatchInformationId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBatchNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsReady = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsDevelopment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BatchInformationIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.BatchLookupTableAdapter = New KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.CompanyIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWebsite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWeeklyOff = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CompanyIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
        Me.FinishFabricGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishFabricBookingDetailsId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishFabricBookingId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ByProgramNoButton = New System.Windows.Forms.Button
        Me.LocationReferenceComboBox = New System.Windows.Forms.ComboBox
        Me.ReceiveQuantity_YrdsSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ReceiveQuantity_PcsSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.IssueQuantity_YrdsSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.IssueQuantity_PcsSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.RollQuantity_IssueSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.BatchNoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BranchIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBranchId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BranchIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.FinishFabricLookupNewTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupNewTableAdapter
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Inventory.GarmentsPartDataSet
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Inventory.KnittingTypeDataSet
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Inventory.CompositionDataSet
        Me.FinishFabricBookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricBookingDataSet = New KSoft_Inventory.FinishFabricBookingDataSet
        Me.FinishFabricBookingDetailsTableAdapter = New KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.FinishFabricBookingDetailsTableAdapter
        Me.BatchLookupDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartTableAdapter = New KSoft_Inventory.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
        Me.KnittingTypeTableAdapter = New KSoft_Inventory.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.CompositionTableAdapter = New KSoft_Inventory.CompositionDataSetTableAdapters.CompositionTableAdapter
        ChallanNoLabel = New System.Windows.Forms.Label
        ChallanDateLabel = New System.Windows.Forms.Label
        FinishFabricBookingIdLabel = New System.Windows.Forms.Label
        ReceiveQuantityLabel = New System.Windows.Forms.Label
        IssueQuantityLabel = New System.Windows.Forms.Label
        BatchNoLabel = New System.Windows.Forms.Label
        RemarksLabel = New System.Windows.Forms.Label
        LCNoLabel = New System.Windows.Forms.Label
        SupplierIdLabel = New System.Windows.Forms.Label
        LocationReferenceLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        BranchIdLabel1 = New System.Windows.Forms.Label
        LCDateLabel = New System.Windows.Forms.Label
        RollQuantityLabel = New System.Windows.Forms.Label
        GatePassNoLabel = New System.Windows.Forms.Label
        VehicleNoLabel = New System.Windows.Forms.Label
        IssueReceiveTypeIdLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        ReceiveQuantity_YrdsLabel = New System.Windows.Forms.Label
        ReceiveQuantity_PcsLabel = New System.Windows.Forms.Label
        IssueQuantity_YrdsLabel = New System.Windows.Forms.Label
        IssueQuantity_PcsLabel = New System.Windows.Forms.Label
        RollQuantity_IssueLabel = New System.Windows.Forms.Label
        BatchNoLabel1 = New System.Windows.Forms.Label
        BranchIdLabel = New System.Windows.Forms.Label
        CType(Me.FinishFabricReceiveIssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricReceiveIssueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsImportedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricReceiveIssueGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingDetailsIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchInformationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveQuantity_YrdsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveQuantity_PcsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueQuantity_YrdsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueQuantity_PcsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollQuantity_IssueSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(25, 57)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 25
        ChallanNoLabel.Text = "Challan No:"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(25, 83)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 26
        ChallanDateLabel.Text = "Challan Date:"
        '
        'FinishFabricBookingIdLabel
        '
        FinishFabricBookingIdLabel.AutoSize = True
        FinishFabricBookingIdLabel.Location = New System.Drawing.Point(471, 139)
        FinishFabricBookingIdLabel.Name = "FinishFabricBookingIdLabel"
        FinishFabricBookingIdLabel.Size = New System.Drawing.Size(74, 13)
        FinishFabricBookingIdLabel.TabIndex = 47
        FinishFabricBookingIdLabel.Text = "Fabric Details:"
        '
        'ReceiveQuantityLabel
        '
        ReceiveQuantityLabel.AutoSize = True
        ReceiveQuantityLabel.Location = New System.Drawing.Point(471, 166)
        ReceiveQuantityLabel.Name = "ReceiveQuantityLabel"
        ReceiveQuantityLabel.Size = New System.Drawing.Size(98, 13)
        ReceiveQuantityLabel.TabIndex = 48
        ReceiveQuantityLabel.Text = "Received Quantity:"
        '
        'IssueQuantityLabel
        '
        IssueQuantityLabel.AutoSize = True
        IssueQuantityLabel.Location = New System.Drawing.Point(707, 166)
        IssueQuantityLabel.Name = "IssueQuantityLabel"
        IssueQuantityLabel.Size = New System.Drawing.Size(80, 13)
        IssueQuantityLabel.TabIndex = 52
        IssueQuantityLabel.Text = "Issue Quantity :"
        '
        'BatchNoLabel
        '
        BatchNoLabel.AutoSize = True
        BatchNoLabel.Location = New System.Drawing.Point(472, 62)
        BatchNoLabel.Name = "BatchNoLabel"
        BatchNoLabel.Size = New System.Drawing.Size(55, 13)
        BatchNoLabel.TabIndex = 44
        BatchNoLabel.Text = "Batch No:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(25, 247)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 32
        RemarksLabel.Text = "Remarks:"
        '
        'LCNoLabel
        '
        LCNoLabel.AutoSize = True
        LCNoLabel.Location = New System.Drawing.Point(263, 85)
        LCNoLabel.Name = "LCNoLabel"
        LCNoLabel.Size = New System.Drawing.Size(40, 13)
        LCNoLabel.TabIndex = 34
        LCNoLabel.Text = "LC No:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(25, 192)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(124, 13)
        SupplierIdLabel.TabIndex = 30
        SupplierIdLabel.Text = "Receive From / Issue to:"
        '
        'LocationReferenceLabel
        '
        LocationReferenceLabel.AutoSize = True
        LocationReferenceLabel.Location = New System.Drawing.Point(25, 220)
        LocationReferenceLabel.Name = "LocationReferenceLabel"
        LocationReferenceLabel.Size = New System.Drawing.Size(104, 13)
        LocationReferenceLabel.TabIndex = 31
        LocationReferenceLabel.Text = "Location Reference:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(263, 59)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 33
        Label1.Text = "Local :"
        '
        'BranchIdLabel1
        '
        BranchIdLabel1.AutoSize = True
        BranchIdLabel1.Location = New System.Drawing.Point(25, 110)
        BranchIdLabel1.Name = "BranchIdLabel1"
        BranchIdLabel1.Size = New System.Drawing.Size(57, 13)
        BranchIdLabel1.TabIndex = 27
        BranchIdLabel1.Text = "Company :"
        '
        'LCDateLabel
        '
        LCDateLabel.AutoSize = True
        LCDateLabel.Location = New System.Drawing.Point(262, 112)
        LCDateLabel.Name = "LCDateLabel"
        LCDateLabel.Size = New System.Drawing.Size(49, 13)
        LCDateLabel.TabIndex = 35
        LCDateLabel.Text = "LC Date:"
        '
        'RollQuantityLabel
        '
        RollQuantityLabel.AutoSize = True
        RollQuantityLabel.Location = New System.Drawing.Point(470, 245)
        RollQuantityLabel.Name = "RollQuantityLabel"
        RollQuantityLabel.Size = New System.Drawing.Size(113, 13)
        RollQuantityLabel.TabIndex = 51
        RollQuantityLabel.Text = "Recived Roll Quantity:"
        '
        'GatePassNoLabel
        '
        GatePassNoLabel.AutoSize = True
        GatePassNoLabel.Location = New System.Drawing.Point(262, 166)
        GatePassNoLabel.Name = "GatePassNoLabel"
        GatePassNoLabel.Size = New System.Drawing.Size(76, 13)
        GatePassNoLabel.TabIndex = 37
        GatePassNoLabel.Text = "Gate Pass No:"
        '
        'VehicleNoLabel
        '
        VehicleNoLabel.AutoSize = True
        VehicleNoLabel.Location = New System.Drawing.Point(262, 139)
        VehicleNoLabel.Name = "VehicleNoLabel"
        VehicleNoLabel.Size = New System.Drawing.Size(62, 13)
        VehicleNoLabel.TabIndex = 36
        VehicleNoLabel.Text = "Vehicle No:"
        '
        'IssueReceiveTypeIdLabel
        '
        IssueReceiveTypeIdLabel.AutoSize = True
        IssueReceiveTypeIdLabel.Location = New System.Drawing.Point(25, 166)
        IssueReceiveTypeIdLabel.Name = "IssueReceiveTypeIdLabel"
        IssueReceiveTypeIdLabel.Size = New System.Drawing.Size(107, 13)
        IssueReceiveTypeIdLabel.TabIndex = 29
        IssueReceiveTypeIdLabel.Text = "Issue/Receive Type:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(472, 85)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 13)
        Label3.TabIndex = 45
        Label3.Text = "Program No:"
        '
        'ReceiveQuantity_YrdsLabel
        '
        ReceiveQuantity_YrdsLabel.AutoSize = True
        ReceiveQuantity_YrdsLabel.Location = New System.Drawing.Point(470, 193)
        ReceiveQuantity_YrdsLabel.Name = "ReceiveQuantity_YrdsLabel"
        ReceiveQuantity_YrdsLabel.Size = New System.Drawing.Size(122, 13)
        ReceiveQuantity_YrdsLabel.TabIndex = 49
        ReceiveQuantity_YrdsLabel.Text = "Received Quantity Yrds:"
        '
        'ReceiveQuantity_PcsLabel
        '
        ReceiveQuantity_PcsLabel.AutoSize = True
        ReceiveQuantity_PcsLabel.Location = New System.Drawing.Point(470, 219)
        ReceiveQuantity_PcsLabel.Name = "ReceiveQuantity_PcsLabel"
        ReceiveQuantity_PcsLabel.Size = New System.Drawing.Size(119, 13)
        ReceiveQuantity_PcsLabel.TabIndex = 50
        ReceiveQuantity_PcsLabel.Text = "Received Quantity Pcs:"
        '
        'IssueQuantity_YrdsLabel
        '
        IssueQuantity_YrdsLabel.AutoSize = True
        IssueQuantity_YrdsLabel.Location = New System.Drawing.Point(707, 190)
        IssueQuantity_YrdsLabel.Name = "IssueQuantity_YrdsLabel"
        IssueQuantity_YrdsLabel.Size = New System.Drawing.Size(101, 13)
        IssueQuantity_YrdsLabel.TabIndex = 53
        IssueQuantity_YrdsLabel.Text = "Issue Quantity Yrds:"
        '
        'IssueQuantity_PcsLabel
        '
        IssueQuantity_PcsLabel.AutoSize = True
        IssueQuantity_PcsLabel.Location = New System.Drawing.Point(707, 218)
        IssueQuantity_PcsLabel.Name = "IssueQuantity_PcsLabel"
        IssueQuantity_PcsLabel.Size = New System.Drawing.Size(98, 13)
        IssueQuantity_PcsLabel.TabIndex = 54
        IssueQuantity_PcsLabel.Text = "Issue Quantity Pcs:"
        '
        'RollQuantity_IssueLabel
        '
        RollQuantity_IssueLabel.AutoSize = True
        RollQuantity_IssueLabel.Location = New System.Drawing.Point(707, 247)
        RollQuantity_IssueLabel.Name = "RollQuantity_IssueLabel"
        RollQuantity_IssueLabel.Size = New System.Drawing.Size(98, 13)
        RollQuantity_IssueLabel.TabIndex = 55
        RollQuantity_IssueLabel.Text = "Roll Quantity Issue:"
        '
        'BatchNoLabel1
        '
        BatchNoLabel1.AutoSize = True
        BatchNoLabel1.Location = New System.Drawing.Point(471, 113)
        BatchNoLabel1.Name = "BatchNoLabel1"
        BatchNoLabel1.Size = New System.Drawing.Size(55, 13)
        BatchNoLabel1.TabIndex = 46
        BatchNoLabel1.Text = "Batch No:"
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(25, 137)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(44, 13)
        BranchIdLabel.TabIndex = 28
        BranchIdLabel.Text = "Branch:"
        '
        'FinishFabricReceiveIssueBindingSource
        '
        Me.FinishFabricReceiveIssueBindingSource.DataMember = "FinishFabricReceiveIssue"
        Me.FinishFabricReceiveIssueBindingSource.DataSource = Me.FinishFabricReceiveIssueDataSet
        '
        'FinishFabricReceiveIssueDataSet
        '
        Me.FinishFabricReceiveIssueDataSet.DataSetName = "FinishFabricReceiveIssueDataSet"
        Me.FinishFabricReceiveIssueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "ChallanNo", True))
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(146, 56)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(111, 20)
        Me.ChallanNoTextEdit.TabIndex = 0
        '
        'ChallanDateDateEdit
        '
        Me.ChallanDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "ChallanDate", True))
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(146, 82)
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(111, 20)
        Me.ChallanDateDateEdit.TabIndex = 1
        '
        'ReceiveQuantitySpinEdit
        '
        Me.ReceiveQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "ReceiveQuantity", True))
        Me.ReceiveQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ReceiveQuantitySpinEdit.Location = New System.Drawing.Point(600, 163)
        Me.ReceiveQuantitySpinEdit.Name = "ReceiveQuantitySpinEdit"
        Me.ReceiveQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Cyan
        Me.ReceiveQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ReceiveQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ReceiveQuantitySpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.ReceiveQuantitySpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantitySpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.ReceiveQuantitySpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantitySpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.ReceiveQuantitySpinEdit.TabIndex = 13
        '
        'IssueQuantitySpinEdit
        '
        Me.IssueQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "IssueQuantity", True))
        Me.IssueQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IssueQuantitySpinEdit.Location = New System.Drawing.Point(821, 163)
        Me.IssueQuantitySpinEdit.Name = "IssueQuantitySpinEdit"
        Me.IssueQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.LightSalmon
        Me.IssueQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IssueQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.IssueQuantitySpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.IssueQuantitySpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantitySpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.IssueQuantitySpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantitySpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.IssueQuantitySpinEdit.TabIndex = 14
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(146, 240)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(308, 20)
        Me.RemarksTextEdit.TabIndex = 7
        '
        'LCNoTextEdit
        '
        Me.LCNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "LCNo", True))
        Me.LCNoTextEdit.Location = New System.Drawing.Point(344, 82)
        Me.LCNoTextEdit.Name = "LCNoTextEdit"
        Me.LCNoTextEdit.Size = New System.Drawing.Size(110, 20)
        Me.LCNoTextEdit.TabIndex = 40
        '
        'FinishFabricReceiveIssueTableAdapter
        '
        Me.FinishFabricReceiveIssueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishFabricReceiveIssueTableAdapter = Me.FinishFabricReceiveIssueTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.FinishFabricReceiveIssueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IsImportedCheckEdit
        '
        Me.IsImportedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "IsImported", True))
        Me.IsImportedCheckEdit.Location = New System.Drawing.Point(342, 56)
        Me.IsImportedCheckEdit.Name = "IsImportedCheckEdit"
        Me.IsImportedCheckEdit.Properties.Caption = ""
        Me.IsImportedCheckEdit.Size = New System.Drawing.Size(27, 19)
        Me.IsImportedCheckEdit.TabIndex = 38
        '
        'FinishFabricReceiveIssueGridControl
        '
        Me.FinishFabricReceiveIssueGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishFabricReceiveIssueGridControl.DataSource = Me.FinishFabricReceiveIssueBindingSource
        Me.FinishFabricReceiveIssueGridControl.Location = New System.Drawing.Point(0, 285)
        Me.FinishFabricReceiveIssueGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FinishFabricReceiveIssueGridControl.MainView = Me.BandedGridView1
        Me.FinishFabricReceiveIssueGridControl.Name = "FinishFabricReceiveIssueGridControl"
        Me.FinishFabricReceiveIssueGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit8})
        Me.FinishFabricReceiveIssueGridControl.Size = New System.Drawing.Size(1064, 284)
        Me.FinishFabricReceiveIssueGridControl.TabIndex = 0
        Me.FinishFabricReceiveIssueGridControl.Tag = "NR"
        Me.FinishFabricReceiveIssueGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1, Me.GridView2})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.Empty.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BandedGridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BandedGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.BandedGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.Preview.Options.UseFont = True
        Me.BandedGridView1.Appearance.Preview.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.Row.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.Row.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5, Me.GridBand2, Me.GridBand3, Me.GridBand4, Me.GridBand1})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFFReceiveIssueId, Me.colChallanNo, Me.colChallanDate, Me.colFinishFabricBookingDetailsId, Me.colBatchInformationId1, Me.colReceiveQuantity, Me.colIssueQuantity, Me.colRemarks, Me.colLCNo, Me.colLCDate, Me.colSupplierId, Me.colLocationReference, Me.colIsImported, Me.colGatePassNo, Me.colIssueReceiveTypeId, Me.colRollQuantity, Me.colVehicleNo, Me.colDyeingDate, Me.colCompanyId1, Me.colBatchNo, Me.colIssueQuantity_Cutting, Me.colBranchId, Me.colIssueQuantity_Cutting_Pcs, Me.colIssueQuantity_Cutting_Yrds, Me.colIssueQuantity_Pcs, Me.colIssueQuantity_Yrds, Me.colReceiveQuantity_Pcs, Me.colReceiveQuantity_Yrds, Me.colRollQuantity_Issue, Me.colUnitId, Me.colIsClose})
        Me.BandedGridView1.GridControl = Me.FinishFabricReceiveIssueGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView1.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "Basic Information"
        Me.GridBand5.Columns.Add(Me.colChallanDate)
        Me.GridBand5.Columns.Add(Me.colChallanNo)
        Me.GridBand5.Columns.Add(Me.colIssueReceiveTypeId)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 226
        '
        'colChallanDate
        '
        Me.colChallanDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colChallanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colChallanDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.Width = 66
        '
        'colChallanNo
        '
        Me.colChallanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colChallanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colChallanNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        '
        'colIssueReceiveTypeId
        '
        Me.colIssueReceiveTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueReceiveTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueReceiveTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueReceiveTypeId.Caption = "Issue Receive Type"
        Me.colIssueReceiveTypeId.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colIssueReceiveTypeId.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId.Name = "colIssueReceiveTypeId"
        Me.colIssueReceiveTypeId.Visible = True
        Me.colIssueReceiveTypeId.Width = 85
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.IssueReceiveTypeBindingSource1
        Me.RepositoryItemLookUpEdit6.DisplayMember = "IssueTypeName"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit6.ValueMember = "IssueReceiveTypeId"
        '
        'IssueReceiveTypeBindingSource1
        '
        Me.IssueReceiveTypeBindingSource1.DataMember = "IssueReceiveType"
        Me.IssueReceiveTypeBindingSource1.DataSource = Me.IssueReceiveTypeDataSet
        '
        'IssueReceiveTypeDataSet
        '
        Me.IssueReceiveTypeDataSet.DataSetName = "IssueReceiveTypeDataSet"
        Me.IssueReceiveTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Fabric Information"
        Me.GridBand2.Columns.Add(Me.colBatchNo)
        Me.GridBand2.Columns.Add(Me.colBatchInformationId1)
        Me.GridBand2.Columns.Add(Me.colFinishFabricBookingDetailsId)
        Me.GridBand2.Columns.Add(Me.colIsClose)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 221
        '
        'colBatchNo
        '
        Me.colBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        '
        'colBatchInformationId1
        '
        Me.colBatchInformationId1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBatchInformationId1.AppearanceCell.Options.UseBackColor = True
        Me.colBatchInformationId1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBatchInformationId1.AppearanceHeader.Options.UseBackColor = True
        Me.colBatchInformationId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchInformationId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchInformationId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchInformationId1.Caption = "Batch No"
        Me.colBatchInformationId1.ColumnEdit = Me.RepositoryItemLookUpEdit7
        Me.colBatchInformationId1.FieldName = "BatchInformationId"
        Me.colBatchInformationId1.Name = "colBatchInformationId1"
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.DataSource = Me.BatchLookupBindingSource
        Me.RepositoryItemLookUpEdit7.DisplayMember = "BatchNo"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        Me.RepositoryItemLookUpEdit7.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit7.ValueMember = "BatchInformationId"
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
        'colFinishFabricBookingDetailsId
        '
        Me.colFinishFabricBookingDetailsId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishFabricBookingDetailsId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishFabricBookingDetailsId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishFabricBookingDetailsId.Caption = "Fabric Details"
        Me.colFinishFabricBookingDetailsId.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colFinishFabricBookingDetailsId.FieldName = "FinishFabricBookingDetailsId"
        Me.colFinishFabricBookingDetailsId.Name = "colFinishFabricBookingDetailsId"
        Me.colFinishFabricBookingDetailsId.Visible = True
        Me.colFinishFabricBookingDetailsId.Width = 146
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RepositoryItemLookUpEdit5.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProgramNo", "Program No", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FabricColorName", "Fabric Color Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishFabricBookingDetailsId", "Finish Fabric Booking Details Id", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Details", "Details", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.FinishFabricLookupNewBindingSource
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Details"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit5.ValueMember = "FinishFabricBookingDetailsId"
        '
        'FinishFabricLookupNewBindingSource
        '
        Me.FinishFabricLookupNewBindingSource.DataMember = "FinishFabricLookupNew"
        Me.FinishFabricLookupNewBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colIsClose
        '
        Me.colIsClose.FieldName = "IsClose"
        Me.colIsClose.Name = "colIsClose"
        Me.colIsClose.Width = 48
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Receive"
        Me.GridBand3.Columns.Add(Me.colReceiveQuantity)
        Me.GridBand3.Columns.Add(Me.colReceiveQuantity_Yrds)
        Me.GridBand3.Columns.Add(Me.colReceiveQuantity_Pcs)
        Me.GridBand3.Columns.Add(Me.colRollQuantity)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 235
        '
        'colReceiveQuantity
        '
        Me.colReceiveQuantity.AppearanceCell.BackColor = System.Drawing.Color.Cyan
        Me.colReceiveQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colReceiveQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Cyan
        Me.colReceiveQuantity.AppearanceHeader.Options.UseBackColor = True
        Me.colReceiveQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiveQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiveQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiveQuantity.Caption = "KG"
        Me.colReceiveQuantity.DisplayFormat.FormatString = "n0"
        Me.colReceiveQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colReceiveQuantity.FieldName = "ReceiveQuantity"
        Me.colReceiveQuantity.Name = "colReceiveQuantity"
        Me.colReceiveQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colReceiveQuantity.Visible = True
        Me.colReceiveQuantity.Width = 58
        '
        'colReceiveQuantity_Yrds
        '
        Me.colReceiveQuantity_Yrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiveQuantity_Yrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiveQuantity_Yrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiveQuantity_Yrds.Caption = "YRD"
        Me.colReceiveQuantity_Yrds.DisplayFormat.FormatString = "n0"
        Me.colReceiveQuantity_Yrds.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colReceiveQuantity_Yrds.FieldName = "ReceiveQuantity_Yrds"
        Me.colReceiveQuantity_Yrds.Name = "colReceiveQuantity_Yrds"
        Me.colReceiveQuantity_Yrds.Visible = True
        Me.colReceiveQuantity_Yrds.Width = 60
        '
        'colReceiveQuantity_Pcs
        '
        Me.colReceiveQuantity_Pcs.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiveQuantity_Pcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiveQuantity_Pcs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiveQuantity_Pcs.Caption = "PCS"
        Me.colReceiveQuantity_Pcs.DisplayFormat.FormatString = "n0"
        Me.colReceiveQuantity_Pcs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colReceiveQuantity_Pcs.FieldName = "ReceiveQuantity_Pcs"
        Me.colReceiveQuantity_Pcs.Name = "colReceiveQuantity_Pcs"
        Me.colReceiveQuantity_Pcs.Visible = True
        Me.colReceiveQuantity_Pcs.Width = 63
        '
        'colRollQuantity
        '
        Me.colRollQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colRollQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRollQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRollQuantity.Caption = "Roll"
        Me.colRollQuantity.DisplayFormat.FormatString = "n0"
        Me.colRollQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colRollQuantity.FieldName = "RollQuantity"
        Me.colRollQuantity.Name = "colRollQuantity"
        Me.colRollQuantity.Visible = True
        Me.colRollQuantity.Width = 54
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Issue"
        Me.GridBand4.Columns.Add(Me.colIssueQuantity)
        Me.GridBand4.Columns.Add(Me.colIssueQuantity_Cutting_Pcs)
        Me.GridBand4.Columns.Add(Me.colIssueQuantity_Yrds)
        Me.GridBand4.Columns.Add(Me.colIssueQuantity_Cutting_Yrds)
        Me.GridBand4.Columns.Add(Me.colIssueQuantity_Pcs)
        Me.GridBand4.Columns.Add(Me.colRollQuantity_Issue)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 235
        '
        'colIssueQuantity
        '
        Me.colIssueQuantity.AppearanceCell.BackColor = System.Drawing.Color.LightSalmon
        Me.colIssueQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colIssueQuantity.AppearanceHeader.BackColor = System.Drawing.Color.LightSalmon
        Me.colIssueQuantity.AppearanceHeader.Options.UseBackColor = True
        Me.colIssueQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity.Caption = "KG"
        Me.colIssueQuantity.DisplayFormat.FormatString = "n0"
        Me.colIssueQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colIssueQuantity.FieldName = "IssueQuantity"
        Me.colIssueQuantity.Name = "colIssueQuantity"
        Me.colIssueQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colIssueQuantity.Visible = True
        Me.colIssueQuantity.Width = 73
        '
        'colIssueQuantity_Cutting_Pcs
        '
        Me.colIssueQuantity_Cutting_Pcs.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity_Cutting_Pcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity_Cutting_Pcs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity_Cutting_Pcs.Caption = "PCS"
        Me.colIssueQuantity_Cutting_Pcs.FieldName = "IssueQuantity_Cutting_Pcs"
        Me.colIssueQuantity_Cutting_Pcs.Name = "colIssueQuantity_Cutting_Pcs"
        Me.colIssueQuantity_Cutting_Pcs.Width = 72
        '
        'colIssueQuantity_Yrds
        '
        Me.colIssueQuantity_Yrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity_Yrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity_Yrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity_Yrds.Caption = "YRD"
        Me.colIssueQuantity_Yrds.DisplayFormat.FormatString = "n0"
        Me.colIssueQuantity_Yrds.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colIssueQuantity_Yrds.FieldName = "IssueQuantity_Yrds"
        Me.colIssueQuantity_Yrds.Name = "colIssueQuantity_Yrds"
        Me.colIssueQuantity_Yrds.Visible = True
        Me.colIssueQuantity_Yrds.Width = 56
        '
        'colIssueQuantity_Cutting_Yrds
        '
        Me.colIssueQuantity_Cutting_Yrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity_Cutting_Yrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity_Cutting_Yrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity_Cutting_Yrds.Caption = "Roll"
        Me.colIssueQuantity_Cutting_Yrds.FieldName = "IssueQuantity_Cutting_Yrds"
        Me.colIssueQuantity_Cutting_Yrds.Name = "colIssueQuantity_Cutting_Yrds"
        Me.colIssueQuantity_Cutting_Yrds.Width = 96
        '
        'colIssueQuantity_Pcs
        '
        Me.colIssueQuantity_Pcs.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity_Pcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity_Pcs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity_Pcs.Caption = "PCS"
        Me.colIssueQuantity_Pcs.DisplayFormat.FormatString = "n0"
        Me.colIssueQuantity_Pcs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colIssueQuantity_Pcs.FieldName = "IssueQuantity_Pcs"
        Me.colIssueQuantity_Pcs.Name = "colIssueQuantity_Pcs"
        Me.colIssueQuantity_Pcs.Visible = True
        Me.colIssueQuantity_Pcs.Width = 55
        '
        'colRollQuantity_Issue
        '
        Me.colRollQuantity_Issue.AppearanceHeader.Options.UseTextOptions = True
        Me.colRollQuantity_Issue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRollQuantity_Issue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRollQuantity_Issue.Caption = "Roll"
        Me.colRollQuantity_Issue.DisplayFormat.FormatString = "n0"
        Me.colRollQuantity_Issue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colRollQuantity_Issue.FieldName = "RollQuantity_Issue"
        Me.colRollQuantity_Issue.Name = "colRollQuantity_Issue"
        Me.colRollQuantity_Issue.Visible = True
        Me.colRollQuantity_Issue.Width = 51
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Basic Information"
        Me.GridBand1.Columns.Add(Me.colFFReceiveIssueId)
        Me.GridBand1.Columns.Add(Me.colDyeingDate)
        Me.GridBand1.Columns.Add(Me.colRemarks)
        Me.GridBand1.Columns.Add(Me.colLCNo)
        Me.GridBand1.Columns.Add(Me.colLCDate)
        Me.GridBand1.Columns.Add(Me.colSupplierId)
        Me.GridBand1.Columns.Add(Me.colLocationReference)
        Me.GridBand1.Columns.Add(Me.colIsImported)
        Me.GridBand1.Columns.Add(Me.colGatePassNo)
        Me.GridBand1.Columns.Add(Me.colVehicleNo)
        Me.GridBand1.Columns.Add(Me.colCompanyId1)
        Me.GridBand1.Columns.Add(Me.colIssueQuantity_Cutting)
        Me.GridBand1.Columns.Add(Me.colBranchId)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 758
        '
        'colFFReceiveIssueId
        '
        Me.colFFReceiveIssueId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFFReceiveIssueId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFFReceiveIssueId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFFReceiveIssueId.FieldName = "FFReceiveIssueId"
        Me.colFFReceiveIssueId.Name = "colFFReceiveIssueId"
        Me.colFFReceiveIssueId.OptionsColumn.ReadOnly = True
        Me.colFFReceiveIssueId.Width = 104
        '
        'colDyeingDate
        '
        Me.colDyeingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeingDate.FieldName = "DyeingDate"
        Me.colDyeingDate.Name = "colDyeingDate"
        Me.colDyeingDate.Width = 104
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.Width = 95
        '
        'colLCNo
        '
        Me.colLCNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLCNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLCNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.Width = 71
        '
        'colLCDate
        '
        Me.colLCDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLCDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLCDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        Me.colLCDate.Visible = True
        Me.colLCDate.Width = 57
        '
        'colSupplierId
        '
        Me.colSupplierId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.Width = 129
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierId", "Supplier Id", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Add1", "Add1", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Add2", "Add2", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactPerson", "Contact Person", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactNo", "Contact No", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierType", "Supplier Type", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 29, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "SupplierCode"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit3.ValueMember = "SupplierId"
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
        'colLocationReference
        '
        Me.colLocationReference.AppearanceHeader.Options.UseTextOptions = True
        Me.colLocationReference.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocationReference.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLocationReference.Caption = "Location Reference"
        Me.colLocationReference.FieldName = "LocationReference"
        Me.colLocationReference.Name = "colLocationReference"
        Me.colLocationReference.Visible = True
        Me.colLocationReference.Width = 66
        '
        'colIsImported
        '
        Me.colIsImported.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsImported.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsImported.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsImported.Caption = "Imported"
        Me.colIsImported.FieldName = "IsImported"
        Me.colIsImported.Name = "colIsImported"
        Me.colIsImported.Visible = True
        Me.colIsImported.Width = 77
        '
        'colGatePassNo
        '
        Me.colGatePassNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGatePassNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGatePassNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGatePassNo.FieldName = "GatePassNo"
        Me.colGatePassNo.Name = "colGatePassNo"
        Me.colGatePassNo.Visible = True
        Me.colGatePassNo.Width = 110
        '
        'colVehicleNo
        '
        Me.colVehicleNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colVehicleNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVehicleNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colVehicleNo.FieldName = "VehicleNo"
        Me.colVehicleNo.Name = "colVehicleNo"
        Me.colVehicleNo.Visible = True
        '
        'colCompanyId1
        '
        Me.colCompanyId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompanyId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompanyId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompanyId1.Caption = "Company"
        Me.colCompanyId1.ColumnEdit = Me.RepositoryItemLookUpEdit8
        Me.colCompanyId1.FieldName = "CompanyId"
        Me.colCompanyId1.Name = "colCompanyId1"
        Me.colCompanyId1.Visible = True
        Me.colCompanyId1.Width = 78
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.DataSource = Me.CompanyBindingSource
        Me.RepositoryItemLookUpEdit8.DisplayMember = "CompanyCode"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit8.ValueMember = "CompanyId"
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
        'colIssueQuantity_Cutting
        '
        Me.colIssueQuantity_Cutting.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colIssueQuantity_Cutting.AppearanceCell.Options.UseBackColor = True
        Me.colIssueQuantity_Cutting.AppearanceHeader.Options.UseTextOptions = True
        Me.colIssueQuantity_Cutting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIssueQuantity_Cutting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIssueQuantity_Cutting.Caption = "Issue Quantity [Cutting]"
        Me.colIssueQuantity_Cutting.FieldName = "IssueQuantity_Cutting"
        Me.colIssueQuantity_Cutting.Name = "colIssueQuantity_Cutting"
        Me.colIssueQuantity_Cutting.Width = 95
        '
        'colBranchId
        '
        Me.colBranchId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBranchId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBranchId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.BranchBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "BranchCode"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "BranchId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "SupplierId"
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
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.FinishFabricLookupBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Name"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "FinishFabricBookingDetailsId"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'FinishFabricLookupBindingSource
        '
        Me.FinishFabricLookupBindingSource.DataMember = "FinishFabricLookup"
        Me.FinishFabricLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchId", "Branch Id", 69, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCode", "Branch Code", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchName", "Branch Name", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchDescription", "Branch Description", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchType", "Branch Type", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.BranchBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "BranchCode"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit1.ValueMember = "BranchId"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinishFabricBookingId", "Finish Fabric Booking Id", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProgramNo", "Program No", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FabricColorName", "Fabric Color Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingType", "Knitting Type", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSM", "GSM", 31, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Details", "Details", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartName", "Part Name", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIA", "DIA", 28, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.FinishFabricLookupBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Details"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit2.ValueMember = "FinishFabricBookingDetailsId"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.IssueReceiveTypeBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "IssueTypeName"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit4.ValueMember = "IssueTypeName"
        '
        'IssueReceiveTypeBindingSource
        '
        Me.IssueReceiveTypeBindingSource.DataMember = "IssueReceiveType"
        Me.IssueReceiveTypeBindingSource.DataSource = Me.IssueReceiveTypeDataSet
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.FinishFabricReceiveIssueGridControl
        Me.GridView2.Name = "GridView2"
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId1, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
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
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
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
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(146, 189)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(308, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 5
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'IssueReceiveTypeTableAdapter
        '
        Me.IssueReceiveTypeTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'LCDateDateEdit
        '
        Me.LCDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "LCDate", True))
        Me.LCDateDateEdit.EditValue = Nothing
        Me.LCDateDateEdit.Location = New System.Drawing.Point(344, 109)
        Me.LCDateDateEdit.Name = "LCDateDateEdit"
        Me.LCDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.LCDateDateEdit.Size = New System.Drawing.Size(110, 20)
        Me.LCDateDateEdit.TabIndex = 41
        '
        'CopyCheckEdit
        '
        Me.CopyCheckEdit.Location = New System.Drawing.Point(405, 54)
        Me.CopyCheckEdit.Name = "CopyCheckEdit"
        Me.CopyCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CopyCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CopyCheckEdit.Properties.Caption = "Copy"
        Me.CopyCheckEdit.Size = New System.Drawing.Size(49, 19)
        Me.CopyCheckEdit.TabIndex = 39
        '
        'RollQuantitySpinEdit
        '
        Me.RollQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "RollQuantity", True))
        Me.RollQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RollQuantitySpinEdit.Location = New System.Drawing.Point(600, 242)
        Me.RollQuantitySpinEdit.Name = "RollQuantitySpinEdit"
        Me.RollQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RollQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RollQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RollQuantitySpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.RollQuantitySpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RollQuantitySpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.RollQuantitySpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RollQuantitySpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.RollQuantitySpinEdit.TabIndex = 19
        '
        'GatePassNoTextEdit
        '
        Me.GatePassNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "GatePassNo", True))
        Me.GatePassNoTextEdit.Location = New System.Drawing.Point(344, 161)
        Me.GatePassNoTextEdit.Name = "GatePassNoTextEdit"
        Me.GatePassNoTextEdit.Size = New System.Drawing.Size(110, 20)
        Me.GatePassNoTextEdit.TabIndex = 43
        '
        'VehicleNoTextEdit
        '
        Me.VehicleNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "VehicleNo", True))
        Me.VehicleNoTextEdit.Location = New System.Drawing.Point(344, 135)
        Me.VehicleNoTextEdit.Name = "VehicleNoTextEdit"
        Me.VehicleNoTextEdit.Size = New System.Drawing.Size(110, 20)
        Me.VehicleNoTextEdit.TabIndex = 42
        '
        'FinishFabricLookupTableAdapter
        '
        Me.FinishFabricLookupTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.ShowAllButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1064, 32)
        Me.FlowLayoutPanel3.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Finish Fabric Receive Issue"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(227, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource1
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "FinishFabricBookingId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView3
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(299, 20)
        Me.GridLookUpEdit1.TabIndex = 1
        '
        'FinishFabricOrderLookupBindingSource1
        '
        Me.FinishFabricOrderLookupBindingSource1.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource1.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo3, Me.colAmendmentNo1, Me.colFinishFabricBookingId2, Me.colDetails2, Me.colIsDevelopment1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo3
        '
        Me.colProgramNo3.FieldName = "ProgramNo"
        Me.colProgramNo3.Name = "colProgramNo3"
        Me.colProgramNo3.Visible = True
        Me.colProgramNo3.VisibleIndex = 0
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
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.OptionsColumn.ReadOnly = True
        '
        'colIsDevelopment1
        '
        Me.colIsDevelopment1.FieldName = "IsDevelopment"
        Me.colIsDevelopment1.Name = "colIsDevelopment1"
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(532, 5)
        Me.ShowAllButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllButton.TabIndex = 2
        Me.ShowAllButton.Text = "Show All"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        '
        'FinishFabricBookingDetailsIdGridLookUpEditView
        '
        Me.FinishFabricBookingDetailsIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colPart1, Me.colFinishFabricBookingDetailsId1, Me.colFinishFabricBookingId1, Me.colColor1, Me.colDetails})
        Me.FinishFabricBookingDetailsIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingDetailsIdGridLookUpEditView.Name = "FinishFabricBookingDetailsIdGridLookUpEditView"
        Me.FinishFabricBookingDetailsIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingDetailsIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        '
        'colPart1
        '
        Me.colPart1.FieldName = "Part"
        Me.colPart1.Name = "colPart1"
        Me.colPart1.OptionsColumn.ReadOnly = True
        '
        'colFinishFabricBookingDetailsId1
        '
        Me.colFinishFabricBookingDetailsId1.FieldName = "FinishFabricBookingDetailsId"
        Me.colFinishFabricBookingDetailsId1.Name = "colFinishFabricBookingDetailsId1"
        Me.colFinishFabricBookingDetailsId1.OptionsColumn.ReadOnly = True
        '
        'colFinishFabricBookingId1
        '
        Me.colFinishFabricBookingId1.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId1.Name = "colFinishFabricBookingId1"
        Me.colFinishFabricBookingId1.OptionsColumn.ReadOnly = True
        '
        'colColor1
        '
        Me.colColor1.FieldName = "Color"
        Me.colColor1.Name = "colColor1"
        Me.colColor1.OptionsColumn.ReadOnly = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'FinishFabricBookingDetailsIdGridLookUpEdit
        '
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "FinishFabricBookingDetailsId", True))
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Enabled = False
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(600, 136)
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Name = "FinishFabricBookingDetailsIdGridLookUpEdit"
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.DataSource = Me.FinishFabricLookupNewBindingSource
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingDetailsId"
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties.View = Me.FinishFabricBookingDetailsIdGridLookUpEditView
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(313, 20)
        Me.FinishFabricBookingDetailsIdGridLookUpEdit.TabIndex = 12
        '
        'IssueReceiveTypeIdGridLookUpEditView
        '
        Me.IssueReceiveTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssueReceiveTypeId1, Me.colIssueTypeName, Me.colDescription})
        Me.IssueReceiveTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IssueReceiveTypeIdGridLookUpEditView.Name = "IssueReceiveTypeIdGridLookUpEditView"
        Me.IssueReceiveTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IssueReceiveTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        'IssueReceiveTypeIdGridLookUpEdit
        '
        Me.IssueReceiveTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "IssueReceiveTypeId", True))
        Me.IssueReceiveTypeIdGridLookUpEdit.Location = New System.Drawing.Point(146, 163)
        Me.IssueReceiveTypeIdGridLookUpEdit.Name = "IssueReceiveTypeIdGridLookUpEdit"
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.DataSource = Me.IssueReceiveTypeBindingSource
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.DisplayMember = "IssueTypeName"
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.ValueMember = "IssueReceiveTypeId"
        Me.IssueReceiveTypeIdGridLookUpEdit.Properties.View = Me.IssueReceiveTypeIdGridLookUpEditView
        Me.IssueReceiveTypeIdGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.IssueReceiveTypeIdGridLookUpEdit.TabIndex = 4
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.Image = Global.KSoft_Inventory.My.Resources.Resources.Delete
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(951, 121)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DeleteButton.Size = New System.Drawing.Size(101, 26)
        Me.DeleteButton.TabIndex = 23
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.KSoft_Inventory.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(951, 154)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(101, 29)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.Image = Global.KSoft_Inventory.My.Resources.Resources.Edit
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(951, 88)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(101, 26)
        Me.SaveButton.TabIndex = 22
        Me.SaveButton.Text = "&Edit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'NewButton
        '
        Me.NewButton.Image = Global.KSoft_Inventory.My.Resources.Resources.AddIcon
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton.Location = New System.Drawing.Point(951, 55)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(30, 4, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NewButton.Size = New System.Drawing.Size(101, 26)
        Me.NewButton.TabIndex = 21
        Me.NewButton.Text = "&Add"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'BatchInformationIdGridLookUpEditView
        '
        Me.BatchInformationIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchInformationId, Me.colBatchNo1, Me.colProgramNo1, Me.colIsReady, Me.colIsDevelopment})
        Me.BatchInformationIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BatchInformationIdGridLookUpEditView.Name = "BatchInformationIdGridLookUpEditView"
        Me.BatchInformationIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BatchInformationIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBatchInformationId
        '
        Me.colBatchInformationId.FieldName = "BatchInformationId"
        Me.colBatchInformationId.Name = "colBatchInformationId"
        Me.colBatchInformationId.OptionsColumn.ReadOnly = True
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
        'BatchInformationIdGridLookUpEdit
        '
        Me.BatchInformationIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "BatchInformationId", True))
        Me.BatchInformationIdGridLookUpEdit.Location = New System.Drawing.Point(600, 57)
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
        Me.BatchInformationIdGridLookUpEdit.Size = New System.Drawing.Size(179, 20)
        Me.BatchInformationIdGridLookUpEdit.TabIndex = 8
        '
        'BatchLookupTableAdapter
        '
        Me.BatchLookupTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(787, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "//"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CompanyIdGridLookUpEditView
        '
        Me.CompanyIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyId, Me.colCompanyCode, Me.colCompanyName, Me.colFax, Me.colWebsite, Me.colContactPerson1, Me.colWeeklyOff})
        Me.CompanyIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CompanyIdGridLookUpEditView.Name = "CompanyIdGridLookUpEditView"
        Me.CompanyIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CompanyIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCompanyId
        '
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.OptionsColumn.ReadOnly = True
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
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        '
        'colWeeklyOff
        '
        Me.colWeeklyOff.FieldName = "WeeklyOff"
        Me.colWeeklyOff.Name = "colWeeklyOff"
        '
        'CompanyIdGridLookUpEdit
        '
        Me.CompanyIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "CompanyId", True))
        Me.CompanyIdGridLookUpEdit.Location = New System.Drawing.Point(146, 108)
        Me.CompanyIdGridLookUpEdit.Name = "CompanyIdGridLookUpEdit"
        Me.CompanyIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyIdGridLookUpEdit.Properties.DataSource = Me.CompanyBindingSource
        Me.CompanyIdGridLookUpEdit.Properties.DisplayMember = "CompanyCode"
        Me.CompanyIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.CompanyIdGridLookUpEdit.Properties.NullText = ""
        Me.CompanyIdGridLookUpEdit.Properties.ValueMember = "CompanyId"
        Me.CompanyIdGridLookUpEdit.Properties.View = Me.CompanyIdGridLookUpEditView
        Me.CompanyIdGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.CompanyIdGridLookUpEdit.TabIndex = 2
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricGridLookUpEdit
        '
        Me.FinishFabricGridLookUpEdit.Location = New System.Drawing.Point(600, 84)
        Me.FinishFabricGridLookUpEdit.Name = "FinishFabricGridLookUpEdit"
        Me.FinishFabricGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricGridLookUpEdit.Properties.DataSource = Me.FinishFabricLookupNewBindingSource
        Me.FinishFabricGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.FinishFabricGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingDetailsId"
        Me.FinishFabricGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.FinishFabricGridLookUpEdit.Size = New System.Drawing.Size(179, 20)
        Me.FinishFabricGridLookUpEdit.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo2, Me.colPart, Me.colFinishFabricBookingDetailsId2, Me.colFinishFabricBookingId, Me.colColor, Me.colDetails1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        Me.colPart.OptionsColumn.ReadOnly = True
        '
        'colFinishFabricBookingDetailsId2
        '
        Me.colFinishFabricBookingDetailsId2.FieldName = "FinishFabricBookingDetailsId"
        Me.colFinishFabricBookingDetailsId2.Name = "colFinishFabricBookingDetailsId2"
        Me.colFinishFabricBookingDetailsId2.OptionsColumn.ReadOnly = True
        '
        'colFinishFabricBookingId
        '
        Me.colFinishFabricBookingId.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId.Name = "colFinishFabricBookingId"
        Me.colFinishFabricBookingId.OptionsColumn.ReadOnly = True
        '
        'colColor
        '
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.ReadOnly = True
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'ByProgramNoButton
        '
        Me.ByProgramNoButton.Location = New System.Drawing.Point(787, 83)
        Me.ByProgramNoButton.Name = "ByProgramNoButton"
        Me.ByProgramNoButton.Size = New System.Drawing.Size(33, 23)
        Me.ByProgramNoButton.TabIndex = 56
        Me.ByProgramNoButton.Text = "//"
        Me.ByProgramNoButton.UseVisualStyleBackColor = True
        '
        'LocationReferenceComboBox
        '
        Me.LocationReferenceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinishFabricReceiveIssueBindingSource, "LocationReference", True))
        Me.LocationReferenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LocationReferenceComboBox.FormattingEnabled = True
        Me.LocationReferenceComboBox.Items.AddRange(New Object() {"4th Floor [Garments]", "5th Floor [Garments]"})
        Me.LocationReferenceComboBox.Location = New System.Drawing.Point(146, 215)
        Me.LocationReferenceComboBox.Name = "LocationReferenceComboBox"
        Me.LocationReferenceComboBox.Size = New System.Drawing.Size(112, 21)
        Me.LocationReferenceComboBox.TabIndex = 6
        '
        'ReceiveQuantity_YrdsSpinEdit
        '
        Me.ReceiveQuantity_YrdsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "ReceiveQuantity_Yrds", True))
        Me.ReceiveQuantity_YrdsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ReceiveQuantity_YrdsSpinEdit.Location = New System.Drawing.Point(600, 190)
        Me.ReceiveQuantity_YrdsSpinEdit.Name = "ReceiveQuantity_YrdsSpinEdit"
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.ReceiveQuantity_YrdsSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantity_YrdsSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.ReceiveQuantity_YrdsSpinEdit.TabIndex = 15
        '
        'ReceiveQuantity_PcsSpinEdit
        '
        Me.ReceiveQuantity_PcsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "ReceiveQuantity_Pcs", True))
        Me.ReceiveQuantity_PcsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ReceiveQuantity_PcsSpinEdit.Location = New System.Drawing.Point(600, 216)
        Me.ReceiveQuantity_PcsSpinEdit.Name = "ReceiveQuantity_PcsSpinEdit"
        Me.ReceiveQuantity_PcsSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReceiveQuantity_PcsSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ReceiveQuantity_PcsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ReceiveQuantity_PcsSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.ReceiveQuantity_PcsSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantity_PcsSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.ReceiveQuantity_PcsSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ReceiveQuantity_PcsSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.ReceiveQuantity_PcsSpinEdit.TabIndex = 17
        '
        'IssueQuantity_YrdsSpinEdit
        '
        Me.IssueQuantity_YrdsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "IssueQuantity_Yrds", True))
        Me.IssueQuantity_YrdsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IssueQuantity_YrdsSpinEdit.Location = New System.Drawing.Point(821, 190)
        Me.IssueQuantity_YrdsSpinEdit.Name = "IssueQuantity_YrdsSpinEdit"
        Me.IssueQuantity_YrdsSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IssueQuantity_YrdsSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IssueQuantity_YrdsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.IssueQuantity_YrdsSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.IssueQuantity_YrdsSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantity_YrdsSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.IssueQuantity_YrdsSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantity_YrdsSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.IssueQuantity_YrdsSpinEdit.TabIndex = 16
        '
        'IssueQuantity_PcsSpinEdit
        '
        Me.IssueQuantity_PcsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "IssueQuantity_Pcs", True))
        Me.IssueQuantity_PcsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IssueQuantity_PcsSpinEdit.Location = New System.Drawing.Point(821, 217)
        Me.IssueQuantity_PcsSpinEdit.Name = "IssueQuantity_PcsSpinEdit"
        Me.IssueQuantity_PcsSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IssueQuantity_PcsSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IssueQuantity_PcsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.IssueQuantity_PcsSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.IssueQuantity_PcsSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantity_PcsSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.IssueQuantity_PcsSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.IssueQuantity_PcsSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.IssueQuantity_PcsSpinEdit.TabIndex = 18
        '
        'RollQuantity_IssueSpinEdit
        '
        Me.RollQuantity_IssueSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "RollQuantity_Issue", True))
        Me.RollQuantity_IssueSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RollQuantity_IssueSpinEdit.Location = New System.Drawing.Point(821, 244)
        Me.RollQuantity_IssueSpinEdit.Name = "RollQuantity_IssueSpinEdit"
        Me.RollQuantity_IssueSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RollQuantity_IssueSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RollQuantity_IssueSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RollQuantity_IssueSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.RollQuantity_IssueSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RollQuantity_IssueSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.RollQuantity_IssueSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RollQuantity_IssueSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.RollQuantity_IssueSpinEdit.TabIndex = 20
        '
        'BatchNoTextEdit
        '
        Me.BatchNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "BatchNo", True))
        Me.BatchNoTextEdit.Location = New System.Drawing.Point(600, 110)
        Me.BatchNoTextEdit.Name = "BatchNoTextEdit"
        Me.BatchNoTextEdit.Size = New System.Drawing.Size(178, 20)
        Me.BatchNoTextEdit.TabIndex = 11
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.FinishFabricReceiveIssueGridControl
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'BranchIdGridLookUpEditView
        '
        Me.BranchIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchId1, Me.colBranchCode, Me.colBranchName, Me.colBranchDescription, Me.colBranchType})
        Me.BranchIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BranchIdGridLookUpEditView.Name = "BranchIdGridLookUpEditView"
        Me.BranchIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BranchIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        Me.colBranchCode.Visible = True
        Me.colBranchCode.VisibleIndex = 0
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 1
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
        'BranchIdGridLookUpEdit
        '
        Me.BranchIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FinishFabricReceiveIssueBindingSource, "BranchId", True))
        Me.BranchIdGridLookUpEdit.Location = New System.Drawing.Point(146, 134)
        Me.BranchIdGridLookUpEdit.Name = "BranchIdGridLookUpEdit"
        Me.BranchIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchIdGridLookUpEdit.Properties.DataSource = Me.BranchBindingSource
        Me.BranchIdGridLookUpEdit.Properties.DisplayMember = "BranchCode"
        Me.BranchIdGridLookUpEdit.Properties.NullText = ""
        Me.BranchIdGridLookUpEdit.Properties.ValueMember = "BranchId"
        Me.BranchIdGridLookUpEdit.Properties.View = Me.BranchIdGridLookUpEditView
        Me.BranchIdGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.BranchIdGridLookUpEdit.TabIndex = 3
        '
        'FinishFabricLookupNewTableAdapter
        '
        Me.FinishFabricLookupNewTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartBindingSource
        '
        Me.GarmentsPartBindingSource.DataMember = "GarmentsPart"
        Me.GarmentsPartBindingSource.DataSource = Me.GarmentsPartDataSet
        '
        'GarmentsPartDataSet
        '
        Me.GarmentsPartDataSet.DataSetName = "GarmentsPartDataSet"
        Me.GarmentsPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompositionBindingSource
        '
        Me.CompositionBindingSource.DataMember = "Composition"
        Me.CompositionBindingSource.DataSource = Me.CompositionDataSet
        '
        'CompositionDataSet
        '
        Me.CompositionDataSet.DataSetName = "CompositionDataSet"
        Me.CompositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingDetailsBindingSource
        '
        Me.FinishFabricBookingDetailsBindingSource.DataMember = "FinishFabricBookingDetails"
        Me.FinishFabricBookingDetailsBindingSource.DataSource = Me.FinishFabricBookingDataSet
        '
        'FinishFabricBookingDataSet
        '
        Me.FinishFabricBookingDataSet.DataSetName = "FinishFabricBookingDataSet"
        Me.FinishFabricBookingDataSet.EnforceConstraints = False
        Me.FinishFabricBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingDetailsTableAdapter
        '
        Me.FinishFabricBookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'BatchLookupDataSetBindingSource
        '
        Me.BatchLookupDataSetBindingSource.DataSource = Me.BatchLookupDataSet
        Me.BatchLookupDataSetBindingSource.Position = 0
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'frmFinishFabricIssueReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 569)
        Me.Controls.Add(Me.FinishFabricReceiveIssueGridControl)
        Me.Controls.Add(BranchIdLabel)
        Me.Controls.Add(Me.BranchIdGridLookUpEdit)
        Me.Controls.Add(BatchNoLabel1)
        Me.Controls.Add(Me.BatchNoTextEdit)
        Me.Controls.Add(RollQuantity_IssueLabel)
        Me.Controls.Add(Me.RollQuantity_IssueSpinEdit)
        Me.Controls.Add(IssueQuantity_PcsLabel)
        Me.Controls.Add(Me.IssueQuantity_PcsSpinEdit)
        Me.Controls.Add(IssueQuantity_YrdsLabel)
        Me.Controls.Add(Me.IssueQuantity_YrdsSpinEdit)
        Me.Controls.Add(ReceiveQuantity_PcsLabel)
        Me.Controls.Add(Me.ReceiveQuantity_PcsSpinEdit)
        Me.Controls.Add(ReceiveQuantity_YrdsLabel)
        Me.Controls.Add(Me.ReceiveQuantity_YrdsSpinEdit)
        Me.Controls.Add(Me.LocationReferenceComboBox)
        Me.Controls.Add(Me.ByProgramNoButton)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.FinishFabricGridLookUpEdit)
        Me.Controls.Add(Me.CompanyIdGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BatchInformationIdGridLookUpEdit)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(IssueReceiveTypeIdLabel)
        Me.Controls.Add(Me.IssueReceiveTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.FinishFabricBookingDetailsIdGridLookUpEdit)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(VehicleNoLabel)
        Me.Controls.Add(Me.VehicleNoTextEdit)
        Me.Controls.Add(GatePassNoLabel)
        Me.Controls.Add(Me.GatePassNoTextEdit)
        Me.Controls.Add(RollQuantityLabel)
        Me.Controls.Add(Me.RollQuantitySpinEdit)
        Me.Controls.Add(Me.CopyCheckEdit)
        Me.Controls.Add(LCDateLabel)
        Me.Controls.Add(Me.LCDateDateEdit)
        Me.Controls.Add(BranchIdLabel1)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IsImportedCheckEdit)
        Me.Controls.Add(ChallanNoLabel)
        Me.Controls.Add(Me.ChallanNoTextEdit)
        Me.Controls.Add(ChallanDateLabel)
        Me.Controls.Add(Me.ChallanDateDateEdit)
        Me.Controls.Add(FinishFabricBookingIdLabel)
        Me.Controls.Add(ReceiveQuantityLabel)
        Me.Controls.Add(Me.ReceiveQuantitySpinEdit)
        Me.Controls.Add(IssueQuantityLabel)
        Me.Controls.Add(Me.IssueQuantitySpinEdit)
        Me.Controls.Add(BatchNoLabel)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextEdit)
        Me.Controls.Add(LCNoLabel)
        Me.Controls.Add(Me.LCNoTextEdit)
        Me.Controls.Add(SupplierIdLabel)
        Me.Controls.Add(LocationReferenceLabel)
        Me.Name = "frmFinishFabricIssueReceive"
        Me.Text = "Finish Fabric Issue Receive"
        CType(Me.FinishFabricReceiveIssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricReceiveIssueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsImportedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricReceiveIssueGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingDetailsIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchInformationIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveQuantity_YrdsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveQuantity_PcsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueQuantity_YrdsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueQuantity_PcsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollQuantity_IssueSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinishFabricReceiveIssueDataSet As KSoft_Inventory.FinishFabricReceiveIssueDataSet
    Friend WithEvents FinishFabricReceiveIssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricReceiveIssueTableAdapter As KSoft_Inventory.FinishFabricReceiveIssueDataSetTableAdapters.FinishFabricReceiveIssueTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.FinishFabricReceiveIssueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ReceiveQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IssueQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsImportedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FinishFabricReceiveIssueGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents FinishFabricBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricLookupTableAdapter As FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupTableAdapter
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents IssueReceiveTypeDataSet As KSoft_Inventory.IssueReceiveTypeDataSet
    Friend WithEvents IssueReceiveTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueReceiveTypeTableAdapter As KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchDataSet As KSoft_Inventory.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IssueReceiveTypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CopyCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RollQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GatePassNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VehicleNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FinishFabricLookupBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents FinishFabricLookupTableAdapter As ECHO_INFORMATION.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FinishFabricBookingDetailsIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricBookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents IssueReceiveTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssueReceiveTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents colIssueReceiveTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BatchInformationIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BatchInformationIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BatchLookupDataSet As KSoft_Inventory.BatchLookupDataSet
    Friend WithEvents BatchLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchLookupTableAdapter As KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
    Friend WithEvents colBatchInformationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsReady As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CompanyIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompanyIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWebsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeeklyOff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FinishFabricGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ByProgramNoButton As System.Windows.Forms.Button
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LocationReferenceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReceiveQuantity_YrdsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ReceiveQuantity_PcsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IssueQuantity_YrdsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IssueQuantity_PcsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RollQuantity_IssueSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BatchNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFFReceiveIssueId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishFabricBookingDetailsId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBatchInformationId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReceiveQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLocationReference As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsImported As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGatePassNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueReceiveTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRollQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVehicleNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompanyId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueQuantity_Cutting As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colIssueQuantity_Cutting_Pcs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueQuantity_Cutting_Yrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueQuantity_Pcs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssueQuantity_Yrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReceiveQuantity_Pcs As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReceiveQuantity_Yrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRollQuantity_Issue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents BranchIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents colBranchId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsClose As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FinishFabricLookupNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricLookupNewTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupNewTableAdapter
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingDetailsId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricBookingDataSet As KSoft_Inventory.FinishFabricBookingDataSet
    Friend WithEvents FinishFabricBookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricBookingDetailsTableAdapter As KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.FinishFabricBookingDetailsTableAdapter
    Friend WithEvents BatchLookupDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartDataSet As KSoft_Inventory.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Inventory.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents KnittingTypeDataSet As KSoft_Inventory.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Inventory.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionDataSet As KSoft_Inventory.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Inventory.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricOrderLookupBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colProgramNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishFabricBookingId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
End Class
