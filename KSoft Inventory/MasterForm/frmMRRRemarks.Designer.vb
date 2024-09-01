<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRRRemarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRRRemarks))
        Me.MRRRemarksDataSet = New KSoft_Inventory.MRRRemarksDataSet
        Me.MRRRemarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRRRemarksTableAdapter = New KSoft_Inventory.MRRRemarksDataSetTableAdapters.MRRRemarksTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.MRRRemarksDataSetTableAdapters.TableAdapterManager
        Me.MRRRemarksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MRRRemarksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MRRRemarksGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMRRNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MRRNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.MRRLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MRRLookupDataSet = New KSoft_Inventory.MRRLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMRRNo3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMRRDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMRRRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MRRLookupTableAdapter = New KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter
        Me.colMRRNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMRRNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.MRRRemarksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRRemarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRRemarksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MRRRemarksBindingNavigator.SuspendLayout()
        CType(Me.MRRRemarksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MRRRemarksDataSet
        '
        Me.MRRRemarksDataSet.DataSetName = "MRRRemarksDataSet"
        Me.MRRRemarksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MRRRemarksBindingSource
        '
        Me.MRRRemarksBindingSource.DataMember = "MRRRemarks"
        Me.MRRRemarksBindingSource.DataSource = Me.MRRRemarksDataSet
        '
        'MRRRemarksTableAdapter
        '
        Me.MRRRemarksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MRRRemarksTableAdapter = Me.MRRRemarksTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.MRRRemarksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MRRRemarksBindingNavigator
        '
        Me.MRRRemarksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MRRRemarksBindingNavigator.BindingSource = Me.MRRRemarksBindingSource
        Me.MRRRemarksBindingNavigator.CountItem = Nothing
        Me.MRRRemarksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MRRRemarksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.MRRRemarksBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.MRRRemarksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MRRRemarksBindingNavigator.MoveFirstItem = Nothing
        Me.MRRRemarksBindingNavigator.MoveLastItem = Nothing
        Me.MRRRemarksBindingNavigator.MoveNextItem = Nothing
        Me.MRRRemarksBindingNavigator.MovePreviousItem = Nothing
        Me.MRRRemarksBindingNavigator.Name = "MRRRemarksBindingNavigator"
        Me.MRRRemarksBindingNavigator.PositionItem = Nothing
        Me.MRRRemarksBindingNavigator.Size = New System.Drawing.Size(889, 25)
        Me.MRRRemarksBindingNavigator.TabIndex = 1
        Me.MRRRemarksBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = Global.KSoft_Inventory.My.Resources.Resources.AddIcon
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MRRRemarksBindingNavigatorSaveItem
        '
        Me.MRRRemarksBindingNavigatorSaveItem.Image = CType(resources.GetObject("MRRRemarksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MRRRemarksBindingNavigatorSaveItem.Name = "MRRRemarksBindingNavigatorSaveItem"
        Me.MRRRemarksBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.MRRRemarksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MRRRemarksGridControl
        '
        Me.MRRRemarksGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MRRRemarksGridControl.DataSource = Me.MRRRemarksBindingSource
        Me.MRRRemarksGridControl.Location = New System.Drawing.Point(2, 28)
        Me.MRRRemarksGridControl.MainView = Me.GridView1
        Me.MRRRemarksGridControl.Name = "MRRRemarksGridControl"
        Me.MRRRemarksGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MRRNoGridLookUpEdit})
        Me.MRRRemarksGridControl.Size = New System.Drawing.Size(889, 367)
        Me.MRRRemarksGridControl.TabIndex = 2
        Me.MRRRemarksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMRRNo, Me.colMRRRemarks})
        Me.GridView1.GridControl = Me.MRRRemarksGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMRRRemarks, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colMRRNo
        '
        Me.colMRRNo.ColumnEdit = Me.MRRNoGridLookUpEdit
        Me.colMRRNo.FieldName = "MRRNo"
        Me.colMRRNo.Name = "colMRRNo"
        Me.colMRRNo.Visible = True
        Me.colMRRNo.VisibleIndex = 0
        Me.colMRRNo.Width = 165
        '
        'MRRNoGridLookUpEdit
        '
        Me.MRRNoGridLookUpEdit.AutoHeight = False
        Me.MRRNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRRNoGridLookUpEdit.DataSource = Me.MRRLookupBindingSource
        Me.MRRNoGridLookUpEdit.DisplayMember = "MRRNo"
        Me.MRRNoGridLookUpEdit.ImmediatePopup = True
        Me.MRRNoGridLookUpEdit.Name = "MRRNoGridLookUpEdit"
        Me.MRRNoGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.MRRNoGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.MRRNoGridLookUpEdit.ValueMember = "MRRNo"
        Me.MRRNoGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'MRRLookupBindingSource
        '
        Me.MRRLookupBindingSource.DataMember = "MRRLookup"
        Me.MRRLookupBindingSource.DataSource = Me.MRRLookupDataSet
        '
        'MRRLookupDataSet
        '
        Me.MRRLookupDataSet.DataSetName = "MRRLookupDataSet"
        Me.MRRLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMRRNo3, Me.colMRRDate})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colMRRNo3
        '
        Me.colMRRNo3.FieldName = "MRRNo"
        Me.colMRRNo3.Name = "colMRRNo3"
        Me.colMRRNo3.Visible = True
        Me.colMRRNo3.VisibleIndex = 0
        '
        'colMRRDate
        '
        Me.colMRRDate.FieldName = "MRRDate"
        Me.colMRRDate.Name = "colMRRDate"
        Me.colMRRDate.Visible = True
        Me.colMRRDate.VisibleIndex = 1
        '
        'colMRRRemarks
        '
        Me.colMRRRemarks.FieldName = "MRRRemarks"
        Me.colMRRRemarks.Name = "colMRRRemarks"
        Me.colMRRRemarks.Visible = True
        Me.colMRRRemarks.VisibleIndex = 1
        Me.colMRRRemarks.Width = 829
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.MRRRemarksGridControl
        Me.GridView2.Name = "GridView2"
        '
        'MRRLookupTableAdapter
        '
        Me.MRRLookupTableAdapter.ClearBeforeFill = True
        '
        'colMRRNo1
        '
        Me.colMRRNo1.FieldName = "MRRNo"
        Me.colMRRNo1.Name = "colMRRNo1"
        Me.colMRRNo1.Visible = True
        Me.colMRRNo1.VisibleIndex = 0
        '
        'colMRRNo2
        '
        Me.colMRRNo2.FieldName = "MRRNo"
        Me.colMRRNo2.Name = "colMRRNo2"
        Me.colMRRNo2.Visible = True
        Me.colMRRNo2.VisibleIndex = 0
        '
        'frmMRRRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 422)
        Me.Controls.Add(Me.MRRRemarksGridControl)
        Me.Controls.Add(Me.MRRRemarksBindingNavigator)
        Me.IsMdiContainer = True
        Me.Name = "frmMRRRemarks"
        Me.Text = "MRR Remarks"
        CType(Me.MRRRemarksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRRemarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRRemarksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MRRRemarksBindingNavigator.ResumeLayout(False)
        Me.MRRRemarksBindingNavigator.PerformLayout()
        CType(Me.MRRRemarksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRRLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MRRRemarksDataSet As KSoft_Inventory.MRRRemarksDataSet
    Friend WithEvents MRRRemarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRRRemarksTableAdapter As KSoft_Inventory.MRRRemarksDataSetTableAdapters.MRRRemarksTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.MRRRemarksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MRRRemarksBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MRRRemarksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MRRRemarksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMRRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MRRNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MRRLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MRRLookupDataSet As KSoft_Inventory.MRRLookupDataSet
    Friend WithEvents MRRLookupTableAdapter As KSoft_Inventory.MRRLookupDataSetTableAdapters.MRRLookupTableAdapter
    Friend WithEvents colMRRNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRRDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
