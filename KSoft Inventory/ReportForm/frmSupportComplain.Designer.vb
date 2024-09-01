<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupportComplain
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
        Dim Label1 As System.Windows.Forms.Label
        Me.MaintenanceComplainDataSet = New KSoft_Inventory.MaintenanceComplainDataSet()
        Me.MaintenanceComplainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenanceComplainTableAdapter = New KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.MaintenanceComplainTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.TableAdapterManager()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItemDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.MaintenanceComplainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceComplainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaintenanceComplainDataSet
        '
        Me.MaintenanceComplainDataSet.DataSetName = "MaintenanceComplainDataSet"
        Me.MaintenanceComplainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaintenanceComplainBindingSource
        '
        Me.MaintenanceComplainBindingSource.DataMember = "MaintenanceComplain"
        Me.MaintenanceComplainBindingSource.DataSource = Me.MaintenanceComplainDataSet
        '
        'MaintenanceComplainTableAdapter
        '
        Me.MaintenanceComplainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MaintenanceComplainTableAdapter = Me.MaintenanceComplainTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 34)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1041, 333)
        Me.CrystalReportViewer1.TabIndex = 4
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(392, 5)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(100, 22)
        Me.ShowButton.TabIndex = 88
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(262, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "To : "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(295, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker2.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 15)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Support-Complain Date    From :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(168, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 84
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(502, 4)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 90
        Label1.Text = "Department :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(807, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
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
        'ItemDepartmentIdGridLookUpEdit
        '
        Me.ItemDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(577, 3)
        Me.ItemDepartmentIdGridLookUpEdit.Name = "ItemDepartmentIdGridLookUpEdit"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemDepartmentIdGridLookUpEdit.Properties.PopupView = Me.ItemDepartmentIdGridLookUpEditView
        Me.ItemDepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.ItemDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(224, 20)
        Me.ItemDepartmentIdGridLookUpEdit.TabIndex = 91
        '
        'frmSupportComplain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 368)
        Me.Controls.Add(Me.ItemDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmSupportComplain"
        Me.Text = "Support Complain List"
        CType(Me.MaintenanceComplainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceComplainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaintenanceComplainDataSet As MaintenanceComplainDataSet
    Friend WithEvents MaintenanceComplainBindingSource As BindingSource
    Friend WithEvents MaintenanceComplainTableAdapter As MaintenanceComplainDataSetTableAdapters.MaintenanceComplainTableAdapter
    Friend WithEvents TableAdapterManager As MaintenanceComplainDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents ItemDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
End Class
