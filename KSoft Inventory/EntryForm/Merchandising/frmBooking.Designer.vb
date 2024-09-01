<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Dim BookingDateLabel As System.Windows.Forms.Label
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim StyleLabel As System.Windows.Forms.Label
        Dim BuyerLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim RefNoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Inventory.BookingDataSet()
        Me.StyleTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.BookingDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Inventory.OrderLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.RefNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BuyerIdComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet()
        Me.DiscontinedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BookingProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAWSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAWSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BookingTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.BookingDataSetTableAdapters.TableAdapterManager()
        Me.BookingDetailsTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingDetailsTableAdapter()
        Me.BookingProgramNoSearchTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoSearchTableAdapter()
        Me.ItemStyleTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.ItemStyleTableAdapter()
        Me.BookingProgramNoLookupTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BookingDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.AWSItemProgramWiseLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWSItemProgramWiaeLookUpDataSet = New KSoft_Inventory.AWSItemProgramWiaeLookUpDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemStyleRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplierRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AccBOMItemLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMItemLookupNewDataSet = New KSoft_Inventory.AccBOMItemLookupNewDataSet()
        Me.AutocompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveDetailsButton = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.BookingProgramNoSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.CopyItemButton = New System.Windows.Forms.Button()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccBOMItemLookupNewTableAdapter = New KSoft_Inventory.AccBOMItemLookupNewDataSetTableAdapters.AccBOMItemLookupNewTableAdapter()
        Me.AWSItemProgramWiseLookUpTableAdapter = New KSoft_Inventory.AWSItemProgramWiaeLookUpDataSetTableAdapters.AWSItemProgramWiseLookUpTableAdapter()
        BookingDateLabel = New System.Windows.Forms.Label()
        ProgramNoLabel = New System.Windows.Forms.Label()
        StyleLabel = New System.Windows.Forms.Label()
        BuyerLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        OrderDateLabel = New System.Windows.Forms.Label()
        RefNoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscontinedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSItemProgramWiseLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSItemProgramWiaeLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMItemLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMItemLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingProgramNoSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingDateLabel
        '
        BookingDateLabel.AutoSize = True
        BookingDateLabel.Location = New System.Drawing.Point(8, 47)
        BookingDateLabel.Name = "BookingDateLabel"
        BookingDateLabel.Size = New System.Drawing.Size(124, 13)
        BookingDateLabel.TabIndex = 5
        BookingDateLabel.Text = "AWS Rcvd by Store on :"
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(8, 23)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(55, 13)
        ProgramNoLabel.TabIndex = 6
        ProgramNoLabel.Text = "AWS No :"
        '
        'StyleLabel
        '
        StyleLabel.AutoSize = True
        StyleLabel.Location = New System.Drawing.Point(671, 43)
        StyleLabel.Name = "StyleLabel"
        StyleLabel.Size = New System.Drawing.Size(33, 13)
        StyleLabel.TabIndex = 7
        StyleLabel.Text = "Style:"
        StyleLabel.Visible = False
        '
        'BuyerLabel
        '
        BuyerLabel.AutoSize = True
        BuyerLabel.Location = New System.Drawing.Point(671, 68)
        BuyerLabel.Name = "BuyerLabel"
        BuyerLabel.Size = New System.Drawing.Size(37, 13)
        BuyerLabel.TabIndex = 8
        BuyerLabel.Text = "Buyer:"
        BuyerLabel.Visible = False
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(7, 120)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 9
        RemarksLabel.Text = "Remarks:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(8, 72)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(62, 13)
        OrderDateLabel.TabIndex = 11
        OrderDateLabel.Text = "Order Date:"
        '
        'RefNoLabel
        '
        RefNoLabel.AutoSize = True
        RefNoLabel.Location = New System.Drawing.Point(8, 96)
        RefNoLabel.Name = "RefNoLabel"
        RefNoLabel.Size = New System.Drawing.Size(44, 13)
        RefNoLabel.TabIndex = 13
        RefNoLabel.Text = "Ref No:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(639, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 13)
        Label3.TabIndex = 19
        Label3.Text = "Program No :"
        Label3.Visible = False
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(280, 72)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIdLabel.TabIndex = 21
        SupplierIdLabel.Text = "Supplier:"
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTextBox
        '
        Me.StyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Style", True))
        Me.StyleTextBox.Location = New System.Drawing.Point(714, 39)
        Me.StyleTextBox.Name = "StyleTextBox"
        Me.StyleTextBox.Size = New System.Drawing.Size(131, 20)
        Me.StyleTextBox.TabIndex = 2
        Me.StyleTextBox.Visible = False
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(140, 118)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(407, 20)
        Me.RemarksTextBox.TabIndex = 4
        '
        'BookingDateDateTimePicker
        '
        Me.BookingDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.BookingDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "BookingDate", True))
        Me.BookingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BookingDateDateTimePicker.Location = New System.Drawing.Point(140, 44)
        Me.BookingDateDateTimePicker.Name = "BookingDateDateTimePicker"
        Me.BookingDateDateTimePicker.Size = New System.Drawing.Size(132, 20)
        Me.BookingDateDateTimePicker.TabIndex = 0
        '
        'BookingDetailsBindingSource
        '
        Me.BookingDetailsBindingSource.DataMember = "FK_BookingDetails_Booking"
        Me.BookingDetailsBindingSource.DataSource = Me.BookingBindingSource
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
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ProgramNoTextBox)
        Me.GroupBox1.Controls.Add(SupplierIdLabel)
        Me.GroupBox1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.CopyButton)
        Me.GroupBox1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(RefNoLabel)
        Me.GroupBox1.Controls.Add(Me.GetDataButton)
        Me.GroupBox1.Controls.Add(Me.RefNoTextEdit)
        Me.GroupBox1.Controls.Add(OrderDateLabel)
        Me.GroupBox1.Controls.Add(Me.OrderDateDateEdit)
        Me.GroupBox1.Controls.Add(Me.BuyerIdComboBox)
        Me.GroupBox1.Controls.Add(Me.DiscontinedCheckEdit)
        Me.GroupBox1.Controls.Add(Me.BookingDateDateTimePicker)
        Me.GroupBox1.Controls.Add(BookingDateLabel)
        Me.GroupBox1.Controls.Add(ProgramNoLabel)
        Me.GroupBox1.Controls.Add(StyleLabel)
        Me.GroupBox1.Controls.Add(Me.StyleTextBox)
        Me.GroupBox1.Controls.Add(BuyerLabel)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1068, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking"
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(140, 20)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ProgramNoTextBox.TabIndex = 23
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(346, 69)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(201, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 22
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
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode1, Me.colSupplierName1})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 0
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 1
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(853, 11)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(67, 23)
        Me.CopyButton.TabIndex = 21
        Me.CopyButton.Text = "Get"
        Me.CopyButton.UseVisualStyleBackColor = True
        Me.CopyButton.Visible = False
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(714, 13)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Properties.View = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 20
        Me.OrderIdGridLookUpEdit.Tag = "NR"
        Me.OrderIdGridLookUpEdit.Visible = False
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
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo1, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'GetDataButton
        '
        Me.GetDataButton.BackColor = System.Drawing.SystemColors.Control
        Me.GetDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GetDataButton.Location = New System.Drawing.Point(279, 19)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(68, 21)
        Me.GetDataButton.TabIndex = 9
        Me.GetDataButton.Tag = "NR"
        Me.GetDataButton.Text = "&Get AWS"
        Me.GetDataButton.UseVisualStyleBackColor = False
        '
        'RefNoTextEdit
        '
        Me.RefNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "RefNo", True))
        Me.RefNoTextEdit.Location = New System.Drawing.Point(140, 93)
        Me.RefNoTextEdit.Name = "RefNoTextEdit"
        Me.RefNoTextEdit.Size = New System.Drawing.Size(407, 20)
        Me.RefNoTextEdit.TabIndex = 14
        '
        'OrderDateDateEdit
        '
        Me.OrderDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "OrderDate", True))
        Me.OrderDateDateEdit.EditValue = Nothing
        Me.OrderDateDateEdit.Location = New System.Drawing.Point(140, 69)
        Me.OrderDateDateEdit.Name = "OrderDateDateEdit"
        Me.OrderDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderDateDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.OrderDateDateEdit.TabIndex = 12
        '
        'BuyerIdComboBox
        '
        Me.BuyerIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BookingBindingSource, "BuyerId", True))
        Me.BuyerIdComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerIdComboBox.DisplayMember = "BuyerCode"
        Me.BuyerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerIdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BuyerIdComboBox.FormattingEnabled = True
        Me.BuyerIdComboBox.Location = New System.Drawing.Point(714, 64)
        Me.BuyerIdComboBox.Name = "BuyerIdComboBox"
        Me.BuyerIdComboBox.Size = New System.Drawing.Size(131, 21)
        Me.BuyerIdComboBox.TabIndex = 3
        Me.BuyerIdComboBox.ValueMember = "BuyerId"
        Me.BuyerIdComboBox.Visible = False
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
        'DiscontinedCheckEdit
        '
        Me.DiscontinedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BookingBindingSource, "Discontined", True))
        Me.DiscontinedCheckEdit.Location = New System.Drawing.Point(138, 144)
        Me.DiscontinedCheckEdit.Name = "DiscontinedCheckEdit"
        Me.DiscontinedCheckEdit.Properties.Caption = "Cancel"
        Me.DiscontinedCheckEdit.Size = New System.Drawing.Size(96, 19)
        Me.DiscontinedCheckEdit.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(714, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 21)
        Me.Button1.TabIndex = 9
        Me.Button1.Tag = "NR"
        Me.Button1.Text = "&Get New Item"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Booking Details..."
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1091, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(95, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(104, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(173, 3)
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
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEntryButton.Location = New System.Drawing.Point(242, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter By AWS No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = "[Type and Select AWS No]"
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(443, 4)
        Me.ProgramNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.BookingProgramNoLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "AWSNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.Tag = "NR"
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "BookingId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit2View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(186, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 8
        Me.ProgramNoGridLookUpEdit.Tag = "NR"
        '
        'BookingProgramNoLookupBindingSource
        '
        Me.BookingProgramNoLookupBindingSource.DataMember = "BookingProgramNoLookup"
        Me.BookingProgramNoLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAWSNo, Me.colAWSDate})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colAWSNo
        '
        Me.colAWSNo.FieldName = "AWSNo"
        Me.colAWSNo.Name = "colAWSNo"
        Me.colAWSNo.Visible = True
        Me.colAWSNo.VisibleIndex = 0
        '
        'colAWSDate
        '
        Me.colAWSDate.FieldName = "AWSDate"
        Me.colAWSDate.Name = "colAWSDate"
        Me.colAWSDate.Visible = True
        Me.colAWSDate.VisibleIndex = 1
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingDetailsTableAdapter = Me.BookingDetailsTableAdapter
        Me.TableAdapterManager.BookingProgramNoSearchTableAdapter = Me.BookingProgramNoSearchTableAdapter
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.ItemStyleTableAdapter = Me.ItemStyleTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookingDetailsTableAdapter
        '
        Me.BookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoSearchTableAdapter
        '
        Me.BookingProgramNoSearchTableAdapter.ClearBeforeFill = True
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoLookupTableAdapter
        '
        Me.BookingProgramNoLookupTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BookingDetailsGridControl
        '
        Me.BookingDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookingDetailsGridControl.DataSource = Me.BookingDetailsBindingSource
        Me.BookingDetailsGridControl.Location = New System.Drawing.Point(11, 265)
        Me.BookingDetailsGridControl.MainView = Me.GridView1
        Me.BookingDetailsGridControl.Name = "BookingDetailsGridControl"
        Me.BookingDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.SupplierRepositoryItemLookUpEdit, Me.ItemStyleRepositoryItemLookUpEdit, Me.UnitLookupGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.BookingDetailsGridControl.Size = New System.Drawing.Size(1067, 272)
        Me.BookingDetailsGridControl.TabIndex = 3
        Me.BookingDetailsGridControl.UseEmbeddedNavigator = True
        Me.BookingDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemSize, Me.colItemColor, Me.colBookingQuantity, Me.colRemarks, Me.colSupplierId, Me.colItemStyleId, Me.colConsumption, Me.colUnitId, Me.colUnitPrice})
        Me.GridView1.GridControl = Me.BookingDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colItemId.AppearanceCell.Options.UseBackColor = True
        Me.colItemId.Caption = "Item Name :: Program No :: Style :: Buyer"
        Me.colItemId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colItemId.FieldName = "AWSDetailsId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BookingQuantity", "")})
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 311
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.AWSItemProgramWiseLookUpBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Details"
        Me.RepositoryItemGridLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "AWSDetailsId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        '
        'AWSItemProgramWiseLookUpBindingSource
        '
        Me.AWSItemProgramWiseLookUpBindingSource.DataMember = "AWSItemProgramWiseLookUp"
        Me.AWSItemProgramWiseLookUpBindingSource.DataSource = Me.AWSItemProgramWiaeLookUpDataSet
        '
        'AWSItemProgramWiaeLookUpDataSet
        '
        Me.AWSItemProgramWiaeLookUpDataSet.DataSetName = "AWSItemProgramWiaeLookUpDataSet"
        Me.AWSItemProgramWiaeLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'colItemSize
        '
        Me.colItemSize.Caption = "Size"
        Me.colItemSize.FieldName = "ItemSize"
        Me.colItemSize.Name = "colItemSize"
        Me.colItemSize.Visible = True
        Me.colItemSize.VisibleIndex = 1
        Me.colItemSize.Width = 99
        '
        'colItemColor
        '
        Me.colItemColor.Caption = "Color"
        Me.colItemColor.FieldName = "ItemColor"
        Me.colItemColor.Name = "colItemColor"
        Me.colItemColor.Visible = True
        Me.colItemColor.VisibleIndex = 2
        Me.colItemColor.Width = 116
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colBookingQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 4
        Me.colBookingQuantity.Width = 106
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 8
        Me.colRemarks.Width = 120
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 7
        Me.colSupplierId.Width = 99
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "SupplierName"
        Me.RepositoryItemGridLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "SupplierId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName2})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName2
        '
        Me.colSupplierName2.FieldName = "SupplierName"
        Me.colSupplierName2.Name = "colSupplierName2"
        Me.colSupplierName2.Visible = True
        Me.colSupplierName2.VisibleIndex = 0
        '
        'colItemStyleId
        '
        Me.colItemStyleId.Caption = "Item Style"
        Me.colItemStyleId.ColumnEdit = Me.ItemStyleRepositoryItemLookUpEdit
        Me.colItemStyleId.FieldName = "ItemStyleId"
        Me.colItemStyleId.Name = "colItemStyleId"
        Me.colItemStyleId.Width = 105
        '
        'ItemStyleRepositoryItemLookUpEdit
        '
        Me.ItemStyleRepositoryItemLookUpEdit.AutoHeight = False
        Me.ItemStyleRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStyle", "Item Style", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ItemStyleRepositoryItemLookUpEdit.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleRepositoryItemLookUpEdit.DisplayMember = "ItemStyle"
        Me.ItemStyleRepositoryItemLookUpEdit.Name = "ItemStyleRepositoryItemLookUpEdit"
        Me.ItemStyleRepositoryItemLookUpEdit.NullText = "[NO STYLE]"
        Me.ItemStyleRepositoryItemLookUpEdit.ValueMember = "ItemStyleId"
        '
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.BookingDataSet
        '
        'colConsumption
        '
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.VisibleIndex = 3
        Me.colConsumption.Width = 90
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookupGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 5
        Me.colUnitId.Width = 42
        '
        'UnitLookupGridLookUpEdit
        '
        Me.UnitLookupGridLookUpEdit.AutoHeight = False
        Me.UnitLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookupGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookupGridLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitLookupGridLookUpEdit.Name = "UnitLookupGridLookUpEdit"
        Me.UnitLookupGridLookUpEdit.NullText = ""
        Me.UnitLookupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UnitLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitLookupGridLookUpEdit.ValueMember = "UnitId"
        Me.UnitLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'colUnitPrice
        '
        Me.colUnitPrice.DisplayFormat.FormatString = "n4"
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 6
        Me.colUnitPrice.Width = 66
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepositoryItemLookUpEdit1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepositoryItemLookUpEdit1.Appearance.Options.UseBackColor = True
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit1.ValueMember = "ItemId"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStye", "Item Stye", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ItemStyleBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "ItemStyle"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "ItemStyleId"
        '
        'SupplierRepositoryItemLookUpEdit
        '
        Me.SupplierRepositoryItemLookUpEdit.AutoHeight = False
        Me.SupplierRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierRepositoryItemLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierRepositoryItemLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierRepositoryItemLookUpEdit.Name = "SupplierRepositoryItemLookUpEdit"
        Me.SupplierRepositoryItemLookUpEdit.NullText = "[TBC]"
        Me.SupplierRepositoryItemLookUpEdit.ValueMember = "SupplierId"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.BookingDetailsGridControl
        Me.GridView2.Name = "GridView2"
        '
        'AccBOMItemLookupNewBindingSource
        '
        Me.AccBOMItemLookupNewBindingSource.DataMember = "AccBOMItemLookupNew"
        Me.AccBOMItemLookupNewBindingSource.DataSource = Me.AccBOMItemLookupNewDataSet
        '
        'AccBOMItemLookupNewDataSet
        '
        Me.AccBOMItemLookupNewDataSet.DataSetName = "AccBOMItemLookupNewDataSet"
        Me.AccBOMItemLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutocompleteCheckBox
        '
        Me.AutocompleteCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutocompleteCheckBox.AutoSize = True
        Me.AutocompleteCheckBox.Checked = True
        Me.AutocompleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutocompleteCheckBox.Location = New System.Drawing.Point(603, 239)
        Me.AutocompleteCheckBox.Name = "AutocompleteCheckBox"
        Me.AutocompleteCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.AutocompleteCheckBox.TabIndex = 4
        Me.AutocompleteCheckBox.Text = "&Auto Complete"
        Me.AutocompleteCheckBox.UseVisualStyleBackColor = True
        Me.AutocompleteCheckBox.Visible = False
        '
        'SaveDetailsButton
        '
        Me.SaveDetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveDetailsButton.Location = New System.Drawing.Point(973, 236)
        Me.SaveDetailsButton.Name = "SaveDetailsButton"
        Me.SaveDetailsButton.Size = New System.Drawing.Size(105, 23)
        Me.SaveDetailsButton.TabIndex = 5
        Me.SaveDetailsButton.Text = "Sa&ve Details (F5)"
        Me.SaveDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveDetailsButton.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoSearchBindingSource
        '
        Me.BookingProgramNoSearchBindingSource.DataMember = "BookingProgramNoSearch"
        Me.BookingProgramNoSearchBindingSource.DataSource = Me.BookingDataSet
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'AddItemButton
        '
        Me.AddItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddItemButton.Location = New System.Drawing.Point(810, 236)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddItemButton.TabIndex = 6
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'CopyItemButton
        '
        Me.CopyItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyItemButton.Location = New System.Drawing.Point(892, 236)
        Me.CopyItemButton.Name = "CopyItemButton"
        Me.CopyItemButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyItemButton.TabIndex = 7
        Me.CopyItemButton.Text = "Copy Item"
        Me.CopyItemButton.UseVisualStyleBackColor = True
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
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'AccBOMItemLookupNewTableAdapter
        '
        Me.AccBOMItemLookupNewTableAdapter.ClearBeforeFill = True
        '
        'AWSItemProgramWiseLookUpTableAdapter
        '
        Me.AWSItemProgramWiseLookUpTableAdapter.ClearBeforeFill = True
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 549)
        Me.Controls.Add(Me.CopyItemButton)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.SaveDetailsButton)
        Me.Controls.Add(Me.AutocompleteCheckBox)
        Me.Controls.Add(Me.BookingDetailsGridControl)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmBooking"
        Me.Text = "Booking"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscontinedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSItemProgramWiseLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSItemProgramWiaeLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMItemLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMItemLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingProgramNoSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingDataSet As KSoft_Inventory.BookingDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.BookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookingDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookingDetailsTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingDetailsTableAdapter
    Friend WithEvents BookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents DiscontinedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BookingProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingProgramNoLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BookingDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    ''''''''''Friend WithEvents ItemColorLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.ItemColorLookupTableAdapter
    Friend WithEvents AutocompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveDetailsButton As System.Windows.Forms.Button
    Friend WithEvents ItemStyleTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colItemStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RefNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BookingProgramNoSearchTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoSearchTableAdapter
    Friend WithEvents BookingProgramNoSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Inventory.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddItemButton As System.Windows.Forms.Button
    Friend WithEvents CopyItemButton As System.Windows.Forms.Button
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetDataButton As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccBOMItemLookupNewDataSet As KSoft_Inventory.AccBOMItemLookupNewDataSet
    Friend WithEvents AccBOMItemLookupNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBOMItemLookupNewTableAdapter As KSoft_Inventory.AccBOMItemLookupNewDataSetTableAdapters.AccBOMItemLookupNewTableAdapter
    Friend WithEvents colAWSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AWSItemProgramWiaeLookUpDataSet As KSoft_Inventory.AWSItemProgramWiaeLookUpDataSet
    Friend WithEvents AWSItemProgramWiseLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSItemProgramWiseLookUpTableAdapter As KSoft_Inventory.AWSItemProgramWiaeLookUpDataSetTableAdapters.AWSItemProgramWiseLookUpTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAWSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
End Class
