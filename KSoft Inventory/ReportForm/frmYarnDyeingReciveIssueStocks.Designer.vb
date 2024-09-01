<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnDyeingReciveIssueStocks
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
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.RunningRadioButton = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IssueProgramLookupDataSet = New KSoft_Inventory.IssueProgramLookupDataSet()
        Me.IssueProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueProgramLookupTableAdapter = New KSoft_Inventory.IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrgStyleBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricBookingLookUpTableAdapter = New KSoft_Inventory.FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter()
        Me.FinishFabricBookingLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FFBLookupDataSet = New KSoft_Inventory.FFBLookupDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 85)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1142, 319)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
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
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(8, 32)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(137, 21)
        Me.DepartmentComboBox.TabIndex = 42
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Department:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "To :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(472, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker2.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Date From :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(472, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AllRadioButton)
        Me.GroupBox1.Controls.Add(Me.RunningRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 71)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Checked = True
        Me.AllRadioButton.Location = New System.Drawing.Point(16, 43)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(36, 17)
        Me.AllRadioButton.TabIndex = 133
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'RunningRadioButton
        '
        Me.RunningRadioButton.AutoSize = True
        Me.RunningRadioButton.Location = New System.Drawing.Point(16, 16)
        Me.RunningRadioButton.Name = "RunningRadioButton"
        Me.RunningRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.RunningRadioButton.TabIndex = 133
        Me.RunningRadioButton.Text = "Running"
        Me.RunningRadioButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 64)
        Me.Button3.TabIndex = 136
        Me.Button3.Text = "&Show Stocks"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(623, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 65)
        Me.Button1.TabIndex = 137
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
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
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
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
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(977, 15)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 46)
        Me.ShowButton.TabIndex = 140
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(831, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Program :: Style :: Buyer:"
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(828, 29)
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
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(143, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 138
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
        'FinishFabricBookingLookUpTableAdapter
        '
        Me.FinishFabricBookingLookUpTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricBookingLookUpBindingSource
        '
        Me.FinishFabricBookingLookUpBindingSource.DataMember = "FinishFabricBookingLookUp"
        Me.FinishFabricBookingLookUpBindingSource.DataSource = Me.FFBLookupDataSet
        '
        'FFBLookupDataSet
        '
        Me.FFBLookupDataSet.DataSetName = "FFBLookupDataSet"
        Me.FFBLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(685, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 67)
        Me.Button2.TabIndex = 141
        Me.Button2.Text = "&Show All [From Start]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1058, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 46)
        Me.Button4.TabIndex = 142
        Me.Button4.Text = "&Show Details"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(333, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 64)
        Me.Button5.TabIndex = 143
        Me.Button5.Text = "&Show Stocks Details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(753, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 67)
        Me.Button6.TabIndex = 144
        Me.Button6.Text = "&Show All [From Start] Details"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(561, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 64)
        Me.Button7.TabIndex = 145
        Me.Button7.Text = "Show Details"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmYarnDyeingReciveIssueStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 405)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmYarnDyeingReciveIssueStocks"
        Me.Text = "Yarn Dyeing Recive Issue Stocks"
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IssueProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents RunningRadioButton As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents IssueProgramLookupDataSet As IssueProgramLookupDataSet
    Friend WithEvents IssueProgramLookupBindingSource As BindingSource
    Friend WithEvents IssueProgramLookupTableAdapter As IssueProgramLookupDataSetTableAdapters.IssueProgramLookupTableAdapter
    Friend WithEvents ItemListLookupTableAdapter As ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemListLookupBindingSource As BindingSource
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrgStyleBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricBookingLookUpTableAdapter As FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter
    Friend WithEvents FinishFabricBookingLookUpBindingSource As BindingSource
    Friend WithEvents FFBLookupDataSet As FFBLookupDataSet
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
