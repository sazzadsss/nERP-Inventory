<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.DepartmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DepartmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DepartmentDataGridView = New System.Windows.Forms.DataGridView
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.DepartmentDataSetTableAdapters.TableAdapterManager
        Me.CurrencyDataSet = New KSoft_Inventory.CurrencyDataSet
        Me.CurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTableAdapter = New KSoft_Inventory.CurrencyDataSetTableAdapters.CurrencyTableAdapter
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.IsLCTracking = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartmentBindingNavigator.SuspendLayout()
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentBindingNavigator
        '
        Me.DepartmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DepartmentBindingNavigator.BindingSource = Me.DepartmentBindingSource
        Me.DepartmentBindingNavigator.CountItem = Nothing
        Me.DepartmentBindingNavigator.DeleteItem = Nothing
        Me.DepartmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DepartmentBindingNavigatorSaveItem})
        Me.DepartmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DepartmentBindingNavigator.MoveFirstItem = Nothing
        Me.DepartmentBindingNavigator.MoveLastItem = Nothing
        Me.DepartmentBindingNavigator.MoveNextItem = Nothing
        Me.DepartmentBindingNavigator.MovePreviousItem = Nothing
        Me.DepartmentBindingNavigator.Name = "DepartmentBindingNavigator"
        Me.DepartmentBindingNavigator.PositionItem = Nothing
        Me.DepartmentBindingNavigator.Size = New System.Drawing.Size(778, 25)
        Me.DepartmentBindingNavigator.TabIndex = 0
        Me.DepartmentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DepartmentBindingNavigatorSaveItem
        '
        Me.DepartmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("DepartmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DepartmentBindingNavigatorSaveItem.Name = "DepartmentBindingNavigatorSaveItem"
        Me.DepartmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DepartmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DepartmentDataGridView
        '
        Me.DepartmentDataGridView.AllowUserToAddRows = False
        Me.DepartmentDataGridView.AutoGenerateColumns = False
        Me.DepartmentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.EmailAddress, Me.CurrencyId, Me.IsLCTracking})
        Me.DepartmentDataGridView.DataSource = Me.DepartmentBindingSource
        Me.DepartmentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DepartmentDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.DepartmentDataGridView.Name = "DepartmentDataGridView"
        Me.DepartmentDataGridView.Size = New System.Drawing.Size(778, 365)
        Me.DepartmentDataGridView.TabIndex = 1
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
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartmentTableAdapter = Me.DepartmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.DepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CurrencyDataSet
        '
        Me.CurrencyDataSet.DataSetName = "CurrencyDataSet"
        Me.CurrencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrencyBindingSource
        '
        Me.CurrencyBindingSource.DataMember = "Currency"
        Me.CurrencyBindingSource.DataSource = Me.CurrencyDataSet
        '
        'CurrencyTableAdapter
        '
        Me.CurrencyTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DepartmentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DepartmentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DepartmentDescription"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DepartmentDescription"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'EmailAddress
        '
        Me.EmailAddress.DataPropertyName = "EmailAddress"
        Me.EmailAddress.HeaderText = "EmailAddress"
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 200
        '
        'CurrencyId
        '
        Me.CurrencyId.DataPropertyName = "CurrencyId"
        Me.CurrencyId.DataSource = Me.CurrencyBindingSource
        Me.CurrencyId.DisplayMember = "CurrencySign"
        Me.CurrencyId.HeaderText = "Currency"
        Me.CurrencyId.Name = "CurrencyId"
        Me.CurrencyId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CurrencyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CurrencyId.ValueMember = "CurrencyId"
        '
        'IsLCTracking
        '
        Me.IsLCTracking.DataPropertyName = "IsLCTracking"
        Me.IsLCTracking.HeaderText = "LC Tracking"
        Me.IsLCTracking.Name = "IsLCTracking"
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 393)
        Me.Controls.Add(Me.DepartmentDataGridView)
        Me.Controls.Add(Me.DepartmentBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDepartment"
        Me.Text = "Department"
        CType(Me.DepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartmentBindingNavigator.ResumeLayout(False)
        Me.DepartmentBindingNavigator.PerformLayout()
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.DepartmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DepartmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DepartmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CurrencyDataSet As KSoft_Inventory.CurrencyDataSet
    Friend WithEvents CurrencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrencyTableAdapter As KSoft_Inventory.CurrencyDataSetTableAdapters.CurrencyTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IsLCTracking As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
