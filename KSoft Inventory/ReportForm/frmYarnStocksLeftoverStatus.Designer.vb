<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYarnStocksLeftoverStatus
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
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 60)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(968, 436)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(907, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 21)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "&Show "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 35)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "&Show Stocks"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(603, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "By Item Name :"
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(907, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 20)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "&Show"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(603, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "By Company:"
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyComboBox.DisplayMember = "CompanyCode"
        Me.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyComboBox.FormattingEnabled = True
        Me.CompanyComboBox.Location = New System.Drawing.Point(685, 33)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(216, 21)
        Me.CompanyComboBox.TabIndex = 35
        Me.CompanyComboBox.ValueMember = "CompanyId"
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "By Department:"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(12, 29)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(137, 21)
        Me.DepartmentComboBox.TabIndex = 40
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(685, 7)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(216, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 41
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
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(275, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 36)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "&Show Stocks LC Wise"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(395, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 36)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Recv Issue Bal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmYarnStocksLeftoverStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 497)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmYarnStocksLeftoverStatus"
        Me.Text = "Yarn Stocks Report"
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListLookupBindingSource As BindingSource
    Friend WithEvents ItemListLookupTableAdapter As ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CompanyComboBox As ComboBox
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
