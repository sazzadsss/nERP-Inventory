<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderwiseadvanceyarnallocation
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShowByDepartmentButton = New System.Windows.Forms.Button()
        Me.DepartmentGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DyeingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnShowByItem = New System.Windows.Forms.Button()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IssueProgramLookupDataSet = New KSoft_Inventory.IssueProgramLookupDataSet()
        Me.IssueProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueProgramLookupTableAdapter = New KSoft_Inventory.IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FFBLookupDataSet = New KSoft_Inventory.FFBLookupDataSet()
        Me.FinishFabricBookingLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricBookingLookUpTableAdapter = New KSoft_Inventory.FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 65)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1227, 370)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1170, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 26)
        Me.Button3.TabIndex = 137
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.Location = New System.Drawing.Point(1030, 8)
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierLookUpEdit.Properties.NullText = ""
        Me.SupplierLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierLookUpEdit.Properties.PopupView = Me.GridView2
        Me.SupplierLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierLookUpEdit.Size = New System.Drawing.Size(134, 20)
        Me.SupplierLookUpEdit.TabIndex = 136
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName, Me.colSupplierCode})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        Me.Label6.Location = New System.Drawing.Point(958, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "By Supplier :"
        '
        'ShowByDepartmentButton
        '
        Me.ShowByDepartmentButton.Location = New System.Drawing.Point(211, 11)
        Me.ShowByDepartmentButton.Name = "ShowByDepartmentButton"
        Me.ShowByDepartmentButton.Size = New System.Drawing.Size(66, 49)
        Me.ShowByDepartmentButton.TabIndex = 134
        Me.ShowByDepartmentButton.Text = "&Show All Program [Running]"
        Me.ShowByDepartmentButton.UseVisualStyleBackColor = True
        '
        'DepartmentGridLookUpEdit
        '
        Me.DepartmentGridLookUpEdit.Location = New System.Drawing.Point(8, 23)
        Me.DepartmentGridLookUpEdit.Name = "DepartmentGridLookUpEdit"
        Me.DepartmentGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.DepartmentGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.DepartmentGridLookUpEdit.Properties.NullText = ""
        Me.DepartmentGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DepartmentGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.DepartmentGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.DepartmentGridLookUpEdit.Size = New System.Drawing.Size(197, 20)
        Me.DepartmentGridLookUpEdit.TabIndex = 133
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentId1, Me.colDepartmentName, Me.colDepartmentDescription, Me.colEmailAddress})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        Me.colDepartmentId1.OptionsColumn.ReadOnly = True
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'colDepartmentDescription
        '
        Me.colDepartmentDescription.FieldName = "DepartmentDescription"
        Me.colDepartmentDescription.Name = "colDepartmentDescription"
        '
        'colEmailAddress
        '
        Me.colEmailAddress.FieldName = "EmailAddress"
        Me.colEmailAddress.Name = "colEmailAddress"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(734, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Date [To]:"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(795, 40)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(75, 20)
        Me.ToDateTimePicker.TabIndex = 130
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 53)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(724, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Date [From]:"
        '
        'DyeingDateTimePicker
        '
        Me.DyeingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.DyeingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DyeingDateTimePicker.Location = New System.Drawing.Point(795, 8)
        Me.DyeingDateTimePicker.Name = "DyeingDateTimePicker"
        Me.DyeingDateTimePicker.Size = New System.Drawing.Size(75, 20)
        Me.DyeingDateTimePicker.TabIndex = 127
        '
        'btnShowByItem
        '
        Me.btnShowByItem.Location = New System.Drawing.Point(643, 38)
        Me.btnShowByItem.Name = "btnShowByItem"
        Me.btnShowByItem.Size = New System.Drawing.Size(75, 23)
        Me.btnShowByItem.TabIndex = 126
        Me.btnShowByItem.Text = "&Show"
        Me.btnShowByItem.UseVisualStyleBackColor = True
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(481, 39)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ItemLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 125
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.GridColumn1, Me.GridColumn2})
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "DepartmentId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ID-Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "By Item Name:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(955, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "By Company:"
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyComboBox.DisplayMember = "CompanyCode"
        Me.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyComboBox.FormattingEnabled = True
        Me.CompanyComboBox.Location = New System.Drawing.Point(1030, 34)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(134, 21)
        Me.CompanyComboBox.TabIndex = 139
        Me.CompanyComboBox.ValueMember = "CompanyId"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1170, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 138
        Me.Button2.Text = "&Show "
        Me.Button2.UseVisualStyleBackColor = True
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
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(643, 9)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 143
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(357, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Program :: Style :: Buyer:"
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(481, 10)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.FinishFabricBookingLookUpBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupView = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 141
        '
        'FinishFabricBookingIdGridLookUpEditView
        '
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(283, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 49)
        Me.Button4.TabIndex = 144
        Me.Button4.Text = "&Show All Program"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FFBLookupDataSet
        '
        Me.FFBLookupDataSet.DataSetName = "FFBLookupDataSet"
        Me.FFBLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingLookUpBindingSource
        '
        Me.FinishFabricBookingLookUpBindingSource.DataMember = "FinishFabricBookingLookUp"
        Me.FinishFabricBookingLookUpBindingSource.DataSource = Me.FFBLookupDataSet
        '
        'FinishFabricBookingLookUpTableAdapter
        '
        Me.FinishFabricBookingLookUpTableAdapter.ClearBeforeFill = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'frmOrderwiseadvanceyarnallocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 435)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SupplierLookUpEdit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShowByDepartmentButton)
        Me.Controls.Add(Me.DepartmentGridLookUpEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DyeingDateTimePicker)
        Me.Controls.Add(Me.btnShowByItem)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmOrderwiseadvanceyarnallocation"
        Me.Text = "Order Wise Advance Yarn Allocation Status"
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListLookupBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ItemListLookupTableAdapter As ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowByDepartmentButton As Button
    Friend WithEvents DepartmentGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DyeingDateTimePicker As DateTimePicker
    Friend WithEvents btnShowByItem As Button
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents CompanyComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents IssueProgramLookupDataSet As IssueProgramLookupDataSet
    Friend WithEvents IssueProgramLookupBindingSource As BindingSource
    Friend WithEvents IssueProgramLookupTableAdapter As IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button4 As Button
    Friend WithEvents FFBLookupDataSet As FFBLookupDataSet
    Friend WithEvents FinishFabricBookingLookUpBindingSource As BindingSource
    Friend WithEvents FinishFabricBookingLookUpTableAdapter As FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
End Class
