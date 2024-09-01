<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnCount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnCount))
        Me.YCountDataSet = New KSoft_Inventory.YCountDataSet
        Me.YarnCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YarnCountTableAdapter = New KSoft_Inventory.YCountDataSetTableAdapters.YarnCountTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.YCountDataSetTableAdapters.TableAdapterManager
        Me.YarnCountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.YarnCountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.YarnCountDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.YCountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnCountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YarnCountBindingNavigator.SuspendLayout()
        CType(Me.YarnCountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YCountDataSet
        '
        Me.YCountDataSet.DataSetName = "YCountDataSet"
        Me.YCountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YarnCountBindingSource
        '
        Me.YarnCountBindingSource.DataMember = "YarnCount"
        Me.YarnCountBindingSource.DataSource = Me.YCountDataSet
        '
        'YarnCountTableAdapter
        '
        Me.YarnCountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.YCountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnCountTableAdapter = Me.YarnCountTableAdapter
        '
        'YarnCountBindingNavigator
        '
        Me.YarnCountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.YarnCountBindingNavigator.BindingSource = Me.YarnCountBindingSource
        Me.YarnCountBindingNavigator.CountItem = Nothing
        Me.YarnCountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.YarnCountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.YarnCountBindingNavigatorSaveItem})
        Me.YarnCountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.YarnCountBindingNavigator.MoveFirstItem = Nothing
        Me.YarnCountBindingNavigator.MoveLastItem = Nothing
        Me.YarnCountBindingNavigator.MoveNextItem = Nothing
        Me.YarnCountBindingNavigator.MovePreviousItem = Nothing
        Me.YarnCountBindingNavigator.Name = "YarnCountBindingNavigator"
        Me.YarnCountBindingNavigator.PositionItem = Nothing
        Me.YarnCountBindingNavigator.Size = New System.Drawing.Size(221, 25)
        Me.YarnCountBindingNavigator.TabIndex = 0
        Me.YarnCountBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'YarnCountBindingNavigatorSaveItem
        '
        Me.YarnCountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.YarnCountBindingNavigatorSaveItem.Image = CType(resources.GetObject("YarnCountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.YarnCountBindingNavigatorSaveItem.Name = "YarnCountBindingNavigatorSaveItem"
        Me.YarnCountBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.YarnCountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'YarnCountDataGridView
        '
        Me.YarnCountDataGridView.AllowUserToAddRows = False
        Me.YarnCountDataGridView.AutoGenerateColumns = False
        Me.YarnCountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YarnCountDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.YarnCountDataGridView.DataSource = Me.YarnCountBindingSource
        Me.YarnCountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YarnCountDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.YarnCountDataGridView.Name = "YarnCountDataGridView"
        Me.YarnCountDataGridView.Size = New System.Drawing.Size(221, 224)
        Me.YarnCountDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Count"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Count"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmYarnCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 249)
        Me.Controls.Add(Me.YarnCountDataGridView)
        Me.Controls.Add(Me.YarnCountBindingNavigator)
        Me.Name = "frmYarnCount"
        Me.Text = "Yarn Count"
        CType(Me.YCountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnCountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YarnCountBindingNavigator.ResumeLayout(False)
        Me.YarnCountBindingNavigator.PerformLayout()
        CType(Me.YarnCountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YCountDataSet As KSoft_Inventory.YCountDataSet
    Friend WithEvents YarnCountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnCountTableAdapter As KSoft_Inventory.YCountDataSetTableAdapters.YarnCountTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.YCountDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YarnCountBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnCountBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents YarnCountDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
