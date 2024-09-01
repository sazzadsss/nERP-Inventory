<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishFabricLookupbyBatch
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
        Me.FinishFabricLookupByBatchDataGridView = New System.Windows.Forms.DataGridView
        Me.FinishFabricLookupByBatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Inventory.FinishFabricOrderLookupDataSet
        Me.FinishFabricLookupbyBatchTableAdapter = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupbyBatchTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.TableAdapterManager
        Me.FinishFabricBookingDetailsId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FabricColorName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiaType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BatchQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FinishFabricLookupByBatchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricLookupByBatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FinishFabricLookupByBatchDataGridView
        '
        Me.FinishFabricLookupByBatchDataGridView.AllowUserToAddRows = False
        Me.FinishFabricLookupByBatchDataGridView.AllowUserToDeleteRows = False
        Me.FinishFabricLookupByBatchDataGridView.AutoGenerateColumns = False
        Me.FinishFabricLookupByBatchDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FinishFabricLookupByBatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishFabricLookupByBatchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FinishFabricBookingDetailsId, Me.DataGridViewTextBoxColumn4, Me.FabricColorName, Me.DataGridViewTextBoxColumn3, Me.Dia, Me.DiaType, Me.BatchQuantity})
        Me.FinishFabricLookupByBatchDataGridView.DataSource = Me.FinishFabricLookupByBatchBindingSource
        Me.FinishFabricLookupByBatchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinishFabricLookupByBatchDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.FinishFabricLookupByBatchDataGridView.Name = "FinishFabricLookupByBatchDataGridView"
        Me.FinishFabricLookupByBatchDataGridView.ReadOnly = True
        Me.FinishFabricLookupByBatchDataGridView.Size = New System.Drawing.Size(772, 284)
        Me.FinishFabricLookupByBatchDataGridView.TabIndex = 2
        '
        'FinishFabricLookupByBatchBindingSource
        '
        Me.FinishFabricLookupByBatchBindingSource.DataMember = "FinishFabricLookupByBatch"
        Me.FinishFabricLookupByBatchBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricLookupbyBatchTableAdapter
        '
        Me.FinishFabricLookupbyBatchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinishFabricBookingDetailsId
        '
        Me.FinishFabricBookingDetailsId.DataPropertyName = "FinishFabricBookingDetailsId"
        Me.FinishFabricBookingDetailsId.HeaderText = "FFBDID"
        Me.FinishFabricBookingDetailsId.Name = "FinishFabricBookingDetailsId"
        Me.FinishFabricBookingDetailsId.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Part"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Part"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'FabricColorName
        '
        Me.FabricColorName.DataPropertyName = "FabricColorName"
        Me.FabricColorName.HeaderText = "Fabric Color Name"
        Me.FabricColorName.Name = "FabricColorName"
        Me.FabricColorName.ReadOnly = True
        Me.FabricColorName.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KnittingType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Knitting Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Dia
        '
        Me.Dia.DataPropertyName = "Dia"
        Me.Dia.HeaderText = "Dia"
        Me.Dia.Name = "Dia"
        Me.Dia.ReadOnly = True
        '
        'DiaType
        '
        Me.DiaType.DataPropertyName = "DiaType"
        Me.DiaType.HeaderText = "DiaType"
        Me.DiaType.Name = "DiaType"
        Me.DiaType.ReadOnly = True
        '
        'BatchQuantity
        '
        Me.BatchQuantity.DataPropertyName = "BatchQuantity"
        Me.BatchQuantity.HeaderText = "BatchQuantity"
        Me.BatchQuantity.Name = "BatchQuantity"
        Me.BatchQuantity.ReadOnly = True
        '
        'frmFinishFabricLookupbyBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 284)
        Me.Controls.Add(Me.FinishFabricLookupByBatchDataGridView)
        Me.Name = "frmFinishFabricLookupbyBatch"
        Me.Text = "Finish Fabric Lookup by Batch"
        CType(Me.FinishFabricLookupByBatchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricLookupByBatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Inventory.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricLookupByBatchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricLookupbyBatchTableAdapter As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricLookupbyBatchTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.FinishFabricOrderLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishFabricLookupByBatchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FinishFabricBookingDetailsId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabricColorName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
