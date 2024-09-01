<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscDelivery
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
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.SupplierIdLabel = New System.Windows.Forms.Label()
        Me.MiscDeliveryDataSet = New KSoft_Inventory.MiscDeliveryDataSet()
        Me.MiscDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscDeliveryTableAdapter = New KSoft_Inventory.MiscDeliveryDataSetTableAdapters.MiscDeliveryTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.MiscDeliveryDataSetTableAdapters.TableAdapterManager()
        Me.MiscDeliveryDetailsTableAdapter = New KSoft_Inventory.MiscDeliveryDataSetTableAdapters.MiscDeliveryDetailsTableAdapter()
        Me.ChallanNoTextBox = New System.Windows.Forms.TextBox()
        Me.ChallanDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AttentionTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.MiscDeliveryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscDeliveryDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Inventory.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPacketQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPacketType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet()
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.UnitTableAdapter = New KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MiscChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscChallanLookupDataSet = New KSoft_Inventory.MiscChallanLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiscChallanLookupTableAdapter = New KSoft_Inventory.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New KSoft_Inventory.SupplierDataSetTableAdapters.TableAdapterManager()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Inventory.UserDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UserTableAdapter = New KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        ChallanNoLabel = New System.Windows.Forms.Label()
        ChallanDateLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.MiscDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(21, 56)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 3
        ChallanNoLabel.Text = "Challan No:"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(21, 83)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 5
        ChallanDateLabel.Text = "Challan Date:"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(334, 83)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 9
        AttentionLabel.Text = "Attention:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(21, 133)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(49, 13)
        RemarksLabel.TabIndex = 11
        RemarksLabel.Text = "Purpose:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(21, 108)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 13)
        Label2.TabIndex = 3
        Label2.Text = "Created/Modified By :"
        '
        'SupplierIdLabel
        '
        Me.SupplierIdLabel.AutoSize = True
        Me.SupplierIdLabel.Location = New System.Drawing.Point(334, 53)
        Me.SupplierIdLabel.Name = "SupplierIdLabel"
        Me.SupplierIdLabel.Size = New System.Drawing.Size(71, 13)
        Me.SupplierIdLabel.TabIndex = 7
        Me.SupplierIdLabel.Text = "Delivered To:"
        '
        'MiscDeliveryDataSet
        '
        Me.MiscDeliveryDataSet.DataSetName = "MiscDeliveryDataSet"
        Me.MiscDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiscDeliveryBindingSource
        '
        Me.MiscDeliveryBindingSource.DataMember = "MiscDelivery"
        Me.MiscDeliveryBindingSource.DataSource = Me.MiscDeliveryDataSet
        '
        'MiscDeliveryTableAdapter
        '
        Me.MiscDeliveryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MiscDeliveryDetailsTableAdapter = Me.MiscDeliveryDetailsTableAdapter
        Me.TableAdapterManager.MiscDeliveryTableAdapter = Me.MiscDeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.MiscDeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MiscDeliveryDetailsTableAdapter
        '
        Me.MiscDeliveryDetailsTableAdapter.ClearBeforeFill = True
        '
        'ChallanNoTextBox
        '
        Me.ChallanNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MiscDeliveryBindingSource, "ChallanNo", True))
        Me.ChallanNoTextBox.Location = New System.Drawing.Point(141, 53)
        Me.ChallanNoTextBox.Name = "ChallanNoTextBox"
        Me.ChallanNoTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ChallanNoTextBox.TabIndex = 4
        '
        'ChallanDateDateTimePicker
        '
        Me.ChallanDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ChallanDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MiscDeliveryBindingSource, "ChallanDate", True))
        Me.ChallanDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ChallanDateDateTimePicker.Location = New System.Drawing.Point(141, 79)
        Me.ChallanDateDateTimePicker.Name = "ChallanDateDateTimePicker"
        Me.ChallanDateDateTimePicker.Size = New System.Drawing.Size(147, 20)
        Me.ChallanDateDateTimePicker.TabIndex = 6
        '
        'AttentionTextBox
        '
        Me.AttentionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MiscDeliveryBindingSource, "Attention", True))
        Me.AttentionTextBox.Location = New System.Drawing.Point(425, 80)
        Me.AttentionTextBox.Multiline = True
        Me.AttentionTextBox.Name = "AttentionTextBox"
        Me.AttentionTextBox.Size = New System.Drawing.Size(202, 45)
        Me.AttentionTextBox.TabIndex = 10
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MiscDeliveryBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(141, 131)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(486, 20)
        Me.RemarksTextBox.TabIndex = 12
        '
        'MiscDeliveryDetailsBindingSource
        '
        Me.MiscDeliveryDetailsBindingSource.DataMember = "FK_MiscDeliveryDetails_MiscDelivery"
        Me.MiscDeliveryDetailsBindingSource.DataSource = Me.MiscDeliveryBindingSource
        '
        'MiscDeliveryDetailsGridControl
        '
        Me.MiscDeliveryDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiscDeliveryDetailsGridControl.DataSource = Me.MiscDeliveryDetailsBindingSource
        Me.MiscDeliveryDetailsGridControl.Location = New System.Drawing.Point(12, 157)
        Me.MiscDeliveryDetailsGridControl.MainView = Me.GridView1
        Me.MiscDeliveryDetailsGridControl.Name = "MiscDeliveryDetailsGridControl"
        Me.MiscDeliveryDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitLookupGridLookUpEdit, Me.RepositoryItemComboBox1})
        Me.MiscDeliveryDetailsGridControl.Size = New System.Drawing.Size(1031, 384)
        Me.MiscDeliveryDetailsGridControl.TabIndex = 13
        Me.MiscDeliveryDetailsGridControl.UseEmbeddedNavigator = True
        Me.MiscDeliveryDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescription, Me.colQTY, Me.colUnit, Me.colRemarks, Me.colPacketQty, Me.colPacketType})
        Me.GridView1.GridControl = Me.MiscDeliveryDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 436
        '
        'colQTY
        '
        Me.colQTY.FieldName = "QTY"
        Me.colQTY.Name = "colQTY"
        Me.colQTY.Visible = True
        Me.colQTY.VisibleIndex = 1
        Me.colQTY.Width = 120
        '
        'colUnit
        '
        Me.colUnit.Caption = "Unit"
        Me.colUnit.ColumnEdit = Me.UnitLookupGridLookUpEdit
        Me.colUnit.FieldName = "UnitId"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Visible = True
        Me.colUnit.VisibleIndex = 2
        Me.colUnit.Width = 85
        '
        'UnitLookupGridLookUpEdit
        '
        Me.UnitLookupGridLookUpEdit.AutoHeight = False
        Me.UnitLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookupGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookupGridLookUpEdit.DisplayMember = "UnitName"
        Me.UnitLookupGridLookUpEdit.Name = "UnitLookupGridLookUpEdit"
        Me.UnitLookupGridLookUpEdit.NullText = ""
        Me.UnitLookupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UnitLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.UnitLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitLookupGridLookUpEdit.ValueMember = "UnitId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 5
        Me.colRemarks.Width = 185
        '
        'colPacketQty
        '
        Me.colPacketQty.FieldName = "PacketQty"
        Me.colPacketQty.Name = "colPacketQty"
        Me.colPacketQty.Visible = True
        Me.colPacketQty.VisibleIndex = 3
        Me.colPacketQty.Width = 97
        '
        'colPacketType
        '
        Me.colPacketType.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colPacketType.FieldName = "PacketType"
        Me.colPacketType.Name = "colPacketType"
        Me.colPacketType.Visible = True
        Me.colPacketType.VisibleIndex = 4
        Me.colPacketType.Width = 90
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Bag/s", "Carton/s", "Packet/s"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MiscDeliveryBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(426, 52)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(201, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 14
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'ChallanNoGridLookUpEdit
        '
        Me.ChallanNoGridLookUpEdit.Location = New System.Drawing.Point(357, 3)
        Me.ChallanNoGridLookUpEdit.Name = "ChallanNoGridLookUpEdit"
        Me.ChallanNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanNoGridLookUpEdit.Properties.DataSource = Me.MiscChallanLookupBindingSource
        Me.ChallanNoGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanNoGridLookUpEdit.Properties.NullText = ""
        Me.ChallanNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ChallanNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanNoGridLookUpEdit.Properties.ValueMember = "MiscDeliveryId"
        Me.ChallanNoGridLookUpEdit.Size = New System.Drawing.Size(190, 20)
        Me.ChallanNoGridLookUpEdit.TabIndex = 15
        '
        'MiscChallanLookupBindingSource
        '
        Me.MiscChallanLookupBindingSource.DataMember = "MiscChallanLookup"
        Me.MiscChallanLookupBindingSource.DataSource = Me.MiscChallanLookupDataSet
        '
        'MiscChallanLookupDataSet
        '
        Me.MiscChallanLookupDataSet.DataSetName = "MiscChallanLookupDataSet"
        Me.MiscChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 0
        '
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 7, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Challan No :"
        '
        'MiscChallanLookupTableAdapter
        '
        Me.MiscChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(553, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 17
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Location = New System.Drawing.Point(634, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 18
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SupplierAddressTableAdapter = Nothing
        Me.TableAdapterManager1.SupplierGoupTableAdapter = Nothing
        Me.TableAdapterManager1.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager1.SupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Inventory.SupplierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChallanNoGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1043, 28)
        Me.FlowLayoutPanel1.TabIndex = 19
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 21)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(72, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 22)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(141, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 21)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(210, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 21)
        Me.CancelEntryButton.TabIndex = 3
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        Me.CancelEntryButton.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(715, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "General Gate Pass Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MiscDeliveryBindingSource, "UserId", True))
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(141, 105)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = ""
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.UserGridLookUpEdit.Properties.ReadOnly = True
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(147, 20)
        Me.UserGridLookUpEdit.TabIndex = 14
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'frmMiscDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 540)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(Me.MiscDeliveryDetailsGridControl)
        Me.Controls.Add(Label2)
        Me.Controls.Add(ChallanNoLabel)
        Me.Controls.Add(Me.ChallanNoTextBox)
        Me.Controls.Add(ChallanDateLabel)
        Me.Controls.Add(Me.ChallanDateDateTimePicker)
        Me.Controls.Add(Me.SupplierIdLabel)
        Me.Controls.Add(AttentionLabel)
        Me.Controls.Add(Me.AttentionTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Name = "frmMiscDelivery"
        Me.Text = "Miscellaneous [MISC] Delivery Challan Print"
        CType(Me.MiscDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MiscDeliveryDataSet As KSoft_Inventory.MiscDeliveryDataSet
    Friend WithEvents MiscDeliveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscDeliveryTableAdapter As KSoft_Inventory.MiscDeliveryDataSetTableAdapters.MiscDeliveryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.MiscDeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MiscDeliveryDetailsTableAdapter As KSoft_Inventory.MiscDeliveryDataSetTableAdapters.MiscDeliveryDetailsTableAdapter
    Friend WithEvents ChallanNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChallanDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AttentionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiscDeliveryDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscDeliveryDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierIdLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Inventory.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Inventory.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MiscChallanLookupDataSet As KSoft_Inventory.MiscChallanLookupDataSet
    Friend WithEvents MiscChallanLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscChallanLookupTableAdapter As KSoft_Inventory.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager1 As KSoft_Inventory.SupplierDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents colPacketQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPacketType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDataSet As UserDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
End Class
