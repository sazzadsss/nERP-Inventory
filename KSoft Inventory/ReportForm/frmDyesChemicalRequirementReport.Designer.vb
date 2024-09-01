<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDyesChemicalRequirementReport
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToMonthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.bgrLongProcess = New System.ComponentModel.BackgroundWorker()
        Me.btnStartProcess = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.GeneratingLabel = New System.Windows.Forms.Label()
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Last Month"
        '
        'ToMonthDateTimePicker
        '
        Me.ToMonthDateTimePicker.CustomFormat = "MMMM"
        Me.ToMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToMonthDateTimePicker.Location = New System.Drawing.Point(128, 17)
        Me.ToMonthDateTimePicker.Name = "ToMonthDateTimePicker"
        Me.ToMonthDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.ToMonthDateTimePicker.TabIndex = 9
        '
        'bgrLongProcess
        '
        '
        'btnStartProcess
        '
        Me.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartProcess.Location = New System.Drawing.Point(438, 15)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(83, 24)
        Me.btnStartProcess.TabIndex = 23
        Me.btnStartProcess.Text = "&Show"
        Me.btnStartProcess.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 46)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1094, 469)
        Me.CrystalReportViewer1.TabIndex = 24
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(241, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(303, 16)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(116, 21)
        Me.CategoryComboBox.TabIndex = 25
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
        'GeneratingLabel
        '
        Me.GeneratingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneratingLabel.BackColor = System.Drawing.Color.Transparent
        Me.GeneratingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratingLabel.ForeColor = System.Drawing.Color.Red
        Me.GeneratingLabel.Location = New System.Drawing.Point(881, 15)
        Me.GeneratingLabel.Name = "GeneratingLabel"
        Me.GeneratingLabel.Size = New System.Drawing.Size(199, 19)
        Me.GeneratingLabel.TabIndex = 28
        Me.GeneratingLabel.Text = "."
        Me.GeneratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'frmDyesChemicalRequirementReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 515)
        Me.Controls.Add(Me.GeneratingLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnStartProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToMonthDateTimePicker)
        Me.Name = "frmDyesChemicalRequirementReport"
        Me.Text = "Dyes Chemical Requirement Report Print"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToMonthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents bgrLongProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStartProcess As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GeneratingLabel As System.Windows.Forms.Label
    Friend WithEvents CategoryDataSet As KSoft_Inventory.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
End Class
