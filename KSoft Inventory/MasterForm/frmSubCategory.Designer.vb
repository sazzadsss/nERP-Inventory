<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCategory
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.SubCategoryDataSetTableAdapters.TableAdapterManager
        Me.SubCategoryDataGridView = New System.Windows.Forms.DataGridView
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet
        Me.CategoryTableAdapter1 = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.CategoryId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(30, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Sub Category"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(299, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(229, 20)
        Me.SearchTextBox.TabIndex = 21
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SubCategoryLookupTableAdapter = Nothing
        Me.TableAdapterManager.SubCategoryTableAdapter = Me.SubCategoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.SubCategoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubCategoryDataGridView
        '
        Me.SubCategoryDataGridView.AllowUserToAddRows = False
        Me.SubCategoryDataGridView.AllowUserToDeleteRows = False
        Me.SubCategoryDataGridView.AutoGenerateColumns = False
        Me.SubCategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SubCategoryDataGridView.ColumnHeadersHeight = 25
        Me.SubCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SubCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SubCategoryDataGridView.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubCategoryDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.SubCategoryDataGridView.Name = "SubCategoryDataGridView"
        Me.SubCategoryDataGridView.Size = New System.Drawing.Size(544, 274)
        Me.SubCategoryDataGridView.TabIndex = 25
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter1
        '
        Me.CategoryTableAdapter1.ClearBeforeFill = True
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(147, 5)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 5, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.CancelLinkLabel.TabIndex = 6
        Me.CancelLinkLabel.TabStop = True
        Me.CancelLinkLabel.Text = "Cancel"
        Me.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(96, 5)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 5, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 4
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 5)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.NewLinkLabel.Name = "NewLinkLabel"
        Me.NewLinkLabel.Size = New System.Drawing.Size(26, 13)
        Me.NewLinkLabel.TabIndex = 3
        Me.NewLinkLabel.TabStop = True
        Me.NewLinkLabel.Text = "Add"
        Me.NewLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Location = New System.Drawing.Point(57, 5)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 9
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SearchTextBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(544, 26)
        Me.FlowLayoutPanel1.TabIndex = 27
        '
        'CategoryId
        '
        Me.CategoryId.DataPropertyName = "CategoryId"
        Me.CategoryId.DataSource = Me.CategoryBindingSource
        Me.CategoryId.DisplayMember = "CategoryName"
        Me.CategoryId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CategoryId.HeaderText = "Category Name"
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CategoryId.ValueMember = "CategoryId"
        Me.CategoryId.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SubCategoryName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sub Category Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SubCategoryDescription"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub Category Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(544, 301)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SubCategoryDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sub Category"
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents CategoryTableAdapter As ECHO_PRINTING.SubCategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents SubCategoryDataSet As KSoft_Inventory.SubCategoryDataSet
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.SubCategoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubCategoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CategoryDataSet As KSoft_Inventory.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter1 As KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CategoryId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
