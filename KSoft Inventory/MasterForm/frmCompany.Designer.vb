<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompany))
        Me.CompanyDataSet = New KSoft_Inventory.CompanyDataSet
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.CompanyDataSetTableAdapters.TableAdapterManager
        Me.CompanyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.CompanyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CompanyDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyBindingNavigator.SuspendLayout()
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompanyTableAdapter = Me.CompanyTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyBindingNavigator
        '
        Me.CompanyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompanyBindingNavigator.BindingSource = Me.CompanyBindingSource
        Me.CompanyBindingNavigator.CountItem = Nothing
        Me.CompanyBindingNavigator.DeleteItem = Nothing
        Me.CompanyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.CompanyBindingNavigatorSaveItem})
        Me.CompanyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompanyBindingNavigator.MoveFirstItem = Nothing
        Me.CompanyBindingNavigator.MoveLastItem = Nothing
        Me.CompanyBindingNavigator.MoveNextItem = Nothing
        Me.CompanyBindingNavigator.MovePreviousItem = Nothing
        Me.CompanyBindingNavigator.Name = "CompanyBindingNavigator"
        Me.CompanyBindingNavigator.PositionItem = Nothing
        Me.CompanyBindingNavigator.Size = New System.Drawing.Size(667, 25)
        Me.CompanyBindingNavigator.TabIndex = 0
        Me.CompanyBindingNavigator.Text = "BindingNavigator1"
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
        'CompanyBindingNavigatorSaveItem
        '
        Me.CompanyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CompanyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompanyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompanyBindingNavigatorSaveItem.Name = "CompanyBindingNavigatorSaveItem"
        Me.CompanyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CompanyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CompanyDataGridView
        '
        Me.CompanyDataGridView.AutoGenerateColumns = False
        Me.CompanyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CompanyDataGridView.DataSource = Me.CompanyBindingSource
        Me.CompanyDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CompanyDataGridView.Name = "CompanyDataGridView"
        Me.CompanyDataGridView.Size = New System.Drawing.Size(667, 297)
        Me.CompanyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CompanyCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CompanyCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CompanyName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CompanyName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Website"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Website"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ContactPerson"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "WeeklyOff"
        Me.DataGridViewTextBoxColumn7.HeaderText = "WeeklyOff"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 325)
        Me.Controls.Add(Me.CompanyDataGridView)
        Me.Controls.Add(Me.CompanyBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company"
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyBindingNavigator.ResumeLayout(False)
        Me.CompanyBindingNavigator.PerformLayout()
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyDataSet As KSoft_Inventory.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Inventory.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.CompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompanyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompanyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompanyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
