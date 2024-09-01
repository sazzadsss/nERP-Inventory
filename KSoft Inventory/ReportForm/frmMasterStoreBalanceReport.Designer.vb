<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasterStoreBalanceReport
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
        Me.btnStartProcessbyvalue = New System.Windows.Forms.Button()
        Me.Template2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Template1RadioButton = New System.Windows.Forms.RadioButton()
        Me.btnStartProcess = New System.Windows.Forms.Button()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet()
        Me.GeneratingLabel = New System.Windows.Forms.Label()
        Me.CmdByQTYAndValue = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartProcessbyvalue
        '
        Me.btnStartProcessbyvalue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartProcessbyvalue.Location = New System.Drawing.Point(1050, 17)
        Me.btnStartProcessbyvalue.Name = "btnStartProcessbyvalue"
        Me.btnStartProcessbyvalue.Size = New System.Drawing.Size(99, 41)
        Me.btnStartProcessbyvalue.TabIndex = 40
        Me.btnStartProcessbyvalue.Text = "Show All By Value"
        Me.btnStartProcessbyvalue.UseVisualStyleBackColor = True
        '
        'Template2RadioButton
        '
        Me.Template2RadioButton.AutoSize = True
        Me.Template2RadioButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Template2RadioButton.Location = New System.Drawing.Point(383, 36)
        Me.Template2RadioButton.Name = "Template2RadioButton"
        Me.Template2RadioButton.Size = New System.Drawing.Size(106, 19)
        Me.Template2RadioButton.TabIndex = 39
        Me.Template2RadioButton.Text = "With Sub Store"
        Me.Template2RadioButton.UseVisualStyleBackColor = True
        '
        'Template1RadioButton
        '
        Me.Template1RadioButton.AutoSize = True
        Me.Template1RadioButton.Checked = True
        Me.Template1RadioButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Template1RadioButton.Location = New System.Drawing.Point(383, 15)
        Me.Template1RadioButton.Name = "Template1RadioButton"
        Me.Template1RadioButton.Size = New System.Drawing.Size(123, 19)
        Me.Template1RadioButton.TabIndex = 38
        Me.Template1RadioButton.TabStop = True
        Me.Template1RadioButton.Text = "Without Sub Store"
        Me.Template1RadioButton.UseVisualStyleBackColor = True
        '
        'btnStartProcess
        '
        Me.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartProcess.Location = New System.Drawing.Point(860, 17)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(92, 41)
        Me.btnStartProcess.TabIndex = 37
        Me.btnStartProcess.Text = "Show All By QTY"
        Me.btnStartProcess.UseVisualStyleBackColor = True
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(84, 35)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(117, 21)
        Me.DepartmentComboBox.TabIndex = 36
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(207, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "To Date "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(207, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "From Date "
        '
        'ToDateDateTimePicker
        '
        Me.ToDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateDateTimePicker.Location = New System.Drawing.Point(288, 38)
        Me.ToDateDateTimePicker.Name = "ToDateDateTimePicker"
        Me.ToDateDateTimePicker.Size = New System.Drawing.Size(77, 20)
        Me.ToDateDateTimePicker.TabIndex = 32
        '
        'FromDateDateTimePicker
        '
        Me.FromDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateDateTimePicker.Location = New System.Drawing.Point(288, 14)
        Me.FromDateDateTimePicker.Name = "FromDateDateTimePicker"
        Me.FromDateDateTimePicker.Size = New System.Drawing.Size(74, 20)
        Me.FromDateDateTimePicker.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnStartProcess)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.GeneratingLabel)
        Me.GroupBox1.Controls.Add(Me.CmdByQTYAndValue)
        Me.GroupBox1.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox1.Controls.Add(Me.btnStartProcessbyvalue)
        Me.GroupBox1.Controls.Add(Me.FromDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Template2RadioButton)
        Me.GroupBox1.Controls.Add(Me.ToDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Template1RadioButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 64)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(958, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 41)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Show By Value"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(770, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 41)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Show By QTY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Company"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CompanyBindingSource
        Me.ComboBox1.DisplayMember = "CompanyCode"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox1.TabIndex = 43
        Me.ComboBox1.ValueMember = "CompanyId"
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneratingLabel
        '
        Me.GeneratingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneratingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratingLabel.ForeColor = System.Drawing.Color.Red
        Me.GeneratingLabel.Location = New System.Drawing.Point(524, 36)
        Me.GeneratingLabel.Name = "GeneratingLabel"
        Me.GeneratingLabel.Size = New System.Drawing.Size(240, 19)
        Me.GeneratingLabel.TabIndex = 42
        Me.GeneratingLabel.Text = "----"
        Me.GeneratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdByQTYAndValue
        '
        Me.CmdByQTYAndValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdByQTYAndValue.Location = New System.Drawing.Point(1155, 17)
        Me.CmdByQTYAndValue.Name = "CmdByQTYAndValue"
        Me.CmdByQTYAndValue.Size = New System.Drawing.Size(99, 41)
        Me.CmdByQTYAndValue.TabIndex = 41
        Me.CmdByQTYAndValue.Text = "Show By QTY And Value"
        Me.CmdByQTYAndValue.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(4, 69)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1260, 579)
        Me.CrystalReportViewer1.TabIndex = 42
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'frmMasterStoreBalanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 652)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMasterStoreBalanceReport"
        Me.Text = "Master Store Balance [2]"
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartProcessbyvalue As System.Windows.Forms.Button
    Friend WithEvents Template2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Template1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents btnStartProcess As System.Windows.Forms.Button
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdByQTYAndValue As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents GeneratingLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
