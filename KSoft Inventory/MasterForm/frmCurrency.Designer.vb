<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrency))
        Me.CurrencyDataSet = New KSoft_Inventory.CurrencyDataSet
        Me.CurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTableAdapter = New KSoft_Inventory.CurrencyDataSetTableAdapters.CurrencyTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.CurrencyDataSetTableAdapters.TableAdapterManager
        Me.CurrencyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CurrencyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CurrencyGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCurrencyId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCurrencySign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCurrencyName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIntegerPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDecimalPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExchangeInTaka = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.CurrencyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrencyBindingNavigator.SuspendLayout()
        CType(Me.CurrencyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CurrencyTableAdapter = Me.CurrencyTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.CurrencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CurrencyBindingNavigator
        '
        Me.CurrencyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CurrencyBindingNavigator.BindingSource = Me.CurrencyBindingSource
        Me.CurrencyBindingNavigator.CountItem = Nothing
        Me.CurrencyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CurrencyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CurrencyBindingNavigatorSaveItem})
        Me.CurrencyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CurrencyBindingNavigator.MoveFirstItem = Nothing
        Me.CurrencyBindingNavigator.MoveLastItem = Nothing
        Me.CurrencyBindingNavigator.MoveNextItem = Nothing
        Me.CurrencyBindingNavigator.MovePreviousItem = Nothing
        Me.CurrencyBindingNavigator.Name = "CurrencyBindingNavigator"
        Me.CurrencyBindingNavigator.PositionItem = Nothing
        Me.CurrencyBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.CurrencyBindingNavigator.TabIndex = 0
        Me.CurrencyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CurrencyBindingNavigatorSaveItem
        '
        Me.CurrencyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CurrencyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CurrencyBindingNavigatorSaveItem.Name = "CurrencyBindingNavigatorSaveItem"
        Me.CurrencyBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CurrencyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CurrencyGridControl
        '
        Me.CurrencyGridControl.DataSource = Me.CurrencyBindingSource
        Me.CurrencyGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrencyGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CurrencyGridControl.MainView = Me.GridView1
        Me.CurrencyGridControl.Name = "CurrencyGridControl"
        Me.CurrencyGridControl.Size = New System.Drawing.Size(792, 395)
        Me.CurrencyGridControl.TabIndex = 1
        Me.CurrencyGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCurrencyId, Me.colCurrencySign, Me.colCurrencyName, Me.colIntegerPart, Me.colDecimalPart, Me.colExchangeInTaka})
        Me.GridView1.GridControl = Me.CurrencyGridControl
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CurrencyGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colCurrencyId
        '
        Me.colCurrencyId.FieldName = "CurrencyId"
        Me.colCurrencyId.Name = "colCurrencyId"
        Me.colCurrencyId.OptionsColumn.ReadOnly = True
        '
        'colCurrencySign
        '
        Me.colCurrencySign.FieldName = "CurrencySign"
        Me.colCurrencySign.Name = "colCurrencySign"
        Me.colCurrencySign.Visible = True
        Me.colCurrencySign.VisibleIndex = 0
        '
        'colCurrencyName
        '
        Me.colCurrencyName.FieldName = "CurrencyName"
        Me.colCurrencyName.Name = "colCurrencyName"
        Me.colCurrencyName.Visible = True
        Me.colCurrencyName.VisibleIndex = 1
        '
        'colIntegerPart
        '
        Me.colIntegerPart.FieldName = "IntegerPart"
        Me.colIntegerPart.Name = "colIntegerPart"
        Me.colIntegerPart.Visible = True
        Me.colIntegerPart.VisibleIndex = 2
        '
        'colDecimalPart
        '
        Me.colDecimalPart.FieldName = "DecimalPart"
        Me.colDecimalPart.Name = "colDecimalPart"
        Me.colDecimalPart.Visible = True
        Me.colDecimalPart.VisibleIndex = 3
        '
        'colExchangeInTaka
        '
        Me.colExchangeInTaka.FieldName = "ExchangeInTaka"
        Me.colExchangeInTaka.Name = "colExchangeInTaka"
        Me.colExchangeInTaka.Visible = True
        Me.colExchangeInTaka.VisibleIndex = 4
        '
        'frmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 420)
        Me.Controls.Add(Me.CurrencyGridControl)
        Me.Controls.Add(Me.CurrencyBindingNavigator)
        Me.Name = "frmCurrency"
        Me.Text = "Currency"
        CType(Me.CurrencyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrencyBindingNavigator.ResumeLayout(False)
        Me.CurrencyBindingNavigator.PerformLayout()
        CType(Me.CurrencyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrencyDataSet As KSoft_Inventory.CurrencyDataSet
    Friend WithEvents CurrencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrencyTableAdapter As KSoft_Inventory.CurrencyDataSetTableAdapters.CurrencyTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.CurrencyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CurrencyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CurrencyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CurrencyGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCurrencyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencySign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntegerPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDecimalPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExchangeInTaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
