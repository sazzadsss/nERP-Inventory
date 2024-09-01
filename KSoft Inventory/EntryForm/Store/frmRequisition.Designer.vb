<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisition
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
        Dim RequisitionNoLabel1 As System.Windows.Forms.Label
        Dim RequisitionDateLabel As System.Windows.Forms.Label
        Dim UrgentLabel As System.Windows.Forms.Label
        Dim RequisitionRemaksLabel As System.Windows.Forms.Label
        Dim RequisitionIdLabel As System.Windows.Forms.Label
        Dim RequireDateLabel As System.Windows.Forms.Label
        Dim LCTypeLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.colLastReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionDataSet = New KSoft_Inventory.RequisitionDataSet()
        Me.BuyerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet()
        Me.RequisitionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.PrintingMediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataSet = New KSoft_Inventory.MediaDataSet()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.t = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.ItemBalanceDataSet = New KSoft_Inventory.ItemBalanceDataSet()
        Me.ItemBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemBalanceTableAdapter = New KSoft_Inventory.ItemBalanceDataSetTableAdapters.ItemBalanceTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Inventory.ItemBalanceDataSetTableAdapters.TableAdapterManager()
        Me.RequisitionNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequisitionDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RequisitionTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.RequisitionDataSetTableAdapters.TableAdapterManager()
        Me.RequisitionDetailsTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionDetailsTableAdapter()
        Me.RequisitionForTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionForTableAdapter()
        Me.RequisitionLookupTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter()
        Me.RequisitionRemaksTextBox = New System.Windows.Forms.TextBox()
        Me.RequisitionForBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionForGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionForRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PrintingMediaTableAdapter = New KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RequisitionLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UrgentComboBox = New System.Windows.Forms.ComboBox()
        Me.RequisitionIdTextBox = New System.Windows.Forms.TextBox()
        Me.RequisitionDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInHand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintingMediaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPaymentMode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colLTMAverage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLMUsages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLMRequisition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.colBrandId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New KSoft_Inventory.BrandDataSet()
        Me.colReceivingClosed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastReceivePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloorRequistionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemListDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDepartmentTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListDepartmentTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LMFirstDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LMLastDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LTMLastDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LTMFirstDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.RequireDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LCTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BrandTableAdapter = New KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RecalculateLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GeneratedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.RequisitionFloorLookupTableAdapter = New KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookupTableAdapter()
        Me.RequisitionFloorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorLookupDataSet = New KSoft_Inventory.RequisitionFloorLookupDataSet()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequistionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        RequisitionNoLabel1 = New System.Windows.Forms.Label()
        RequisitionDateLabel = New System.Windows.Forms.Label()
        UrgentLabel = New System.Windows.Forms.Label()
        RequisitionRemaksLabel = New System.Windows.Forms.Label()
        RequisitionIdLabel = New System.Windows.Forms.Label()
        RequireDateLabel = New System.Windows.Forms.Label()
        LCTypeLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.RequisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionForBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionForGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneratedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequisitionNoLabel1
        '
        RequisitionNoLabel1.AutoSize = True
        RequisitionNoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RequisitionNoLabel1.Location = New System.Drawing.Point(18, 52)
        RequisitionNoLabel1.Name = "RequisitionNoLabel1"
        RequisitionNoLabel1.Size = New System.Drawing.Size(94, 13)
        RequisitionNoLabel1.TabIndex = 7
        RequisitionNoLabel1.Text = "Requisition No:"
        '
        'RequisitionDateLabel
        '
        RequisitionDateLabel.AutoSize = True
        RequisitionDateLabel.Location = New System.Drawing.Point(18, 78)
        RequisitionDateLabel.Name = "RequisitionDateLabel"
        RequisitionDateLabel.Size = New System.Drawing.Size(88, 13)
        RequisitionDateLabel.TabIndex = 9
        RequisitionDateLabel.Text = "Requisition Date:"
        '
        'UrgentLabel
        '
        UrgentLabel.AutoSize = True
        UrgentLabel.Location = New System.Drawing.Point(226, 78)
        UrgentLabel.Name = "UrgentLabel"
        UrgentLabel.Size = New System.Drawing.Size(42, 13)
        UrgentLabel.TabIndex = 11
        UrgentLabel.Text = "Urgent:"
        '
        'RequisitionRemaksLabel
        '
        RequisitionRemaksLabel.AutoSize = True
        RequisitionRemaksLabel.Location = New System.Drawing.Point(18, 179)
        RequisitionRemaksLabel.Name = "RequisitionRemaksLabel"
        RequisitionRemaksLabel.Size = New System.Drawing.Size(161, 13)
        RequisitionRemaksLabel.TabIndex = 21
        RequisitionRemaksLabel.Text = "Comments By Authorized Officer:"
        '
        'RequisitionIdLabel
        '
        RequisitionIdLabel.AutoSize = True
        RequisitionIdLabel.Location = New System.Drawing.Point(482, 51)
        RequisitionIdLabel.Name = "RequisitionIdLabel"
        RequisitionIdLabel.Size = New System.Drawing.Size(74, 13)
        RequisitionIdLabel.TabIndex = 25
        RequisitionIdLabel.Text = "Requisition Id:"
        '
        'RequireDateLabel
        '
        RequireDateLabel.AutoSize = True
        RequireDateLabel.Location = New System.Drawing.Point(18, 104)
        RequireDateLabel.Name = "RequireDateLabel"
        RequireDateLabel.Size = New System.Drawing.Size(73, 13)
        RequireDateLabel.TabIndex = 32
        RequireDateLabel.Text = "Require Date:"
        '
        'LCTypeLabel
        '
        LCTypeLabel.AutoSize = True
        LCTypeLabel.Location = New System.Drawing.Point(226, 104)
        LCTypeLabel.Name = "LCTypeLabel"
        LCTypeLabel.Size = New System.Drawing.Size(85, 13)
        LCTypeLabel.TabIndex = 33
        LCTypeLabel.Text = "Purchase Type :"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(18, 130)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 34
        AttentionLabel.Text = "Attention:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(19, 154)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(75, 13)
        Label6.TabIndex = 42
        Label6.Text = "Generated By:"
        '
        'colLastReceiveDate
        '
        Me.colLastReceiveDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLastReceiveDate.AppearanceCell.Options.UseBackColor = True
        Me.colLastReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastReceiveDate.FieldName = "LastReceiveDate"
        Me.colLastReceiveDate.Name = "colLastReceiveDate"
        Me.colLastReceiveDate.Visible = True
        Me.colLastReceiveDate.VisibleIndex = 11
        '
        'RequisitionBindingSource
        '
        Me.RequisitionBindingSource.DataMember = "Requisition"
        Me.RequisitionBindingSource.DataSource = Me.RequisitionDataSet
        '
        'RequisitionDataSet
        '
        Me.RequisitionDataSet.DataSetName = "RequisitionDataSet"
        Me.RequisitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource1
        '
        Me.BuyerBindingSource1.DataMember = "Buyer"
        Me.BuyerBindingSource1.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionDetailsBindingSource
        '
        Me.RequisitionDetailsBindingSource.DataMember = "FK_RequisitionDetails_Requisition"
        Me.RequisitionDetailsBindingSource.DataSource = Me.RequisitionBindingSource
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
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        't
        '
        Me.t.ClearBeforeFill = True
        '
        'ItemBalanceDataSet
        '
        Me.ItemBalanceDataSet.DataSetName = "ItemBalanceDataSet"
        Me.ItemBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemBalanceBindingSource
        '
        Me.ItemBalanceBindingSource.DataMember = "ItemBalance"
        Me.ItemBalanceBindingSource.DataSource = Me.ItemBalanceDataSet
        '
        'ItemBalanceTableAdapter
        '
        Me.ItemBalanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Inventory.ItemBalanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequisitionNoTextEdit
        '
        Me.RequisitionNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "RequisitionNo", True))
        Me.RequisitionNoTextEdit.Location = New System.Drawing.Point(128, 49)
        Me.RequisitionNoTextEdit.Name = "RequisitionNoTextEdit"
        Me.RequisitionNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RequisitionNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RequisitionNoTextEdit.Properties.ReadOnly = True
        Me.RequisitionNoTextEdit.Size = New System.Drawing.Size(274, 20)
        Me.RequisitionNoTextEdit.TabIndex = 8
        '
        'RequisitionDateDateEdit
        '
        Me.RequisitionDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "RequisitionDate", True))
        Me.RequisitionDateDateEdit.EditValue = Nothing
        Me.RequisitionDateDateEdit.Location = New System.Drawing.Point(128, 75)
        Me.RequisitionDateDateEdit.Name = "RequisitionDateDateEdit"
        Me.RequisitionDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequisitionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequisitionDateDateEdit.Size = New System.Drawing.Size(92, 20)
        Me.RequisitionDateDateEdit.TabIndex = 10
        '
        'RequisitionTableAdapter
        '
        Me.RequisitionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RequisitionDetailsTableAdapter = Me.RequisitionDetailsTableAdapter
        Me.TableAdapterManager.RequisitionForTableAdapter = Me.RequisitionForTableAdapter
        Me.TableAdapterManager.RequisitionLookupTableAdapter = Me.RequisitionLookupTableAdapter
        Me.TableAdapterManager.RequisitionTableAdapter = Me.RequisitionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.RequisitionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequisitionDetailsTableAdapter
        '
        Me.RequisitionDetailsTableAdapter.ClearBeforeFill = True
        '
        'RequisitionForTableAdapter
        '
        Me.RequisitionForTableAdapter.ClearBeforeFill = True
        '
        'RequisitionLookupTableAdapter
        '
        Me.RequisitionLookupTableAdapter.ClearBeforeFill = True
        '
        'RequisitionRemaksTextBox
        '
        Me.RequisitionRemaksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisitionBindingSource, "RequisitionRemaks", True))
        Me.RequisitionRemaksTextBox.Location = New System.Drawing.Point(21, 199)
        Me.RequisitionRemaksTextBox.Multiline = True
        Me.RequisitionRemaksTextBox.Name = "RequisitionRemaksTextBox"
        Me.RequisitionRemaksTextBox.Size = New System.Drawing.Size(381, 21)
        Me.RequisitionRemaksTextBox.TabIndex = 22
        '
        'RequisitionForBindingSource
        '
        Me.RequisitionForBindingSource.DataMember = "Requisition_RequisitionFor"
        Me.RequisitionForBindingSource.DataSource = Me.RequisitionBindingSource
        '
        'RequisitionForGridControl
        '
        Me.RequisitionForGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequisitionForGridControl.DataSource = Me.RequisitionForBindingSource
        Me.RequisitionForGridControl.Location = New System.Drawing.Point(420, 48)
        Me.RequisitionForGridControl.MainView = Me.GridView1
        Me.RequisitionForGridControl.Name = "RequisitionForGridControl"
        Me.RequisitionForGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemLookUpEdit1})
        Me.RequisitionForGridControl.Size = New System.Drawing.Size(606, 142)
        Me.RequisitionForGridControl.TabIndex = 22
        Me.RequisitionForGridControl.UseEmbeddedNavigator = True
        Me.RequisitionForGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colStyle, Me.colBuyerId, Me.colOrderQuantity, Me.colRequisitionForRemarks})
        Me.GridView1.GridControl = Me.RequisitionForGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colStyle
        '
        Me.colStyle.FieldName = "Style"
        Me.colStyle.Name = "colStyle"
        Me.colStyle.Visible = True
        Me.colStyle.VisibleIndex = 1
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyerName", "Buyer Name")})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.BuyerBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "BuyerName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "BuyerId"
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 3
        '
        'colRequisitionForRemarks
        '
        Me.colRequisitionForRemarks.Caption = "Remarks"
        Me.colRequisitionForRemarks.FieldName = "RequisitionForRemarks"
        Me.colRequisitionForRemarks.Name = "colRequisitionForRemarks"
        Me.colRequisitionForRemarks.Visible = True
        Me.colRequisitionForRemarks.VisibleIndex = 4
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.BuyerBindingSource1
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "BuyerName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "BuyerId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'PrintingMediaTableAdapter
        '
        Me.PrintingMediaTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(532, 6)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.RequisitionLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequisitionNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "RequisitionId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(169, 20)
        Me.GridLookUpEdit1.TabIndex = 23
        '
        'RequisitionLookupBindingSource
        '
        Me.RequisitionLookupBindingSource.DataMember = "RequisitionLookup"
        Me.RequisitionLookupBindingSource.DataSource = Me.RequisitionDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionId, Me.colRequisitionNo, Me.colRequisitionDate, Me.colDepartmentId})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.colRequisitionDate.FieldName = "RequisitionDate"
        Me.colRequisitionDate.Name = "colRequisitionDate"
        Me.colRequisitionDate.Visible = True
        Me.colRequisitionDate.VisibleIndex = 1
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(417, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Select Requisition No"
        '
        'UrgentComboBox
        '
        Me.UrgentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisitionBindingSource, "Urgent", True))
        Me.UrgentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UrgentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UrgentComboBox.FormattingEnabled = True
        Me.UrgentComboBox.Items.AddRange(New Object() {"Normal", "Urgent", "Top Urgent"})
        Me.UrgentComboBox.Location = New System.Drawing.Point(319, 74)
        Me.UrgentComboBox.Name = "UrgentComboBox"
        Me.UrgentComboBox.Size = New System.Drawing.Size(83, 21)
        Me.UrgentComboBox.TabIndex = 25
        '
        'RequisitionIdTextBox
        '
        Me.RequisitionIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisitionBindingSource, "RequisitionId", True))
        Me.RequisitionIdTextBox.Location = New System.Drawing.Point(562, 48)
        Me.RequisitionIdTextBox.Name = "RequisitionIdTextBox"
        Me.RequisitionIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RequisitionIdTextBox.TabIndex = 26
        '
        'RequisitionDetailsGridControl
        '
        Me.RequisitionDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequisitionDetailsGridControl.DataSource = Me.RequisitionDetailsBindingSource
        Me.RequisitionDetailsGridControl.Location = New System.Drawing.Point(21, 226)
        Me.RequisitionDetailsGridControl.MainView = Me.GridView2
        Me.RequisitionDetailsGridControl.Name = "RequisitionDetailsGridControl"
        Me.RequisitionDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemGridLookUpEdit2})
        Me.RequisitionDetailsGridControl.Size = New System.Drawing.Size(1004, 305)
        Me.RequisitionDetailsGridControl.TabIndex = 27
        Me.RequisitionDetailsGridControl.UseEmbeddedNavigator = True
        Me.RequisitionDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colQuantity, Me.colRemarks, Me.colInHand, Me.colPrintingMediaId, Me.colPaymentMode, Me.colLTMAverage, Me.colLMUsages, Me.colLMRequisition, Me.colSupplierId, Me.colBrandId, Me.colReceivingClosed, Me.colLastReceiveDate, Me.colLastReceivePrice, Me.colFloorRequistionNo})
        Me.GridView2.GridControl = Me.RequisitionDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.Caption = "ID/Item Name"
        Me.colItemId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 170
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.ItemListLookupBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "ID-Name"
        Me.RepositoryItemGridLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ItemId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colQuantity
        '
        Me.colQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 2
        Me.colQuantity.Width = 65
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        Me.colRemarks.Width = 66
        '
        'colInHand
        '
        Me.colInHand.AppearanceHeader.Options.UseTextOptions = True
        Me.colInHand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInHand.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInHand.FieldName = "InHand"
        Me.colInHand.Name = "colInHand"
        Me.colInHand.Visible = True
        Me.colInHand.VisibleIndex = 1
        Me.colInHand.Width = 60
        '
        'colPrintingMediaId
        '
        Me.colPrintingMediaId.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintingMediaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintingMediaId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintingMediaId.Caption = "Requisition For"
        Me.colPrintingMediaId.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colPrintingMediaId.FieldName = "PrintingMediaId"
        Me.colPrintingMediaId.Name = "colPrintingMediaId"
        Me.colPrintingMediaId.Visible = True
        Me.colPrintingMediaId.VisibleIndex = 3
        Me.colPrintingMediaId.Width = 100
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MediaName", "Media Name", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.PrintingMediaBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "MediaName"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ValueMember = "PrintingMediaId"
        '
        'colPaymentMode
        '
        Me.colPaymentMode.AppearanceHeader.Options.UseTextOptions = True
        Me.colPaymentMode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPaymentMode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPaymentMode.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colPaymentMode.FieldName = "PaymentMode"
        Me.colPaymentMode.Name = "colPaymentMode"
        Me.colPaymentMode.Visible = True
        Me.colPaymentMode.VisibleIndex = 4
        Me.colPaymentMode.Width = 58
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Cash", "Check"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colLTMAverage
        '
        Me.colLTMAverage.AppearanceHeader.Options.UseTextOptions = True
        Me.colLTMAverage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLTMAverage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLTMAverage.Caption = "LTM Average"
        Me.colLTMAverage.FieldName = "LTMAverage"
        Me.colLTMAverage.Name = "colLTMAverage"
        Me.colLTMAverage.Width = 67
        '
        'colLMUsages
        '
        Me.colLMUsages.AppearanceHeader.Options.UseTextOptions = True
        Me.colLMUsages.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLMUsages.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLMUsages.Caption = "LM Usages"
        Me.colLMUsages.FieldName = "LMUsages"
        Me.colLMUsages.Name = "colLMUsages"
        Me.colLMUsages.Visible = True
        Me.colLMUsages.VisibleIndex = 9
        Me.colLMUsages.Width = 55
        '
        'colLMRequisition
        '
        Me.colLMRequisition.AppearanceHeader.Options.UseTextOptions = True
        Me.colLMRequisition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLMRequisition.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLMRequisition.Caption = "LM Receive"
        Me.colLMRequisition.FieldName = "LMRequisition"
        Me.colLMRequisition.Name = "colLMRequisition"
        Me.colLMRequisition.Visible = True
        Me.colLMRequisition.VisibleIndex = 8
        Me.colLMRequisition.Width = 61
        '
        'colSupplierId
        '
        Me.colSupplierId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 6
        Me.colSupplierId.Width = 79
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "SupplierCode"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "SupplierId"
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
        'colBrandId
        '
        Me.colBrandId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBrandId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBrandId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBrandId.Caption = "Brand"
        Me.colBrandId.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colBrandId.FieldName = "BrandId"
        Me.colBrandId.Name = "colBrandId"
        Me.colBrandId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBrandId.Visible = True
        Me.colBrandId.VisibleIndex = 5
        Me.colBrandId.Width = 79
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.BrandBindingSource
        Me.RepositoryItemLookUpEdit5.DisplayMember = "BrandName"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit5.ValueMember = "BrandId"
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
        'colReceivingClosed
        '
        Me.colReceivingClosed.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceivingClosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceivingClosed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceivingClosed.FieldName = "ReceivingClosed"
        Me.colReceivingClosed.Name = "colReceivingClosed"
        Me.colReceivingClosed.Visible = True
        Me.colReceivingClosed.VisibleIndex = 10
        Me.colReceivingClosed.Width = 68
        '
        'colLastReceivePrice
        '
        Me.colLastReceivePrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLastReceivePrice.AppearanceCell.Options.UseBackColor = True
        Me.colLastReceivePrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastReceivePrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastReceivePrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastReceivePrice.FieldName = "LastReceivePrice"
        Me.colLastReceivePrice.Name = "colLastReceivePrice"
        Me.colLastReceivePrice.Visible = True
        Me.colLastReceivePrice.VisibleIndex = 12
        '
        'colFloorRequistionNo
        '
        Me.colFloorRequistionNo.FieldName = "FloorRequistionNo"
        Me.colFloorRequistionNo.Name = "colFloorRequistionNo"
        Me.colFloorRequistionNo.OptionsColumn.AllowEdit = False
        Me.colFloorRequistionNo.OptionsColumn.ReadOnly = True
        Me.colFloorRequistionNo.Visible = True
        Me.colFloorRequistionNo.VisibleIndex = 13
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ItemListDepartmentBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "ItemName"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = "[Select an Item]"
        Me.RepositoryItemLookUpEdit2.ValueMember = "ItemId"
        '
        'ItemListDepartmentBindingSource
        '
        Me.ItemListDepartmentBindingSource.DataMember = "ItemListDepartment"
        Me.ItemListDepartmentBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDepartmentTableAdapter
        '
        Me.ItemListDepartmentTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CopyButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1038, 31)
        Me.FlowLayoutPanel1.TabIndex = 28
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 25)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(72, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 25)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(141, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 25)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEntryButton.Location = New System.Drawing.Point(210, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 25)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyButton.Location = New System.Drawing.Point(279, 3)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(63, 25)
        Me.CopyButton.TabIndex = 26
        Me.CopyButton.Tag = "NR"
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Location = New System.Drawing.Point(348, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(63, 25)
        Me.PrintButton.TabIndex = 25
        Me.PrintButton.Tag = "NR"
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LMFirstDateTimePicker
        '
        Me.LMFirstDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LMFirstDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LMFirstDateTimePicker.Enabled = False
        Me.LMFirstDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LMFirstDateTimePicker.Location = New System.Drawing.Point(84, 537)
        Me.LMFirstDateTimePicker.Name = "LMFirstDateTimePicker"
        Me.LMFirstDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.LMFirstDateTimePicker.TabIndex = 29
        '
        'LMLastDateTimePicker
        '
        Me.LMLastDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LMLastDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LMLastDateTimePicker.Enabled = False
        Me.LMLastDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LMLastDateTimePicker.Location = New System.Drawing.Point(252, 537)
        Me.LMLastDateTimePicker.Name = "LMLastDateTimePicker"
        Me.LMLastDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.LMLastDateTimePicker.TabIndex = 30
        '
        'LTMLastDateTimePicker
        '
        Me.LTMLastDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LTMLastDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LTMLastDateTimePicker.Enabled = False
        Me.LTMLastDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LTMLastDateTimePicker.Location = New System.Drawing.Point(617, 537)
        Me.LTMLastDateTimePicker.Name = "LTMLastDateTimePicker"
        Me.LTMLastDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.LTMLastDateTimePicker.TabIndex = 32
        Me.LTMLastDateTimePicker.Visible = False
        '
        'LTMFirstDateTimePicker
        '
        Me.LTMFirstDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LTMFirstDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.LTMFirstDateTimePicker.Enabled = False
        Me.LTMFirstDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LTMFirstDateTimePicker.Location = New System.Drawing.Point(430, 537)
        Me.LTMFirstDateTimePicker.Name = "LTMFirstDateTimePicker"
        Me.LTMFirstDateTimePicker.Size = New System.Drawing.Size(103, 20)
        Me.LTMFirstDateTimePicker.TabIndex = 31
        Me.LTMFirstDateTimePicker.Visible = False
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'RequireDateDateEdit
        '
        Me.RequireDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "RequireDate", True))
        Me.RequireDateDateEdit.EditValue = Nothing
        Me.RequireDateDateEdit.Location = New System.Drawing.Point(128, 101)
        Me.RequireDateDateEdit.Name = "RequireDateDateEdit"
        Me.RequireDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequireDateDateEdit.Size = New System.Drawing.Size(92, 20)
        Me.RequireDateDateEdit.TabIndex = 33
        '
        'LCTypeTextEdit
        '
        Me.LCTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "LCType", True))
        Me.LCTypeTextEdit.Location = New System.Drawing.Point(319, 101)
        Me.LCTypeTextEdit.Name = "LCTypeTextEdit"
        Me.LCTypeTextEdit.Size = New System.Drawing.Size(83, 20)
        Me.LCTypeTextEdit.TabIndex = 34
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(128, 127)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(274, 20)
        Me.AttentionTextEdit.TabIndex = 35
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "LMFirstDate"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 541)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "LMLastDate"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "LTMFirstDate"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(539, 541)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "LTMLastDate"
        Me.Label5.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(737, 540)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Current Month As Last Month"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'RecalculateLinkLabel
        '
        Me.RecalculateLinkLabel.AutoSize = True
        Me.RecalculateLinkLabel.Location = New System.Drawing.Point(417, 202)
        Me.RecalculateLinkLabel.Name = "RecalculateLinkLabel"
        Me.RecalculateLinkLabel.Size = New System.Drawing.Size(185, 13)
        Me.RecalculateLinkLabel.TabIndex = 41
        Me.RecalculateLinkLabel.TabStop = True
        Me.RecalculateLinkLabel.Text = "Re-calculate selected inhand quantity"
        '
        'GeneratedByTextEdit
        '
        Me.GeneratedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionBindingSource, "GeneratedBy", True))
        Me.GeneratedByTextEdit.Location = New System.Drawing.Point(128, 152)
        Me.GeneratedByTextEdit.Name = "GeneratedByTextEdit"
        Me.GeneratedByTextEdit.Size = New System.Drawing.Size(274, 20)
        Me.GeneratedByTextEdit.TabIndex = 43
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'RequisitionFloorLookupTableAdapter
        '
        Me.RequisitionFloorLookupTableAdapter.ClearBeforeFill = True
        '
        'RequisitionFloorLookupBindingSource
        '
        Me.RequisitionFloorLookupBindingSource.DataMember = "RequisitionFloorLookup"
        Me.RequisitionFloorLookupBindingSource.DataSource = Me.RequisitionFloorLookupDataSet
        '
        'RequisitionFloorLookupDataSet
        '
        Me.RequisitionFloorLookupDataSet.DataSetName = "RequisitionFloorLookupDataSet"
        Me.RequisitionFloorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowButton
        '
        Me.ShowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(950, 197)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 46
        Me.ShowButton.Text = "&Get"
        Me.ShowButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(654, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Floor Requisition No :"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(768, 198)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.RequisitionFloorLookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "RequisitionNo"
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.ValueMember = "RequistionFloorId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView3
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(176, 20)
        Me.GridLookUpEdit2.TabIndex = 44
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.colRequistionDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "RequisitionNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'colRequistionDate
        '
        Me.colRequistionDate.FieldName = "RequistionDate"
        Me.colRequistionDate.Name = "colRequistionDate"
        Me.colRequistionDate.Visible = True
        Me.colRequistionDate.VisibleIndex = 1
        '
        'frmRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 569)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.GeneratedByTextEdit)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.RecalculateLinkLabel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(AttentionLabel)
        Me.Controls.Add(Me.AttentionTextEdit)
        Me.Controls.Add(LCTypeLabel)
        Me.Controls.Add(Me.LCTypeTextEdit)
        Me.Controls.Add(RequireDateLabel)
        Me.Controls.Add(Me.RequireDateDateEdit)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.RequisitionDetailsGridControl)
        Me.Controls.Add(Me.UrgentComboBox)
        Me.Controls.Add(Me.RequisitionForGridControl)
        Me.Controls.Add(Me.RequisitionRemaksTextBox)
        Me.Controls.Add(RequisitionNoLabel1)
        Me.Controls.Add(Me.RequisitionNoTextEdit)
        Me.Controls.Add(RequisitionDateLabel)
        Me.Controls.Add(Me.RequisitionDateDateEdit)
        Me.Controls.Add(UrgentLabel)
        Me.Controls.Add(RequisitionRemaksLabel)
        Me.Controls.Add(RequisitionIdLabel)
        Me.Controls.Add(Me.RequisitionIdTextBox)
        Me.Controls.Add(Me.LTMLastDateTimePicker)
        Me.Controls.Add(Me.LTMFirstDateTimePicker)
        Me.Controls.Add(Me.LMLastDateTimePicker)
        Me.Controls.Add(Me.LMFirstDateTimePicker)
        Me.Name = "frmRequisition"
        Me.Text = "Requisition"
        CType(Me.RequisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionForBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionForGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneratedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RequisitionDataSet As KSoft_Inventory.RequisitionDataSet
    Friend WithEvents RequisitionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.RequisitionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequisitionDetailsTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionDetailsTableAdapter
    Friend WithEvents RequisitionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents t As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemBalanceDataSet As KSoft_Inventory.ItemBalanceDataSet
    Friend WithEvents ItemBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemBalanceTableAdapter As KSoft_Inventory.ItemBalanceDataSetTableAdapters.ItemBalanceTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Inventory.ItemBalanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequisitionNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequisitionDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequisitionForTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionForTableAdapter
    Friend WithEvents RequisitionRemaksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequisitionForBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionForGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionForRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediaDataSet As KSoft_Inventory.MediaDataSet
    Friend WithEvents PrintingMediaTableAdapter As KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter
    Friend WithEvents RequisitionLookupTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RequisitionLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UrgentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RequisitionDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInHand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintingMediaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentMode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemListDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDepartmentTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListDepartmentTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LMFirstDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LTMLastDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LTMFirstDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LMLastDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents colLTMAverage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLMUsages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLMRequisition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequireDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BrandDataSet As KSoft_Inventory.BrandDataSet
    Friend WithEvents BrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandTableAdapter As KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colReceivingClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RecalculateLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GeneratedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastReceivePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionFloorLookupTableAdapter As RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookupTableAdapter
    Friend WithEvents RequisitionFloorLookupBindingSource As BindingSource
    Friend WithEvents RequisitionFloorLookupDataSet As RequisitionFloorLookupDataSet
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequistionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloorRequistionNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
