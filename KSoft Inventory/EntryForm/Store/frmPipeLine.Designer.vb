<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPipeLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPipeLine))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ItemListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ItemListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ItemListDataGridView = New System.Windows.Forms.DataGridView
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemListBindingNavigator.SuspendLayout()
        CType(Me.ItemListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemListBindingNavigator
        '
        Me.ItemListBindingNavigator.AddNewItem = Nothing
        Me.ItemListBindingNavigator.BindingSource = Me.ItemListBindingSource
        Me.ItemListBindingNavigator.CountItem = Nothing
        Me.ItemListBindingNavigator.DeleteItem = Nothing
        Me.ItemListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemListBindingNavigatorSaveItem})
        Me.ItemListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemListBindingNavigator.MoveFirstItem = Nothing
        Me.ItemListBindingNavigator.MoveLastItem = Nothing
        Me.ItemListBindingNavigator.MoveNextItem = Nothing
        Me.ItemListBindingNavigator.MovePreviousItem = Nothing
        Me.ItemListBindingNavigator.Name = "ItemListBindingNavigator"
        Me.ItemListBindingNavigator.PositionItem = Nothing
        Me.ItemListBindingNavigator.Size = New System.Drawing.Size(643, 25)
        Me.ItemListBindingNavigator.TabIndex = 0
        Me.ItemListBindingNavigator.Text = "BindingNavigator1"
        '
        'ItemListBindingNavigatorSaveItem
        '
        Me.ItemListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemListBindingNavigatorSaveItem.Name = "ItemListBindingNavigatorSaveItem"
        Me.ItemListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ItemListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemListDataGridView
        '
        Me.ItemListDataGridView.AllowUserToAddRows = False
        Me.ItemListDataGridView.AllowUserToDeleteRows = False
        Me.ItemListDataGridView.AutoGenerateColumns = False
        Me.ItemListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ItemListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.ItemListDataGridView.DataSource = Me.ItemListBindingSource
        Me.ItemListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ItemListDataGridView.Name = "ItemListDataGridView"
        Me.ItemListDataGridView.Size = New System.Drawing.Size(643, 355)
        Me.ItemListDataGridView.TabIndex = 1
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(457, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(182, 20)
        Me.SearchTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Name Search"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemName"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemDescription"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PipelineQuantity"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Pipeline Quantity"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PipeLineDate"
        DataGridViewCellStyle3.Format = "dd-MMM-yy"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn19.HeaderText = "PipeLine Date"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemLeadTimeTableAdapter = Nothing
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'frmPipeLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ItemListDataGridView)
        Me.Controls.Add(Me.ItemListBindingNavigator)
        Me.Name = "frmPipeLine"
        Me.Text = "Pipe Line"
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemListBindingNavigator.ResumeLayout(False)
        Me.ItemListBindingNavigator.PerformLayout()
        CType(Me.ItemListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ItemListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
