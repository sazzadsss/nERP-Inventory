<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitionReport
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
        Dim Label3 As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.RequisitionLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionDataSet = New KSoft_Inventory.RequisitionDataSet()
        Me.RequisitionLookupTableAdapter = New KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ItemDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequisitionDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RequisitionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(528, 55)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(91, 13)
        Label3.TabIndex = 38
        Label3.Text = "Department From:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 111)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1214, 455)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'RequisitionLookupBindingSource
        '
        Me.RequisitionLookupBindingSource.DataMember = "RequisitionLookup"
        Me.RequisitionLookupBindingSource.DataSource = Me.RequisitionDataSet
        '
        'RequisitionDataSet
        '
        Me.RequisitionDataSet.DataSetName = "RequisitionDataSet"
        Me.RequisitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionLookupTableAdapter
        '
        Me.RequisitionLookupTableAdapter.ClearBeforeFill = True
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
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(85, 24)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(164, 21)
        Me.DepartmentComboBox.TabIndex = 3
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Department:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Requisition No:"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(85, 62)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.RequisitionLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequisitionNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "RequisitionId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(164, 20)
        Me.GridLookUpEdit1.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionId, Me.colRequisitionNo1, Me.colRequisitionDate1, Me.colDepartmentId})
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
        'colRequisitionNo1
        '
        Me.colRequisitionNo1.FieldName = "RequisitionNo"
        Me.colRequisitionNo1.Name = "colRequisitionNo1"
        Me.colRequisitionNo1.Visible = True
        Me.colRequisitionNo1.VisibleIndex = 0
        '
        'colRequisitionDate1
        '
        Me.colRequisitionDate1.FieldName = "RequisitionDate"
        Me.colRequisitionDate1.Name = "colRequisitionDate1"
        Me.colRequisitionDate1.Visible = True
        Me.colRequisitionDate1.VisibleIndex = 1
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridLookUpEdit1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 102)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Requisition:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(346, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 96)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
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
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(1044, 20)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 14
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
        Me.Label4.Location = New System.Drawing.Point(1041, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "By Item Name:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(265, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 96)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemDepartmentIdGridLookUpEdit
        '
        Me.ItemDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(625, 53)
        Me.ItemDepartmentIdGridLookUpEdit.Name = "ItemDepartmentIdGridLookUpEdit"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemDepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.View = Me.ItemDepartmentIdGridLookUpEditView
        Me.ItemDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(147, 20)
        Me.ItemDepartmentIdGridLookUpEdit.TabIndex = 39
        '
        'ItemDepartmentIdGridLookUpEditView
        '
        Me.ItemDepartmentIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName2})
        Me.ItemDepartmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ItemDepartmentIdGridLookUpEditView.Name = "ItemDepartmentIdGridLookUpEditView"
        Me.ItemDepartmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ItemDepartmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName2
        '
        Me.colDepartmentName2.FieldName = "DepartmentName"
        Me.colDepartmentName2.Name = "colDepartmentName2"
        Me.colDepartmentName2.Visible = True
        Me.colDepartmentName2.VisibleIndex = 0
        '
        'RequisitionDateTimePicker2
        '
        Me.RequisitionDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker2.Location = New System.Drawing.Point(625, 29)
        Me.RequisitionDateTimePicker2.Name = "RequisitionDateTimePicker2"
        Me.RequisitionDateTimePicker2.Size = New System.Drawing.Size(147, 20)
        Me.RequisitionDateTimePicker2.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(596, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "To:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(503, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Requisition Date From :"
        '
        'RequisitionDateTimePicker
        '
        Me.RequisitionDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker.Location = New System.Drawing.Point(625, 6)
        Me.RequisitionDateTimePicker.Name = "RequisitionDateTimePicker"
        Me.RequisitionDateTimePicker.Size = New System.Drawing.Size(147, 20)
        Me.RequisitionDateTimePicker.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(778, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 25)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(778, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 45)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "&Show"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(426, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 97)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "&Show Purchase Requisition Status"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(862, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 45)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Detatils"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(862, 52)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(73, 25)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Detatils"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1044, 48)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 25)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "By Item Status With Date"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1044, 80)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 25)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "By Item Status From Starting"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(941, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(97, 73)
        Me.Button11.TabIndex = 48
        Me.Button11.Text = "All Purchase Requisition Status With Date"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(778, 83)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(260, 22)
        Me.Button10.TabIndex = 49
        Me.Button10.Text = "All Purchase Requisition Status From Starting"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frmRequisitionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 566)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ItemDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.RequisitionDateTimePicker2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RequisitionDateTimePicker)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmRequisitionReport"
        Me.Text = "Purchase Requisition (Print)"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents RequisitionLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionDataSet As KSoft_Inventory.RequisitionDataSet
    Friend WithEvents RequisitionLookupTableAdapter As KSoft_Inventory.RequisitionDataSetTableAdapters.RequisitionLookupTableAdapter
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ItemDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionDateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RequisitionDateTimePicker As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
End Class
