<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequisitionFloorPrint
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
        Dim Label4 As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RequisitionFloorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorLookupDataSet = New KSoft_Inventory.RequisitionFloorLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequistionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RequisitionFloorLookupTableAdapter = New KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.RequisitionDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RequisitionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ItemDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentLookupDataSet = New KSoft_Inventory.DepartmentLookupDataSet()
        Me.ItemDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentLookupDataSetTableAdapters.DepartmentTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ByItemLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(471, 37)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(155, 13)
        Label4.TabIndex = 31
        Label4.Text = " Department / Requisiton From:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 66)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1309, 500)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(385, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 56)
        Me.PrintButton.TabIndex = 25
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(10, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Floor Requisition No :"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(121, 36)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.RequisitionFloorLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequisitionNo"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.ValueMember = "RequistionFloorId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView3
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(176, 20)
        Me.GridLookUpEdit1.TabIndex = 23
        '
        'RequisitionFloorLookupBindingSource
        '
        Me.RequisitionFloorLookupBindingSource.DataMember = "RequisitionFloorLookup"
        Me.RequisitionFloorLookupBindingSource.DataSource = Me.RequisitionFloorLookupDataSet
        '
        'RequisitionFloorLookupDataSet
        '
        Me.RequisitionFloorLookupDataSet.DataSetName = "RequisitionFloorLookupDataSet"
        Me.RequisitionFloorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionNo, Me.colRequistionDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.Name = "colRequisitionNo"
        Me.colRequisitionNo.Visible = True
        Me.colRequisitionNo.VisibleIndex = 0
        '
        'colRequistionDate
        '
        Me.colRequistionDate.FieldName = "RequistionDate"
        Me.colRequistionDate.Name = "colRequistionDate"
        Me.colRequistionDate.Visible = True
        Me.colRequistionDate.VisibleIndex = 1
        '
        'RequisitionFloorLookupTableAdapter
        '
        Me.RequisitionFloorLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(303, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 56)
        Me.ShowButton.TabIndex = 26
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'RequisitionDateTimePicker2
        '
        Me.RequisitionDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker2.Location = New System.Drawing.Point(760, 9)
        Me.RequisitionDateTimePicker2.Name = "RequisitionDateTimePicker2"
        Me.RequisitionDateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(734, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Requisition Date From :"
        '
        'RequisitionDateTimePicker
        '
        Me.RequisitionDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.RequisitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RequisitionDateTimePicker.Location = New System.Drawing.Point(632, 9)
        Me.RequisitionDateTimePicker.Name = "RequisitionDateTimePicker"
        Me.RequisitionDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.RequisitionDateTimePicker.TabIndex = 27
        '
        'ItemDepartmentIdGridLookUpEdit
        '
        Me.ItemDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(632, 37)
        Me.ItemDepartmentIdGridLookUpEdit.Name = "ItemDepartmentIdGridLookUpEdit"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemDepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.View = Me.ItemDepartmentIdGridLookUpEditView
        Me.ItemDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(224, 20)
        Me.ItemDepartmentIdGridLookUpEdit.TabIndex = 32
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentLookupDataSet
        '
        'DepartmentLookupDataSet
        '
        Me.DepartmentLookupDataSet.DataSetName = "DepartmentLookupDataSet"
        Me.DepartmentLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(862, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(862, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(943, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Details"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(943, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Details"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Department:"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(121, 10)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.DepartmentBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "DepartmentName"
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.ValueMember = "DepartmentId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(176, 20)
        Me.GridLookUpEdit2.TabIndex = 37
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "DepartmentName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1024, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "By Item Name:"
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.Location = New System.Drawing.Point(1024, 23)
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Properties.NullText = ""
        Me.ItemLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemLookupGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemLookupGridLookUpEdit.Properties.View = Me.GridView2
        Me.ItemLookupGridLookUpEdit.Size = New System.Drawing.Size(273, 20)
        Me.ItemLookupGridLookUpEdit.TabIndex = 41
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.GridColumn2, Me.GridColumn3})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
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
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "DepartmentId"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ID-Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'ByItemLinkLabel
        '
        Me.ByItemLinkLabel.AutoSize = True
        Me.ByItemLinkLabel.Location = New System.Drawing.Point(1157, 47)
        Me.ByItemLinkLabel.Name = "ByItemLinkLabel"
        Me.ByItemLinkLabel.Size = New System.Drawing.Size(140, 13)
        Me.ByItemLinkLabel.TabIndex = 39
        Me.ByItemLinkLabel.TabStop = True
        Me.ByItemLinkLabel.Text = "By Item Status From Starting"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1024, 47)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(126, 13)
        Me.LinkLabel1.TabIndex = 42
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "By Item Status With Date"
        '
        'frmRequisitionFloorPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 566)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ItemLookupGridLookUpEdit)
        Me.Controls.Add(Me.ByItemLinkLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ItemDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.RequisitionDateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RequisitionDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmRequisitionFloorPrint"
        Me.Text = "Floor Requisition Print"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionFloorLookupDataSet As RequisitionFloorLookupDataSet
    Friend WithEvents RequisitionFloorLookupBindingSource As BindingSource
    Friend WithEvents RequisitionFloorLookupTableAdapter As RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookUpTableAdapter
    Friend WithEvents ShowButton As Button
    Friend WithEvents colRequistionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents RequisitionDateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RequisitionDateTimePicker As DateTimePicker
    Friend WithEvents ItemDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentLookupDataSet As DepartmentLookupDataSet
    Friend WithEvents DepartmentTableAdapter As DepartmentLookupDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents ItemListDataSet As ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemListLookupBindingSource As BindingSource
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ByItemLinkLabel As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
