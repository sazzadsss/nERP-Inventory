<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishFabricBookingClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinishFabricBookingClosing))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colIsClose = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FinishFabricBookingDataSet = New KSoft_Inventory.FinishFabricBookingDataSet
        Me.FinishFabricBookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricBookingTableAdapter = New KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.FinishFabricBookingTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.TableAdapterManager
        Me.FinishFabricBookingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FinishFabricBookingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FinishFabricBookingGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsDevelopment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsGreigeClose = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.FinishFabricBookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinishFabricBookingBindingNavigator.SuspendLayout()
        CType(Me.FinishFabricBookingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colIsClose
        '
        Me.colIsClose.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsClose.AppearanceCell.Options.UseBackColor = True
        Me.colIsClose.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsClose.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsClose.FieldName = "IsClose"
        Me.colIsClose.Name = "colIsClose"
        Me.colIsClose.Visible = True
        Me.colIsClose.VisibleIndex = 4
        Me.colIsClose.Width = 97
        '
        'FinishFabricBookingDataSet
        '
        Me.FinishFabricBookingDataSet.DataSetName = "FinishFabricBookingDataSet"
        Me.FinishFabricBookingDataSet.EnforceConstraints = False
        Me.FinishFabricBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingBindingSource
        '
        Me.FinishFabricBookingBindingSource.DataMember = "FinishFabricBooking"
        Me.FinishFabricBookingBindingSource.DataSource = Me.FinishFabricBookingDataSet
        '
        'FinishFabricBookingTableAdapter
        '
        Me.FinishFabricBookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishFabricBookingDetailsTableAdapter = Nothing
        Me.TableAdapterManager.FinishFabricBookingTableAdapter = Me.FinishFabricBookingTableAdapter
        Me.TableAdapterManager.GreyFabricTableAdapter = Nothing
        Me.TableAdapterManager.KnittingPlanningTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationTableAdapter = Nothing
        Me.TableAdapterManager.YarnLotAllocationTableAdapter = Nothing
        '
        'FinishFabricBookingBindingNavigator
        '
        Me.FinishFabricBookingBindingNavigator.AddNewItem = Nothing
        Me.FinishFabricBookingBindingNavigator.BindingSource = Me.FinishFabricBookingBindingSource
        Me.FinishFabricBookingBindingNavigator.CountItem = Nothing
        Me.FinishFabricBookingBindingNavigator.DeleteItem = Nothing
        Me.FinishFabricBookingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator2, Me.FinishFabricBookingBindingNavigatorSaveItem})
        Me.FinishFabricBookingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinishFabricBookingBindingNavigator.MoveFirstItem = Nothing
        Me.FinishFabricBookingBindingNavigator.MoveLastItem = Nothing
        Me.FinishFabricBookingBindingNavigator.MoveNextItem = Nothing
        Me.FinishFabricBookingBindingNavigator.MovePreviousItem = Nothing
        Me.FinishFabricBookingBindingNavigator.Name = "FinishFabricBookingBindingNavigator"
        Me.FinishFabricBookingBindingNavigator.PositionItem = Nothing
        Me.FinishFabricBookingBindingNavigator.Size = New System.Drawing.Size(711, 25)
        Me.FinishFabricBookingBindingNavigator.TabIndex = 0
        Me.FinishFabricBookingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FinishFabricBookingBindingNavigatorSaveItem
        '
        Me.FinishFabricBookingBindingNavigatorSaveItem.Image = CType(resources.GetObject("FinishFabricBookingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinishFabricBookingBindingNavigatorSaveItem.Name = "FinishFabricBookingBindingNavigatorSaveItem"
        Me.FinishFabricBookingBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FinishFabricBookingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FinishFabricBookingGridControl
        '
        Me.FinishFabricBookingGridControl.DataSource = Me.FinishFabricBookingBindingSource
        Me.FinishFabricBookingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinishFabricBookingGridControl.Location = New System.Drawing.Point(0, 25)
        Me.FinishFabricBookingGridControl.MainView = Me.GridView1
        Me.FinishFabricBookingGridControl.Name = "FinishFabricBookingGridControl"
        Me.FinishFabricBookingGridControl.Size = New System.Drawing.Size(711, 337)
        Me.FinishFabricBookingGridControl.TabIndex = 1
        Me.FinishFabricBookingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colBuyerName, Me.colIsDevelopment, Me.colIsClose, Me.colIsGreigeClose})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colIsClose
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.FinishFabricBookingGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colProgramNo.AppearanceCell.Options.UseBackColor = True
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsColumn.ReadOnly = True
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        Me.colProgramNo.Width = 167
        '
        'colBuyerName
        '
        Me.colBuyerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colBuyerName.AppearanceCell.Options.UseBackColor = True
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.OptionsColumn.AllowEdit = False
        Me.colBuyerName.OptionsColumn.ReadOnly = True
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        Me.colBuyerName.Width = 242
        '
        'colIsDevelopment
        '
        Me.colIsDevelopment.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colIsDevelopment.AppearanceCell.Options.UseBackColor = True
        Me.colIsDevelopment.FieldName = "IsDevelopment"
        Me.colIsDevelopment.Name = "colIsDevelopment"
        Me.colIsDevelopment.OptionsColumn.AllowEdit = False
        Me.colIsDevelopment.OptionsColumn.ReadOnly = True
        Me.colIsDevelopment.Visible = True
        Me.colIsDevelopment.VisibleIndex = 0
        Me.colIsDevelopment.Width = 91
        '
        'colIsGreigeClose
        '
        Me.colIsGreigeClose.FieldName = "IsGreigeClose"
        Me.colIsGreigeClose.Name = "colIsGreigeClose"
        Me.colIsGreigeClose.Visible = True
        Me.colIsGreigeClose.VisibleIndex = 3
        Me.colIsGreigeClose.Width = 96
        '
        'frmFinishFabricBookingClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 362)
        Me.Controls.Add(Me.FinishFabricBookingGridControl)
        Me.Controls.Add(Me.FinishFabricBookingBindingNavigator)
        Me.Name = "frmFinishFabricBookingClosing"
        Me.Text = "Finish Fabric Booking Closing"
        CType(Me.FinishFabricBookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinishFabricBookingBindingNavigator.ResumeLayout(False)
        Me.FinishFabricBookingBindingNavigator.PerformLayout()
        CType(Me.FinishFabricBookingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinishFabricBookingDataSet As KSoft_Inventory.FinishFabricBookingDataSet
    Friend WithEvents FinishFabricBookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricBookingTableAdapter As KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.FinishFabricBookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.FinishFabricBookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishFabricBookingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FinishFabricBookingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FinishFabricBookingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDevelopment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsGreigeClose As DevExpress.XtraGrid.Columns.GridColumn
End Class
