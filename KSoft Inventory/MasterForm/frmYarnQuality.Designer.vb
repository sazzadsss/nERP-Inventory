<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnQuality
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnQuality))
        Me.YarnQualityDataSet = New KSoft_Inventory.YarnQualityDataSet
        Me.YarnQualityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnQualityTableAdapter = New KSoft_Inventory.YarnQualityDataSetTableAdapters.YarnQualityTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.YarnQualityDataSetTableAdapters.TableAdapterManager
        Me.YarnQualityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.YarnQualityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.YarnQualityDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.YarnQualityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnQualityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnQualityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YarnQualityBindingNavigator.SuspendLayout()
        CType(Me.YarnQualityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YarnQualityDataSet
        '
        Me.YarnQualityDataSet.DataSetName = "YarnQualityDataSet"
        Me.YarnQualityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnQualityBindingSource
        '
        Me.YarnQualityBindingSource.DataMember = "YarnQuality"
        Me.YarnQualityBindingSource.DataSource = Me.YarnQualityDataSet
        '
        'YarnQualityTableAdapter
        '
        Me.YarnQualityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.YarnQualityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnQualityTableAdapter = Me.YarnQualityTableAdapter
        '
        'YarnQualityBindingNavigator
        '
        Me.YarnQualityBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.YarnQualityBindingNavigator.BindingSource = Me.YarnQualityBindingSource
        Me.YarnQualityBindingNavigator.CountItem = Nothing
        Me.YarnQualityBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.YarnQualityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.YarnQualityBindingNavigatorSaveItem})
        Me.YarnQualityBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.YarnQualityBindingNavigator.MoveFirstItem = Nothing
        Me.YarnQualityBindingNavigator.MoveLastItem = Nothing
        Me.YarnQualityBindingNavigator.MoveNextItem = Nothing
        Me.YarnQualityBindingNavigator.MovePreviousItem = Nothing
        Me.YarnQualityBindingNavigator.Name = "YarnQualityBindingNavigator"
        Me.YarnQualityBindingNavigator.PositionItem = Nothing
        Me.YarnQualityBindingNavigator.Size = New System.Drawing.Size(398, 25)
        Me.YarnQualityBindingNavigator.TabIndex = 0
        Me.YarnQualityBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'YarnQualityBindingNavigatorSaveItem
        '
        Me.YarnQualityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.YarnQualityBindingNavigatorSaveItem.Image = CType(resources.GetObject("YarnQualityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.YarnQualityBindingNavigatorSaveItem.Name = "YarnQualityBindingNavigatorSaveItem"
        Me.YarnQualityBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.YarnQualityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'YarnQualityDataGridView
        '
        Me.YarnQualityDataGridView.AllowUserToAddRows = False
        Me.YarnQualityDataGridView.AutoGenerateColumns = False
        Me.YarnQualityDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.YarnQualityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YarnQualityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.YarnQualityDataGridView.DataSource = Me.YarnQualityBindingSource
        Me.YarnQualityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YarnQualityDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.YarnQualityDataGridView.Name = "YarnQualityDataGridView"
        Me.YarnQualityDataGridView.Size = New System.Drawing.Size(398, 230)
        Me.YarnQualityDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "YarnQuality"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Yarn Quality"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmYarnQuality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 255)
        Me.Controls.Add(Me.YarnQualityDataGridView)
        Me.Controls.Add(Me.YarnQualityBindingNavigator)
        Me.Name = "frmYarnQuality"
        Me.Text = "Yarn Quality"
        CType(Me.YarnQualityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnQualityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnQualityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YarnQualityBindingNavigator.ResumeLayout(False)
        Me.YarnQualityBindingNavigator.PerformLayout()
        CType(Me.YarnQualityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YarnQualityDataSet As KSoft_Inventory.YarnQualityDataSet
    Friend WithEvents YarnQualityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnQualityTableAdapter As KSoft_Inventory.YarnQualityDataSetTableAdapters.YarnQualityTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.YarnQualityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YarnQualityBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnQualityBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnQualityDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
