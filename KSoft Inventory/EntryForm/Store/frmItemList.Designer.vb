<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemList
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
        Dim ItemIdLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim ItemDescriptionLabel As System.Windows.Forms.Label
        Dim QuantityPerPacketLabel As System.Windows.Forms.Label
        Dim PreviousPriceLabel As System.Windows.Forms.Label
        Dim CurrentPriceLabel As System.Windows.Forms.Label
        Dim ReorderLabelLabel As System.Windows.Forms.Label
        Dim ExpireLabelLabel As System.Windows.Forms.Label
        Dim DollarPriceLabel As System.Windows.Forms.Label
        Dim YarnTypeIdLabel As System.Windows.Forms.Label
        Dim YarnQualityLabel As System.Windows.Forms.Label
        Dim YarnCountLabel1 As System.Windows.Forms.Label
        Dim AvgPriceLabel As System.Windows.Forms.Label
        Dim AccBuyerIdLabel As System.Windows.Forms.Label
        Dim AccItemNameLabel As System.Windows.Forms.Label
        Dim AccItemStyleLabel As System.Windows.Forms.Label
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OriginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginDataSet = New KSoft_Inventory.OriginDataSet()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New KSoft_Inventory.BrandDataSet()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.SubCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager()
        Me.ItemIdTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.ItemDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SubCategoryIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubCategoryId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CategoryIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CategoryIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubCategoryLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CategoryLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AvgPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DollarPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ExpireLabelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReorderLabelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CurrentPriceTextBox = New System.Windows.Forms.TextBox()
        Me.PreviousPriceTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.QuantityPerPacketTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.SubCategoryTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter()
        Me.BrandTableAdapter = New KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.OriginTableAdapter = New KSoft_Inventory.OriginDataSetTableAdapters.OriginTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.UpdateAccButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YDOrderGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YDOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YDOrderLookupDataSet = New KSoft_Inventory.YDOrderLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYDOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Inventory.OrderLookupDataSet()
        Me.SubCategoryLookupTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.IsCertifyCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DiscontinueCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.YarnQualityGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnQualityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnQualityDataSet = New KSoft_Inventory.YarnQualityDataSet()
        Me.YarnQualityGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnQualityId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnQuality = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnCountGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YCountDataSet = New KSoft_Inventory.YCountDataSet()
        Me.YarnCountGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCountId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnTypeDataSet = New KSoft_Inventory.YarnTypeDataSet()
        Me.YarnTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnTypeTableAdapter = New KSoft_Inventory.YarnTypeDataSetTableAdapters.YarnTypeTableAdapter()
        Me.YarnCountTableAdapter = New KSoft_Inventory.YCountDataSetTableAdapters.YarnCountTableAdapter()
        Me.YarnQualityTableAdapter = New KSoft_Inventory.YarnQualityDataSetTableAdapters.YarnQualityTableAdapter()
        Me.ItemListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit8View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOriginId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBrandId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubCategoryId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantityPerPacket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreviousPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPipelineQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPipeLineDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDollarPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit9View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnQuality1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit10View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnCount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit11View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExpireLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReorderLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderLookupTableAdapter = New KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.AccessoriesListLookupTableAdapter1 = New KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.AccItemStyleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccItemNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccBuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet()
        Me.AccBuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YDOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.YDOrderDetailsTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter()
        Me.YDOrderTableAdapter = New KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter()
        ItemIdLabel = New System.Windows.Forms.Label()
        ItemNameLabel = New System.Windows.Forms.Label()
        ItemDescriptionLabel = New System.Windows.Forms.Label()
        QuantityPerPacketLabel = New System.Windows.Forms.Label()
        PreviousPriceLabel = New System.Windows.Forms.Label()
        CurrentPriceLabel = New System.Windows.Forms.Label()
        ReorderLabelLabel = New System.Windows.Forms.Label()
        ExpireLabelLabel = New System.Windows.Forms.Label()
        DollarPriceLabel = New System.Windows.Forms.Label()
        YarnTypeIdLabel = New System.Windows.Forms.Label()
        YarnQualityLabel = New System.Windows.Forms.Label()
        YarnCountLabel1 = New System.Windows.Forms.Label()
        AvgPriceLabel = New System.Windows.Forms.Label()
        AccBuyerIdLabel = New System.Windows.Forms.Label()
        AccItemNameLabel = New System.Windows.Forms.Label()
        AccItemStyleLabel = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubCategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AvgPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpireLabelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderLabelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.YDOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.IsCertifyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.YarnQualityGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnQualityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnQualityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnQualityGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnCountGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnCountGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.AccItemStyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemIdLabel
        '
        ItemIdLabel.AutoSize = True
        ItemIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemIdLabel.Location = New System.Drawing.Point(23, 28)
        ItemIdLabel.Name = "ItemIdLabel"
        ItemIdLabel.Size = New System.Drawing.Size(50, 13)
        ItemIdLabel.TabIndex = 3
        ItemIdLabel.Text = "Item Id:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New System.Drawing.Point(23, 52)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(61, 13)
        ItemNameLabel.TabIndex = 4
        ItemNameLabel.Text = "Item Name:"
        '
        'ItemDescriptionLabel
        '
        ItemDescriptionLabel.AutoSize = True
        ItemDescriptionLabel.Location = New System.Drawing.Point(23, 76)
        ItemDescriptionLabel.Name = "ItemDescriptionLabel"
        ItemDescriptionLabel.Size = New System.Drawing.Size(86, 13)
        ItemDescriptionLabel.TabIndex = 4
        ItemDescriptionLabel.Text = "Item Description:"
        '
        'QuantityPerPacketLabel
        '
        QuantityPerPacketLabel.AutoSize = True
        QuantityPerPacketLabel.Location = New System.Drawing.Point(16, 29)
        QuantityPerPacketLabel.Name = "QuantityPerPacketLabel"
        QuantityPerPacketLabel.Size = New System.Drawing.Size(105, 13)
        QuantityPerPacketLabel.TabIndex = 4
        QuantityPerPacketLabel.Text = "Quantity Per Packet:"
        '
        'PreviousPriceLabel
        '
        PreviousPriceLabel.AutoSize = True
        PreviousPriceLabel.Location = New System.Drawing.Point(235, 27)
        PreviousPriceLabel.Name = "PreviousPriceLabel"
        PreviousPriceLabel.Size = New System.Drawing.Size(78, 13)
        PreviousPriceLabel.TabIndex = 6
        PreviousPriceLabel.Text = "Previous Price:"
        '
        'CurrentPriceLabel
        '
        CurrentPriceLabel.AutoSize = True
        CurrentPriceLabel.Location = New System.Drawing.Point(235, 54)
        CurrentPriceLabel.Name = "CurrentPriceLabel"
        CurrentPriceLabel.Size = New System.Drawing.Size(71, 13)
        CurrentPriceLabel.TabIndex = 7
        CurrentPriceLabel.Text = "Current Price:"
        '
        'ReorderLabelLabel
        '
        ReorderLabelLabel.AutoSize = True
        ReorderLabelLabel.Location = New System.Drawing.Point(585, 29)
        ReorderLabelLabel.Name = "ReorderLabelLabel"
        ReorderLabelLabel.Size = New System.Drawing.Size(77, 13)
        ReorderLabelLabel.TabIndex = 8
        ReorderLabelLabel.Text = "Reorder Label:"
        '
        'ExpireLabelLabel
        '
        ExpireLabelLabel.AutoSize = True
        ExpireLabelLabel.Location = New System.Drawing.Point(585, 56)
        ExpireLabelLabel.Name = "ExpireLabelLabel"
        ExpireLabelLabel.Size = New System.Drawing.Size(68, 13)
        ExpireLabelLabel.TabIndex = 10
        ExpireLabelLabel.Text = "Expire Label:"
        '
        'DollarPriceLabel
        '
        DollarPriceLabel.AutoSize = True
        DollarPriceLabel.Location = New System.Drawing.Point(506, 28)
        DollarPriceLabel.Name = "DollarPriceLabel"
        DollarPriceLabel.Size = New System.Drawing.Size(64, 13)
        DollarPriceLabel.TabIndex = 12
        DollarPriceLabel.Text = "Dollar Price:"
        '
        'YarnTypeIdLabel
        '
        YarnTypeIdLabel.AutoSize = True
        YarnTypeIdLabel.Location = New System.Drawing.Point(26, 29)
        YarnTypeIdLabel.Name = "YarnTypeIdLabel"
        YarnTypeIdLabel.Size = New System.Drawing.Size(92, 13)
        YarnTypeIdLabel.TabIndex = 0
        YarnTypeIdLabel.Text = "Yarn Composition:"
        '
        'YarnQualityLabel
        '
        YarnQualityLabel.AutoSize = True
        YarnQualityLabel.Location = New System.Drawing.Point(462, 29)
        YarnQualityLabel.Name = "YarnQualityLabel"
        YarnQualityLabel.Size = New System.Drawing.Size(67, 13)
        YarnQualityLabel.TabIndex = 4
        YarnQualityLabel.Text = "Yarn Quality:"
        '
        'YarnCountLabel1
        '
        YarnCountLabel1.AutoSize = True
        YarnCountLabel1.Location = New System.Drawing.Point(281, 29)
        YarnCountLabel1.Name = "YarnCountLabel1"
        YarnCountLabel1.Size = New System.Drawing.Size(63, 13)
        YarnCountLabel1.TabIndex = 8
        YarnCountLabel1.Text = "Yarn Count:"
        '
        'AvgPriceLabel
        '
        AvgPriceLabel.AutoSize = True
        AvgPriceLabel.Location = New System.Drawing.Point(386, 26)
        AvgPriceLabel.Name = "AvgPriceLabel"
        AvgPriceLabel.Size = New System.Drawing.Size(56, 13)
        AvgPriceLabel.TabIndex = 14
        AvgPriceLabel.Text = "Avg Price:"
        '
        'AccBuyerIdLabel
        '
        AccBuyerIdLabel.AutoSize = True
        AccBuyerIdLabel.Location = New System.Drawing.Point(813, 29)
        AccBuyerIdLabel.Name = "AccBuyerIdLabel"
        AccBuyerIdLabel.Size = New System.Drawing.Size(55, 13)
        AccBuyerIdLabel.TabIndex = 0
        AccBuyerIdLabel.Text = "For Buyer:"
        '
        'AccItemNameLabel
        '
        AccItemNameLabel.AutoSize = True
        AccItemNameLabel.Location = New System.Drawing.Point(25, 29)
        AccItemNameLabel.Name = "AccItemNameLabel"
        AccItemNameLabel.Size = New System.Drawing.Size(98, 13)
        AccItemNameLabel.TabIndex = 2
        AccItemNameLabel.Text = "Accessories Name:"
        '
        'AccItemStyleLabel
        '
        AccItemStyleLabel.AutoSize = True
        AccItemStyleLabel.Location = New System.Drawing.Point(412, 29)
        AccItemStyleLabel.Name = "AccItemStyleLabel"
        AccItemStyleLabel.Size = New System.Drawing.Size(93, 13)
        AccItemStyleLabel.TabIndex = 4
        AccItemStyleLabel.Text = "Accessories Style:"
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.OriginBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Origin"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "OriginId"
        '
        'OriginBindingSource
        '
        Me.OriginBindingSource.DataMember = "Origin"
        Me.OriginBindingSource.DataSource = Me.OriginDataSet
        '
        'OriginDataSet
        '
        Me.OriginDataSet.DataSetName = "OriginDataSet"
        Me.OriginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.BrandBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "BrandName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "BrandId"
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.BrandDataSetBindingSource
        '
        'BrandDataSetBindingSource
        '
        Me.BrandDataSetBindingSource.DataSource = Me.BrandDataSet
        Me.BrandDataSetBindingSource.Position = 0
        '
        'BrandDataSet
        '
        Me.BrandDataSet.DataSetName = "BrandDataSet"
        Me.BrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.CategoryBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "CategoryName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "CategoryId"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryLookupBindingSource
        '
        Me.SubCategoryLookupBindingSource.DataMember = "SubCategoryLookup"
        Me.SubCategoryLookupBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemLeadTimeTableAdapter = Nothing
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemIdTextBox
        '
        Me.ItemIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "ItemId", True))
        Me.ItemIdTextBox.Location = New System.Drawing.Point(115, 24)
        Me.ItemIdTextBox.Name = "ItemIdTextBox"
        Me.ItemIdTextBox.ReadOnly = True
        Me.ItemIdTextBox.Size = New System.Drawing.Size(257, 20)
        Me.ItemIdTextBox.TabIndex = 0
        Me.ItemIdTextBox.Tag = "NR"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "ItemName", True))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(115, 49)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(257, 20)
        Me.ItemNameTextBox.TabIndex = 1
        '
        'ItemDescriptionTextBox
        '
        Me.ItemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "ItemDescription", True))
        Me.ItemDescriptionTextBox.Location = New System.Drawing.Point(115, 74)
        Me.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox"
        Me.ItemDescriptionTextBox.Size = New System.Drawing.Size(257, 20)
        Me.ItemDescriptionTextBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SubCategoryIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.CategoryIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.SubCategoryLinkLabel)
        Me.GroupBox1.Controls.Add(Me.CategoryLinkLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(455, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category"
        '
        'SubCategoryIdGridLookUpEdit
        '
        Me.SubCategoryIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "SubCategoryId", True))
        Me.SubCategoryIdGridLookUpEdit.Location = New System.Drawing.Point(90, 56)
        Me.SubCategoryIdGridLookUpEdit.Name = "SubCategoryIdGridLookUpEdit"
        Me.SubCategoryIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubCategoryIdGridLookUpEdit.Properties.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryIdGridLookUpEdit.Properties.DisplayMember = "SubCategoryName"
        Me.SubCategoryIdGridLookUpEdit.Properties.NullText = ""
        Me.SubCategoryIdGridLookUpEdit.Properties.ValueMember = "SubCategoryId"
        Me.SubCategoryIdGridLookUpEdit.Properties.View = Me.SubCategoryIdGridLookUpEditView
        Me.SubCategoryIdGridLookUpEdit.Size = New System.Drawing.Size(186, 20)
        Me.SubCategoryIdGridLookUpEdit.TabIndex = 6
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryIdGridLookUpEditView
        '
        Me.SubCategoryIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubCategoryId1, Me.colSubCategoryName, Me.colSubCategoryDescription, Me.colCategoryId2, Me.colDepartmentId1})
        Me.SubCategoryIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SubCategoryIdGridLookUpEditView.Name = "SubCategoryIdGridLookUpEditView"
        Me.SubCategoryIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SubCategoryIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSubCategoryId1
        '
        Me.colSubCategoryId1.FieldName = "SubCategoryId"
        Me.colSubCategoryId1.Name = "colSubCategoryId1"
        Me.colSubCategoryId1.OptionsColumn.ReadOnly = True
        '
        'colSubCategoryName
        '
        Me.colSubCategoryName.FieldName = "SubCategoryName"
        Me.colSubCategoryName.Name = "colSubCategoryName"
        Me.colSubCategoryName.Visible = True
        Me.colSubCategoryName.VisibleIndex = 0
        '
        'colSubCategoryDescription
        '
        Me.colSubCategoryDescription.FieldName = "SubCategoryDescription"
        Me.colSubCategoryDescription.Name = "colSubCategoryDescription"
        '
        'colCategoryId2
        '
        Me.colCategoryId2.FieldName = "CategoryId"
        Me.colCategoryId2.Name = "colCategoryId2"
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'CategoryIdGridLookUpEdit
        '
        Me.CategoryIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "CategoryId", True))
        Me.CategoryIdGridLookUpEdit.Location = New System.Drawing.Point(90, 28)
        Me.CategoryIdGridLookUpEdit.Name = "CategoryIdGridLookUpEdit"
        Me.CategoryIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryIdGridLookUpEdit.Properties.DataSource = Me.CategoryBindingSource
        Me.CategoryIdGridLookUpEdit.Properties.DisplayMember = "CategoryName"
        Me.CategoryIdGridLookUpEdit.Properties.NullText = ""
        Me.CategoryIdGridLookUpEdit.Properties.ValueMember = "CategoryId"
        Me.CategoryIdGridLookUpEdit.Properties.View = Me.CategoryIdGridLookUpEditView
        Me.CategoryIdGridLookUpEdit.Size = New System.Drawing.Size(186, 20)
        Me.CategoryIdGridLookUpEdit.TabIndex = 5
        '
        'CategoryIdGridLookUpEditView
        '
        Me.CategoryIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryId1, Me.colCategoryName, Me.colCategoryDescription, Me.colDepartmentId})
        Me.CategoryIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CategoryIdGridLookUpEditView.Name = "CategoryIdGridLookUpEditView"
        Me.CategoryIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CategoryIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCategoryId1
        '
        Me.colCategoryId1.FieldName = "CategoryId"
        Me.colCategoryId1.Name = "colCategoryId1"
        Me.colCategoryId1.OptionsColumn.ReadOnly = True
        '
        'colCategoryName
        '
        Me.colCategoryName.FieldName = "CategoryName"
        Me.colCategoryName.Name = "colCategoryName"
        Me.colCategoryName.Visible = True
        Me.colCategoryName.VisibleIndex = 0
        '
        'colCategoryDescription
        '
        Me.colCategoryDescription.FieldName = "CategoryDescription"
        Me.colCategoryDescription.Name = "colCategoryDescription"
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'SubCategoryLinkLabel
        '
        Me.SubCategoryLinkLabel.AutoSize = True
        Me.SubCategoryLinkLabel.Location = New System.Drawing.Point(21, 59)
        Me.SubCategoryLinkLabel.Name = "SubCategoryLinkLabel"
        Me.SubCategoryLinkLabel.Size = New System.Drawing.Size(71, 13)
        Me.SubCategoryLinkLabel.TabIndex = 3
        Me.SubCategoryLinkLabel.TabStop = True
        Me.SubCategoryLinkLabel.Text = "Sub Category"
        '
        'CategoryLinkLabel
        '
        Me.CategoryLinkLabel.AutoSize = True
        Me.CategoryLinkLabel.Location = New System.Drawing.Point(21, 31)
        Me.CategoryLinkLabel.Name = "CategoryLinkLabel"
        Me.CategoryLinkLabel.Size = New System.Drawing.Size(49, 13)
        Me.CategoryLinkLabel.TabIndex = 2
        Me.CategoryLinkLabel.TabStop = True
        Me.CategoryLinkLabel.Text = "Category"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(AvgPriceLabel)
        Me.GroupBox2.Controls.Add(Me.AvgPriceSpinEdit)
        Me.GroupBox2.Controls.Add(DollarPriceLabel)
        Me.GroupBox2.Controls.Add(Me.DollarPriceSpinEdit)
        Me.GroupBox2.Controls.Add(ExpireLabelLabel)
        Me.GroupBox2.Controls.Add(Me.ExpireLabelTextEdit)
        Me.GroupBox2.Controls.Add(ReorderLabelLabel)
        Me.GroupBox2.Controls.Add(Me.ReorderLabelTextEdit)
        Me.GroupBox2.Controls.Add(CurrentPriceLabel)
        Me.GroupBox2.Controls.Add(Me.CurrentPriceTextBox)
        Me.GroupBox2.Controls.Add(PreviousPriceLabel)
        Me.GroupBox2.Controls.Add(Me.PreviousPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.LinkLabel5)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.QuantityPerPacketTextBox)
        Me.GroupBox2.Controls.Add(QuantityPerPacketLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 95)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Measurement And Appoximately Price"
        '
        'AvgPriceSpinEdit
        '
        Me.AvgPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AvgPrice", True))
        Me.AvgPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AvgPriceSpinEdit.Location = New System.Drawing.Point(388, 51)
        Me.AvgPriceSpinEdit.Name = "AvgPriceSpinEdit"
        Me.AvgPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AvgPriceSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.AvgPriceSpinEdit.TabIndex = 15
        '
        'DollarPriceSpinEdit
        '
        Me.DollarPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "DollarPrice", True))
        Me.DollarPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DollarPriceSpinEdit.Location = New System.Drawing.Point(509, 51)
        Me.DollarPriceSpinEdit.Name = "DollarPriceSpinEdit"
        Me.DollarPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DollarPriceSpinEdit.Size = New System.Drawing.Size(70, 20)
        Me.DollarPriceSpinEdit.TabIndex = 13
        '
        'ExpireLabelTextEdit
        '
        Me.ExpireLabelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "ExpireLabel", True))
        Me.ExpireLabelTextEdit.Location = New System.Drawing.Point(668, 53)
        Me.ExpireLabelTextEdit.Name = "ExpireLabelTextEdit"
        Me.ExpireLabelTextEdit.Properties.Mask.EditMask = "n0"
        Me.ExpireLabelTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ExpireLabelTextEdit.Size = New System.Drawing.Size(58, 20)
        Me.ExpireLabelTextEdit.TabIndex = 6
        '
        'ReorderLabelTextEdit
        '
        Me.ReorderLabelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "ReorderLabel", True))
        Me.ReorderLabelTextEdit.Location = New System.Drawing.Point(668, 26)
        Me.ReorderLabelTextEdit.Name = "ReorderLabelTextEdit"
        Me.ReorderLabelTextEdit.Properties.Mask.EditMask = "f0"
        Me.ReorderLabelTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ReorderLabelTextEdit.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
        Me.ReorderLabelTextEdit.Size = New System.Drawing.Size(58, 20)
        Me.ReorderLabelTextEdit.TabIndex = 5
        '
        'CurrentPriceTextBox
        '
        Me.CurrentPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "CurrentPrice", True))
        Me.CurrentPriceTextBox.Location = New System.Drawing.Point(319, 51)
        Me.CurrentPriceTextBox.Name = "CurrentPriceTextBox"
        Me.CurrentPriceTextBox.Size = New System.Drawing.Size(61, 20)
        Me.CurrentPriceTextBox.TabIndex = 4
        '
        'PreviousPriceTextBox
        '
        Me.PreviousPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "PreviousPrice", True))
        Me.PreviousPriceTextBox.Location = New System.Drawing.Point(319, 24)
        Me.PreviousPriceTextBox.Name = "PreviousPriceTextBox"
        Me.PreviousPriceTextBox.Size = New System.Drawing.Size(61, 20)
        Me.PreviousPriceTextBox.TabIndex = 3
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(16, 56)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(26, 13)
        Me.LinkLabel5.TabIndex = 5
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Unit"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ItemListBindingSource, "UnitId", True))
        Me.ComboBox3.DataSource = Me.UnitBindingSource
        Me.ComboBox3.DisplayMember = "UnitCode"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(127, 52)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox3.TabIndex = 1
        Me.ComboBox3.ValueMember = "UnitId"
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
        'QuantityPerPacketTextBox
        '
        Me.QuantityPerPacketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityPerPacketTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemListBindingSource, "QuantityPerPacket", True))
        Me.QuantityPerPacketTextBox.Location = New System.Drawing.Point(127, 25)
        Me.QuantityPerPacketTextBox.Name = "QuantityPerPacketTextBox"
        Me.QuantityPerPacketTextBox.Size = New System.Drawing.Size(102, 20)
        Me.QuantityPerPacketTextBox.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ItemIdLabel)
        Me.GroupBox3.Controls.Add(Me.ItemIdTextBox)
        Me.GroupBox3.Controls.Add(ItemNameLabel)
        Me.GroupBox3.Controls.Add(Me.ItemNameTextBox)
        Me.GroupBox3.Controls.Add(ItemDescriptionLabel)
        Me.GroupBox3.Controls.Add(Me.ItemDescriptionTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(41, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 107)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chemical Description"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LinkLabel4)
        Me.GroupBox4.Controls.Add(Me.LinkLabel3)
        Me.GroupBox4.Controls.Add(Me.ComboBox5)
        Me.GroupBox4.Controls.Add(Me.ComboBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(41, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 93)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "For Printing"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(23, 28)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel4.TabIndex = 2
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Origin"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(23, 57)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Brand"
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ItemListBindingSource, "BrandId", True))
        Me.ComboBox5.DataSource = Me.BrandBindingSource
        Me.ComboBox5.DisplayMember = "BrandCode"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(88, 53)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox5.TabIndex = 1
        Me.ComboBox5.ValueMember = "BrandId"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ItemListBindingSource, "OriginId", True))
        Me.ComboBox4.DataSource = Me.OriginBindingSource
        Me.ComboBox4.DisplayMember = "Origin"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(88, 25)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox4.TabIndex = 0
        Me.ComboBox4.ValueMember = "OriginId"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.White
        Me.SearchTextBox.Location = New System.Drawing.Point(469, 10)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(276, 20)
        Me.SearchTextBox.TabIndex = 0
        Me.SearchTextBox.Tag = "NR"
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'OriginTableAdapter
        '
        Me.OriginTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1072, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateAccButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SearchTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.YDOrderGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1194, 41)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 5)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 30)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(72, 5)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 30)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(141, 5)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 30)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEntryButton.Location = New System.Drawing.Point(210, 5)
        Me.CancelEntryButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 30)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = False
        '
        'UpdateAccButton
        '
        Me.UpdateAccButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UpdateAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateAccButton.Location = New System.Drawing.Point(279, 5)
        Me.UpdateAccButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.UpdateAccButton.Name = "UpdateAccButton"
        Me.UpdateAccButton.Size = New System.Drawing.Size(81, 30)
        Me.UpdateAccButton.TabIndex = 3
        Me.UpdateAccButton.Tag = "NR"
        Me.UpdateAccButton.Text = "&Refresh"
        Me.UpdateAccButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filter by Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(751, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Yarn Dyeing Order No :"
        '
        'YDOrderGridLookUpEdit
        '
        Me.YDOrderGridLookUpEdit.Location = New System.Drawing.Point(874, 10)
        Me.YDOrderGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.YDOrderGridLookUpEdit.Name = "YDOrderGridLookUpEdit"
        Me.YDOrderGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YDOrderGridLookUpEdit.Properties.DataSource = Me.YDOrderBindingSource
        Me.YDOrderGridLookUpEdit.Properties.DisplayMember = "YDOrderNo"
        Me.YDOrderGridLookUpEdit.Properties.NullText = ""
        Me.YDOrderGridLookUpEdit.Properties.ValueMember = "YDOrderId"
        Me.YDOrderGridLookUpEdit.Properties.View = Me.GridView2
        Me.YDOrderGridLookUpEdit.Size = New System.Drawing.Size(132, 20)
        Me.YDOrderGridLookUpEdit.TabIndex = 5
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYDOrderNo})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colYDOrderNo
        '
        Me.colYDOrderNo.FieldName = "YDOrderNo"
        Me.colYDOrderNo.Name = "colYDOrderNo"
        Me.colYDOrderNo.Visible = True
        Me.colYDOrderNo.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowButton.Location = New System.Drawing.Point(1012, 5)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(81, 30)
        Me.ShowButton.TabIndex = 7
        Me.ShowButton.Tag = "NR"
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = False
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
        'SubCategoryLookupTableAdapter
        '
        Me.SubCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.IsCertifyCheckEdit)
        Me.GroupBox5.Controls.Add(Me.DiscontinueCheckEdit)
        Me.GroupBox5.Location = New System.Drawing.Point(1049, 47)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(112, 107)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Discontinue"
        '
        'IsCertifyCheckEdit
        '
        Me.IsCertifyCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "IsCertify", True))
        Me.IsCertifyCheckEdit.Location = New System.Drawing.Point(12, 59)
        Me.IsCertifyCheckEdit.Name = "IsCertifyCheckEdit"
        Me.IsCertifyCheckEdit.Properties.Caption = "Certified"
        Me.IsCertifyCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsCertifyCheckEdit.TabIndex = 10
        '
        'DiscontinueCheckEdit
        '
        Me.DiscontinueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "Discontinue", True))
        Me.DiscontinueCheckEdit.Location = New System.Drawing.Point(12, 30)
        Me.DiscontinueCheckEdit.Name = "DiscontinueCheckEdit"
        Me.DiscontinueCheckEdit.Properties.Caption = "Discontinue"
        Me.DiscontinueCheckEdit.Size = New System.Drawing.Size(100, 19)
        Me.DiscontinueCheckEdit.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.YarnQualityGridLookUpEdit)
        Me.GroupBox6.Controls.Add(Me.YarnCountGridLookUpEdit)
        Me.GroupBox6.Controls.Add(YarnCountLabel1)
        Me.GroupBox6.Controls.Add(YarnQualityLabel)
        Me.GroupBox6.Controls.Add(YarnTypeIdLabel)
        Me.GroupBox6.Controls.Add(Me.YarnTypeIdGridLookUpEdit)
        Me.GroupBox6.Location = New System.Drawing.Point(40, 264)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(648, 62)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "For Yarn Store"
        '
        'YarnQualityGridLookUpEdit
        '
        Me.YarnQualityGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "YarnQuality", True))
        Me.YarnQualityGridLookUpEdit.Location = New System.Drawing.Point(535, 26)
        Me.YarnQualityGridLookUpEdit.Name = "YarnQualityGridLookUpEdit"
        Me.YarnQualityGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnQualityGridLookUpEdit.Properties.DataSource = Me.YarnQualityBindingSource
        Me.YarnQualityGridLookUpEdit.Properties.DisplayMember = "YarnQuality"
        Me.YarnQualityGridLookUpEdit.Properties.NullText = ""
        Me.YarnQualityGridLookUpEdit.Properties.ValueMember = "YarnQuality"
        Me.YarnQualityGridLookUpEdit.Properties.View = Me.YarnQualityGridLookUpEditView
        Me.YarnQualityGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.YarnQualityGridLookUpEdit.TabIndex = 10
        '
        'YarnQualityBindingSource
        '
        Me.YarnQualityBindingSource.DataMember = "YarnQuality"
        Me.YarnQualityBindingSource.DataSource = Me.YarnQualityDataSet
        '
        'YarnQualityDataSet
        '
        Me.YarnQualityDataSet.DataSetName = "YarnQualityDataSet"
        Me.YarnQualityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnQualityGridLookUpEditView
        '
        Me.YarnQualityGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYarnQualityId, Me.colYarnQuality})
        Me.YarnQualityGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnQualityGridLookUpEditView.Name = "YarnQualityGridLookUpEditView"
        Me.YarnQualityGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnQualityGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colYarnQualityId
        '
        Me.colYarnQualityId.FieldName = "YarnQualityId"
        Me.colYarnQualityId.Name = "colYarnQualityId"
        Me.colYarnQualityId.OptionsColumn.ReadOnly = True
        '
        'colYarnQuality
        '
        Me.colYarnQuality.FieldName = "YarnQuality"
        Me.colYarnQuality.Name = "colYarnQuality"
        Me.colYarnQuality.Visible = True
        Me.colYarnQuality.VisibleIndex = 0
        '
        'YarnCountGridLookUpEdit
        '
        Me.YarnCountGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "YarnCount", True))
        Me.YarnCountGridLookUpEdit.Location = New System.Drawing.Point(350, 26)
        Me.YarnCountGridLookUpEdit.Name = "YarnCountGridLookUpEdit"
        Me.YarnCountGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnCountGridLookUpEdit.Properties.DataSource = Me.YarnCountBindingSource
        Me.YarnCountGridLookUpEdit.Properties.DisplayMember = "Count"
        Me.YarnCountGridLookUpEdit.Properties.NullText = ""
        Me.YarnCountGridLookUpEdit.Properties.ValueMember = "Count"
        Me.YarnCountGridLookUpEdit.Properties.View = Me.YarnCountGridLookUpEditView
        Me.YarnCountGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.YarnCountGridLookUpEdit.TabIndex = 9
        '
        'YarnCountBindingSource
        '
        Me.YarnCountBindingSource.DataMember = "YarnCount"
        Me.YarnCountBindingSource.DataSource = Me.YCountDataSet
        '
        'YCountDataSet
        '
        Me.YCountDataSet.DataSetName = "YCountDataSet"
        Me.YCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnCountGridLookUpEditView
        '
        Me.YarnCountGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCountId, Me.colCount})
        Me.YarnCountGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnCountGridLookUpEditView.Name = "YarnCountGridLookUpEditView"
        Me.YarnCountGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnCountGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCountId
        '
        Me.colCountId.FieldName = "CountId"
        Me.colCountId.Name = "colCountId"
        Me.colCountId.OptionsColumn.ReadOnly = True
        '
        'colCount
        '
        Me.colCount.FieldName = "Count"
        Me.colCount.Name = "colCount"
        Me.colCount.Visible = True
        Me.colCount.VisibleIndex = 0
        '
        'YarnTypeIdGridLookUpEdit
        '
        Me.YarnTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "YarnTypeId", True))
        Me.YarnTypeIdGridLookUpEdit.EditValue = ""
        Me.YarnTypeIdGridLookUpEdit.Location = New System.Drawing.Point(124, 26)
        Me.YarnTypeIdGridLookUpEdit.Name = "YarnTypeIdGridLookUpEdit"
        Me.YarnTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnTypeIdGridLookUpEdit.Properties.DataSource = Me.YarnTypeBindingSource
        Me.YarnTypeIdGridLookUpEdit.Properties.DisplayMember = "YarnType"
        Me.YarnTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.YarnTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.YarnTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnTypeIdGridLookUpEdit.Properties.ValueMember = "YarnTypeId"
        Me.YarnTypeIdGridLookUpEdit.Properties.View = Me.YarnTypeIdGridLookUpEditView
        Me.YarnTypeIdGridLookUpEdit.Size = New System.Drawing.Size(135, 20)
        Me.YarnTypeIdGridLookUpEdit.TabIndex = 1
        '
        'YarnTypeBindingSource
        '
        Me.YarnTypeBindingSource.DataMember = "YarnType"
        Me.YarnTypeBindingSource.DataSource = Me.YarnTypeDataSet
        '
        'YarnTypeDataSet
        '
        Me.YarnTypeDataSet.DataSetName = "YarnTypeDataSet"
        Me.YarnTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnTypeIdGridLookUpEditView
        '
        Me.YarnTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYarnTypeId, Me.colYarnType, Me.colRemarks})
        Me.YarnTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnTypeIdGridLookUpEditView.Name = "YarnTypeIdGridLookUpEditView"
        Me.YarnTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colYarnTypeId
        '
        Me.colYarnTypeId.FieldName = "YarnTypeId"
        Me.colYarnTypeId.Name = "colYarnTypeId"
        Me.colYarnTypeId.OptionsColumn.ReadOnly = True
        '
        'colYarnType
        '
        Me.colYarnType.FieldName = "YarnType"
        Me.colYarnType.Name = "colYarnType"
        Me.colYarnType.Visible = True
        Me.colYarnType.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'YarnTypeTableAdapter
        '
        Me.YarnTypeTableAdapter.ClearBeforeFill = True
        '
        'YarnCountTableAdapter
        '
        Me.YarnCountTableAdapter.ClearBeforeFill = True
        '
        'YarnQualityTableAdapter
        '
        Me.YarnQualityTableAdapter.ClearBeforeFill = True
        '
        'ItemListGridControl
        '
        Me.ItemListGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemListGridControl.DataSource = Me.ItemListBindingSource
        Me.ItemListGridControl.Location = New System.Drawing.Point(0, 19)
        Me.ItemListGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ItemListGridControl.MainView = Me.GridView1
        Me.ItemListGridControl.Name = "ItemListGridControl"
        Me.ItemListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemGridLookUpEdit7, Me.RepositoryItemGridLookUpEdit8, Me.RepositoryItemGridLookUpEdit9, Me.RepositoryItemGridLookUpEdit10, Me.RepositoryItemGridLookUpEdit11})
        Me.ItemListGridControl.Size = New System.Drawing.Size(1121, 147)
        Me.ItemListGridControl.TabIndex = 8
        Me.ItemListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName, Me.colOriginId, Me.colBrandId, Me.colCategoryId, Me.colSubCategoryId, Me.colUnitId, Me.colQuantityPerPacket, Me.colPreviousPrice, Me.colCurrentPrice, Me.colDiscontinue, Me.colPipelineQuantity, Me.colPipeLineDate, Me.colDollarPrice, Me.colYarnTypeId1, Me.colYarnQuality1, Me.colYarnLotNo, Me.colYarnCount, Me.colExpireLabel, Me.colItemDescription, Me.colItemId, Me.colReorderLabel, Me.colAccessoriesId})
        Me.GridView1.GridControl = Me.ItemListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.OptionsColumn.AllowEdit = False
        Me.colItemName.OptionsColumn.ReadOnly = True
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        Me.colItemName.Width = 173
        '
        'colOriginId
        '
        Me.colOriginId.AppearanceHeader.Options.UseTextOptions = True
        Me.colOriginId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOriginId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOriginId.Caption = "Origin"
        Me.colOriginId.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colOriginId.FieldName = "OriginId"
        Me.colOriginId.Name = "colOriginId"
        Me.colOriginId.OptionsColumn.AllowEdit = False
        Me.colOriginId.OptionsColumn.ReadOnly = True
        Me.colOriginId.Visible = True
        Me.colOriginId.VisibleIndex = 2
        Me.colOriginId.Width = 82
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.OriginBindingSource
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "Origin"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.NullText = ""
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "OriginId"
        Me.RepositoryItemGridLookUpEdit8.View = Me.RepositoryItemGridLookUpEdit8View
        '
        'RepositoryItemGridLookUpEdit8View
        '
        Me.RepositoryItemGridLookUpEdit8View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOriginId1, Me.colOrigin})
        Me.RepositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit8View.Name = "RepositoryItemGridLookUpEdit8View"
        Me.RepositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = False
        '
        'colOriginId1
        '
        Me.colOriginId1.FieldName = "OriginId"
        Me.colOriginId1.Name = "colOriginId1"
        Me.colOriginId1.OptionsColumn.ReadOnly = True
        '
        'colOrigin
        '
        Me.colOrigin.FieldName = "Origin"
        Me.colOrigin.Name = "colOrigin"
        Me.colOrigin.Visible = True
        Me.colOrigin.VisibleIndex = 0
        '
        'colBrandId
        '
        Me.colBrandId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBrandId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBrandId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBrandId.Caption = "Brand"
        Me.colBrandId.ColumnEdit = Me.RepositoryItemGridLookUpEdit7
        Me.colBrandId.FieldName = "BrandId"
        Me.colBrandId.Name = "colBrandId"
        Me.colBrandId.OptionsColumn.AllowEdit = False
        Me.colBrandId.OptionsColumn.ReadOnly = True
        Me.colBrandId.Visible = True
        Me.colBrandId.VisibleIndex = 3
        Me.colBrandId.Width = 87
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.BrandBindingSource
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "BrandCode"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "BrandId"
        Me.RepositoryItemGridLookUpEdit7.View = Me.RepositoryItemGridLookUpEdit7View
        '
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBrandId1, Me.colBrandCode, Me.colBrandName, Me.colDepartmentId4})
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'colBrandId1
        '
        Me.colBrandId1.FieldName = "BrandId"
        Me.colBrandId1.Name = "colBrandId1"
        Me.colBrandId1.OptionsColumn.ReadOnly = True
        '
        'colBrandCode
        '
        Me.colBrandCode.FieldName = "BrandCode"
        Me.colBrandCode.Name = "colBrandCode"
        Me.colBrandCode.Visible = True
        Me.colBrandCode.VisibleIndex = 0
        '
        'colBrandName
        '
        Me.colBrandName.FieldName = "BrandName"
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.Visible = True
        Me.colBrandName.VisibleIndex = 1
        '
        'colDepartmentId4
        '
        Me.colDepartmentId4.FieldName = "DepartmentId"
        Me.colDepartmentId4.Name = "colDepartmentId4"
        '
        'colCategoryId
        '
        Me.colCategoryId.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategoryId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategoryId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCategoryId.Caption = "Category"
        Me.colCategoryId.ColumnEdit = Me.RepositoryItemGridLookUpEdit5
        Me.colCategoryId.FieldName = "CategoryId"
        Me.colCategoryId.Name = "colCategoryId"
        Me.colCategoryId.OptionsColumn.AllowEdit = False
        Me.colCategoryId.OptionsColumn.ReadOnly = True
        Me.colCategoryId.Visible = True
        Me.colCategoryId.VisibleIndex = 4
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.CategoryBindingSource
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "CategoryName"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "CategoryId"
        Me.RepositoryItemGridLookUpEdit5.View = Me.RepositoryItemGridLookUpEdit5View
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryId4, Me.colCategoryName1, Me.colCategoryDescription1, Me.colDepartmentId3})
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'colCategoryId4
        '
        Me.colCategoryId4.FieldName = "CategoryId"
        Me.colCategoryId4.Name = "colCategoryId4"
        Me.colCategoryId4.OptionsColumn.ReadOnly = True
        '
        'colCategoryName1
        '
        Me.colCategoryName1.FieldName = "CategoryName"
        Me.colCategoryName1.Name = "colCategoryName1"
        Me.colCategoryName1.Visible = True
        Me.colCategoryName1.VisibleIndex = 0
        '
        'colCategoryDescription1
        '
        Me.colCategoryDescription1.FieldName = "CategoryDescription"
        Me.colCategoryDescription1.Name = "colCategoryDescription1"
        '
        'colDepartmentId3
        '
        Me.colDepartmentId3.FieldName = "DepartmentId"
        Me.colDepartmentId3.Name = "colDepartmentId3"
        '
        'colSubCategoryId
        '
        Me.colSubCategoryId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubCategoryId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubCategoryId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubCategoryId.Caption = "Sub Category"
        Me.colSubCategoryId.ColumnEdit = Me.RepositoryItemGridLookUpEdit4
        Me.colSubCategoryId.FieldName = "SubCategoryId"
        Me.colSubCategoryId.Name = "colSubCategoryId"
        Me.colSubCategoryId.OptionsColumn.AllowEdit = False
        Me.colSubCategoryId.OptionsColumn.ReadOnly = True
        Me.colSubCategoryId.Visible = True
        Me.colSubCategoryId.VisibleIndex = 5
        Me.colSubCategoryId.Width = 102
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.SubCategoryLookupBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "SubCategoryName"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.NullText = ""
        Me.RepositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "SubCategoryId"
        Me.RepositoryItemGridLookUpEdit4.View = Me.RepositoryItemGridLookUpEdit4View
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubCategoryId2, Me.colCategoryId3, Me.colSubCategoryName1, Me.colSubCategoryDescription1, Me.colDepartmentId2})
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colSubCategoryId2
        '
        Me.colSubCategoryId2.FieldName = "SubCategoryId"
        Me.colSubCategoryId2.Name = "colSubCategoryId2"
        Me.colSubCategoryId2.OptionsColumn.ReadOnly = True
        '
        'colCategoryId3
        '
        Me.colCategoryId3.FieldName = "CategoryId"
        Me.colCategoryId3.Name = "colCategoryId3"
        '
        'colSubCategoryName1
        '
        Me.colSubCategoryName1.FieldName = "SubCategoryName"
        Me.colSubCategoryName1.Name = "colSubCategoryName1"
        Me.colSubCategoryName1.Visible = True
        Me.colSubCategoryName1.VisibleIndex = 0
        '
        'colSubCategoryDescription1
        '
        Me.colSubCategoryDescription1.FieldName = "SubCategoryDescription"
        Me.colSubCategoryDescription1.Name = "colSubCategoryDescription1"
        '
        'colDepartmentId2
        '
        Me.colDepartmentId2.FieldName = "DepartmentId"
        Me.colDepartmentId2.Name = "colDepartmentId2"
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.AllowEdit = False
        Me.colUnitId.OptionsColumn.ReadOnly = True
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 6
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = ""
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "UnitId"
        Me.RepositoryItemGridLookUpEdit6.View = Me.RepositoryItemGridLookUpEdit6View
        '
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = False
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
        'colQuantityPerPacket
        '
        Me.colQuantityPerPacket.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuantityPerPacket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuantityPerPacket.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuantityPerPacket.FieldName = "QuantityPerPacket"
        Me.colQuantityPerPacket.Name = "colQuantityPerPacket"
        Me.colQuantityPerPacket.OptionsColumn.AllowEdit = False
        Me.colQuantityPerPacket.OptionsColumn.ReadOnly = True
        Me.colQuantityPerPacket.Visible = True
        Me.colQuantityPerPacket.VisibleIndex = 7
        Me.colQuantityPerPacket.Width = 85
        '
        'colPreviousPrice
        '
        Me.colPreviousPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreviousPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreviousPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreviousPrice.FieldName = "PreviousPrice"
        Me.colPreviousPrice.Name = "colPreviousPrice"
        Me.colPreviousPrice.OptionsColumn.AllowEdit = False
        Me.colPreviousPrice.OptionsColumn.ReadOnly = True
        Me.colPreviousPrice.Visible = True
        Me.colPreviousPrice.VisibleIndex = 8
        Me.colPreviousPrice.Width = 94
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colCurrentPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCurrentPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        Me.colCurrentPrice.OptionsColumn.AllowEdit = False
        Me.colCurrentPrice.OptionsColumn.ReadOnly = True
        Me.colCurrentPrice.Visible = True
        Me.colCurrentPrice.VisibleIndex = 9
        '
        'colDiscontinue
        '
        Me.colDiscontinue.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscontinue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscontinue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.OptionsColumn.AllowEdit = False
        Me.colDiscontinue.OptionsColumn.ReadOnly = True
        Me.colDiscontinue.Visible = True
        Me.colDiscontinue.VisibleIndex = 10
        '
        'colPipelineQuantity
        '
        Me.colPipelineQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colPipelineQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPipelineQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPipelineQuantity.FieldName = "PipelineQuantity"
        Me.colPipelineQuantity.Name = "colPipelineQuantity"
        Me.colPipelineQuantity.OptionsColumn.AllowEdit = False
        Me.colPipelineQuantity.OptionsColumn.ReadOnly = True
        Me.colPipelineQuantity.Visible = True
        Me.colPipelineQuantity.VisibleIndex = 11
        '
        'colPipeLineDate
        '
        Me.colPipeLineDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPipeLineDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPipeLineDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPipeLineDate.FieldName = "PipeLineDate"
        Me.colPipeLineDate.Name = "colPipeLineDate"
        Me.colPipeLineDate.OptionsColumn.AllowEdit = False
        Me.colPipeLineDate.OptionsColumn.ReadOnly = True
        Me.colPipeLineDate.Visible = True
        Me.colPipeLineDate.VisibleIndex = 12
        '
        'colDollarPrice
        '
        Me.colDollarPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colDollarPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDollarPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDollarPrice.FieldName = "DollarPrice"
        Me.colDollarPrice.Name = "colDollarPrice"
        Me.colDollarPrice.OptionsColumn.AllowEdit = False
        Me.colDollarPrice.OptionsColumn.ReadOnly = True
        Me.colDollarPrice.Visible = True
        Me.colDollarPrice.VisibleIndex = 13
        '
        'colYarnTypeId1
        '
        Me.colYarnTypeId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnTypeId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnTypeId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnTypeId1.Caption = "Yarn Type"
        Me.colYarnTypeId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit9
        Me.colYarnTypeId1.FieldName = "YarnTypeId"
        Me.colYarnTypeId1.Name = "colYarnTypeId1"
        Me.colYarnTypeId1.OptionsColumn.AllowEdit = False
        Me.colYarnTypeId1.OptionsColumn.ReadOnly = True
        Me.colYarnTypeId1.Visible = True
        Me.colYarnTypeId1.VisibleIndex = 14
        '
        'RepositoryItemGridLookUpEdit9
        '
        Me.RepositoryItemGridLookUpEdit9.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit9.DataSource = Me.YarnTypeBindingSource
        Me.RepositoryItemGridLookUpEdit9.DisplayMember = "YarnType"
        Me.RepositoryItemGridLookUpEdit9.Name = "RepositoryItemGridLookUpEdit9"
        Me.RepositoryItemGridLookUpEdit9.NullText = ""
        Me.RepositoryItemGridLookUpEdit9.ValueMember = "YarnTypeId"
        Me.RepositoryItemGridLookUpEdit9.View = Me.RepositoryItemGridLookUpEdit9View
        '
        'RepositoryItemGridLookUpEdit9View
        '
        Me.RepositoryItemGridLookUpEdit9View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit9View.Name = "RepositoryItemGridLookUpEdit9View"
        Me.RepositoryItemGridLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit9View.OptionsView.ShowGroupPanel = False
        '
        'colYarnQuality1
        '
        Me.colYarnQuality1.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnQuality1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnQuality1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnQuality1.Caption = "Yarn Quality"
        Me.colYarnQuality1.ColumnEdit = Me.RepositoryItemGridLookUpEdit10
        Me.colYarnQuality1.FieldName = "YarnQuality"
        Me.colYarnQuality1.Name = "colYarnQuality1"
        Me.colYarnQuality1.OptionsColumn.AllowEdit = False
        Me.colYarnQuality1.OptionsColumn.ReadOnly = True
        Me.colYarnQuality1.Visible = True
        Me.colYarnQuality1.VisibleIndex = 15
        '
        'RepositoryItemGridLookUpEdit10
        '
        Me.RepositoryItemGridLookUpEdit10.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit10.DataSource = Me.YarnQualityBindingSource
        Me.RepositoryItemGridLookUpEdit10.DisplayMember = "YarnQuality"
        Me.RepositoryItemGridLookUpEdit10.Name = "RepositoryItemGridLookUpEdit10"
        Me.RepositoryItemGridLookUpEdit10.NullText = ""
        Me.RepositoryItemGridLookUpEdit10.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit10.ValueMember = "YarnQualityId"
        Me.RepositoryItemGridLookUpEdit10.View = Me.RepositoryItemGridLookUpEdit10View
        '
        'RepositoryItemGridLookUpEdit10View
        '
        Me.RepositoryItemGridLookUpEdit10View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit10View.Name = "RepositoryItemGridLookUpEdit10View"
        Me.RepositoryItemGridLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit10View.OptionsView.ShowGroupPanel = False
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnLotNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnLotNo.Caption = "Yarn Lot No"
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        Me.colYarnLotNo.OptionsColumn.AllowEdit = False
        Me.colYarnLotNo.OptionsColumn.ReadOnly = True
        Me.colYarnLotNo.Visible = True
        Me.colYarnLotNo.VisibleIndex = 16
        '
        'colYarnCount
        '
        Me.colYarnCount.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnCount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnCount.Caption = "Yarn Count"
        Me.colYarnCount.ColumnEdit = Me.RepositoryItemGridLookUpEdit11
        Me.colYarnCount.FieldName = "YarnCount"
        Me.colYarnCount.Name = "colYarnCount"
        Me.colYarnCount.OptionsColumn.AllowEdit = False
        Me.colYarnCount.OptionsColumn.ReadOnly = True
        Me.colYarnCount.Visible = True
        Me.colYarnCount.VisibleIndex = 17
        '
        'RepositoryItemGridLookUpEdit11
        '
        Me.RepositoryItemGridLookUpEdit11.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit11.DataSource = Me.YarnCountBindingSource
        Me.RepositoryItemGridLookUpEdit11.DisplayMember = "Count"
        Me.RepositoryItemGridLookUpEdit11.Name = "RepositoryItemGridLookUpEdit11"
        Me.RepositoryItemGridLookUpEdit11.NullText = ""
        Me.RepositoryItemGridLookUpEdit11.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit11.ValueMember = "CountId"
        Me.RepositoryItemGridLookUpEdit11.View = Me.RepositoryItemGridLookUpEdit11View
        '
        'RepositoryItemGridLookUpEdit11View
        '
        Me.RepositoryItemGridLookUpEdit11View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit11View.Name = "RepositoryItemGridLookUpEdit11View"
        Me.RepositoryItemGridLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit11View.OptionsView.ShowGroupPanel = False
        '
        'colExpireLabel
        '
        Me.colExpireLabel.AppearanceHeader.Options.UseTextOptions = True
        Me.colExpireLabel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExpireLabel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExpireLabel.FieldName = "ExpireLabel"
        Me.colExpireLabel.Name = "colExpireLabel"
        Me.colExpireLabel.OptionsColumn.AllowEdit = False
        Me.colExpireLabel.OptionsColumn.ReadOnly = True
        Me.colExpireLabel.Visible = True
        Me.colExpireLabel.VisibleIndex = 18
        '
        'colItemDescription
        '
        Me.colItemDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.OptionsColumn.AllowEdit = False
        Me.colItemDescription.OptionsColumn.ReadOnly = True
        Me.colItemDescription.Visible = True
        Me.colItemDescription.VisibleIndex = 1
        Me.colItemDescription.Width = 149
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.AllowEdit = False
        Me.colItemId.OptionsColumn.ReadOnly = True
        '
        'colReorderLabel
        '
        Me.colReorderLabel.AppearanceHeader.Options.UseTextOptions = True
        Me.colReorderLabel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReorderLabel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReorderLabel.FieldName = "ReorderLabel"
        Me.colReorderLabel.Name = "colReorderLabel"
        Me.colReorderLabel.OptionsColumn.AllowEdit = False
        Me.colReorderLabel.OptionsColumn.ReadOnly = True
        Me.colReorderLabel.Visible = True
        Me.colReorderLabel.VisibleIndex = 19
        '
        'colAccessoriesId
        '
        Me.colAccessoriesId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colAccessoriesId.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colAccessoriesId.AppearanceCell.Options.UseBackColor = True
        Me.colAccessoriesId.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccessoriesId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccessoriesId.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colAccessoriesId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccessoriesId.Caption = "ACC ID"
        Me.colAccessoriesId.FieldName = "AccessoriesId"
        Me.colAccessoriesId.Name = "colAccessoriesId"
        Me.colAccessoriesId.Width = 60
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesListLookupTableAdapter1
        '
        Me.AccessoriesListLookupTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.Gold
        Me.GroupBox7.Controls.Add(AccItemStyleLabel)
        Me.GroupBox7.Controls.Add(Me.AccItemStyleTextEdit)
        Me.GroupBox7.Controls.Add(AccItemNameLabel)
        Me.GroupBox7.Controls.Add(Me.AccItemNameTextEdit)
        Me.GroupBox7.Controls.Add(AccBuyerIdLabel)
        Me.GroupBox7.Controls.Add(Me.AccBuyerIdGridLookUpEdit)
        Me.GroupBox7.Location = New System.Drawing.Point(40, 333)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1121, 68)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "For Accessories Store"
        '
        'AccItemStyleTextEdit
        '
        Me.AccItemStyleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccItemStyle", True))
        Me.AccItemStyleTextEdit.Location = New System.Drawing.Point(505, 26)
        Me.AccItemStyleTextEdit.Name = "AccItemStyleTextEdit"
        Me.AccItemStyleTextEdit.Size = New System.Drawing.Size(287, 20)
        Me.AccItemStyleTextEdit.TabIndex = 5
        '
        'AccItemNameTextEdit
        '
        Me.AccItemNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccItemName", True))
        Me.AccItemNameTextEdit.Location = New System.Drawing.Point(124, 26)
        Me.AccItemNameTextEdit.Name = "AccItemNameTextEdit"
        Me.AccItemNameTextEdit.Size = New System.Drawing.Size(282, 20)
        Me.AccItemNameTextEdit.TabIndex = 3
        '
        'AccBuyerIdGridLookUpEdit
        '
        Me.AccBuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccBuyerId", True))
        Me.AccBuyerIdGridLookUpEdit.Location = New System.Drawing.Point(873, 26)
        Me.AccBuyerIdGridLookUpEdit.Name = "AccBuyerIdGridLookUpEdit"
        Me.AccBuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.AccBuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.AccBuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.AccBuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.AccBuyerIdGridLookUpEdit.Properties.View = Me.AccBuyerIdGridLookUpEditView
        Me.AccBuyerIdGridLookUpEdit.Size = New System.Drawing.Size(132, 20)
        Me.AccBuyerIdGridLookUpEdit.TabIndex = 1
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
        'AccBuyerIdGridLookUpEditView
        '
        Me.AccBuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerCode, Me.colBuyerName})
        Me.AccBuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.AccBuyerIdGridLookUpEditView.Name = "AccBuyerIdGridLookUpEditView"
        Me.AccBuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AccBuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.ItemListGridControl)
        Me.Panel1.Location = New System.Drawing.Point(40, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 166)
        Me.Panel1.TabIndex = 10
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Expand Item List"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.BookingDetailsIdGridLookUpEdit)
        Me.GroupBox8.Location = New System.Drawing.Point(695, 264)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(466, 63)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "YD Details"
        '
        'BookingDetailsIdGridLookUpEdit
        '
        Me.BookingDetailsIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "YDOrderDetailsId", True))
        Me.BookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(19, 26)
        Me.BookingDetailsIdGridLookUpEdit.Name = "BookingDetailsIdGridLookUpEdit"
        Me.BookingDetailsIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.BookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDetailsIdGridLookUpEdit.Properties.DataSource = Me.YDOrderDetailsBindingSource
        Me.BookingDetailsIdGridLookUpEdit.Properties.DisplayMember = "ItemDetails"
        Me.BookingDetailsIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BookingDetailsIdGridLookUpEdit.Properties.ValueMember = "YDOrderDetailsId"
        Me.BookingDetailsIdGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.BookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(441, 20)
        Me.BookingDetailsIdGridLookUpEdit.TabIndex = 11
        Me.BookingDetailsIdGridLookUpEdit.Tag = "XTRAEDITOR"
        '
        'YDOrderDetailsBindingSource
        '
        Me.YDOrderDetailsBindingSource.DataMember = "YDOrderDetails"
        Me.YDOrderDetailsBindingSource.DataSource = Me.YDOrderLookupDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'YDOrderDetailsTableAdapter
        '
        Me.YDOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'YDOrderTableAdapter
        '
        Me.YDOrderTableAdapter.ClearBeforeFill = True
        '
        'frmItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 593)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "frmItemList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item List"
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SubCategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AvgPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpireLabelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderLabelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.YDOrderGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.IsCertifyCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.YarnQualityGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnQualityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnQualityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnQualityGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnCountGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnCountGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.AccItemStyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YDOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CategoryDataSet As KSoft_Inventory.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents SubCategoryDataSet As KSoft_Inventory.SubCategoryDataSet
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents BrandDataSet As KSoft_Inventory.BrandDataSet
    Friend WithEvents BrandDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandTableAdapter As KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents OriginDataSet As KSoft_Inventory.OriginDataSet
    Friend WithEvents OriginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OriginTableAdapter As KSoft_Inventory.OriginDataSetTableAdapters.OriginTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents QuantityPerPacketTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SubCategoryLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CategoryLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents CurrentPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreviousPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExpireLabelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReorderLabelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubCategoryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryLookupTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscontinueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DollarPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents YarnTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YarnTypeDataSet As KSoft_Inventory.YarnTypeDataSet
    Friend WithEvents YarnTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnTypeTableAdapter As KSoft_Inventory.YarnTypeDataSetTableAdapters.YarnTypeTableAdapter
    Friend WithEvents colYarnTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnQualityGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnQualityGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YarnCountGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnCountGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YCountDataSet As KSoft_Inventory.YCountDataSet
    Friend WithEvents YarnCountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnCountTableAdapter As KSoft_Inventory.YCountDataSetTableAdapters.YarnCountTableAdapter
    Friend WithEvents YarnQualityDataSet As KSoft_Inventory.YarnQualityDataSet
    Friend WithEvents YarnQualityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnQualityTableAdapter As KSoft_Inventory.YarnQualityDataSetTableAdapters.YarnQualityTableAdapter
    Friend WithEvents colYarnQualityId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnQuality As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityPerPacket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreviousPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPipelineQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPipeLineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDollarPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnQuality1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnCount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpireLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReorderLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsCertifyCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OrderLookupTableAdapter As KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Inventory.OrderLookupDataSet
    Friend WithEvents colAccessoriesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents AccessoriesListLookupTableAdapter1 As KSoft_Inventory.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
    Friend WithEvents UpdateAccButton As System.Windows.Forms.Button
    Friend WithEvents SubCategoryIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SubCategoryIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CategoryIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CategoryIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSubCategoryId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSubCategoryId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCategoryId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBrandId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit8View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOriginId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit9View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit10View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit11View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AvgPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents AccItemStyleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccItemNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccBuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents AccBuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents BookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YDOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderLookupDataSet As KSoft_Inventory.YDOrderLookupDataSet
    Friend WithEvents YDOrderDetailsTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderDetailsTableAdapter
    Friend WithEvents YDOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YDOrderTableAdapter As KSoft_Inventory.YDOrderLookupDataSetTableAdapters.YDOrderTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents YDOrderGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As Button
    Friend WithEvents colYDOrderNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
