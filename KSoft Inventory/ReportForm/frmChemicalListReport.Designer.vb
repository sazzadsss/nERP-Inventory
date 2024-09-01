<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChemicalListReport
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
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.SubCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet()
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.SubCategoryTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter()
        Me.CategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New KSoft_Inventory.BrandDataSet()
        Me.BrandTableAdapter = New KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SubStoreWiseShow = New System.Windows.Forms.Button()
        Me.SubStoreWiseComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintingMediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaDataSet = New KSoft_Inventory.MediaDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdShowSummery = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PrintingMediaTableAdapter = New KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 48)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1029, 374)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(71, 15)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(116, 21)
        Me.DepartmentComboBox.TabIndex = 1
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
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Department"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(632, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.Enabled = False
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(276, 15)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(116, 21)
        Me.CategoryComboBox.TabIndex = 4
        Me.CategoryComboBox.ValueMember = "CategoryId"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryComboBox
        '
        Me.SubCategoryComboBox.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryComboBox.DisplayMember = "SubCategoryName"
        Me.SubCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubCategoryComboBox.Enabled = False
        Me.SubCategoryComboBox.FormattingEnabled = True
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(506, 15)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(116, 21)
        Me.SubCategoryComboBox.TabIndex = 7
        Me.SubCategoryComboBox.ValueMember = "SubCategoryId"
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'CategoryCheckBox
        '
        Me.CategoryCheckBox.AutoSize = True
        Me.CategoryCheckBox.Location = New System.Drawing.Point(202, 17)
        Me.CategoryCheckBox.Name = "CategoryCheckBox"
        Me.CategoryCheckBox.Size = New System.Drawing.Size(68, 17)
        Me.CategoryCheckBox.TabIndex = 9
        Me.CategoryCheckBox.Text = "Category"
        Me.CategoryCheckBox.UseVisualStyleBackColor = True
        '
        'SubCategoryCheckBox
        '
        Me.SubCategoryCheckBox.AutoSize = True
        Me.SubCategoryCheckBox.Location = New System.Drawing.Point(410, 17)
        Me.SubCategoryCheckBox.Name = "SubCategoryCheckBox"
        Me.SubCategoryCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.SubCategoryCheckBox.TabIndex = 10
        Me.SubCategoryCheckBox.Text = "Sub Category"
        Me.SubCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'BrandComboBox
        '
        Me.BrandComboBox.DataSource = Me.BrandBindingSource
        Me.BrandComboBox.DisplayMember = "BrandName"
        Me.BrandComboBox.FormattingEnabled = True
        Me.BrandComboBox.Location = New System.Drawing.Point(756, 15)
        Me.BrandComboBox.Name = "BrandComboBox"
        Me.BrandComboBox.Size = New System.Drawing.Size(116, 21)
        Me.BrandComboBox.TabIndex = 11
        Me.BrandComboBox.ValueMember = "BrandId"
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.BrandDataSet
        '
        'BrandDataSet
        '
        Me.BrandDataSet.DataSetName = "BrandDataSet"
        Me.BrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(700, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "By Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "From"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(152, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(81, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(81, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'SubStoreWiseShow
        '
        Me.SubStoreWiseShow.Location = New System.Drawing.Point(382, 16)
        Me.SubStoreWiseShow.Name = "SubStoreWiseShow"
        Me.SubStoreWiseShow.Size = New System.Drawing.Size(90, 23)
        Me.SubStoreWiseShow.TabIndex = 17
        Me.SubStoreWiseShow.Text = "Show Details"
        Me.SubStoreWiseShow.UseVisualStyleBackColor = True
        '
        'SubStoreWiseComboBox
        '
        Me.SubStoreWiseComboBox.DataSource = Me.PrintingMediaBindingSource
        Me.SubStoreWiseComboBox.DisplayMember = "MediaName"
        Me.SubStoreWiseComboBox.FormattingEnabled = True
        Me.SubStoreWiseComboBox.Location = New System.Drawing.Point(293, 16)
        Me.SubStoreWiseComboBox.Name = "SubStoreWiseComboBox"
        Me.SubStoreWiseComboBox.Size = New System.Drawing.Size(82, 21)
        Me.SubStoreWiseComboBox.TabIndex = 18
        Me.SubStoreWiseComboBox.ValueMember = "PrintingMediaId"
        '
        'PrintingMediaBindingSource
        '
        Me.PrintingMediaBindingSource.DataMember = "PrintingMedia"
        Me.PrintingMediaBindingSource.DataSource = Me.MediaDataSet
        '
        'MediaDataSet
        '
        Me.MediaDataSet.DataSetName = "MediaDataSet"
        Me.MediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "SubStore"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdShowSummery)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.SubStoreWiseComboBox)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.SubStoreWiseShow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 45)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'CmdShowSummery
        '
        Me.CmdShowSummery.Location = New System.Drawing.Point(478, 16)
        Me.CmdShowSummery.Name = "CmdShowSummery"
        Me.CmdShowSummery.Size = New System.Drawing.Size(90, 23)
        Me.CmdShowSummery.TabIndex = 21
        Me.CmdShowSummery.Text = "Show Summery"
        Me.CmdShowSummery.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1045, 452)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1037, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Item"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BrandComboBox)
        Me.GroupBox2.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox2.Controls.Add(Me.SubCategoryCheckBox)
        Me.GroupBox2.Controls.Add(Me.SubCategoryComboBox)
        Me.GroupBox2.Controls.Add(Me.CategoryCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(880, 45)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1037, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sub Store Wise Issue"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(4, 44)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1029, 377)
        Me.CrystalReportViewer2.TabIndex = 21
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'PrintingMediaTableAdapter
        '
        Me.PrintingMediaTableAdapter.ClearBeforeFill = True
        '
        'frmChemicalListReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 452)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmChemicalListReport"
        Me.Text = "Material Item List"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoryDataSet As KSoft_Inventory.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryDataSet As KSoft_Inventory.SubCategoryDataSet
    Friend WithEvents SubCategoryTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents CategoryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SubCategoryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BrandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BrandDataSet As KSoft_Inventory.BrandDataSet
    Friend WithEvents BrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandTableAdapter As KSoft_Inventory.BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SubStoreWiseShow As System.Windows.Forms.Button
    Friend WithEvents SubStoreWiseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PrintingMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediaDataSet As KSoft_Inventory.MediaDataSet
    Friend WithEvents PrintingMediaTableAdapter As KSoft_Inventory.MediaDataSetTableAdapters.PrintingMediaTableAdapter
    Friend WithEvents CmdShowSummery As System.Windows.Forms.Button
End Class
