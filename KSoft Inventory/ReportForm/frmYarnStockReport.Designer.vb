<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYarnStockReport
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
        Me.components = New System.ComponentModel.Container()
        Dim Label10 As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PhysicalButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RealButton = New System.Windows.Forms.Button()
        Me.PhysicalTextBox = New System.Windows.Forms.TextBox()
        Me.RealTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TTLDayTextBox = New System.Windows.Forms.TextBox()
        Me.ByItemCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ShowByDateButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PIListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter()
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningLCDataSet = New KSoft_Inventory.OpeningLCDataSet()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.LCListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter()
        Me.LCListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
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
        Me.Button10 = New System.Windows.Forms.Button()
        Me.LCIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Label10 = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Arial", 8.0!)
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(1073, 37)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(83, 20)
        Label10.TabIndex = 67
        Label10.Text = "PI No :"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.BackColor = System.Drawing.Color.Transparent
        SupplierIdLabel.Font = New System.Drawing.Font("Arial", 8.0!)
        SupplierIdLabel.ForeColor = System.Drawing.Color.Black
        SupplierIdLabel.Location = New System.Drawing.Point(1073, 65)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(83, 20)
        SupplierIdLabel.TabIndex = 65
        SupplierIdLabel.Text = "Brand/Supplier:"
        SupplierIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Arial", 8.0!)
        Label11.ForeColor = System.Drawing.Color.Black
        Label11.Location = New System.Drawing.Point(1073, 8)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(49, 20)
        Label11.TabIndex = 61
        Label11.Text = "LC No  :"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 119)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1316, 361)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyComboBox.DisplayMember = "CompanyCode"
        Me.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyComboBox.FormattingEnabled = True
        Me.CompanyComboBox.Location = New System.Drawing.Point(951, 8)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(116, 21)
        Me.CompanyComboBox.TabIndex = 1
        Me.CompanyComboBox.ValueMember = "CompanyId"
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
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(880, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "By Company:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Show Stocks"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(101, 66)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 5
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(267, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Show Stocks"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "By Department:"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(101, 11)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(160, 21)
        Me.DepartmentComboBox.TabIndex = 11
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(951, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "&Show Company Wise"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PhysicalButton
        '
        Me.PhysicalButton.Location = New System.Drawing.Point(838, 7)
        Me.PhysicalButton.Name = "PhysicalButton"
        Me.PhysicalButton.Size = New System.Drawing.Size(42, 24)
        Me.PhysicalButton.TabIndex = 16
        Me.PhysicalButton.Text = "&Show"
        Me.PhysicalButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Physical Stock In Hand > "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(561, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Real Stock In Hand > "
        '
        'RealButton
        '
        Me.RealButton.Location = New System.Drawing.Point(838, 34)
        Me.RealButton.Name = "RealButton"
        Me.RealButton.Size = New System.Drawing.Size(42, 24)
        Me.RealButton.TabIndex = 20
        Me.RealButton.Text = "&Show"
        Me.RealButton.UseVisualStyleBackColor = True
        '
        'PhysicalTextBox
        '
        Me.PhysicalTextBox.Location = New System.Drawing.Point(688, 9)
        Me.PhysicalTextBox.Name = "PhysicalTextBox"
        Me.PhysicalTextBox.Size = New System.Drawing.Size(74, 20)
        Me.PhysicalTextBox.TabIndex = 21
        '
        'RealTextBox
        '
        Me.RealTextBox.Location = New System.Drawing.Point(688, 36)
        Me.RealTextBox.Name = "RealTextBox"
        Me.RealTextBox.Size = New System.Drawing.Size(74, 20)
        Me.RealTextBox.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(768, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "TTL DAY > "
        '
        'TTLDayTextBox
        '
        Me.TTLDayTextBox.Location = New System.Drawing.Point(771, 36)
        Me.TTLDayTextBox.Name = "TTLDayTextBox"
        Me.TTLDayTextBox.Size = New System.Drawing.Size(61, 20)
        Me.TTLDayTextBox.TabIndex = 24
        '
        'ByItemCheckBox
        '
        Me.ByItemCheckBox.AutoSize = True
        Me.ByItemCheckBox.Location = New System.Drawing.Point(5, 67)
        Me.ByItemCheckBox.Name = "ByItemCheckBox"
        Me.ByItemCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.ByItemCheckBox.TabIndex = 25
        Me.ByItemCheckBox.Text = "By Item Name:"
        Me.ByItemCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(561, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "TTL Day From :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(782, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(838, 63)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 24)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "&Show"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(750, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "To :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(688, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "To :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(198, 91)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(63, 20)
        Me.DateTimePicker2.TabIndex = 34
        '
        'ShowByDateButton
        '
        Me.ShowByDateButton.Location = New System.Drawing.Point(267, 90)
        Me.ShowByDateButton.Name = "ShowByDateButton"
        Me.ShowByDateButton.Size = New System.Drawing.Size(180, 22)
        Me.ShowByDateButton.TabIndex = 33
        Me.ShowByDateButton.Text = "&Show Stocks By Date"
        Me.ShowByDateButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "By Date From :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(58, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(951, 62)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 23)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "&Show By Date"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'PIListBindingSource
        '
        Me.PIListBindingSource.DataMember = "PIList"
        Me.PIListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'OpeningLCDataSet
        '
        Me.OpeningLCDataSet.DataSetName = "OpeningLCDataSet"
        Me.OpeningLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LCListTableAdapter
        '
        Me.LCListTableAdapter.ClearBeforeFill = True
        '
        'LCListBindingSource
        '
        Me.LCListBindingSource.DataMember = "LCList"
        Me.LCListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'PIGridLookUpEdit
        '
        Me.PIGridLookUpEdit.Location = New System.Drawing.Point(1158, 37)
        Me.PIGridLookUpEdit.Name = "PIGridLookUpEdit"
        Me.PIGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.PIGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PIGridLookUpEdit.Properties.DataSource = Me.PIListBindingSource
        Me.PIGridLookUpEdit.Properties.DisplayMember = "PINo"
        Me.PIGridLookUpEdit.Properties.NullText = ""
        Me.PIGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.PIGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PIGridLookUpEdit.Properties.ValueMember = "PIId"
        Me.PIGridLookUpEdit.Size = New System.Drawing.Size(92, 20)
        Me.PIGridLookUpEdit.TabIndex = 69
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPINo, Me.colPIDate})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colPINo
        '
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Name = "colPINo"
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 0
        '
        'colPIDate
        '
        Me.colPIDate.FieldName = "PIDate"
        Me.colPIDate.Name = "colPIDate"
        Me.colPIDate.Visible = True
        Me.colPIDate.VisibleIndex = 1
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(1256, 34)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(55, 21)
        Me.Button12.TabIndex = 68
        Me.Button12.Text = "&Show"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(1256, 65)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(55, 21)
        Me.Button11.TabIndex = 66
        Me.Button11.Text = "&Show"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(1158, 65)
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
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(92, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 64
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
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1256, 7)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(55, 21)
        Me.Button10.TabIndex = 63
        Me.Button10.Text = "&Show"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'LCIdGridLookUpEdit
        '
        Me.LCIdGridLookUpEdit.Location = New System.Drawing.Point(1158, 8)
        Me.LCIdGridLookUpEdit.Name = "LCIdGridLookUpEdit"
        Me.LCIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCIdGridLookUpEdit.Properties.DataSource = Me.LCListBindingSource
        Me.LCIdGridLookUpEdit.Properties.DisplayMember = "LCNo"
        Me.LCIdGridLookUpEdit.Properties.NullText = ""
        Me.LCIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LCIdGridLookUpEdit.Properties.PopupView = Me.GridView3
        Me.LCIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LCIdGridLookUpEdit.Properties.ValueMember = "LCId"
        Me.LCIdGridLookUpEdit.Size = New System.Drawing.Size(92, 20)
        Me.LCIdGridLookUpEdit.TabIndex = 62
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo, Me.colLCDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 0
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        Me.colLCDate.Visible = True
        Me.colLCDate.VisibleIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 22)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "&Show LC Wise"
        Me.Button1.UseVisualStyleBackColor = True
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
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(101, 37)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(160, 21)
        Me.CategoryComboBox.TabIndex = 71
        Me.CategoryComboBox.ValueMember = "CategoryId"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(267, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 23)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "&Show Stocks"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "By Category :"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(362, 36)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 22)
        Me.Button8.TabIndex = 77
        Me.Button8.Text = "&Show LC Wise"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(362, 65)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 22)
        Me.Button9.TabIndex = 78
        Me.Button9.Text = "&Show LC Wise"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(453, 10)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(41, 21)
        Me.Button13.TabIndex = 79
        Me.Button13.Text = "R.I.B"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(453, 65)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(41, 22)
        Me.Button15.TabIndex = 81
        Me.Button15.Text = "R.I.B"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(497, 10)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(61, 21)
        Me.Button14.TabIndex = 82
        Me.Button14.Text = "Without 0"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'frmYarnStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 480)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PIGridLookUpEdit)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(SupplierIdLabel)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.LCIdGridLookUpEdit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ShowByDateButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ByItemCheckBox)
        Me.Controls.Add(Me.TTLDayTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RealTextBox)
        Me.Controls.Add(Me.PhysicalTextBox)
        Me.Controls.Add(Me.RealButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PhysicalButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmYarnStockReport"
        Me.Text = "Lotwise Transaction Stocks Report"
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CompanyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PhysicalButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RealButton As System.Windows.Forms.Button
    Friend WithEvents PhysicalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RealTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TTLDayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ByItemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ShowByDateButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents PIListTableAdapter As OpeningLCDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents PIListBindingSource As BindingSource
    Friend WithEvents OpeningLCDataSet As OpeningLCDataSet
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents LCListTableAdapter As OpeningLCDataSetTableAdapters.LCListTableAdapter
    Friend WithEvents LCListBindingSource As BindingSource
    Friend WithEvents PIGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
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
    Friend WithEvents Button10 As Button
    Friend WithEvents LCIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents CategoryDataSet As CategoryDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
End Class
