<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveryChallanReport
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
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChallanGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ChallanLookupIssuedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanLookupIssuedDataSet = New KSoft_Inventory.ChallanLookupIssuedDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIssueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanLookupIssuedIssueTableAdapter = New KSoft_Inventory.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowByChallanDateButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1242, 438)
        Me.CrystalReportViewer1.TabIndex = 40
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(81, 16)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(172, 21)
        Me.DepartmentComboBox.TabIndex = 38
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Department"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(471, 8)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(83, 42)
        Me.ShowButton.TabIndex = 37
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Challan No :"
        '
        'ChallanGridLookUpEdit
        '
        Me.ChallanGridLookUpEdit.Location = New System.Drawing.Point(321, 16)
        Me.ChallanGridLookUpEdit.Name = "ChallanGridLookUpEdit"
        Me.ChallanGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanGridLookUpEdit.Properties.DataSource = Me.ChallanLookupIssuedBindingSource
        Me.ChallanGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Properties.NullText = ""
        Me.ChallanGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.ChallanGridLookUpEdit.Properties.ValueMember = "ChallanNo"
        Me.ChallanGridLookUpEdit.Size = New System.Drawing.Size(144, 20)
        Me.ChallanGridLookUpEdit.TabIndex = 41
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
        'ChallanLookupIssuedIssueTableAdapter
        '
        Me.ChallanLookupIssuedIssueTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(649, 8)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(83, 42)
        Me.PrintButton.TabIndex = 37
        Me.PrintButton.Text = "Print (Out)"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 42)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Print (In)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(817, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "From :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(987, 8)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.ToDateTimePicker.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(951, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "To :"
        '
        'ShowByChallanDateButton
        '
        Me.ShowByChallanDateButton.Location = New System.Drawing.Point(1091, 6)
        Me.ShowByChallanDateButton.Name = "ShowByChallanDateButton"
        Me.ShowByChallanDateButton.Size = New System.Drawing.Size(58, 23)
        Me.ShowByChallanDateButton.TabIndex = 69
        Me.ShowByChallanDateButton.Text = "&Show"
        Me.ShowByChallanDateButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(741, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Challan Date :"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(853, 8)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.FromDateTimePicker.TabIndex = 67
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
        Me.Label6.Location = New System.Drawing.Point(741, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Supplier"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1091, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.Location = New System.Drawing.Point(853, 34)
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
        Me.SupplierGridLookUpEdit.TabIndex = 79
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
        'frmDeliveryChallanReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 499)
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
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmDeliveryChallanReport"
        Me.Text = "Material Delivery Challan Print"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChallanGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ChallanLookupIssuedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChallanLookupIssuedDataSet As KSoft_Inventory.ChallanLookupIssuedDataSet
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanLookupIssuedIssueTableAdapter As KSoft_Inventory.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ShowByChallanDateButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
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
End Class
