<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemReceivedReport
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(716, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Supplier:"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(880, 21)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(98, 23)
        Me.ShowButton.TabIndex = 30
        Me.ShowButton.Text = "Show by Supplier"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.Location = New System.Drawing.Point(719, 22)
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierGridLookUpEdit.Properties.NullText = "[Type Supplier Name]"
        Me.SupplierGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.SupplierGridLookUpEdit.Size = New System.Drawing.Size(155, 20)
        Me.SupplierGridLookUpEdit.TabIndex = 31
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(338, 23)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "From: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "To : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(206, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(15, 23)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(140, 21)
        Me.DepartmentComboBox.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Department:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 78)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1146, 364)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Date:"
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
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(436, 22)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(188, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 34
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(630, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Show by Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(433, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Item Name:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(811, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Show by [Date + Item Name + Supplier Name]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmItemReceivedReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 443)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.SupplierGridLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmItemReceivedReport"
        Me.Text = "Item Received Report"
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListLookupBindingSource As BindingSource
    Friend WithEvents ItemListLookupTableAdapter As ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
