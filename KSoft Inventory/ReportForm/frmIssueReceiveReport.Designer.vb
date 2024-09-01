<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueReceiveReport
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
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LoadByDateButton = New System.Windows.Forms.Button()
        Me.IssuedToProgramButton = New System.Windows.Forms.Button()
        Me.LoanButton = New System.Windows.Forms.Button()
        Me.AllButton = New System.Windows.Forms.Button()
        Me.IssueButton = New System.Windows.Forms.Button()
        Me.ReceiveButton = New System.Windows.Forms.Button()
        Me.SupplierwiseLoanButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ItemAndDateLoanButton = New System.Windows.Forms.Button()
        Me.IssueByDateButton = New System.Windows.Forms.Button()
        Me.ReceiveByDateButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MRRLooupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRRLookupDataSet = New KSoft_Inventory.MRRLookupDataSet()
        Me.MRRLookupTableAdapter = New KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter()
        Me.colMRRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRRDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        BranchIdLabel = New System.Windows.Forms.Label()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MRRLooupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 140)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1238, 352)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(180, 151)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(114, 21)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(252, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateCheckBox
        '
        Me.DateCheckBox.AutoSize = True
        Me.DateCheckBox.Location = New System.Drawing.Point(172, 46)
        Me.DateCheckBox.Name = "DateCheckBox"
        Me.DateCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.DateCheckBox.TabIndex = 19
        Me.DateCheckBox.Text = "Date From:"
        Me.DateCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(456, 46)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(167, 20)
        Me.DateTimePicker2.TabIndex = 16
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(6, 45)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(160, 21)
        Me.DepartmentComboBox.TabIndex = 0
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
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.Location = New System.Drawing.Point(252, 10)
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.Properties.DataSource = Me.ItemListBindingSource
        Me.ItemNameGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemNameGridLookUpEdit.Properties.NullText = "[Type Item Name]"
        Me.ItemNameGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ItemNameGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.Size = New System.Drawing.Size(371, 20)
        Me.ItemNameGridLookUpEdit.TabIndex = 13
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Issue", "IssueDetails"})
        Me.ComboBox1.Location = New System.Drawing.Point(23, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.Location = New System.Drawing.Point(1027, 37)
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierGridLookUpEdit.Properties.NullText = "[Type Supplier Name]"
        Me.SupplierGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.SupplierGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierGridLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.SupplierGridLookUpEdit.TabIndex = 12
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.colSupplierName.Width = 280
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
        Me.colSupplierCode.Width = 101
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'LoadByDateButton
        '
        Me.LoadByDateButton.Location = New System.Drawing.Point(769, 45)
        Me.LoadByDateButton.Name = "LoadByDateButton"
        Me.LoadByDateButton.Size = New System.Drawing.Size(77, 40)
        Me.LoadByDateButton.TabIndex = 33
        Me.LoadByDateButton.Text = "Loan All"
        Me.ToolTip1.SetToolTip(Me.LoadByDateButton, "For Dyes & Chemical")
        Me.LoadByDateButton.UseVisualStyleBackColor = True
        '
        'IssuedToProgramButton
        '
        Me.IssuedToProgramButton.Location = New System.Drawing.Point(629, 8)
        Me.IssuedToProgramButton.Name = "IssuedToProgramButton"
        Me.IssuedToProgramButton.Size = New System.Drawing.Size(134, 23)
        Me.IssuedToProgramButton.TabIndex = 24
        Me.IssuedToProgramButton.Text = "Issued to Program"
        Me.IssuedToProgramButton.UseVisualStyleBackColor = True
        '
        'LoanButton
        '
        Me.LoanButton.Location = New System.Drawing.Point(852, 8)
        Me.LoanButton.Name = "LoanButton"
        Me.LoanButton.Size = New System.Drawing.Size(133, 23)
        Me.LoanButton.TabIndex = 23
        Me.LoanButton.Text = "Issued to Loan"
        Me.LoanButton.UseVisualStyleBackColor = True
        '
        'AllButton
        '
        Me.AllButton.Location = New System.Drawing.Point(440, 71)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(92, 52)
        Me.AllButton.TabIndex = 22
        Me.AllButton.Text = "All [Receive/Issue] [Item]"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'IssueButton
        '
        Me.IssueButton.Location = New System.Drawing.Point(347, 71)
        Me.IssueButton.Name = "IssueButton"
        Me.IssueButton.Size = New System.Drawing.Size(89, 52)
        Me.IssueButton.TabIndex = 21
        Me.IssueButton.Text = "Issue [Item]"
        Me.IssueButton.UseVisualStyleBackColor = True
        '
        'ReceiveButton
        '
        Me.ReceiveButton.Location = New System.Drawing.Point(252, 71)
        Me.ReceiveButton.Name = "ReceiveButton"
        Me.ReceiveButton.Size = New System.Drawing.Size(89, 52)
        Me.ReceiveButton.TabIndex = 20
        Me.ReceiveButton.Text = "Receive [Item]"
        Me.ReceiveButton.UseVisualStyleBackColor = True
        '
        'SupplierwiseLoanButton
        '
        Me.SupplierwiseLoanButton.Location = New System.Drawing.Point(1027, 60)
        Me.SupplierwiseLoanButton.Name = "SupplierwiseLoanButton"
        Me.SupplierwiseLoanButton.Size = New System.Drawing.Size(180, 63)
        Me.SupplierwiseLoanButton.TabIndex = 14
        Me.SupplierwiseLoanButton.Text = "Supplierwise Loan"
        Me.SupplierwiseLoanButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1027, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Supplier:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(852, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Issue Details [Auto Feed]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.BranchComboBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(BranchIdLabel)
        Me.GroupBox1.Controls.Add(Me.ItemAndDateLoanButton)
        Me.GroupBox1.Controls.Add(Me.LoadByDateButton)
        Me.GroupBox1.Controls.Add(Me.IssueByDateButton)
        Me.GroupBox1.Controls.Add(Me.ReceiveByDateButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SupplierwiseLoanButton)
        Me.GroupBox1.Controls.Add(Me.IssuedToProgramButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox1.Controls.Add(Me.SupplierGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.LoanButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AllButton)
        Me.GroupBox1.Controls.Add(Me.ItemNameGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.IssueButton)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.ReceiveButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateCheckBox)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1213, 134)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(769, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemAndDateLoanButton
        '
        Me.ItemAndDateLoanButton.Location = New System.Drawing.Point(538, 71)
        Me.ItemAndDateLoanButton.Name = "ItemAndDateLoanButton"
        Me.ItemAndDateLoanButton.Size = New System.Drawing.Size(87, 52)
        Me.ItemAndDateLoanButton.TabIndex = 34
        Me.ItemAndDateLoanButton.Text = "Loan [Item]"
        Me.ItemAndDateLoanButton.UseVisualStyleBackColor = True
        '
        'IssueByDateButton
        '
        Me.IssueByDateButton.Location = New System.Drawing.Point(700, 45)
        Me.IssueByDateButton.Name = "IssueByDateButton"
        Me.IssueByDateButton.Size = New System.Drawing.Size(63, 40)
        Me.IssueByDateButton.TabIndex = 30
        Me.IssueByDateButton.Text = "Issue [Date]"
        Me.IssueByDateButton.UseVisualStyleBackColor = True
        '
        'ReceiveByDateButton
        '
        Me.ReceiveByDateButton.Location = New System.Drawing.Point(629, 45)
        Me.ReceiveByDateButton.Name = "ReceiveByDateButton"
        Me.ReceiveByDateButton.Size = New System.Drawing.Size(65, 40)
        Me.ReceiveByDateButton.TabIndex = 29
        Me.ReceiveByDateButton.Text = "Receive [Date]"
        Me.ReceiveByDateButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(423, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "To : "
        '
        'MRRLookupDataSet
        '
        Me.MRRLookupDataSet.DataSetName = "MRRLookupDataSet"
        Me.MRRLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MRRLookupTableAdapter
        '
        Me.MRRLookupTableAdapter.ClearBeforeFill = True
        '
        'colMRRNo
        '
        Me.colMRRNo.FieldName = "MRRNo"
        Me.colMRRNo.Name = "colMRRNo"
        Me.colMRRNo.Visible = True
        Me.colMRRNo.VisibleIndex = 0
        '
        'colMRRDate
        '
        Me.colMRRDate.FieldName = "MRRDate"
        Me.colMRRDate.Name = "colMRRDate"
        Me.colMRRDate.Visible = True
        Me.colMRRDate.VisibleIndex = 1
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BranchComboBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(700, 88)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(146, 21)
        Me.BranchComboBox.TabIndex = 25
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(631, 91)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(47, 13)
        BranchIdLabel.TabIndex = 26
        BranchIdLabel.Text = "Branch :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(852, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 21)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Issue [Date]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmIssueReceiveReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 492)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmIssueReceiveReport"
        Me.Text = "Material Receive Issue And Loan Report"
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MRRLooupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SupplierwiseLoanButton As System.Windows.Forms.Button
    Friend WithEvents LoanButton As System.Windows.Forms.Button
    Friend WithEvents AllButton As System.Windows.Forms.Button
    Friend WithEvents IssueButton As System.Windows.Forms.Button
    Friend WithEvents ReceiveButton As System.Windows.Forms.Button
    Friend WithEvents IssuedToProgramButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IssueByDateButton As System.Windows.Forms.Button
    Friend WithEvents ReceiveByDateButton As System.Windows.Forms.Button
    Friend WithEvents MRRLookupDataSet As KSoft_Inventory.MRRLookupDataSet
    Friend WithEvents MRRLooupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRRLookupTableAdapter As KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter
    Friend WithEvents colMRRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoadByDateButton As System.Windows.Forms.Button
    Friend WithEvents ItemAndDateLoanButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents BranchComboBox As ComboBox
End Class
