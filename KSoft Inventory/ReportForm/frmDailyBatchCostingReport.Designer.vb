<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyBatchCostingReport
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
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DyeingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ShowBatchButton = New System.Windows.Forms.Button()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricColorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFinishFabricBookingId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FinishFabricColorLookupTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricColorLookupTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DyeingBuyerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingBuyerDataSet = New KSoft_Inventory.DyeingBuyerDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByBuyerButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShadeDepthButton = New System.Windows.Forms.Button()
        Me.DyeingBuyerListTableAdapter = New KSoft_Inventory.DyeingBuyerDataSetTableAdapters.DyeingBuyerListTableAdapter()
        Me.BatchSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchLookupDataSet = New KSoft_Inventory.BatchLookupDataSet()
        Me.BatchSearchTableAdapter = New KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchSearchTableAdapter()
        Me.BatchLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchLookupTableAdapter = New KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricColorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingBuyerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingBuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 97)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1098, 299)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(882, 43)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.BatchLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Batch No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "BatchInformationId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(111, 20)
        Me.GridLookUpEdit1.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'DyeingDateTimePicker
        '
        Me.DyeingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.DyeingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DyeingDateTimePicker.Location = New System.Drawing.Point(111, 16)
        Me.DyeingDateTimePicker.Name = "DyeingDateTimePicker"
        Me.DyeingDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DyeingDateTimePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dyeing Date [From]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(879, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter by Batch No :"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(217, 39)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(113, 23)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ShowBatchButton
        '
        Me.ShowBatchButton.Location = New System.Drawing.Point(1029, 42)
        Me.ShowBatchButton.Name = "ShowBatchButton"
        Me.ShowBatchButton.Size = New System.Drawing.Size(57, 23)
        Me.ShowBatchButton.TabIndex = 6
        Me.ShowBatchButton.Text = "&Show"
        Me.ShowBatchButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.EditValue = ""
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(445, 16)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.ItemListBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "ItemName"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = "[Type Item Name]"
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "ItemId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(105, 20)
        Me.GridLookUpEdit2.TabIndex = 7
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.EnforceConstraints = False
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colDepartmentId})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(554, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(999, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(445, 41)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridView2
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(105, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 10
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.Caption = "Details"
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(554, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Filter by Item Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Filter by Program No :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(111, 41)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.ToDateTimePicker.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Dyeing Date [To]"
        '
        'ColorGridLookUpEdit
        '
        Me.ColorGridLookUpEdit.Location = New System.Drawing.Point(678, 41)
        Me.ColorGridLookUpEdit.Name = "ColorGridLookUpEdit"
        Me.ColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorGridLookUpEdit.Properties.DataSource = Me.FinishFabricColorLookupBindingSource
        Me.ColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.ColorGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ColorGridLookUpEdit.Properties.NullText = ""
        Me.ColorGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ColorGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ColorGridLookUpEdit.Properties.ValueMember = "FabricColorName"
        Me.ColorGridLookUpEdit.Properties.View = Me.GridView3
        Me.ColorGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.ColorGridLookUpEdit.TabIndex = 16
        '
        'FinishFabricColorLookupBindingSource
        '
        Me.FinishFabricColorLookupBindingSource.DataMember = "FinishFabricColorLookup"
        Me.FinishFabricColorLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFinishFabricBookingId1, Me.colFabricColorName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colFinishFabricBookingId1
        '
        Me.colFinishFabricBookingId1.FieldName = "FinishFabricBookingId"
        Me.colFinishFabricBookingId1.Name = "colFinishFabricBookingId1"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(604, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "And By Color :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(807, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "&Show"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FinishFabricColorLookupTableAdapter
        '
        Me.FinishFabricColorLookupTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(217, 68)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "&Finishing Costing"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(678, 17)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.DyeingBuyerListBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.View = Me.GridView4
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 21
        '
        'DyeingBuyerListBindingSource
        '
        Me.DyeingBuyerListBindingSource.DataMember = "DyeingBuyerList"
        Me.DyeingBuyerListBindingSource.DataSource = Me.DyeingBuyerDataSet
        '
        'DyeingBuyerDataSet
        '
        Me.DyeingBuyerDataSet.DataSetName = "DyeingBuyerDataSet"
        Me.DyeingBuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.Caption = "Buyer"
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'ShowByBuyerButton
        '
        Me.ShowByBuyerButton.Location = New System.Drawing.Point(807, 15)
        Me.ShowByBuyerButton.Name = "ShowByBuyerButton"
        Me.ShowByBuyerButton.Size = New System.Drawing.Size(53, 23)
        Me.ShowByBuyerButton.TabIndex = 22
        Me.ShowByBuyerButton.Text = "&Show"
        Me.ShowByBuyerButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(604, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Buyer :"
        '
        'ShadeDepthButton
        '
        Me.ShadeDepthButton.Location = New System.Drawing.Point(111, 68)
        Me.ShadeDepthButton.Name = "ShadeDepthButton"
        Me.ShadeDepthButton.Size = New System.Drawing.Size(100, 23)
        Me.ShadeDepthButton.TabIndex = 24
        Me.ShadeDepthButton.Text = "&Shade Depth"
        Me.ShadeDepthButton.UseVisualStyleBackColor = True
        '
        'DyeingBuyerListTableAdapter
        '
        Me.DyeingBuyerListTableAdapter.ClearBeforeFill = True
        '
        'BatchSearchBindingSource
        '
        Me.BatchSearchBindingSource.DataMember = "BatchSearch"
        Me.BatchSearchBindingSource.DataSource = Me.BatchLookupDataSet
        '
        'BatchLookupDataSet
        '
        Me.BatchLookupDataSet.DataSetName = "BatchLookupDataSet"
        Me.BatchLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BatchSearchTableAdapter
        '
        Me.BatchSearchTableAdapter.ClearBeforeFill = True
        '
        'BatchLookupBindingSource
        '
        Me.BatchLookupBindingSource.DataMember = "BatchLookup"
        Me.BatchLookupBindingSource.DataSource = Me.BatchLookupDataSet
        '
        'BatchLookupTableAdapter
        '
        Me.BatchLookupTableAdapter.ClearBeforeFill = True
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'frmDailyBatchCostingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 400)
        Me.Controls.Add(Me.ShadeDepthButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShowByBuyerButton)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ColorGridLookUpEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.ShowBatchButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DyeingDateTimePicker)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmDailyBatchCostingReport"
        Me.Text = "Daily Batch Costing Report"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricColorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingBuyerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingBuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DyeingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents BatchLookupDataSet As KSoft_Inventory.BatchLookupDataSet
    Friend WithEvents BatchSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchSearchTableAdapter As KSoft_Inventory.BatchLookupDataSetTableAdapters.BatchSearchTableAdapter
    Friend WithEvents ShowBatchButton As System.Windows.Forms.Button
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents FinishFabricColorLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricColorLookupTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricColorLookupTableAdapter
    Friend WithEvents colFinishFabricBookingId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowByBuyerButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShadeDepthButton As System.Windows.Forms.Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DyeingBuyerDataSet As DyeingBuyerDataSet
    Friend WithEvents DyeingBuyerListBindingSource As BindingSource
    Friend WithEvents DyeingBuyerListTableAdapter As DyeingBuyerDataSetTableAdapters.DyeingBuyerListTableAdapter
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BatchLookupBindingSource As BindingSource
    Friend WithEvents BatchLookupTableAdapter As BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
