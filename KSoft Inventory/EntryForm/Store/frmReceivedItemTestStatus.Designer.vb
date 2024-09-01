<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedItemTestStatus
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
        Me.ReceiveItemTestStatusGridControl = New DevExpress.XtraGrid.GridControl
        Me.ReceiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveDataSet = New KSoft_Inventory.ReceiveDataSet
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colReceiveId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceiveQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Inventory.BranchDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBranchId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Inventory.SupplierDataSet
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImported = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIssueReceiveTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.IssueReceiveTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueReceiveTypeDataSet = New KSoft_Inventory.IssueReceiveTypeDataSet
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIssueReceiveTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIssueTypeName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.LCListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpeningLCDataSet = New KSoft_Inventory.OpeningLCDataSet
        Me.RepositoryItemGridLookUpEdit8View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLCId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCDate2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPIId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.PIListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPIId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPIDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRequisitionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTestStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTestComments = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLCId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ReceiveTableAdapter = New KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter
        Me.BranchTableAdapter = New KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
        Me.IssueReceiveTypeTableAdapter = New KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
        Me.PIListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter
        Me.SupplierTableAdapter = New KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.CmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.DepartmentGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDepartmentId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmailAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LCListTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
        Me.ItemListLookupTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.ExportToExcel = New System.Windows.Forms.LinkLabel
        Me.colItemName2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ReceiveItemTestStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReceiveItemTestStatusGridControl
        '
        Me.ReceiveItemTestStatusGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReceiveItemTestStatusGridControl.DataSource = Me.ReceiveBindingSource
        Me.ReceiveItemTestStatusGridControl.Location = New System.Drawing.Point(2, 50)
        Me.ReceiveItemTestStatusGridControl.MainView = Me.GridView1
        Me.ReceiveItemTestStatusGridControl.Name = "ReceiveItemTestStatusGridControl"
        Me.ReceiveItemTestStatusGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemCheckEdit1, Me.RepositoryItemGridLookUpEdit7, Me.RepositoryItemGridLookUpEdit8})
        Me.ReceiveItemTestStatusGridControl.Size = New System.Drawing.Size(1092, 322)
        Me.ReceiveItemTestStatusGridControl.TabIndex = 0
        Me.ReceiveItemTestStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReceiveBindingSource
        '
        Me.ReceiveBindingSource.DataMember = "Receive"
        Me.ReceiveBindingSource.DataSource = Me.ReceiveDataSet
        '
        'ReceiveDataSet
        '
        Me.ReceiveDataSet.DataSetName = "ReceiveDataSet"
        Me.ReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkOrange
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkOrange
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.SkyBlue
        Me.GridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.Linen
        Me.GridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.AntiqueWhite
        Me.GridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.Orange
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.GridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Wheat
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Wheat
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Wheat
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Wheat
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Wheat
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Orange
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Tan
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.Khaki
        Me.GridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.Cornsilk
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.GridView1.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Tan
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceiveId, Me.colReceiveDate, Me.colChallanNo, Me.colReceiveQuantity, Me.colBranchId, Me.colRemarks1, Me.colPrice, Me.colProgramNo1, Me.colLCDate1, Me.colSupplierId2, Me.colImported, Me.colIssueReceiveTypeId, Me.colItemId2, Me.colYarnLotNo, Me.colLCNo2, Me.colLCId3, Me.colPIId1, Me.colTestStatus, Me.colTestComments})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1005, 394, 216, 199)
        Me.GridView1.GridControl = Me.ReceiveItemTestStatusGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colReceiveId
        '
        Me.colReceiveId.FieldName = "ReceiveId"
        Me.colReceiveId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colReceiveId.Name = "colReceiveId"
        Me.colReceiveId.OptionsColumn.ReadOnly = True
        Me.colReceiveId.Width = 63
        '
        'colReceiveDate
        '
        Me.colReceiveDate.FieldName = "ReceiveDate"
        Me.colReceiveDate.Name = "colReceiveDate"
        Me.colReceiveDate.OptionsColumn.ReadOnly = True
        Me.colReceiveDate.Visible = True
        Me.colReceiveDate.VisibleIndex = 0
        Me.colReceiveDate.Width = 84
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.OptionsColumn.ReadOnly = True
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 1
        '
        'colReceiveQuantity
        '
        Me.colReceiveQuantity.FieldName = "ReceiveQuantity"
        Me.colReceiveQuantity.Name = "colReceiveQuantity"
        Me.colReceiveQuantity.OptionsColumn.ReadOnly = True
        Me.colReceiveQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colReceiveQuantity.Visible = True
        Me.colReceiveQuantity.VisibleIndex = 7
        Me.colReceiveQuantity.Width = 105
        '
        'colBranchId
        '
        Me.colBranchId.Caption = "Branch"
        Me.colBranchId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.OptionsColumn.ReadOnly = True
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 2
        Me.colBranchId.Width = 65
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.BranchBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "BranchName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "BranchId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchId1, Me.colBranchCode, Me.colBranchName, Me.colBranchDescription, Me.colBranchType})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBranchId1
        '
        Me.colBranchId1.FieldName = "BranchId"
        Me.colBranchId1.Name = "colBranchId1"
        Me.colBranchId1.OptionsColumn.ReadOnly = True
        '
        'colBranchCode
        '
        Me.colBranchCode.FieldName = "BranchCode"
        Me.colBranchCode.Name = "colBranchCode"
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'colBranchDescription
        '
        Me.colBranchDescription.FieldName = "BranchDescription"
        Me.colBranchDescription.Name = "colBranchDescription"
        '
        'colBranchType
        '
        Me.colBranchType.FieldName = "BranchType"
        Me.colBranchType.Name = "colBranchType"
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.OptionsColumn.ReadOnly = True
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 14
        Me.colRemarks1.Width = 81
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.ReadOnly = True
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 5
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.OptionsColumn.ReadOnly = True
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 3
        Me.colProgramNo1.Width = 78
        '
        'colLCDate1
        '
        Me.colLCDate1.FieldName = "LCDate"
        Me.colLCDate1.Name = "colLCDate1"
        Me.colLCDate1.OptionsColumn.ReadOnly = True
        Me.colLCDate1.Visible = True
        Me.colLCDate1.VisibleIndex = 10
        Me.colLCDate1.Width = 68
        '
        'colSupplierId2
        '
        Me.colSupplierId2.Caption = "Supplier"
        Me.colSupplierId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colSupplierId2.FieldName = "SupplierId"
        Me.colSupplierId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSupplierId2.Name = "colSupplierId2"
        Me.colSupplierId2.OptionsColumn.ReadOnly = True
        Me.colSupplierId2.Visible = True
        Me.colSupplierId2.VisibleIndex = 12
        Me.colSupplierId2.Width = 104
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = ""
        Me.RepositoryItemGridLookUpEdit6.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "SupplierId"
        Me.RepositoryItemGridLookUpEdit6.View = Me.RepositoryItemGridLookUpEdit6View
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
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId1, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId1
        '
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        Me.colSupplierId1.OptionsColumn.ReadOnly = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        '
        'colAdd1
        '
        Me.colAdd1.FieldName = "Add1"
        Me.colAdd1.Name = "colAdd1"
        '
        'colAdd2
        '
        Me.colAdd2.FieldName = "Add2"
        Me.colAdd2.Name = "colAdd2"
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        '
        'colImported
        '
        Me.colImported.FieldName = "Imported"
        Me.colImported.Name = "colImported"
        Me.colImported.OptionsColumn.ReadOnly = True
        Me.colImported.Visible = True
        Me.colImported.VisibleIndex = 13
        Me.colImported.Width = 66
        '
        'colIssueReceiveTypeId
        '
        Me.colIssueReceiveTypeId.Caption = "Receive Type"
        Me.colIssueReceiveTypeId.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colIssueReceiveTypeId.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colIssueReceiveTypeId.Name = "colIssueReceiveTypeId"
        Me.colIssueReceiveTypeId.OptionsColumn.ReadOnly = True
        Me.colIssueReceiveTypeId.Visible = True
        Me.colIssueReceiveTypeId.VisibleIndex = 8
        Me.colIssueReceiveTypeId.Width = 100
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.IssueReceiveTypeBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "IssueTypeName"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "IssueReceiveTypeId"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'IssueReceiveTypeBindingSource
        '
        Me.IssueReceiveTypeBindingSource.DataMember = "IssueReceiveType"
        Me.IssueReceiveTypeBindingSource.DataSource = Me.IssueReceiveTypeDataSet
        '
        'IssueReceiveTypeDataSet
        '
        Me.IssueReceiveTypeDataSet.DataSetName = "IssueReceiveTypeDataSet"
        Me.IssueReceiveTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIssueReceiveTypeId1, Me.colIssueTypeName, Me.colDescription})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colIssueReceiveTypeId1
        '
        Me.colIssueReceiveTypeId1.FieldName = "IssueReceiveTypeId"
        Me.colIssueReceiveTypeId1.Name = "colIssueReceiveTypeId1"
        Me.colIssueReceiveTypeId1.OptionsColumn.ReadOnly = True
        '
        'colIssueTypeName
        '
        Me.colIssueTypeName.FieldName = "IssueTypeName"
        Me.colIssueTypeName.Name = "colIssueTypeName"
        Me.colIssueTypeName.Visible = True
        Me.colIssueTypeName.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colItemId2
        '
        Me.colItemId2.Caption = "Item Name"
        Me.colItemId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit7
        Me.colItemId2.FieldName = "ItemId"
        Me.colItemId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId2.Name = "colItemId2"
        Me.colItemId2.OptionsColumn.ReadOnly = True
        Me.colItemId2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colItemId2.Visible = True
        Me.colItemId2.VisibleIndex = 4
        Me.colItemId2.Width = 263
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.ItemListLookupBindingSource
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "ItemId"
        Me.RepositoryItemGridLookUpEdit7.View = Me.RepositoryItemGridLookUpEdit7View
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
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName2})
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.Caption = "Lot No"
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        Me.colYarnLotNo.OptionsColumn.ReadOnly = True
        Me.colYarnLotNo.Visible = True
        Me.colYarnLotNo.VisibleIndex = 6
        Me.colYarnLotNo.Width = 77
        '
        'colLCNo2
        '
        Me.colLCNo2.Caption = "LcNo"
        Me.colLCNo2.FieldName = "LCNo"
        Me.colLCNo2.Name = "colLCNo2"
        Me.colLCNo2.OptionsColumn.ReadOnly = True
        Me.colLCNo2.Width = 78
        '
        'colLCId3
        '
        Me.colLCId3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLCId3.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLCId3.AppearanceCell.Options.UseBackColor = True
        Me.colLCId3.Caption = "LC No"
        Me.colLCId3.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colLCId3.FieldName = "LCId"
        Me.colLCId3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colLCId3.Name = "colLCId3"
        Me.colLCId3.OptionsColumn.ReadOnly = True
        Me.colLCId3.Visible = True
        Me.colLCId3.VisibleIndex = 9
        Me.colLCId3.Width = 74
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.LCListBindingSource
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "LCNo"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.NullText = ""
        Me.RepositoryItemGridLookUpEdit8.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit8.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "LCId"
        Me.RepositoryItemGridLookUpEdit8.View = Me.RepositoryItemGridLookUpEdit8View
        '
        'LCListBindingSource
        '
        Me.LCListBindingSource.DataMember = "LCList"
        Me.LCListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'OpeningLCDataSet
        '
        Me.OpeningLCDataSet.DataSetName = "OpeningLCDataSet"
        Me.OpeningLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit8View
        '
        Me.RepositoryItemGridLookUpEdit8View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId2, Me.colLCNo1, Me.colDepartmentId5, Me.colSupplierId3, Me.colLCDate2, Me.colCompanyId1, Me.colBuyerId1, Me.colRemarks3})
        Me.RepositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit8View.Name = "RepositoryItemGridLookUpEdit8View"
        Me.RepositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = False
        '
        'colLCId2
        '
        Me.colLCId2.FieldName = "LCId"
        Me.colLCId2.Name = "colLCId2"
        Me.colLCId2.OptionsColumn.ReadOnly = True
        '
        'colLCNo1
        '
        Me.colLCNo1.FieldName = "LCNo"
        Me.colLCNo1.Name = "colLCNo1"
        Me.colLCNo1.Visible = True
        Me.colLCNo1.VisibleIndex = 0
        '
        'colDepartmentId5
        '
        Me.colDepartmentId5.FieldName = "DepartmentId"
        Me.colDepartmentId5.Name = "colDepartmentId5"
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        '
        'colLCDate2
        '
        Me.colLCDate2.FieldName = "LCDate"
        Me.colLCDate2.Name = "colLCDate2"
        '
        'colCompanyId1
        '
        Me.colCompanyId1.FieldName = "CompanyId"
        Me.colCompanyId1.Name = "colCompanyId1"
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colRemarks3
        '
        Me.colRemarks3.FieldName = "Remarks"
        Me.colRemarks3.Name = "colRemarks3"
        '
        'colPIId1
        '
        Me.colPIId1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPIId1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPIId1.AppearanceCell.Options.UseBackColor = True
        Me.colPIId1.Caption = "PI No"
        Me.colPIId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit5
        Me.colPIId1.FieldName = "PIId"
        Me.colPIId1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPIId1.Name = "colPIId1"
        Me.colPIId1.OptionsColumn.ReadOnly = True
        Me.colPIId1.Visible = True
        Me.colPIId1.VisibleIndex = 11
        Me.colPIId1.Width = 74
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.PIListBindingSource1
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "PINo"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.NullText = ""
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "PIId"
        Me.RepositoryItemGridLookUpEdit5.View = Me.RepositoryItemGridLookUpEdit5View
        '
        'PIListBindingSource1
        '
        Me.PIListBindingSource1.DataMember = "PIList"
        Me.PIListBindingSource1.DataSource = Me.OpeningLCDataSet
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPIId, Me.colPINo, Me.colPIDate, Me.colLCId1, Me.colItemId1, Me.colLCQuantity, Me.colUnitId, Me.colRemarks2, Me.colLotNo, Me.colLCPrice, Me.colETA, Me.colRequisitionId})
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'colPIId
        '
        Me.colPIId.FieldName = "PIId"
        Me.colPIId.Name = "colPIId"
        Me.colPIId.OptionsColumn.ReadOnly = True
        '
        'colPINo
        '
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Name = "colPINo"
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 0
        '
        'colPIDate
        '
        Me.colPIDate.FieldName = "PIDate"
        Me.colPIDate.Name = "colPIDate"
        '
        'colLCId1
        '
        Me.colLCId1.FieldName = "LCId"
        Me.colLCId1.Name = "colLCId1"
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        '
        'colLCQuantity
        '
        Me.colLCQuantity.FieldName = "LCQuantity"
        Me.colLCQuantity.Name = "colLCQuantity"
        '
        'colUnitId
        '
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        '
        'colLCPrice
        '
        Me.colLCPrice.FieldName = "LCPrice"
        Me.colLCPrice.Name = "colLCPrice"
        '
        'colETA
        '
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        '
        'colRequisitionId
        '
        Me.colRequisitionId.FieldName = "RequisitionId"
        Me.colRequisitionId.Name = "colRequisitionId"
        '
        'colTestStatus
        '
        Me.colTestStatus.FieldName = "TestStatus"
        Me.colTestStatus.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colTestStatus.Name = "colTestStatus"
        Me.colTestStatus.Visible = True
        Me.colTestStatus.VisibleIndex = 15
        Me.colTestStatus.Width = 77
        '
        'colTestComments
        '
        Me.colTestComments.FieldName = "TestComments"
        Me.colTestComments.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colTestComments.Name = "colTestComments"
        Me.colTestComments.Visible = True
        Me.colTestComments.VisibleIndex = 16
        Me.colTestComments.Width = 95
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ItemId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.LCListBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "LCNo"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.NullText = ""
        Me.RepositoryItemGridLookUpEdit4.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "LCId"
        Me.RepositoryItemGridLookUpEdit4.View = Me.RepositoryItemGridLookUpEdit4View
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId, Me.colLCNo, Me.colDepartmentId1, Me.colSupplierId, Me.colLCDate, Me.colCompanyId, Me.colBuyerId, Me.colRemarks})
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colLCId
        '
        Me.colLCId.FieldName = "LCId"
        Me.colLCId.Name = "colLCId"
        Me.colLCId.OptionsColumn.ReadOnly = True
        Me.colLCId.Visible = True
        Me.colLCId.VisibleIndex = 0
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 1
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        Me.colDepartmentId1.Visible = True
        Me.colDepartmentId1.VisibleIndex = 2
        '
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 3
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Name = "colLCDate"
        Me.colLCDate.Visible = True
        Me.colLCDate.VisibleIndex = 4
        '
        'colCompanyId
        '
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.Visible = True
        Me.colCompanyId.VisibleIndex = 5
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 6
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ReceiveTableAdapter
        '
        Me.ReceiveTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'IssueReceiveTypeTableAdapter
        '
        Me.IssueReceiveTypeTableAdapter.ClearBeforeFill = True
        '
        'PIListBindingSource
        '
        Me.PIListBindingSource.DataMember = "PIList"
        Me.PIListBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'PIListTableAdapter
        '
        Me.PIListTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'CmdSave
        '
        Me.CmdSave.Location = New System.Drawing.Point(630, 10)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(75, 23)
        Me.CmdSave.TabIndex = 1
        Me.CmdSave.Text = "&Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Department"
        '
        'DepartmentGridLookUpEdit
        '
        Me.DepartmentGridLookUpEdit.Location = New System.Drawing.Point(78, 10)
        Me.DepartmentGridLookUpEdit.Name = "DepartmentGridLookUpEdit"
        Me.DepartmentGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.DepartmentGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.DepartmentGridLookUpEdit.Properties.NullText = ""
        Me.DepartmentGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DepartmentGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.DepartmentGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.DepartmentGridLookUpEdit.Size = New System.Drawing.Size(223, 20)
        Me.DepartmentGridLookUpEdit.TabIndex = 3
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentId2, Me.colDepartmentName, Me.colDepartmentDescription, Me.colEmailAddress})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'ItemGridLookUpEdit
        '
        Me.ItemGridLookUpEdit.Location = New System.Drawing.Point(394, 12)
        Me.ItemGridLookUpEdit.Name = "ItemGridLookUpEdit"
        Me.ItemGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemGridLookUpEdit.Properties.DataSource = Me.ItemListLookupBindingSource
        Me.ItemGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.ItemGridLookUpEdit.Properties.NullText = ""
        Me.ItemGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.ItemGridLookUpEdit.Properties.View = Me.GridView2
        Me.ItemGridLookUpEdit.Size = New System.Drawing.Size(149, 20)
        Me.ItemGridLookUpEdit.TabIndex = 5
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId3, Me.colItemName1, Me.colDepartmentId3, Me.GridColumn2})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colItemId3
        '
        Me.colItemId3.FieldName = "ItemId"
        Me.colItemId3.Name = "colItemId3"
        Me.colItemId3.OptionsColumn.ReadOnly = True
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'colDepartmentId3
        '
        Me.colDepartmentId3.FieldName = "DepartmentId"
        Me.colDepartmentId3.Name = "colDepartmentId3"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ID-Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(330, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Item Name"
        '
        'LCListTableAdapter
        '
        Me.LCListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MRNoLookUpTableAdapter = Nothing
        Me.TableAdapterManager.ReceiveTableAdapter = Me.ReceiveTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(549, 10)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 23)
        Me.cmdRefresh.TabIndex = 6
        Me.cmdRefresh.Text = "&Load"
        '
        'ExportToExcel
        '
        Me.ExportToExcel.AutoSize = True
        Me.ExportToExcel.Location = New System.Drawing.Point(724, 15)
        Me.ExportToExcel.Name = "ExportToExcel"
        Me.ExportToExcel.Size = New System.Drawing.Size(78, 13)
        Me.ExportToExcel.TabIndex = 8
        Me.ExportToExcel.TabStop = True
        Me.ExportToExcel.Text = "&Export to Excel"
        '
        'colItemName2
        '
        Me.colItemName2.FieldName = "ItemName"
        Me.colItemName2.Name = "colItemName2"
        Me.colItemName2.Visible = True
        Me.colItemName2.VisibleIndex = 0
        '
        'frmReceivedItemTestStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 376)
        Me.Controls.Add(Me.ExportToExcel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.ItemGridLookUpEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.DepartmentGridLookUpEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.ReceiveItemTestStatusGridControl)
        Me.Name = "frmReceivedItemTestStatus"
        Me.Text = "Received Item Test Status"
        CType(Me.ReceiveItemTestStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueReceiveTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceiveItemTestStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReceiveId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImported As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueReceiveTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReceiveDataSet As KSoft_Inventory.ReceiveDataSet
    Friend WithEvents ReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiveTableAdapter As KSoft_Inventory.ReceiveDataSetTableAdapters.ReceiveTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchDataSet As KSoft_Inventory.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Inventory.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents colBranchId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssueReceiveTypeDataSet As KSoft_Inventory.IssueReceiveTypeDataSet
    Friend WithEvents IssueReceiveTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueReceiveTypeTableAdapter As KSoft_Inventory.IssueReceiveTypeDataSetTableAdapters.IssueReceiveTypeTableAdapter
    Friend WithEvents colIssueReceiveTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIssueTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents OpeningLCDataSet As KSoft_Inventory.OpeningLCDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PIListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.PIListTableAdapter
    Friend WithEvents PIListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colPIId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierDataSet As KSoft_Inventory.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Inventory.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DepartmentGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LCListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCListTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.LCListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents colDepartmentId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colItemId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTestStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit8View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExportToExcel As System.Windows.Forms.LinkLabel
    Friend WithEvents colItemName2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
