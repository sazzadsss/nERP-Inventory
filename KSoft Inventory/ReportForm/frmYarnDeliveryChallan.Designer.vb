<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYarnDeliveryChallan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.ChallanGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ChallanLookupIssuedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanLookupIssuedDataSet = New KSoft_Inventory.ChallanLookupIssuedDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.ChallanLookupIssuedIssueTableAdapter = New KSoft_Inventory.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PrintInButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowByChallanDateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueProgramLookupDataSet = New KSoft_Inventory.IssueProgramLookupDataSet()
        Me.IssueProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueProgramLookupTableAdapter = New KSoft_Inventory.IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrgStyleBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Challan No :"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(254, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 55)
        Me.ShowButton.TabIndex = 44
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(432, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(83, 55)
        Me.PrintButton.TabIndex = 43
        Me.PrintButton.Text = "Print [Out-House]"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Department:"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.Enabled = False
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(73, 4)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(172, 21)
        Me.DepartmentComboBox.TabIndex = 45
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
        'ChallanGridLookUpEdit
        '
        Me.ChallanGridLookUpEdit.Location = New System.Drawing.Point(73, 38)
        Me.ChallanGridLookUpEdit.Name = "ChallanGridLookUpEdit"
        Me.ChallanGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanGridLookUpEdit.Properties.DataSource = Me.ChallanLookupIssuedBindingSource
        Me.ChallanGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Properties.NullText = ""
        Me.ChallanGridLookUpEdit.Properties.ValueMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.ChallanGridLookUpEdit.TabIndex = 48
        '
        'ChallanLookupIssuedBindingSource
        '
        Me.ChallanLookupIssuedBindingSource.DataMember = "ChallanLookupIssued"
        Me.ChallanLookupIssuedBindingSource.DataSource = Me.ChallanLookupIssuedDataSet
        '
        'ChallanLookupIssuedDataSet
        '
        Me.ChallanLookupIssuedDataSet.DataSetName = "ChallanLookupIssuedDataSet"
        Me.ChallanLookupIssuedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
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
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'ChallanLookupIssuedIssueTableAdapter
        '
        Me.ChallanLookupIssuedIssueTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 76)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1247, 549)
        Me.CrystalReportViewer1.TabIndex = 49
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PrintInButton
        '
        Me.PrintInButton.Location = New System.Drawing.Point(343, 4)
        Me.PrintInButton.Name = "PrintInButton"
        Me.PrintInButton.Size = New System.Drawing.Size(83, 55)
        Me.PrintInButton.TabIndex = 43
        Me.PrintInButton.Text = "Print [In-House]"
        Me.PrintInButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(719, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "From :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(755, 36)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.ToDateTimePicker.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(719, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "To :"
        '
        'ShowByChallanDateButton
        '
        Me.ShowByChallanDateButton.Location = New System.Drawing.Point(853, 5)
        Me.ShowByChallanDateButton.Name = "ShowByChallanDateButton"
        Me.ShowByChallanDateButton.Size = New System.Drawing.Size(58, 51)
        Me.ShowByChallanDateButton.TabIndex = 63
        Me.ShowByChallanDateButton.Text = "&Show"
        Me.ShowByChallanDateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(639, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Challan Date :"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(755, 5)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.FromDateTimePicker.TabIndex = 61
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1141, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 129
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.Location = New System.Drawing.Point(979, 50)
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierLookUpEdit.Properties.NullText = ""
        Me.SupplierLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierLookUpEdit.Properties.View = Me.GridView1
        Me.SupplierLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.SupplierLookUpEdit.TabIndex = 128
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName, Me.colSupplierCode})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(924, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Supplier :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1141, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(924, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Program:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(924, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Company:"
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1141, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyIdComboBox.DisplayMember = "CompanyName"
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(979, 27)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(156, 21)
        Me.CompanyIdComboBox.TabIndex = 132
        Me.CompanyIdComboBox.ValueMember = "CompanyId"
        '
        'IssueProgramLookupDataSet
        '
        Me.IssueProgramLookupDataSet.DataSetName = "IssueProgramLookupDataSet"
        Me.IssueProgramLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssueProgramLookupBindingSource
        '
        Me.IssueProgramLookupBindingSource.DataMember = "IssueProgramLookup"
        Me.IssueProgramLookupBindingSource.DataSource = Me.IssueProgramLookupDataSet
        '
        'IssueProgramLookupTableAdapter
        '
        Me.IssueProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(979, 4)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.IssueProgramLookupBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "PrgStyleBuyer"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.View = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 133
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(521, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 55)
        Me.Button4.TabIndex = 134
        Me.Button4.Text = "Print [Sub-Contract]"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmYarnDeliveryChallan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 625)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.Controls.Add(Me.CompanyIdComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SupplierLookUpEdit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowByChallanDateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ChallanGridLookUpEdit)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrintInButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmYarnDeliveryChallan"
        Me.Text = "Yarn Delivery Challan"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents ChallanGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents ChallanLookupIssuedBindingSource As BindingSource
    Friend WithEvents ChallanLookupIssuedDataSet As ChallanLookupIssuedDataSet
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents ChallanLookupIssuedIssueTableAdapter As ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PrintInButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowByChallanDateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents Button3 As Button
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents CompanyIdComboBox As ComboBox
    Friend WithEvents IssueProgramLookupDataSet As IssueProgramLookupDataSet
    Friend WithEvents IssueProgramLookupBindingSource As BindingSource
    Friend WithEvents IssueProgramLookupTableAdapter As IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrgStyleBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button4 As Button
End Class
