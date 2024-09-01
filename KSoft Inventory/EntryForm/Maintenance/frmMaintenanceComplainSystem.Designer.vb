<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenanceComplainSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceComplainSystem))
        Me.MaintenanceComplainDataSet = New KSoft_Inventory.MaintenanceComplainDataSet()
        Me.MaintenanceComplainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenanceComplainTableAdapter = New KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.MaintenanceComplainTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.TableAdapterManager()
        Me.MaintenanceComplainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaintenanceComplainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.MaintenanceComplainGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComplainId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplainDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colExpectedResolvedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualResolvedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfDelay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StatusComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriorityComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfDrop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplainDrop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsiblePerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentsOnStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.RequestForLabel = New DevExpress.XtraEditors.LabelControl()
        CType(Me.MaintenanceComplainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceComplainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceComplainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaintenanceComplainBindingNavigator.SuspendLayout()
        CType(Me.MaintenanceComplainGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriorityComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MaintenanceComplainBindingNavigator
        '
        Me.MaintenanceComplainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MaintenanceComplainBindingNavigator.BackgroundImage = Global.KSoft_Inventory.My.Resources.Resources.ToolbarBackground
        Me.MaintenanceComplainBindingNavigator.BindingSource = Me.MaintenanceComplainBindingSource
        Me.MaintenanceComplainBindingNavigator.CountItem = Nothing
        Me.MaintenanceComplainBindingNavigator.DeleteItem = Nothing
        Me.MaintenanceComplainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripButton, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.MaintenanceComplainBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripLabel1, Me.ToolStripComboBox1})
        Me.MaintenanceComplainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MaintenanceComplainBindingNavigator.MoveFirstItem = Nothing
        Me.MaintenanceComplainBindingNavigator.MoveLastItem = Nothing
        Me.MaintenanceComplainBindingNavigator.MoveNextItem = Nothing
        Me.MaintenanceComplainBindingNavigator.MovePreviousItem = Nothing
        Me.MaintenanceComplainBindingNavigator.Name = "MaintenanceComplainBindingNavigator"
        Me.MaintenanceComplainBindingNavigator.PositionItem = Nothing
        Me.MaintenanceComplainBindingNavigator.Size = New System.Drawing.Size(1197, 25)
        Me.MaintenanceComplainBindingNavigator.TabIndex = 0
        Me.MaintenanceComplainBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.DeleteToolStripButton.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MaintenanceComplainBindingNavigatorSaveItem
        '
        Me.MaintenanceComplainBindingNavigatorSaveItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaintenanceComplainBindingNavigatorSaveItem.Image = CType(resources.GetObject("MaintenanceComplainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaintenanceComplainBindingNavigatorSaveItem.Name = "MaintenanceComplainBindingNavigatorSaveItem"
        Me.MaintenanceComplainBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.MaintenanceComplainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton1.Image = Global.KSoft_Inventory.My.Resources.Resources.Print
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton1.Text = "Print Preview"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripButton2.Image = Global.KSoft_Inventory.My.Resources.Resources.Print
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButton2.Text = "Report Show"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel1.Text = "Filter by Status"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"--ALL--", "Pending", "Running", "Completed"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(150, 25)
        '
        'MaintenanceComplainGridControl
        '
        Me.MaintenanceComplainGridControl.DataSource = Me.MaintenanceComplainBindingSource
        Me.MaintenanceComplainGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenanceComplainGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MaintenanceComplainGridControl.LookAndFeel.SkinName = "Money Twins"
        Me.MaintenanceComplainGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaintenanceComplainGridControl.MainView = Me.GridView1
        Me.MaintenanceComplainGridControl.Name = "MaintenanceComplainGridControl"
        Me.MaintenanceComplainGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.StatusComboBox, Me.DepartmentGridLookUpEdit, Me.PriorityComboBox, Me.RepositoryItemMemoEdit1})
        Me.MaintenanceComplainGridControl.Size = New System.Drawing.Size(1197, 406)
        Me.MaintenanceComplainGridControl.TabIndex = 1
        Me.MaintenanceComplainGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComplainId, Me.colDepartmentId, Me.colComplainDate, Me.colMachine, Me.colDescription, Me.colExpectedResolvedDate, Me.colActualResolvedDate, Me.colCauseOfDelay, Me.colStatus, Me.colPriority, Me.colComments, Me.colCauseOfDrop, Me.colComplainDrop, Me.colResponsiblePerson, Me.colLocation, Me.colCategory, Me.colCommentsOnStatus})
        Me.GridView1.GridControl = Me.MaintenanceComplainGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colComplainId
        '
        Me.colComplainId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colComplainId.AppearanceCell.Options.UseBackColor = True
        Me.colComplainId.AppearanceHeader.Options.UseTextOptions = True
        Me.colComplainId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComplainId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComplainId.FieldName = "ComplainId"
        Me.colComplainId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colComplainId.Name = "colComplainId"
        Me.colComplainId.OptionsColumn.ReadOnly = True
        Me.colComplainId.Visible = True
        Me.colComplainId.VisibleIndex = 0
        Me.colComplainId.Width = 73
        '
        'colDepartmentId
        '
        Me.colDepartmentId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDepartmentId.AppearanceCell.Options.UseBackColor = True
        Me.colDepartmentId.AppearanceHeader.Options.UseTextOptions = True
        Me.colDepartmentId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDepartmentId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDepartmentId.Caption = "Department"
        Me.colDepartmentId.ColumnEdit = Me.DepartmentGridLookUpEdit
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colDepartmentId.Name = "colDepartmentId"
        Me.colDepartmentId.OptionsColumn.AllowEdit = False
        Me.colDepartmentId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDepartmentId.Visible = True
        Me.colDepartmentId.VisibleIndex = 1
        Me.colDepartmentId.Width = 106
        '
        'DepartmentGridLookUpEdit
        '
        Me.DepartmentGridLookUpEdit.AutoHeight = False
        Me.DepartmentGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentGridLookUpEdit.DataSource = Me.DepartmentBindingSource
        Me.DepartmentGridLookUpEdit.DisplayMember = "DepartmentName"
        Me.DepartmentGridLookUpEdit.Name = "DepartmentGridLookUpEdit"
        Me.DepartmentGridLookUpEdit.NullText = ""
        Me.DepartmentGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.DepartmentGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentGridLookUpEdit.ValueMember = "DepartmentId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentId1, Me.colDepartmentName, Me.colDepartmentDescription})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        Me.colDepartmentId1.OptionsColumn.ReadOnly = True
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'colDepartmentDescription
        '
        Me.colDepartmentDescription.FieldName = "DepartmentDescription"
        Me.colDepartmentDescription.Name = "colDepartmentDescription"
        '
        'colComplainDate
        '
        Me.colComplainDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colComplainDate.AppearanceCell.Options.UseBackColor = True
        Me.colComplainDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colComplainDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComplainDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComplainDate.Caption = "Complain Date"
        Me.colComplainDate.FieldName = "ComplainDate"
        Me.colComplainDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colComplainDate.Name = "colComplainDate"
        Me.colComplainDate.Visible = True
        Me.colComplainDate.VisibleIndex = 2
        '
        'colMachine
        '
        Me.colMachine.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMachine.AppearanceCell.Options.UseBackColor = True
        Me.colMachine.AppearanceHeader.Options.UseTextOptions = True
        Me.colMachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMachine.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 5
        '
        'colDescription
        '
        Me.colDescription.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDescription.AppearanceCell.Options.UseBackColor = True
        Me.colDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDescription.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 6
        Me.colDescription.Width = 398
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colExpectedResolvedDate
        '
        Me.colExpectedResolvedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExpectedResolvedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExpectedResolvedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExpectedResolvedDate.Caption = "Expected Resolved Date"
        Me.colExpectedResolvedDate.CustomizationCaption = "Expected Resolved Date"
        Me.colExpectedResolvedDate.FieldName = "ExpectedResolvedDate"
        Me.colExpectedResolvedDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colExpectedResolvedDate.Name = "colExpectedResolvedDate"
        Me.colExpectedResolvedDate.Visible = True
        Me.colExpectedResolvedDate.VisibleIndex = 8
        Me.colExpectedResolvedDate.Width = 100
        '
        'colActualResolvedDate
        '
        Me.colActualResolvedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colActualResolvedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActualResolvedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colActualResolvedDate.FieldName = "ActualResolvedDate"
        Me.colActualResolvedDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colActualResolvedDate.Name = "colActualResolvedDate"
        Me.colActualResolvedDate.Visible = True
        Me.colActualResolvedDate.VisibleIndex = 9
        Me.colActualResolvedDate.Width = 80
        '
        'colCauseOfDelay
        '
        Me.colCauseOfDelay.AppearanceHeader.Options.UseTextOptions = True
        Me.colCauseOfDelay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCauseOfDelay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCauseOfDelay.FieldName = "CauseOfDelay"
        Me.colCauseOfDelay.Name = "colCauseOfDelay"
        Me.colCauseOfDelay.Visible = True
        Me.colCauseOfDelay.VisibleIndex = 10
        Me.colCauseOfDelay.Width = 117
        '
        'colStatus
        '
        Me.colStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStatus.Caption = "Status"
        Me.colStatus.ColumnEdit = Me.StatusComboBox
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 12
        Me.colStatus.Width = 94
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AutoHeight = False
        Me.StatusComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StatusComboBox.Items.AddRange(New Object() {"Pending", "Running", "Completed"})
        Me.StatusComboBox.Name = "StatusComboBox"
        '
        'colPriority
        '
        Me.colPriority.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPriority.AppearanceCell.Options.UseBackColor = True
        Me.colPriority.AppearanceHeader.Options.UseTextOptions = True
        Me.colPriority.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPriority.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPriority.ColumnEdit = Me.PriorityComboBox
        Me.colPriority.FieldName = "Priority"
        Me.colPriority.Name = "colPriority"
        Me.colPriority.Visible = True
        Me.colPriority.VisibleIndex = 7
        Me.colPriority.Width = 102
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.AutoHeight = False
        Me.PriorityComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PriorityComboBox.Items.AddRange(New Object() {"Regular", "Important", "High Important"})
        Me.PriorityComboBox.Name = "PriorityComboBox"
        '
        'colComments
        '
        Me.colComments.AppearanceHeader.Options.UseTextOptions = True
        Me.colComments.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComments.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 16
        Me.colComments.Width = 93
        '
        'colCauseOfDrop
        '
        Me.colCauseOfDrop.AppearanceHeader.Options.UseTextOptions = True
        Me.colCauseOfDrop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCauseOfDrop.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCauseOfDrop.FieldName = "CauseOfDrop"
        Me.colCauseOfDrop.Name = "colCauseOfDrop"
        Me.colCauseOfDrop.Visible = True
        Me.colCauseOfDrop.VisibleIndex = 15
        '
        'colComplainDrop
        '
        Me.colComplainDrop.AppearanceHeader.Options.UseTextOptions = True
        Me.colComplainDrop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComplainDrop.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComplainDrop.FieldName = "ComplainDrop"
        Me.colComplainDrop.Name = "colComplainDrop"
        Me.colComplainDrop.Visible = True
        Me.colComplainDrop.VisibleIndex = 14
        '
        'colResponsiblePerson
        '
        Me.colResponsiblePerson.AppearanceHeader.Options.UseTextOptions = True
        Me.colResponsiblePerson.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colResponsiblePerson.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colResponsiblePerson.FieldName = "ResponsiblePerson"
        Me.colResponsiblePerson.Name = "colResponsiblePerson"
        Me.colResponsiblePerson.Visible = True
        Me.colResponsiblePerson.VisibleIndex = 11
        Me.colResponsiblePerson.Width = 87
        '
        'colLocation
        '
        Me.colLocation.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLocation.AppearanceCell.Options.UseBackColor = True
        Me.colLocation.AppearanceHeader.Options.UseTextOptions = True
        Me.colLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLocation.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 3
        Me.colLocation.Width = 84
        '
        'colCategory
        '
        Me.colCategory.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCategory.AppearanceCell.Options.UseBackColor = True
        Me.colCategory.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 4
        '
        'colCommentsOnStatus
        '
        Me.colCommentsOnStatus.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCommentsOnStatus.AppearanceCell.Options.UseBackColor = True
        Me.colCommentsOnStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colCommentsOnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCommentsOnStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCommentsOnStatus.FieldName = "CommentsOnStatus"
        Me.colCommentsOnStatus.Name = "colCommentsOnStatus"
        Me.colCommentsOnStatus.Visible = True
        Me.colCommentsOnStatus.VisibleIndex = 13
        Me.colCommentsOnStatus.Width = 120
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink2})
        '
        'PrintableComponentLink2
        '
        Me.PrintableComponentLink2.Component = Me.MaintenanceComplainGridControl
        Me.PrintableComponentLink2.PrintingSystemBase = Me.PrintingSystem1
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.MaintenanceComplainGridControl
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'RequestForLabel
        '
        Me.RequestForLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequestForLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RequestForLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestForLabel.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.RequestForLabel.Appearance.Options.UseBackColor = True
        Me.RequestForLabel.Appearance.Options.UseFont = True
        Me.RequestForLabel.Appearance.Options.UseForeColor = True
        Me.RequestForLabel.Location = New System.Drawing.Point(664, 0)
        Me.RequestForLabel.Name = "RequestForLabel"
        Me.RequestForLabel.Size = New System.Drawing.Size(100, 19)
        Me.RequestForLabel.TabIndex = 2
        Me.RequestForLabel.Text = "RequesrtFor"
        '
        'frmMaintenanceComplainSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 431)
        Me.Controls.Add(Me.RequestForLabel)
        Me.Controls.Add(Me.MaintenanceComplainGridControl)
        Me.Controls.Add(Me.MaintenanceComplainBindingNavigator)
        Me.Name = "frmMaintenanceComplainSystem"
        Me.Text = "Support-Complain System"
        CType(Me.MaintenanceComplainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceComplainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceComplainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaintenanceComplainBindingNavigator.ResumeLayout(False)
        Me.MaintenanceComplainBindingNavigator.PerformLayout()
        CType(Me.MaintenanceComplainGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriorityComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaintenanceComplainDataSet As KSoft_Inventory.MaintenanceComplainDataSet
    Friend WithEvents MaintenanceComplainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaintenanceComplainTableAdapter As KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.MaintenanceComplainTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.MaintenanceComplainDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaintenanceComplainBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaintenanceComplainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaintenanceComplainGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComplainId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplainDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpectedResolvedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfDelay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StatusComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfDrop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplainDrop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsiblePerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriorityComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colCommentsOnStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequestForLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colActualResolvedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
