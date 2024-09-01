<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitionNo
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
        Me.RequisitionFloorLookupDataSet = New KSoft_Inventory.RequisitionFloorLookupDataSet()
        Me.RequisitionFloorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorLookupTableAdapter = New KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookupTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.TableAdapterManager()
        Me.RequisitionFloorLookupGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.YarnRequisitionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.YarnRequisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnRequsitionDataSet = New KSoft_Inventory.YarnRequsitionDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYarnRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnRequisitionTableAdapter = New KSoft_Inventory.YarnRequsitionDataSetTableAdapters.YarnRequisitionTableAdapter()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnRequisitionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnRequisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnRequsitionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequisitionFloorLookupDataSet
        '
        Me.RequisitionFloorLookupDataSet.DataSetName = "RequisitionFloorLookupDataSet"
        Me.RequisitionFloorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionFloorLookupBindingSource
        '
        Me.RequisitionFloorLookupBindingSource.DataMember = "RequisitionFloorLookup"
        Me.RequisitionFloorLookupBindingSource.DataSource = Me.RequisitionFloorLookupDataSet
        '
        'RequisitionFloorLookupTableAdapter
        '
        Me.RequisitionFloorLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RequisitionFloorLookupTableAdapter = Me.RequisitionFloorLookupTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequisitionFloorLookupGridControl
        '
        Me.RequisitionFloorLookupGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequisitionFloorLookupGridControl.DataSource = Me.RequisitionFloorLookupBindingSource
        Me.RequisitionFloorLookupGridControl.Location = New System.Drawing.Point(0, 2)
        Me.RequisitionFloorLookupGridControl.MainView = Me.GridView1
        Me.RequisitionFloorLookupGridControl.Name = "RequisitionFloorLookupGridControl"
        Me.RequisitionFloorLookupGridControl.Size = New System.Drawing.Size(392, 229)
        Me.RequisitionFloorLookupGridControl.TabIndex = 1
        Me.RequisitionFloorLookupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionNo})
        Me.GridView1.GridControl = Me.RequisitionFloorLookupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colRequisitionNo.Name = "colRequisitionNo"
        Me.colRequisitionNo.OptionsColumn.AllowEdit = False
        Me.colRequisitionNo.OptionsColumn.ReadOnly = True
        Me.colRequisitionNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRequisitionNo.Visible = True
        Me.colRequisitionNo.VisibleIndex = 0
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.RequisitionFloorLookupGridControl
        Me.GridView2.Name = "GridView2"
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.Location = New System.Drawing.Point(283, 237)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(97, 23)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "&OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'YarnRequisitionGridControl
        '
        Me.YarnRequisitionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YarnRequisitionGridControl.DataSource = Me.YarnRequisitionBindingSource
        Me.YarnRequisitionGridControl.Location = New System.Drawing.Point(0, 2)
        Me.YarnRequisitionGridControl.MainView = Me.GridView3
        Me.YarnRequisitionGridControl.Name = "YarnRequisitionGridControl"
        Me.YarnRequisitionGridControl.Size = New System.Drawing.Size(392, 220)
        Me.YarnRequisitionGridControl.TabIndex = 2
        Me.YarnRequisitionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'YarnRequisitionBindingSource
        '
        Me.YarnRequisitionBindingSource.DataMember = "YarnRequisition"
        Me.YarnRequisitionBindingSource.DataSource = Me.YarnRequsitionDataSet
        '
        'YarnRequsitionDataSet
        '
        Me.YarnRequsitionDataSet.DataSetName = "YarnRequsitionDataSet"
        Me.YarnRequsitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYarnRequisitionNo})
        Me.GridView3.GridControl = Me.YarnRequisitionGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colYarnRequisitionNo
        '
        Me.colYarnRequisitionNo.FieldName = "YarnRequisitionNo"
        Me.colYarnRequisitionNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colYarnRequisitionNo.Name = "colYarnRequisitionNo"
        Me.colYarnRequisitionNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colYarnRequisitionNo.Visible = True
        Me.colYarnRequisitionNo.VisibleIndex = 0
        '
        'YarnRequisitionTableAdapter
        '
        Me.YarnRequisitionTableAdapter.ClearBeforeFill = True
        '
        'frmRequisitionNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 271)
        Me.Controls.Add(Me.YarnRequisitionGridControl)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.RequisitionFloorLookupGridControl)
        Me.Name = "frmRequisitionNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisition No"
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnRequisitionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnRequisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnRequsitionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RequisitionFloorLookupDataSet As KSoft_Inventory.RequisitionFloorLookupDataSet
    Friend WithEvents RequisitionFloorLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionFloorLookupTableAdapter As KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookupTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.RequisitionFloorLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequisitionFloorLookupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents YarnRequisitionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYarnRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnRequsitionDataSet As YarnRequsitionDataSet
    Friend WithEvents YarnRequisitionBindingSource As BindingSource
    Friend WithEvents YarnRequisitionTableAdapter As YarnRequsitionDataSetTableAdapters.YarnRequisitionTableAdapter
End Class
