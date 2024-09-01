<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRRReport
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
        Dim Label4 As System.Windows.Forms.Label
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.MRRButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MRRGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MRRLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRRLookupDataSet = New KSoft_Inventory.MRRLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMRRNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRRDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MRRLookupTableAdapter = New KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RequisitionDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RequisitionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(500, 38)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 13)
        Label4.TabIndex = 41
        Label4.Text = "Department :"
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
        'MRRButton
        '
        Me.MRRButton.Location = New System.Drawing.Point(259, 8)
        Me.MRRButton.Name = "MRRButton"
        Me.MRRButton.Size = New System.Drawing.Size(73, 48)
        Me.MRRButton.TabIndex = 31
        Me.MRRButton.Text = "Show"
        Me.MRRButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "MRR No :"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(81, 8)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(172, 21)
        Me.DepartmentComboBox.TabIndex = 32
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Department :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 66)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(970, 374)
        Me.CrystalReportViewer1.TabIndex = 34
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'MRRGridLookUpEdit
        '
        Me.MRRGridLookUpEdit.Location = New System.Drawing.Point(81, 36)
        Me.MRRGridLookUpEdit.Name = "MRRGridLookUpEdit"
        Me.MRRGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRRGridLookUpEdit.Properties.DataSource = Me.MRRLookupBindingSource
        Me.MRRGridLookUpEdit.Properties.DisplayMember = "MRRNo"
        Me.MRRGridLookUpEdit.Properties.NullText = ""
        Me.MRRGridLookUpEdit.Properties.ValueMember = "MRRNo"
        Me.MRRGridLookUpEdit.Properties.View = Me.GridView2
        Me.MRRGridLookUpEdit.Size = New System.Drawing.Size(172, 20)
        Me.MRRGridLookUpEdit.TabIndex = 35
        '
        'MRRLookupBindingSource
        '
        Me.MRRLookupBindingSource.DataMember = "MRRLookup"
        Me.MRRLookupBindingSource.DataSource = Me.MRRLookupDataSet
        '
        'MRRLookupDataSet
        '
        Me.MRRLookupDataSet.DataSetName = "MRRLookupDataSet"
        Me.MRRLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMRRNo1, Me.colMRRDate1, Me.colSupplierName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colMRRNo1
        '
        Me.colMRRNo1.FieldName = "MRRNo"
        Me.colMRRNo1.Name = "colMRRNo1"
        Me.colMRRNo1.Visible = True
        Me.colMRRNo1.VisibleIndex = 0
        '
        'colMRRDate1
        '
        Me.colMRRDate1.FieldName = "MRRDate"
        Me.colMRRDate1.Name = "colMRRDate1"
        Me.colMRRDate1.Visible = True
        Me.colMRRDate1.VisibleIndex = 1
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 2
        '
        'MRRLookupTableAdapter
        '
        Me.MRRLookupTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(805, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RequisitionDateTimePicker2
        '
        Me.RequisitionDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker2.Location = New System.Drawing.Point(703, 5)
        Me.RequisitionDateTimePicker2.Name = "RequisitionDateTimePicker2"
        Me.RequisitionDateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker2.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(677, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(477, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "MRR Date From :"
        '
        'RequisitionDateTimePicker
        '
        Me.RequisitionDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker.Location = New System.Drawing.Point(575, 5)
        Me.RequisitionDateTimePicker.Name = "RequisitionDateTimePicker"
        Me.RequisitionDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(805, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemDepartmentIdGridLookUpEdit
        '
        Me.ItemDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(575, 37)
        Me.ItemDepartmentIdGridLookUpEdit.Name = "ItemDepartmentIdGridLookUpEdit"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemDepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.View = Me.ItemDepartmentIdGridLookUpEditView
        Me.ItemDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(224, 20)
        Me.ItemDepartmentIdGridLookUpEdit.TabIndex = 44
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
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(338, 8)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(73, 48)
        Me.PrintButton.TabIndex = 45
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(886, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "&Details"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(886, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "&Details"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmMRRReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 442)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ItemDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.RequisitionDateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RequisitionDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MRRGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MRRButton)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmMRRReport"
        Me.Text = "Material Received Report"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents MRRButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MRRGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMRRNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MRRLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRRLookupDataSet As KSoft_Inventory.MRRLookupDataSet
    Friend WithEvents MRRLookupTableAdapter As KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents RequisitionDateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RequisitionDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents ItemDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
