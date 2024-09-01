<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParameter))
        Me.ParameterDataSet = New KSoft_Inventory.ParameterDataSet
        Me.ParameterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParameterTableAdapter = New KSoft_Inventory.ParameterDataSetTableAdapters.ParameterTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ParameterDataSetTableAdapters.TableAdapterManager
        Me.ParameterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ParameterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ParameterDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParameterBindingNavigator.SuspendLayout()
        CType(Me.ParameterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParameterDataSet
        '
        Me.ParameterDataSet.DataSetName = "ParameterDataSet"
        Me.ParameterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ParameterBindingSource
        '
        Me.ParameterBindingSource.DataMember = "Parameter"
        Me.ParameterBindingSource.DataSource = Me.ParameterDataSet
        '
        'ParameterTableAdapter
        '
        Me.ParameterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ParameterTableAdapter = Me.ParameterTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ParameterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ParameterBindingNavigator
        '
        Me.ParameterBindingNavigator.AddNewItem = Nothing
        Me.ParameterBindingNavigator.BindingSource = Me.ParameterBindingSource
        Me.ParameterBindingNavigator.CountItem = Nothing
        Me.ParameterBindingNavigator.DeleteItem = Nothing
        Me.ParameterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParameterBindingNavigatorSaveItem})
        Me.ParameterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParameterBindingNavigator.MoveFirstItem = Nothing
        Me.ParameterBindingNavigator.MoveLastItem = Nothing
        Me.ParameterBindingNavigator.MoveNextItem = Nothing
        Me.ParameterBindingNavigator.MovePreviousItem = Nothing
        Me.ParameterBindingNavigator.Name = "ParameterBindingNavigator"
        Me.ParameterBindingNavigator.PositionItem = Nothing
        Me.ParameterBindingNavigator.Size = New System.Drawing.Size(646, 25)
        Me.ParameterBindingNavigator.TabIndex = 0
        Me.ParameterBindingNavigator.Text = "BindingNavigator1"
        '
        'ParameterBindingNavigatorSaveItem
        '
        Me.ParameterBindingNavigatorSaveItem.Image = CType(resources.GetObject("ParameterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ParameterBindingNavigatorSaveItem.Name = "ParameterBindingNavigatorSaveItem"
        Me.ParameterBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.ParameterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ParameterDataGridView
        '
        Me.ParameterDataGridView.AllowUserToAddRows = False
        Me.ParameterDataGridView.AllowUserToDeleteRows = False
        Me.ParameterDataGridView.AutoGenerateColumns = False
        Me.ParameterDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ParameterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParameterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ParameterDataGridView.DataSource = Me.ParameterBindingSource
        Me.ParameterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParameterDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ParameterDataGridView.Name = "ParameterDataGridView"
        Me.ParameterDataGridView.Size = New System.Drawing.Size(646, 246)
        Me.ParameterDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PrameterId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Parameter Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrameterName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Parameter Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumberValue"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Number Value"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TextValue"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Text Value"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 271)
        Me.Controls.Add(Me.ParameterDataGridView)
        Me.Controls.Add(Me.ParameterBindingNavigator)
        Me.Name = "frmParameter"
        Me.Text = "Parameter"
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParameterBindingNavigator.ResumeLayout(False)
        Me.ParameterBindingNavigator.PerformLayout()
        CType(Me.ParameterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ParameterDataSet As KSoft_Inventory.ParameterDataSet
    Friend WithEvents ParameterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParameterTableAdapter As KSoft_Inventory.ParameterDataSetTableAdapters.ParameterTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ParameterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ParameterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ParameterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ParameterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
