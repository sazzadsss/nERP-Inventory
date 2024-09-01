<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemList2
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.VItemListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrentPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VItemListDataSet = New KSoft_Inventory.vItemListDataSet
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ColumnComboBox = New System.Windows.Forms.ComboBox
        Me.VItemListTableAdapter = New KSoft_Inventory.vItemListDataSetTableAdapters.vItemListTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.vItemListDataSetTableAdapters.TableAdapterManager
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.VItemListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(577, 368)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'VItemListDataGridView
        '
        Me.VItemListDataGridView.AllowUserToAddRows = False
        Me.VItemListDataGridView.AllowUserToDeleteRows = False
        Me.VItemListDataGridView.AutoGenerateColumns = False
        Me.VItemListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.VItemListDataGridView.ColumnHeadersHeight = 35
        Me.VItemListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.VItemListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.SubCategoryName, Me.PreviousPrice, Me.CurrentPrice})
        Me.VItemListDataGridView.DataSource = Me.VItemListBindingSource
        Me.VItemListDataGridView.Location = New System.Drawing.Point(15, 54)
        Me.VItemListDataGridView.Name = "VItemListDataGridView"
        Me.VItemListDataGridView.ReadOnly = True
        Me.VItemListDataGridView.RowHeadersVisible = False
        Me.VItemListDataGridView.Size = New System.Drawing.Size(708, 308)
        Me.VItemListDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ItemId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ItemId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BrandCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'SubCategoryName
        '
        Me.SubCategoryName.DataPropertyName = "SubCategoryName"
        Me.SubCategoryName.HeaderText = "Sub Category"
        Me.SubCategoryName.Name = "SubCategoryName"
        Me.SubCategoryName.ReadOnly = True
        '
        'PreviousPrice
        '
        Me.PreviousPrice.DataPropertyName = "PreviousPrice"
        Me.PreviousPrice.HeaderText = "Previous Price"
        Me.PreviousPrice.Name = "PreviousPrice"
        Me.PreviousPrice.ReadOnly = True
        Me.PreviousPrice.Width = 75
        '
        'CurrentPrice
        '
        Me.CurrentPrice.DataPropertyName = "CurrentPrice"
        Me.CurrentPrice.HeaderText = "Current Price"
        Me.CurrentPrice.Name = "CurrentPrice"
        Me.CurrentPrice.ReadOnly = True
        Me.CurrentPrice.Width = 75
        '
        'VItemListBindingSource
        '
        Me.VItemListBindingSource.DataMember = "vItemList"
        Me.VItemListBindingSource.DataSource = Me.VItemListDataSet
        '
        'VItemListDataSet
        '
        Me.VItemListDataSet.DataSetName = "vItemListDataSet"
        Me.VItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(142, 27)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(192, 20)
        Me.SearchTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ColumnComboBox
        '
        Me.ColumnComboBox.FormattingEnabled = True
        Me.ColumnComboBox.Items.AddRange(New Object() {"Item Name", "Brand Code", "Category", "Sub Category"})
        Me.ColumnComboBox.Location = New System.Drawing.Point(15, 27)
        Me.ColumnComboBox.Name = "ColumnComboBox"
        Me.ColumnComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ColumnComboBox.TabIndex = 10
        '
        'VItemListTableAdapter
        '
        Me.VItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.vItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmItemList2
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(743, 409)
        Me.Controls.Add(Me.ColumnComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.VItemListDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemList2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item No Search Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.VItemListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents VItemListDataSet As KSoft_Inventory.vItemListDataSet
    Friend WithEvents VItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VItemListTableAdapter As KSoft_Inventory.vItemListDataSetTableAdapters.vItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.vItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VItemListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentPrice As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
