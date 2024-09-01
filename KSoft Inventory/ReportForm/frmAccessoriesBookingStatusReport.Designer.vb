<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesBookingStatusReport
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShowAllButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BookingProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Inventory.BookingDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.SubCatGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubCategoryDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SubCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryLookupTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter()
        Me.SubCategoryTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter()
        Me.GridLookUpEdit3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.BookingProgramNoLookupTableAdapter = New KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Inventory.OrderLookupDataSet()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrderLookupTableAdapter = New KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.AWSNoShowButton = New System.Windows.Forms.Button()
        Me.PGNoShowButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AWSNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AWSProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWSLookupDataSet = New KSoft_Inventory.AWSLookupDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramSearchGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AccBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMLookUpDataSet = New KSoft_Inventory.AccBOMLookUpDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccBookingLookupTableAdapter = New KSoft_Inventory.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter()
        Me.AWSProgramLookupTableAdapter = New KSoft_Inventory.AWSLookupDataSetTableAdapters.AWSProgramLookupTableAdapter()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 100)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1140, 397)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(231, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 21)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowAllButton
        '
        Me.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAllButton.Location = New System.Drawing.Point(682, 16)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 21)
        Me.ShowAllButton.TabIndex = 8
        Me.ShowAllButton.Text = "Show All"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        Me.ShowAllButton.Visible = False
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = ""
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(69, 18)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.BookingProgramNoLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[AWS :: Program :: Style ]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "BookingId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 9
        '
        'BookingProgramNoLookupBindingSource
        '
        Me.BookingProgramNoLookupBindingSource.DataMember = "BookingProgramNoLookup"
        Me.BookingProgramNoLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(909, 17)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerCode"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = "[Buyer]"
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Properties.View = Me.GridView1
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 10
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.colBuyerCode, Me.colBuyerName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1055, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SubCatGridLookUpEdit
        '
        Me.SubCatGridLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubCatGridLookUpEdit.Location = New System.Drawing.Point(909, 43)
        Me.SubCatGridLookUpEdit.Name = "SubCatGridLookUpEdit"
        Me.SubCatGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubCatGridLookUpEdit.Properties.DataSource = Me.SubCategoryBindingSource
        Me.SubCatGridLookUpEdit.Properties.DisplayMember = "SubCategoryName"
        Me.SubCatGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SubCatGridLookUpEdit.Properties.NullText = "[Sub Category]"
        Me.SubCatGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SubCatGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SubCatGridLookUpEdit.Properties.ValueMember = "SubCategoryId"
        Me.SubCatGridLookUpEdit.Properties.View = Me.GridView2
        Me.SubCatGridLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.SubCatGridLookUpEdit.TabIndex = 11
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubCategoryId, Me.colSubCategoryName, Me.colSubCategoryDescription, Me.colCategoryId, Me.colDepartmentId1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSubCategoryId
        '
        Me.colSubCategoryId.FieldName = "SubCategoryId"
        Me.colSubCategoryId.Name = "colSubCategoryId"
        Me.colSubCategoryId.OptionsColumn.ReadOnly = True
        '
        'colSubCategoryName
        '
        Me.colSubCategoryName.FieldName = "SubCategoryName"
        Me.colSubCategoryName.Name = "colSubCategoryName"
        Me.colSubCategoryName.Visible = True
        Me.colSubCategoryName.VisibleIndex = 0
        '
        'colSubCategoryDescription
        '
        Me.colSubCategoryDescription.FieldName = "SubCategoryDescription"
        Me.colSubCategoryDescription.Name = "colSubCategoryDescription"
        '
        'colCategoryId
        '
        Me.colCategoryId.FieldName = "CategoryId"
        Me.colCategoryId.Name = "colCategoryId"
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'SubCategoryLookupBindingSource
        '
        Me.SubCategoryLookupBindingSource.DataMember = "SubCategoryLookup"
        Me.SubCategoryLookupBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryLookupTableAdapter
        '
        Me.SubCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit3
        '
        Me.GridLookUpEdit3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLookUpEdit3.Location = New System.Drawing.Point(763, 17)
        Me.GridLookUpEdit3.Name = "GridLookUpEdit3"
        Me.GridLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit3.Properties.DataSource = Me.DepartmentBindingSource
        Me.GridLookUpEdit3.Properties.DisplayMember = "DepartmentName"
        Me.GridLookUpEdit3.Properties.ImmediatePopup = True
        Me.GridLookUpEdit3.Properties.NullText = "[Department]"
        Me.GridLookUpEdit3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit3.Properties.ValueMember = "DepartmentId"
        Me.GridLookUpEdit3.Properties.View = Me.GridView3
        Me.GridLookUpEdit3.Size = New System.Drawing.Size(140, 20)
        Me.GridLookUpEdit3.TabIndex = 12
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
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentId2, Me.colDepartmentName, Me.colDepartmentDescription, Me.colEmailAddress})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentId2
        '
        Me.colDepartmentId2.FieldName = "DepartmentId"
        Me.colDepartmentId2.Name = "colDepartmentId2"
        Me.colDepartmentId2.OptionsColumn.ReadOnly = True
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'colDepartmentDescription
        '
        Me.colDepartmentDescription.FieldName = "DepartmentDescription"
        Me.colDepartmentDescription.Name = "colDepartmentDescription"
        '
        'colEmailAddress
        '
        Me.colEmailAddress.FieldName = "EmailAddress"
        Me.colEmailAddress.Name = "colEmailAddress"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'BookingProgramNoLookupTableAdapter
        '
        Me.BookingProgramNoLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(231, 45)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(79, 23)
        Me.ShowButton.TabIndex = 110
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Program No"
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(69, 47)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "PrgAndStyle"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Properties.View = Me.FinishFabricBookingIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 108
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingIdGridLookUpEditView
        '
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "AWS No :"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'AWSNoShowButton
        '
        Me.AWSNoShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AWSNoShowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWSNoShowButton.Location = New System.Drawing.Point(239, 18)
        Me.AWSNoShowButton.Name = "AWSNoShowButton"
        Me.AWSNoShowButton.Size = New System.Drawing.Size(74, 21)
        Me.AWSNoShowButton.TabIndex = 112
        Me.AWSNoShowButton.Text = "Show"
        Me.AWSNoShowButton.UseVisualStyleBackColor = True
        '
        'PGNoShowButton
        '
        Me.PGNoShowButton.Location = New System.Drawing.Point(238, 45)
        Me.PGNoShowButton.Name = "PGNoShowButton"
        Me.PGNoShowButton.Size = New System.Drawing.Size(75, 23)
        Me.PGNoShowButton.TabIndex = 113
        Me.PGNoShowButton.Text = "&Show"
        Me.PGNoShowButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "AWS No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Program No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Me.ShowButton)
        Me.GroupBox1.Location = New System.Drawing.Point(331, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 80)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Old Accessories Program"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AWSNoLookUpEdit)
        Me.GroupBox2.Controls.Add(Me.ProgramSearchGridLookUpEdit)
        Me.GroupBox2.Controls.Add(Me.PGNoShowButton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.AWSNoShowButton)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 80)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Accessoreis Program"
        '
        'AWSNoLookUpEdit
        '
        Me.AWSNoLookUpEdit.EditValue = "[AWS :: Program :: Style ]"
        Me.AWSNoLookUpEdit.Location = New System.Drawing.Point(72, 18)
        Me.AWSNoLookUpEdit.Name = "AWSNoLookUpEdit"
        Me.AWSNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AWSNoLookUpEdit.Properties.DataSource = Me.AWSProgramLookupBindingSource
        Me.AWSNoLookUpEdit.Properties.DisplayMember = "Details"
        Me.AWSNoLookUpEdit.Properties.NullText = "[AWS :: Program :: Style ]"
        Me.AWSNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AWSNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AWSNoLookUpEdit.Properties.ValueMember = "AWSNo"
        Me.AWSNoLookUpEdit.Properties.View = Me.GridView4
        Me.AWSNoLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.AWSNoLookUpEdit.TabIndex = 118
        '
        'AWSProgramLookupBindingSource
        '
        Me.AWSProgramLookupBindingSource.DataMember = "AWSProgramLookup"
        Me.AWSProgramLookupBindingSource.DataSource = Me.AWSLookupDataSet
        '
        'AWSLookupDataSet
        '
        Me.AWSLookupDataSet.DataSetName = "AWSLookupDataSet"
        Me.AWSLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails2})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'ProgramSearchGridLookUpEdit
        '
        Me.ProgramSearchGridLookUpEdit.Location = New System.Drawing.Point(72, 47)
        Me.ProgramSearchGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.ProgramSearchGridLookUpEdit.Name = "ProgramSearchGridLookUpEdit"
        Me.ProgramSearchGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramSearchGridLookUpEdit.Properties.DataSource = Me.AccBookingLookupBindingSource
        Me.ProgramSearchGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramSearchGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramSearchGridLookUpEdit.Properties.NullText = ""
        Me.ProgramSearchGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramSearchGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramSearchGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramSearchGridLookUpEdit.Properties.View = Me.GridView8
        Me.ProgramSearchGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.ProgramSearchGridLookUpEdit.TabIndex = 117
        Me.ProgramSearchGridLookUpEdit.Tag = "NR"
        '
        'AccBookingLookupBindingSource
        '
        Me.AccBookingLookupBindingSource.DataMember = "AccBookingLookup"
        Me.AccBookingLookupBindingSource.DataSource = Me.AccBOMLookUpDataSet
        '
        'AccBOMLookUpDataSet
        '
        Me.AccBOMLookUpDataSet.DataSetName = "AccBOMLookUpDataSet"
        Me.AccBOMLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'AccBookingLookupTableAdapter
        '
        Me.AccBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'AWSProgramLookupTableAdapter
        '
        Me.AWSProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'frmAccessoriesBookingStatusReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridLookUpEdit3)
        Me.Controls.Add(Me.SubCatGridLookUpEdit)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowAllButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmAccessoriesBookingStatusReport"
        Me.Text = "Accessories Booking Status"
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BookingProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingDataSet As KSoft_Inventory.BookingDataSet
    Friend WithEvents BookingProgramNoLookupTableAdapter As KSoft_Inventory.BookingDataSetTableAdapters.BookingProgramNoLookupTableAdapter
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubCatGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SubCategoryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryDataSet As KSoft_Inventory.SubCategoryDataSet
    Friend WithEvents SubCategoryLookupTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents colSubCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents colDepartmentId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Inventory.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Inventory.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AWSNoShowButton As System.Windows.Forms.Button
    Friend WithEvents PGNoShowButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgramSearchGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBOMLookUpDataSet As KSoft_Inventory.AccBOMLookUpDataSet
    Friend WithEvents AccBookingLookupTableAdapter As KSoft_Inventory.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
    Friend WithEvents AWSNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AWSLookupDataSet As KSoft_Inventory.AWSLookupDataSet
    Friend WithEvents AWSProgramLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSProgramLookupTableAdapter As KSoft_Inventory.AWSLookupDataSetTableAdapters.AWSProgramLookupTableAdapter
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
