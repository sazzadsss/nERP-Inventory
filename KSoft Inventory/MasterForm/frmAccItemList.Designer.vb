<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccItemList
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
        Dim UnitIdLabel As System.Windows.Forms.Label
        Dim CurrentPriceLabel As System.Windows.Forms.Label
        Dim AccItemNameLabel As System.Windows.Forms.Label
        Dim AccBuyerIdLabel As System.Windows.Forms.Label
        Dim AccItemStyleIdLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccItemList))
        Me.ItemListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet
        Me.CurrentPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.AccItemNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ItemNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.AccItemStyleTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.AccBuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet
        Me.AccBuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CnclButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.ItemListLookupGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAccItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccItemStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UnitLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        UnitIdLabel = New System.Windows.Forms.Label
        CurrentPriceLabel = New System.Windows.Forms.Label
        AccItemNameLabel = New System.Windows.Forms.Label
        AccBuyerIdLabel = New System.Windows.Forms.Label
        AccItemStyleIdLabel = New System.Windows.Forms.Label
        ItemNameLabel = New System.Windows.Forms.Label
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemListBindingNavigator.SuspendLayout()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccItemStyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitIdLabel
        '
        UnitIdLabel.AutoSize = True
        UnitIdLabel.Location = New System.Drawing.Point(264, 70)
        UnitIdLabel.Name = "UnitIdLabel"
        UnitIdLabel.Size = New System.Drawing.Size(74, 13)
        UnitIdLabel.TabIndex = 7
        UnitIdLabel.Text = "Booking Unit :"
        '
        'CurrentPriceLabel
        '
        CurrentPriceLabel.AutoSize = True
        CurrentPriceLabel.Location = New System.Drawing.Point(470, 70)
        CurrentPriceLabel.Name = "CurrentPriceLabel"
        CurrentPriceLabel.Size = New System.Drawing.Size(71, 13)
        CurrentPriceLabel.TabIndex = 9
        CurrentPriceLabel.Text = "Current Price:"
        '
        'AccItemNameLabel
        '
        AccItemNameLabel.AutoSize = True
        AccItemNameLabel.Location = New System.Drawing.Point(23, 18)
        AccItemNameLabel.Name = "AccItemNameLabel"
        AccItemNameLabel.Size = New System.Drawing.Size(98, 13)
        AccItemNameLabel.TabIndex = 17
        AccItemNameLabel.Text = "Accessories Name:"
        '
        'AccBuyerIdLabel
        '
        AccBuyerIdLabel.AutoSize = True
        AccBuyerIdLabel.Location = New System.Drawing.Point(24, 73)
        AccBuyerIdLabel.Name = "AccBuyerIdLabel"
        AccBuyerIdLabel.Size = New System.Drawing.Size(55, 13)
        AccBuyerIdLabel.TabIndex = 19
        AccBuyerIdLabel.Text = "For Buyer:"
        '
        'AccItemStyleIdLabel
        '
        AccItemStyleIdLabel.AutoSize = True
        AccItemStyleIdLabel.Location = New System.Drawing.Point(23, 44)
        AccItemStyleIdLabel.Name = "AccItemStyleIdLabel"
        AccItemStyleIdLabel.Size = New System.Drawing.Size(95, 13)
        AccItemStyleIdLabel.TabIndex = 21
        AccItemStyleIdLabel.Text = "Accessories Spec:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New System.Drawing.Point(24, 99)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(79, 13)
        ItemNameLabel.TabIndex = 26
        ItemNameLabel.Text = "Full Acc Name:"
        '
        'ItemListBindingNavigator
        '
        Me.ItemListBindingNavigator.AddNewItem = Nothing
        Me.ItemListBindingNavigator.BindingSource = Me.ItemListBindingSource
        Me.ItemListBindingNavigator.CountItem = Nothing
        Me.ItemListBindingNavigator.DeleteItem = Nothing
        Me.ItemListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ItemListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemListBindingNavigator.MoveFirstItem = Nothing
        Me.ItemListBindingNavigator.MoveLastItem = Nothing
        Me.ItemListBindingNavigator.MoveNextItem = Nothing
        Me.ItemListBindingNavigator.MovePreviousItem = Nothing
        Me.ItemListBindingNavigator.Name = "ItemListBindingNavigator"
        Me.ItemListBindingNavigator.PositionItem = Nothing
        Me.ItemListBindingNavigator.Size = New System.Drawing.Size(856, 25)
        Me.ItemListBindingNavigator.TabIndex = 0
        Me.ItemListBindingNavigator.Text = "BindingNavigator1"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripButton1.Text = "Save to Accessories List"
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'UnitIdGridLookUpEditView
        '
        Me.UnitIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.UnitIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UnitIdGridLookUpEditView.Name = "UnitIdGridLookUpEditView"
        Me.UnitIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UnitIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 1
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 0
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(344, 67)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitName"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Properties.View = Me.UnitIdGridLookUpEditView
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(109, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 8
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrentPriceSpinEdit
        '
        Me.CurrentPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CurrentPriceSpinEdit.Location = New System.Drawing.Point(549, 67)
        Me.CurrentPriceSpinEdit.Name = "CurrentPriceSpinEdit"
        Me.CurrentPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CurrentPriceSpinEdit.Size = New System.Drawing.Size(72, 20)
        Me.CurrentPriceSpinEdit.TabIndex = 10
        '
        'AccItemNameTextEdit
        '
        Me.AccItemNameTextEdit.Location = New System.Drawing.Point(127, 15)
        Me.AccItemNameTextEdit.Name = "AccItemNameTextEdit"
        Me.AccItemNameTextEdit.Size = New System.Drawing.Size(494, 20)
        Me.AccItemNameTextEdit.TabIndex = 18
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(ItemNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ItemNameTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccItemStyleTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccBuyerIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccItemNameTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(AccItemStyleIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(UnitIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(AccBuyerIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CurrentPriceSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(CurrentPriceLabel)
        Me.SplitContainer1.Panel1.Controls.Add(AccItemNameLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.CnclButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.OKButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ItemListLookupGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(856, 470)
        Me.SplitContainer1.SplitterDistance = 132
        Me.SplitContainer1.TabIndex = 24
        '
        'ItemNameTextEdit
        '
        Me.ItemNameTextEdit.Location = New System.Drawing.Point(127, 93)
        Me.ItemNameTextEdit.Name = "ItemNameTextEdit"
        Me.ItemNameTextEdit.Size = New System.Drawing.Size(494, 20)
        Me.ItemNameTextEdit.TabIndex = 27
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(629, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(629, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AccItemStyleTextEdit
        '
        Me.AccItemStyleTextEdit.Location = New System.Drawing.Point(127, 41)
        Me.AccItemStyleTextEdit.Name = "AccItemStyleTextEdit"
        Me.AccItemStyleTextEdit.Size = New System.Drawing.Size(494, 20)
        Me.AccItemStyleTextEdit.TabIndex = 24
        '
        'AccBuyerIdGridLookUpEdit
        '
        Me.AccBuyerIdGridLookUpEdit.Location = New System.Drawing.Point(127, 67)
        Me.AccBuyerIdGridLookUpEdit.Name = "AccBuyerIdGridLookUpEdit"
        Me.AccBuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.AccBuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.AccBuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.AccBuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.AccBuyerIdGridLookUpEdit.Properties.View = Me.AccBuyerIdGridLookUpEditView
        Me.AccBuyerIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.AccBuyerIdGridLookUpEdit.TabIndex = 23
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
        'AccBuyerIdGridLookUpEditView
        '
        Me.AccBuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerCode, Me.colBuyerName})
        Me.AccBuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.AccBuyerIdGridLookUpEditView.Name = "AccBuyerIdGridLookUpEditView"
        Me.AccBuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AccBuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        'CnclButton
        '
        Me.CnclButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CnclButton.Location = New System.Drawing.Point(750, 305)
        Me.CnclButton.Name = "CnclButton"
        Me.CnclButton.Size = New System.Drawing.Size(88, 23)
        Me.CnclButton.TabIndex = 4
        Me.CnclButton.Text = "&Cancel"
        Me.CnclButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(629, 305)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(113, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ItemListLookupGridControl
        '
        Me.ItemListLookupGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemListLookupGridControl.DataSource = Me.ItemListLookupBindingSource
        Me.ItemListLookupGridControl.Location = New System.Drawing.Point(0, 3)
        Me.ItemListLookupGridControl.MainView = Me.GridView1
        Me.ItemListLookupGridControl.Name = "ItemListLookupGridControl"
        Me.ItemListLookupGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BuyerLookupGridLookUpEdit, Me.UnitLookupGridLookUpEdit})
        Me.ItemListLookupGridControl.Size = New System.Drawing.Size(853, 296)
        Me.ItemListLookupGridControl.TabIndex = 2
        Me.ItemListLookupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccItemName, Me.colAccItemStyle, Me.colAccBuyerId, Me.colUnitId, Me.colCurrentPrice, Me.colItemName})
        Me.GridView1.GridControl = Me.ItemListLookupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAccItemName
        '
        Me.colAccItemName.Caption = "Acc Name"
        Me.colAccItemName.FieldName = "AccItemName"
        Me.colAccItemName.Name = "colAccItemName"
        Me.colAccItemName.Visible = True
        Me.colAccItemName.VisibleIndex = 1
        Me.colAccItemName.Width = 210
        '
        'colAccItemStyle
        '
        Me.colAccItemStyle.Caption = "Acc Specification"
        Me.colAccItemStyle.FieldName = "AccItemStyle"
        Me.colAccItemStyle.Name = "colAccItemStyle"
        Me.colAccItemStyle.Visible = True
        Me.colAccItemStyle.VisibleIndex = 2
        Me.colAccItemStyle.Width = 236
        '
        'colAccBuyerId
        '
        Me.colAccBuyerId.Caption = "Buyer"
        Me.colAccBuyerId.ColumnEdit = Me.BuyerLookupGridLookUpEdit
        Me.colAccBuyerId.FieldName = "AccBuyerId"
        Me.colAccBuyerId.Name = "colAccBuyerId"
        Me.colAccBuyerId.Visible = True
        Me.colAccBuyerId.VisibleIndex = 3
        Me.colAccBuyerId.Width = 107
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.AutoHeight = False
        Me.BuyerLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerLookupGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.NullText = ""
        Me.BuyerLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerLookupGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 0
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookupGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Width = 55
        '
        'UnitLookupGridLookUpEdit
        '
        Me.UnitLookupGridLookUpEdit.AutoHeight = False
        Me.UnitLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookupGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookupGridLookUpEdit.DisplayMember = "UnitName"
        Me.UnitLookupGridLookUpEdit.Name = "UnitLookupGridLookUpEdit"
        Me.UnitLookupGridLookUpEdit.ValueMember = "UnitId"
        Me.UnitLookupGridLookUpEdit.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.Caption = "Max Price"
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        Me.colCurrentPrice.Width = 62
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        Me.colItemName.Width = 279
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemLeadTimeTableAdapter = Nothing
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        Me.colUnitName1.Visible = True
        Me.colUnitName1.VisibleIndex = 0
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 1
        '
        'frmAccItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 495)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ItemListBindingNavigator)
        Me.Name = "frmAccItemList"
        Me.Text = "Accessories  List"
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemListBindingNavigator.ResumeLayout(False)
        Me.ItemListBindingNavigator.PerformLayout()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccItemStyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents UnitIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CurrentPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AccItemNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AccBuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents AccBuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccItemStyleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemListLookupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccItemStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CnclButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemNameTextEdit As DevExpress.XtraEditors.TextEdit
End Class
