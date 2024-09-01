<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyer
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
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.BuyerDataSet = New KSoft_Inventory.BuyerDataSet
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.BuyerDataSetTableAdapters.TableAdapterManager
        Me.BuyerDataGridView = New System.Windows.Forms.DataGridView
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buyer Name"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Enabled = False
        Me.SearchTextBox.Location = New System.Drawing.Point(283, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(155, 20)
        Me.SearchTextBox.TabIndex = 16
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyerTableAdapter = Me.BuyerTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.BuyerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuyerDataGridView
        '
        Me.BuyerDataGridView.AllowUserToAddRows = False
        Me.BuyerDataGridView.AutoGenerateColumns = False
        Me.BuyerDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BuyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuyerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BuyerDataGridView.DataSource = Me.BuyerBindingSource
        Me.BuyerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BuyerDataGridView.Location = New System.Drawing.Point(0, 29)
        Me.BuyerDataGridView.Name = "BuyerDataGridView"
        Me.BuyerDataGridView.Size = New System.Drawing.Size(478, 241)
        Me.BuyerDataGridView.TabIndex = 18
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(478, 26)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BuyerCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BuyerCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BuyerName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BuyerName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmBuyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(478, 270)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.BuyerDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBuyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buyer"
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuyerDataSet As KSoft_Inventory.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Inventory.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.BuyerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuyerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
