<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishFabricReceiveIssueReport
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
        Me.components = New System.ComponentModel.Container
        Me.GMTRadioButton = New System.Windows.Forms.RadioButton
        Me.DyeingRadioButton = New System.Windows.Forms.RadioButton
        Me.CloseProgramButton = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ShowByPrgButton = New System.Windows.Forms.Button
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
        Me.ShowMoreDetailsButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SampleRadioButton = New System.Windows.Forms.RadioButton
        Me.BulkRadioButton = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ExMonthAndYearTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExMonthAndYearDataSet = New KSoft_Inventory.ExMonthAndYearDataSet
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colExMonth = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExYear = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExMonthAndYear = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ExMonthAndYearTableAdapter = New KSoft_Inventory.ExMonthAndYearDataSetTableAdapters.ExMonthAndYearTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RunningProgramButton = New System.Windows.Forms.Button
        Me.AllProgramButton = New System.Windows.Forms.Button
        Me.MultipleProgramTextBox2 = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ShowCompactButton = New System.Windows.Forms.Button
        Me.ShowCompact2Button = New System.Windows.Forms.Button
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExMonthAndYearTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExMonthAndYearDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GMTRadioButton
        '
        Me.GMTRadioButton.AutoSize = True
        Me.GMTRadioButton.Location = New System.Drawing.Point(24, 38)
        Me.GMTRadioButton.Name = "GMTRadioButton"
        Me.GMTRadioButton.Size = New System.Drawing.Size(128, 17)
        Me.GMTRadioButton.TabIndex = 0
        Me.GMTRadioButton.Text = "Garments Finish Store"
        Me.GMTRadioButton.UseVisualStyleBackColor = True
        '
        'DyeingRadioButton
        '
        Me.DyeingRadioButton.AutoSize = True
        Me.DyeingRadioButton.Checked = True
        Me.DyeingRadioButton.Location = New System.Drawing.Point(24, 18)
        Me.DyeingRadioButton.Name = "DyeingRadioButton"
        Me.DyeingRadioButton.Size = New System.Drawing.Size(116, 17)
        Me.DyeingRadioButton.TabIndex = 1
        Me.DyeingRadioButton.TabStop = True
        Me.DyeingRadioButton.Text = "Dyeing Finish Store"
        Me.DyeingRadioButton.UseVisualStyleBackColor = True
        '
        'CloseProgramButton
        '
        Me.CloseProgramButton.Location = New System.Drawing.Point(266, 12)
        Me.CloseProgramButton.Name = "CloseProgramButton"
        Me.CloseProgramButton.Size = New System.Drawing.Size(69, 65)
        Me.CloseProgramButton.TabIndex = 2
        Me.CloseProgramButton.Text = "&Close Program"
        Me.CloseProgramButton.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
         Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 86)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1115, 402)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(495, 51)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(115, 20)
        Me.GridLookUpEdit1.TabIndex = 19
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'ShowByPrgButton
        '
        Me.ShowByPrgButton.Location = New System.Drawing.Point(766, 14)
        Me.ShowByPrgButton.Name = "ShowByPrgButton"
        Me.ShowByPrgButton.Size = New System.Drawing.Size(91, 28)
        Me.ShowByPrgButton.TabIndex = 20
        Me.ShowByPrgButton.Text = "&Show  Summery"
        Me.ShowByPrgButton.UseVisualStyleBackColor = True
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowMoreDetailsButton
        '
        Me.ShowMoreDetailsButton.Location = New System.Drawing.Point(766, 48)
        Me.ShowMoreDetailsButton.Name = "ShowMoreDetailsButton"
        Me.ShowMoreDetailsButton.Size = New System.Drawing.Size(91, 29)
        Me.ShowMoreDetailsButton.TabIndex = 21
        Me.ShowMoreDetailsButton.Text = "&Show Details"
        Me.ShowMoreDetailsButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DyeingRadioButton)
        Me.GroupBox1.Controls.Add(Me.GMTRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 69)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Store"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SampleRadioButton)
        Me.GroupBox2.Controls.Add(Me.BulkRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(174, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(86, 69)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulk/Sample"
        '
        'SampleRadioButton
        '
        Me.SampleRadioButton.AutoSize = True
        Me.SampleRadioButton.Location = New System.Drawing.Point(15, 42)
        Me.SampleRadioButton.Name = "SampleRadioButton"
        Me.SampleRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SampleRadioButton.TabIndex = 1
        Me.SampleRadioButton.TabStop = True
        Me.SampleRadioButton.Text = "Sample"
        Me.SampleRadioButton.UseVisualStyleBackColor = True
        '
        'BulkRadioButton
        '
        Me.BulkRadioButton.AutoSize = True
        Me.BulkRadioButton.Checked = True
        Me.BulkRadioButton.Location = New System.Drawing.Point(15, 17)
        Me.BulkRadioButton.Name = "BulkRadioButton"
        Me.BulkRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.BulkRadioButton.TabIndex = 0
        Me.BulkRadioButton.TabStop = True
        Me.BulkRadioButton.Text = "Bulk"
        Me.BulkRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Filter by Program No"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(973, 34)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.ExMonthAndYearTableBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "ExMonthAndYear"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.ValueMember = "ExMonthAndYear"
        Me.GridLookUpEdit2.Properties.View = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(132, 20)
        Me.GridLookUpEdit2.TabIndex = 25
        '
        'ExMonthAndYearTableBindingSource
        '
        Me.ExMonthAndYearTableBindingSource.DataMember = "ExMonthAndYearTable"
        Me.ExMonthAndYearTableBindingSource.DataSource = Me.ExMonthAndYearDataSet
        '
        'ExMonthAndYearDataSet
        '
        Me.ExMonthAndYearDataSet.DataSetName = "ExMonthAndYearDataSet"
        Me.ExMonthAndYearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExMonth, Me.colExYear, Me.colExMonthAndYear})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colExMonth
        '
        Me.colExMonth.FieldName = "ExMonth"
        Me.colExMonth.Name = "colExMonth"
        '
        'colExYear
        '
        Me.colExYear.FieldName = "ExYear"
        Me.colExYear.Name = "colExYear"
        '
        'colExMonthAndYear
        '
        Me.colExMonthAndYear.FieldName = "ExMonthAndYear"
        Me.colExMonthAndYear.Name = "colExMonthAndYear"
        Me.colExMonthAndYear.OptionsColumn.ReadOnly = True
        Me.colExMonthAndYear.Visible = True
        Me.colExMonthAndYear.VisibleIndex = 0
        '
        'ExMonthAndYearTableAdapter
        '
        Me.ExMonthAndYearTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(971, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Ex Month wise filter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(973, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Full"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1020, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Rcvd Bal >2%"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(959, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(3, 69)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'RunningProgramButton
        '
        Me.RunningProgramButton.Location = New System.Drawing.Point(341, 13)
        Me.RunningProgramButton.Name = "RunningProgramButton"
        Me.RunningProgramButton.Size = New System.Drawing.Size(57, 65)
        Me.RunningProgramButton.TabIndex = 30
        Me.RunningProgramButton.Text = "&Running Program"
        Me.RunningProgramButton.UseVisualStyleBackColor = True
        '
        'AllProgramButton
        '
        Me.AllProgramButton.Location = New System.Drawing.Point(434, 91)
        Me.AllProgramButton.Name = "AllProgramButton"
        Me.AllProgramButton.Size = New System.Drawing.Size(57, 65)
        Me.AllProgramButton.TabIndex = 31
        Me.AllProgramButton.Text = "&All Program"
        Me.AllProgramButton.UseVisualStyleBackColor = True
        '
        'MultipleProgramTextBox2
        '
        Me.MultipleProgramTextBox2.Location = New System.Drawing.Point(640, 14)
        Me.MultipleProgramTextBox2.Multiline = True
        Me.MultipleProgramTextBox2.Name = "MultipleProgramTextBox2"
        Me.MultipleProgramTextBox2.Size = New System.Drawing.Size(119, 63)
        Me.MultipleProgramTextBox2.TabIndex = 53
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(615, 54)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(19, 13)
        Me.LinkLabel1.TabIndex = 54
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>"
        '
        'ShowCompactButton
        '
        Me.ShowCompactButton.Location = New System.Drawing.Point(862, 15)
        Me.ShowCompactButton.Name = "ShowCompactButton"
        Me.ShowCompactButton.Size = New System.Drawing.Size(68, 63)
        Me.ShowCompactButton.TabIndex = 55
        Me.ShowCompactButton.Text = "&Show Compact"
        Me.ShowCompactButton.UseVisualStyleBackColor = True
        '
        'ShowCompact2Button
        '
        Me.ShowCompact2Button.Location = New System.Drawing.Point(404, 13)
        Me.ShowCompact2Button.Name = "ShowCompact2Button"
        Me.ShowCompact2Button.Size = New System.Drawing.Size(68, 63)
        Me.ShowCompact2Button.TabIndex = 55
        Me.ShowCompact2Button.Text = "&Show Compact"
        Me.ShowCompact2Button.UseVisualStyleBackColor = True
        '
        'frmFinishFabricReceiveIssueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 489)
        Me.Controls.Add(Me.ShowCompact2Button)
        Me.Controls.Add(Me.ShowCompactButton)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MultipleProgramTextBox2)
        Me.Controls.Add(Me.RunningProgramButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShowMoreDetailsButton)
        Me.Controls.Add(Me.ShowByPrgButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.CloseProgramButton)
        Me.Controls.Add(Me.AllProgramButton)
        Me.Name = "frmFinishFabricReceiveIssueReport"
        Me.Text = "Finish Fabric Receive Issue Report"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExMonthAndYearTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExMonthAndYearDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GMTRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DyeingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CloseProgramButton As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByPrgButton As System.Windows.Forms.Button
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents ShowMoreDetailsButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SampleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BulkRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExMonthAndYearDataSet As KSoft_Inventory.ExMonthAndYearDataSet
    Friend WithEvents ExMonthAndYearTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExMonthAndYearTableAdapter As KSoft_Inventory.ExMonthAndYearDataSetTableAdapters.ExMonthAndYearTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colExMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExMonthAndYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RunningProgramButton As System.Windows.Forms.Button
    Friend WithEvents AllProgramButton As System.Windows.Forms.Button
    Friend WithEvents MultipleProgramTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ShowCompactButton As System.Windows.Forms.Button
    Friend WithEvents ShowCompact2Button As System.Windows.Forms.Button
End Class
