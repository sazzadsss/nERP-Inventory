<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterrialReceiveIssueReport
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
        Dim BranchIdLabel As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MRRLooupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.MRRLookupTableAdapter = New KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter()
        Me.MRRLookupDataSet = New KSoft_Inventory.MRRLookupDataSet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.colUserLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.AllButton = New System.Windows.Forms.Button()
        Me.IssueButton = New System.Windows.Forms.Button()
        Me.ReceiveButton = New System.Windows.Forms.Button()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet()
        Me.SubCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryLookupTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.SubCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        BranchIdLabel = New System.Windows.Forms.Label()
        CType(Me.MRRLooupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(950, 8)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(47, 13)
        BranchIdLabel.TabIndex = 34
        BranchIdLabel.Text = "Branch :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 123)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1238, 380)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
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
        'MRRLookupTableAdapter
        '
        Me.MRRLookupTableAdapter.ClearBeforeFill = True
        '
        'MRRLookupDataSet
        '
        Me.MRRLookupDataSet.DataSetName = "MRRLookupDataSet"
        Me.MRRLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
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
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(14, 35)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(116, 21)
        Me.DepartmentComboBox.TabIndex = 2
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Department:"
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.Location = New System.Drawing.Point(285, 38)
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.ItemNameGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ItemNameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.Properties.DataSource = Me.ItemListBindingSource
        Me.ItemNameGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Properties.NullText = "[Type Item Name]"
        Me.ItemNameGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ItemNameGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.Size = New System.Drawing.Size(282, 20)
        Me.ItemNameGridLookUpEdit.TabIndex = 19
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colItemDescription, Me.colOriginId, Me.colBrandId, Me.colCategoryId, Me.colSubCategoryId, Me.colUnitId, Me.colQuantityPerPacket, Me.colPreviousPrice, Me.colCurrentPrice, Me.colDepartmentId, Me.colReorderLabel, Me.colExpireLabel, Me.colUserLabel})
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
        'colUserLabel
        '
        Me.colUserLabel.FieldName = "UserLabel"
        Me.colUserLabel.Name = "colUserLabel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "To : "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(176, 54)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'AllButton
        '
        Me.AllButton.Location = New System.Drawing.Point(475, 64)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(92, 52)
        Me.AllButton.TabIndex = 32
        Me.AllButton.Text = "All [Receive/Issue] [Item]"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'IssueButton
        '
        Me.IssueButton.Location = New System.Drawing.Point(380, 65)
        Me.IssueButton.Name = "IssueButton"
        Me.IssueButton.Size = New System.Drawing.Size(89, 52)
        Me.IssueButton.TabIndex = 31
        Me.IssueButton.Text = "Issue [Item]"
        Me.IssueButton.UseVisualStyleBackColor = True
        '
        'ReceiveButton
        '
        Me.ReceiveButton.Location = New System.Drawing.Point(285, 64)
        Me.ReceiveButton.Name = "ReceiveButton"
        Me.ReceiveButton.Size = New System.Drawing.Size(89, 52)
        Me.ReceiveButton.TabIndex = 30
        Me.ReceiveButton.Text = "Receive [Item]"
        Me.ReceiveButton.UseVisualStyleBackColor = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BranchComboBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(953, 37)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(78, 21)
        Me.BranchComboBox.TabIndex = 33
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(953, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 51)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Issue [Date]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryLookupBindingSource
        '
        Me.SubCategoryLookupBindingSource.DataMember = "SubCategoryLookup"
        Me.SubCategoryLookupBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryLookupTableAdapter
        '
        Me.SubCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(570, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Category"
        '
        'SubCategoryComboBox
        '
        Me.SubCategoryComboBox.DataSource = Me.SubCategoryLookupBindingSource
        Me.SubCategoryComboBox.DisplayMember = "SubCategoryName"
        Me.SubCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubCategoryComboBox.FormattingEnabled = True
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(763, 37)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(184, 21)
        Me.SubCategoryComboBox.TabIndex = 40
        Me.SubCategoryComboBox.ValueMember = "SubCategoryId"
        '
        'SubCategoryCheckBox
        '
        Me.SubCategoryCheckBox.AutoSize = True
        Me.SubCategoryCheckBox.Checked = True
        Me.SubCategoryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubCategoryCheckBox.Location = New System.Drawing.Point(763, 4)
        Me.SubCategoryCheckBox.Name = "SubCategoryCheckBox"
        Me.SubCategoryCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.SubCategoryCheckBox.TabIndex = 39
        Me.SubCategoryCheckBox.Text = "SubCategory"
        Me.SubCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(573, 38)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(184, 21)
        Me.CategoryComboBox.TabIndex = 38
        Me.CategoryComboBox.ValueMember = "CategoryId"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(763, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 52)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Receive     [Sub Category]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "From :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Date:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(573, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 52)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Receive [Category]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(668, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 52)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Issue [Category]"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(858, 64)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 52)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "Issue           [Sub Category]"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmMaterrialReceiveIssueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 503)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubCategoryComboBox)
        Me.Controls.Add(Me.SubCategoryCheckBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(BranchIdLabel)
        Me.Controls.Add(Me.AllButton)
        Me.Controls.Add(Me.IssueButton)
        Me.Controls.Add(Me.ReceiveButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ItemNameGridLookUpEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmMaterrialReceiveIssueReport"
        Me.Text = "Materrial Receive Issue Report"
        CType(Me.MRRLooupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MRRLooupBindingSource As BindingSource
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListBindingSource As BindingSource
    Friend WithEvents ItemListTableAdapter As ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents MRRLookupTableAdapter As MRRLookupDataSetTableAdapters.MRRLookupTableAdapter
    Friend WithEvents MRRLookupDataSet As MRRLookupDataSet
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colUserLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents AllButton As Button
    Friend WithEvents IssueButton As Button
    Friend WithEvents ReceiveButton As Button
    Friend WithEvents BranchComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents CategoryDataSet As CategoryDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents SubCategoryDataSet As SubCategoryDataSet
    Friend WithEvents SubCategoryLookupBindingSource As BindingSource
    Friend WithEvents SubCategoryLookupTableAdapter As SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents SubCategoryComboBox As ComboBox
    Friend WithEvents SubCategoryCheckBox As CheckBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
End Class
