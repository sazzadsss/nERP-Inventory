<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLCDetailsView
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
        Me.OpeningLCDataSet = New KSoft_Inventory.OpeningLCDataSet
        Me.LCDetailsViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LCDetailsViewTableAdapter = New KSoft_Inventory.OpeningLCDataSetTableAdapters.LCDetailsViewTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager
        Me.LCDetailsViewGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLCId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPINo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPIDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLCPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OKButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDetailsViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCDetailsViewGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpeningLCDataSet
        '
        Me.OpeningLCDataSet.DataSetName = "OpeningLCDataSet"
        Me.OpeningLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LCDetailsViewBindingSource
        '
        Me.LCDetailsViewBindingSource.DataMember = "LCDetailsView"
        Me.LCDetailsViewBindingSource.DataSource = Me.OpeningLCDataSet
        '
        'LCDetailsViewTableAdapter
        '
        Me.LCDetailsViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.LCListTableAdapter = Nothing
        Me.TableAdapterManager.PIListTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LCDetailsViewGridControl
        '
        Me.LCDetailsViewGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCDetailsViewGridControl.DataSource = Me.LCDetailsViewBindingSource
        Me.LCDetailsViewGridControl.Location = New System.Drawing.Point(3, 2)
        Me.LCDetailsViewGridControl.MainView = Me.GridView1
        Me.LCDetailsViewGridControl.Name = "LCDetailsViewGridControl"
        Me.LCDetailsViewGridControl.Size = New System.Drawing.Size(977, 313)
        Me.LCDetailsViewGridControl.TabIndex = 1
        Me.LCDetailsViewGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCId, Me.colLCNo, Me.colLCDate, Me.colPINo, Me.colPIDate, Me.colLCQuantity, Me.colRemarks, Me.colLotNo, Me.colSupplierName, Me.colSupplierCode, Me.colItemName, Me.colUnitCode, Me.colLCPrice, Me.colCompanyCode})
        Me.GridView1.GridControl = Me.LCDetailsViewGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colLCId
        '
        Me.colLCId.FieldName = "LCId"
        Me.colLCId.Name = "colLCId"
        Me.colLCId.OptionsColumn.ReadOnly = True
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 0
        Me.colLCNo.Width = 71
        '
        'colLCDate
        '
        Me.colLCDate.FieldName = "LCDate"
        Me.colLCDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colLCDate.Name = "colLCDate"
        Me.colLCDate.Visible = True
        Me.colLCDate.VisibleIndex = 1
        Me.colLCDate.Width = 65
        '
        'colPINo
        '
        Me.colPINo.FieldName = "PINo"
        Me.colPINo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colPINo.Name = "colPINo"
        Me.colPINo.Visible = True
        Me.colPINo.VisibleIndex = 2
        Me.colPINo.Width = 74
        '
        'colPIDate
        '
        Me.colPIDate.FieldName = "PIDate"
        Me.colPIDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colPIDate.Name = "colPIDate"
        Me.colPIDate.Visible = True
        Me.colPIDate.VisibleIndex = 3
        Me.colPIDate.Width = 69
        '
        'colLCQuantity
        '
        Me.colLCQuantity.FieldName = "LCQuantity"
        Me.colLCQuantity.Name = "colLCQuantity"
        Me.colLCQuantity.Visible = True
        Me.colLCQuantity.VisibleIndex = 6
        Me.colLCQuantity.Width = 78
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 12
        Me.colRemarks.Width = 73
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 9
        Me.colLotNo.Width = 59
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 11
        Me.colSupplierName.Width = 94
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 10
        Me.colSupplierCode.Width = 88
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 5
        Me.colItemName.Width = 193
        '
        'colUnitCode
        '
        Me.colUnitCode.Caption = "Unit"
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 8
        Me.colUnitCode.Width = 39
        '
        'colLCPrice
        '
        Me.colLCPrice.FieldName = "LCPrice"
        Me.colLCPrice.Name = "colLCPrice"
        Me.colLCPrice.Visible = True
        Me.colLCPrice.VisibleIndex = 7
        Me.colLCPrice.Width = 61
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 4
        Me.colCompanyCode.Width = 93
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(649, 321)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(149, 26)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(813, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLCDetailsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.LCDetailsViewGridControl)
        Me.Name = "frmLCDetailsView"
        Me.Text = "LC Details View"
        CType(Me.OpeningLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDetailsViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCDetailsViewGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpeningLCDataSet As KSoft_Inventory.OpeningLCDataSet
    Friend WithEvents LCDetailsViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LCDetailsViewTableAdapter As KSoft_Inventory.OpeningLCDataSetTableAdapters.LCDetailsViewTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.OpeningLCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LCDetailsViewGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLCId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colLCPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
