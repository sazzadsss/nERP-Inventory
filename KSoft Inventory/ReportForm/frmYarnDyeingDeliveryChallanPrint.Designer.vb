<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnDyeingDeliveryChallanPrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.ChallanLookupIssuedDataSet = New KSoft_Inventory.ChallanLookupIssuedDataSet()
        Me.ChallanLookupIssuedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanLookupIssuedIssueTableAdapter = New KSoft_Inventory.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowByChallanDateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ChallanGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IssueProgramLookupTableAdapter = New KSoft_Inventory.IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter()
        Me.IssueProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueProgramLookupDataSet = New KSoft_Inventory.IssueProgramLookupDataSet()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrgStyleBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 82)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1137, 417)
        Me.CrystalReportViewer1.TabIndex = 41
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
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
        'ChallanLookupIssuedDataSet
        '
        Me.ChallanLookupIssuedDataSet.DataSetName = "ChallanLookupIssuedDataSet"
        Me.ChallanLookupIssuedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChallanLookupIssuedBindingSource
        '
        Me.ChallanLookupIssuedBindingSource.DataMember = "ChallanLookupIssued"
        Me.ChallanLookupIssuedBindingSource.DataSource = Me.ChallanLookupIssuedDataSet
        '
        'ChallanLookupIssuedIssueTableAdapter
        '
        Me.ChallanLookupIssuedIssueTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(847, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Supplier:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1058, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.Location = New System.Drawing.Point(896, 55)
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
        Me.SupplierGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.SupplierGridLookUpEdit.TabIndex = 95
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(612, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "From :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(654, 42)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "To :"
        '
        'ShowByChallanDateButton
        '
        Me.ShowByChallanDateButton.Location = New System.Drawing.Point(758, 10)
        Me.ShowByChallanDateButton.Name = "ShowByChallanDateButton"
        Me.ShowByChallanDateButton.Size = New System.Drawing.Size(58, 53)
        Me.ShowByChallanDateButton.TabIndex = 90
        Me.ShowByChallanDateButton.Text = "&Show"
        Me.ShowByChallanDateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(532, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Challan Date :"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(654, 10)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.FromDateTimePicker.TabIndex = 88
        '
        'ChallanGridLookUpEdit
        '
        Me.ChallanGridLookUpEdit.Location = New System.Drawing.Point(73, 43)
        Me.ChallanGridLookUpEdit.Name = "ChallanGridLookUpEdit"
        Me.ChallanGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanGridLookUpEdit.Properties.DataSource = Me.ChallanLookupIssuedBindingSource
        Me.ChallanGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Properties.NullText = ""
        Me.ChallanGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.ChallanGridLookUpEdit.Properties.ValueMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.ChallanGridLookUpEdit.TabIndex = 87
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colIssueDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 0
        '
        'colIssueDate
        '
        Me.colIssueDate.Caption = "Challan Date"
        Me.colIssueDate.FieldName = "IssueDate"
        Me.colIssueDate.Name = "colIssueDate"
        Me.colIssueDate.Visible = True
        Me.colIssueDate.VisibleIndex = 1
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(73, 12)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(172, 21)
        Me.DepartmentComboBox.TabIndex = 85
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Department:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 51)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Print (In)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(429, 12)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(83, 51)
        Me.PrintButton.TabIndex = 83
        Me.PrintButton.Text = "Print (Out)"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(251, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 51)
        Me.ShowButton.TabIndex = 84
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Challan No :"
        '
        'IssueProgramLookupTableAdapter
        '
        Me.IssueProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'IssueProgramLookupBindingSource
        '
        Me.IssueProgramLookupBindingSource.DataMember = "IssueProgramLookup"
        Me.IssueProgramLookupBindingSource.DataSource = Me.IssueProgramLookupDataSet
        '
        'IssueProgramLookupDataSet
        '
        Me.IssueProgramLookupDataSet.DataSetName = "IssueProgramLookupDataSet"
        Me.IssueProgramLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
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
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(896, 5)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.IssueProgramLookupBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "PrgStyleBuyer"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupView = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 139
        '
        'FinishFabricBookingIdGridLookUpEditView
        '
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrgStyleBuyer})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colPrgStyleBuyer
        '
        Me.colPrgStyleBuyer.Caption = "Program No :: Style Name :: Buyer Name"
        Me.colPrgStyleBuyer.FieldName = "PrgStyleBuyer"
        Me.colPrgStyleBuyer.Name = "colPrgStyleBuyer"
        Me.colPrgStyleBuyer.Visible = True
        Me.colPrgStyleBuyer.VisibleIndex = 0
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyIdComboBox.DisplayMember = "CompanyName"
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(896, 30)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(156, 21)
        Me.CompanyIdComboBox.TabIndex = 138
        Me.CompanyIdComboBox.ValueMember = "CompanyId"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1058, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 137
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(841, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Company:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1058, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 135
        Me.Button4.Text = "&Show"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(841, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Program:"
        '
        'frmYarnDyeingDeliveryChallanPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 499)
        Me.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.Controls.Add(Me.CompanyIdComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SupplierGridLookUpEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowByChallanDateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ChallanGridLookUpEdit)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmYarnDyeingDeliveryChallanPrint"
        Me.Text = "Yarn Dyeing Delivery Challan Print"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents ChallanLookupIssuedDataSet As ChallanLookupIssuedDataSet
    Friend WithEvents ChallanLookupIssuedBindingSource As BindingSource
    Friend WithEvents ChallanLookupIssuedIssueTableAdapter As ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowByChallanDateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents ChallanGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IssueProgramLookupTableAdapter As IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter
    Friend WithEvents IssueProgramLookupBindingSource As BindingSource
    Friend WithEvents IssueProgramLookupDataSet As IssueProgramLookupDataSet
    Friend WithEvents CompanyTableAdapter As CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrgStyleBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyIdComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
End Class
