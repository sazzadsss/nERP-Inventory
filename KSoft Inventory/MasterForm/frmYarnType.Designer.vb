<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnType))
        Me.YarnTypeDataSet = New KSoft_Inventory.YarnTypeDataSet
        Me.YarnTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnTypeTableAdapter = New KSoft_Inventory.YarnTypeDataSetTableAdapters.YarnTypeTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.YarnTypeDataSetTableAdapters.TableAdapterManager
        Me.YarnTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.YarnTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.YarnTypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.YarnTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YarnTypeBindingNavigator.SuspendLayout()
        CType(Me.YarnTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YarnTypeDataSet
        '
        Me.YarnTypeDataSet.DataSetName = "YarnTypeDataSet"
        Me.YarnTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnTypeBindingSource
        '
        Me.YarnTypeBindingSource.DataMember = "YarnType"
        Me.YarnTypeBindingSource.DataSource = Me.YarnTypeDataSet
        '
        'YarnTypeTableAdapter
        '
        Me.YarnTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.YarnTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnTypeTableAdapter = Me.YarnTypeTableAdapter
        '
        'YarnTypeBindingNavigator
        '
        Me.YarnTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.YarnTypeBindingNavigator.BindingSource = Me.YarnTypeBindingSource
        Me.YarnTypeBindingNavigator.CountItem = Nothing
        Me.YarnTypeBindingNavigator.DeleteItem = Nothing
        Me.YarnTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.YarnTypeBindingNavigatorSaveItem})
        Me.YarnTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.YarnTypeBindingNavigator.MoveFirstItem = Nothing
        Me.YarnTypeBindingNavigator.MoveLastItem = Nothing
        Me.YarnTypeBindingNavigator.MoveNextItem = Nothing
        Me.YarnTypeBindingNavigator.MovePreviousItem = Nothing
        Me.YarnTypeBindingNavigator.Name = "YarnTypeBindingNavigator"
        Me.YarnTypeBindingNavigator.PositionItem = Nothing
        Me.YarnTypeBindingNavigator.Size = New System.Drawing.Size(467, 25)
        Me.YarnTypeBindingNavigator.TabIndex = 0
        Me.YarnTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'YarnTypeBindingNavigatorSaveItem
        '
        Me.YarnTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("YarnTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.YarnTypeBindingNavigatorSaveItem.Name = "YarnTypeBindingNavigatorSaveItem"
        Me.YarnTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.YarnTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'YarnTypeDataGridView
        '
        Me.YarnTypeDataGridView.AutoGenerateColumns = False
        Me.YarnTypeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.YarnTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YarnTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.YarnTypeDataGridView.DataSource = Me.YarnTypeBindingSource
        Me.YarnTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.YarnTypeDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.YarnTypeDataGridView.Name = "YarnTypeDataGridView"
        Me.YarnTypeDataGridView.Size = New System.Drawing.Size(467, 298)
        Me.YarnTypeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "YarnType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Yarn Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmYarnType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 326)
        Me.Controls.Add(Me.YarnTypeDataGridView)
        Me.Controls.Add(Me.YarnTypeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmYarnType"
        Me.Text = "Yarn Type"
        CType(Me.YarnTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YarnTypeBindingNavigator.ResumeLayout(False)
        Me.YarnTypeBindingNavigator.PerformLayout()
        CType(Me.YarnTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YarnTypeDataSet As KSoft_Inventory.YarnTypeDataSet
    Friend WithEvents YarnTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnTypeTableAdapter As KSoft_Inventory.YarnTypeDataSetTableAdapters.YarnTypeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.YarnTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YarnTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnTypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
