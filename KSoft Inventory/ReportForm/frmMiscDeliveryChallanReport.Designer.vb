<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscDeliveryChallanReport
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
        Dim Label9 As System.Windows.Forms.Label
        Me.ChallanGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MiscChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscChallanLookupDataSet = New KSoft_Inventory.MiscChallanLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MiscChallanLookupTableAdapter = New KSoft_Inventory.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowByChallanDateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrintInButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UserDataSet = New KSoft_Inventory.UserDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(781, 50)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(110, 13)
        Label9.TabIndex = 80
        Label9.Text = "Created/Modified By :"
        '
        'ChallanGridLookUpEdit
        '
        Me.ChallanGridLookUpEdit.Location = New System.Drawing.Point(80, 38)
        Me.ChallanGridLookUpEdit.Name = "ChallanGridLookUpEdit"
        Me.ChallanGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanGridLookUpEdit.Properties.DataSource = Me.MiscChallanLookupBindingSource
        Me.ChallanGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Properties.NullText = ""
        Me.ChallanGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.ChallanGridLookUpEdit.Properties.ValueMember = "MiscDeliveryId"
        Me.ChallanGridLookUpEdit.Size = New System.Drawing.Size(144, 20)
        Me.ChallanGridLookUpEdit.TabIndex = 47
        '
        'MiscChallanLookupBindingSource
        '
        Me.MiscChallanLookupBindingSource.DataMember = "MiscChallanLookup"
        Me.MiscChallanLookupBindingSource.DataSource = Me.MiscChallanLookupDataSet
        '
        'MiscChallanLookupDataSet
        '
        Me.MiscChallanLookupDataSet.DataSetName = "MiscChallanLookupDataSet"
        Me.MiscChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
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
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 93)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1170, 539)
        Me.CrystalReportViewer1.TabIndex = 46
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.Enabled = False
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(80, 4)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(144, 21)
        Me.DepartmentComboBox.TabIndex = 44
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Department:"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(230, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 64)
        Me.ShowButton.TabIndex = 43
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Challan No :"
        '
        'MiscChallanLookupTableAdapter
        '
        Me.MiscChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(549, 63)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "To :"
        '
        'ShowByChallanDateButton
        '
        Me.ShowByChallanDateButton.Location = New System.Drawing.Point(653, 6)
        Me.ShowByChallanDateButton.Name = "ShowByChallanDateButton"
        Me.ShowByChallanDateButton.Size = New System.Drawing.Size(58, 80)
        Me.ShowByChallanDateButton.TabIndex = 69
        Me.ShowByChallanDateButton.Text = "&Show "
        Me.ShowByChallanDateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Challan Date:"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(549, 21)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.FromDateTimePicker.TabIndex = 67
        '
        'PrintInButton
        '
        Me.PrintInButton.Location = New System.Drawing.Point(319, 4)
        Me.PrintInButton.Name = "PrintInButton"
        Me.PrintInButton.Size = New System.Drawing.Size(83, 63)
        Me.PrintInButton.TabIndex = 73
        Me.PrintInButton.Text = "Print (In)"
        Me.PrintInButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(408, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(83, 63)
        Me.PrintButton.TabIndex = 74
        Me.PrintButton.Text = "Print (Out)"
        Me.PrintButton.UseVisualStyleBackColor = True
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
        Me.Label6.Location = New System.Drawing.Point(781, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Supplier"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1022, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.Location = New System.Drawing.Point(784, 23)
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
        Me.SupplierGridLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.SupplierGridLookUpEdit.TabIndex = 76
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "3 Copies"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "5 Copies"
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1022, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(784, 66)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = ""
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.UserGridLookUpEdit.TabIndex = 83
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(717, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 80)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "&Show Details"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1086, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 85
        Me.Button4.Text = "Show Details"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1086, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 23)
        Me.Button5.TabIndex = 86
        Me.Button5.Text = "Show Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "From:"
        '
        'frmMiscDeliveryChallanReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 631)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SupplierGridLookUpEdit)
        Me.Controls.Add(Me.PrintInButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowByChallanDateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ChallanGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmMiscDeliveryChallanReport"
        Me.Text = "Misc Delivery Challan Print"
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChallanGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MiscChallanLookupDataSet As KSoft_Inventory.MiscChallanLookupDataSet
    Friend WithEvents MiscChallanLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscChallanLookupTableAdapter As KSoft_Inventory.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowByChallanDateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents PrintInButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents UserDataSet As UserDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
End Class
