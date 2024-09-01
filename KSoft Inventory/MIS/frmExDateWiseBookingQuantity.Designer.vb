<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExDateWiseBookingQuantity
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
        Me.CriticalPathFinishFabricDataSet = New KSoft_Inventory.CriticalPathFinishFabricDataSet
        Me.CriticalPathMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriticalPath_MainTableAdapter = New KSoft_Inventory.CriticalPathFinishFabricDataSetTableAdapters.CriticalPath_MainTableAdapter
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldCriticalPathId = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldProgramNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBuyer = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStyle = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricColorName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldColorLD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricType = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricComposition = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldYarnCount = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFGSM = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricBookingDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldLastAmendmentDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricRequireDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldExDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderQuantity = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldConsumption = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFinishQuantity = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGreyQuantity = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIsComplete = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ExportButton = New System.Windows.Forms.Button
        CType(Me.CriticalPathFinishFabricDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriticalPathMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CriticalPathFinishFabricDataSet
        '
        Me.CriticalPathFinishFabricDataSet.DataSetName = "CriticalPathFinishFabricDataSet"
        Me.CriticalPathFinishFabricDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CriticalPathMainBindingSource
        '
        Me.CriticalPathMainBindingSource.DataMember = "CriticalPath_Main"
        Me.CriticalPathMainBindingSource.DataSource = Me.CriticalPathFinishFabricDataSet
        '
        'CriticalPath_MainTableAdapter
        '
        Me.CriticalPath_MainTableAdapter.ClearBeforeFill = True
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.CriticalPathMainBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCriticalPathId, Me.fieldProgramNo, Me.fieldBuyer, Me.fieldStyle, Me.fieldFabricColorName, Me.fieldColorLD, Me.fieldFabricType, Me.fieldFabricComposition, Me.fieldYarnCount, Me.fieldFGSM, Me.fieldFabricBookingDate, Me.fieldLastAmendmentDate, Me.fieldFabricRequireDate, Me.fieldExDate, Me.fieldOrderQuantity, Me.fieldConsumption, Me.fieldFinishQuantity, Me.fieldGreyQuantity, Me.fieldIsComplete})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 35)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(796, 438)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldCriticalPathId
        '
        Me.fieldCriticalPathId.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCriticalPathId.AreaIndex = 0
        Me.fieldCriticalPathId.Caption = "Critical Path Id"
        Me.fieldCriticalPathId.FieldName = "CriticalPathId"
        Me.fieldCriticalPathId.Name = "fieldCriticalPathId"
        Me.fieldCriticalPathId.Visible = False
        '
        'fieldProgramNo
        '
        Me.fieldProgramNo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldProgramNo.AreaIndex = 0
        Me.fieldProgramNo.Caption = "Program No"
        Me.fieldProgramNo.FieldName = "ProgramNo"
        Me.fieldProgramNo.Name = "fieldProgramNo"
        Me.fieldProgramNo.Visible = False
        '
        'fieldBuyer
        '
        Me.fieldBuyer.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldBuyer.AreaIndex = 0
        Me.fieldBuyer.Caption = "Buyer"
        Me.fieldBuyer.FieldName = "Buyer"
        Me.fieldBuyer.Name = "fieldBuyer"
        Me.fieldBuyer.Visible = False
        '
        'fieldStyle
        '
        Me.fieldStyle.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldStyle.AreaIndex = 1
        Me.fieldStyle.Caption = "Style"
        Me.fieldStyle.FieldName = "Style"
        Me.fieldStyle.Name = "fieldStyle"
        Me.fieldStyle.Visible = False
        '
        'fieldFabricColorName
        '
        Me.fieldFabricColorName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFabricColorName.AreaIndex = 2
        Me.fieldFabricColorName.Caption = "Fabric Color Name"
        Me.fieldFabricColorName.FieldName = "FabricColorName"
        Me.fieldFabricColorName.Name = "fieldFabricColorName"
        Me.fieldFabricColorName.Visible = False
        '
        'fieldColorLD
        '
        Me.fieldColorLD.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldColorLD.AreaIndex = 3
        Me.fieldColorLD.Caption = "Color LD"
        Me.fieldColorLD.FieldName = "ColorLD"
        Me.fieldColorLD.Name = "fieldColorLD"
        Me.fieldColorLD.Visible = False
        '
        'fieldFabricType
        '
        Me.fieldFabricType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFabricType.AreaIndex = 0
        Me.fieldFabricType.Caption = "Fabric Type"
        Me.fieldFabricType.FieldName = "FabricType"
        Me.fieldFabricType.Name = "fieldFabricType"
        '
        'fieldFabricComposition
        '
        Me.fieldFabricComposition.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFabricComposition.AreaIndex = 4
        Me.fieldFabricComposition.Caption = "Fabric Composition"
        Me.fieldFabricComposition.FieldName = "FabricComposition"
        Me.fieldFabricComposition.Name = "fieldFabricComposition"
        Me.fieldFabricComposition.Visible = False
        '
        'fieldYarnCount
        '
        Me.fieldYarnCount.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldYarnCount.AreaIndex = 5
        Me.fieldYarnCount.Caption = "Yarn Count"
        Me.fieldYarnCount.FieldName = "YarnCount"
        Me.fieldYarnCount.Name = "fieldYarnCount"
        Me.fieldYarnCount.Visible = False
        '
        'fieldFGSM
        '
        Me.fieldFGSM.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFGSM.AreaIndex = 6
        Me.fieldFGSM.Caption = "FGSM"
        Me.fieldFGSM.FieldName = "FGSM"
        Me.fieldFGSM.Name = "fieldFGSM"
        Me.fieldFGSM.Visible = False
        '
        'fieldFabricBookingDate
        '
        Me.fieldFabricBookingDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFabricBookingDate.AreaIndex = 6
        Me.fieldFabricBookingDate.Caption = "Fabric Booking Date"
        Me.fieldFabricBookingDate.FieldName = "FabricBookingDate"
        Me.fieldFabricBookingDate.Name = "fieldFabricBookingDate"
        Me.fieldFabricBookingDate.Visible = False
        '
        'fieldLastAmendmentDate
        '
        Me.fieldLastAmendmentDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldLastAmendmentDate.AreaIndex = 0
        Me.fieldLastAmendmentDate.Caption = "Last Amendment Date"
        Me.fieldLastAmendmentDate.FieldName = "LastAmendmentDate"
        Me.fieldLastAmendmentDate.Name = "fieldLastAmendmentDate"
        Me.fieldLastAmendmentDate.Visible = False
        '
        'fieldFabricRequireDate
        '
        Me.fieldFabricRequireDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFabricRequireDate.AreaIndex = 0
        Me.fieldFabricRequireDate.Caption = "Fabric Require Date"
        Me.fieldFabricRequireDate.FieldName = "FabricRequireDate"
        Me.fieldFabricRequireDate.Name = "fieldFabricRequireDate"
        Me.fieldFabricRequireDate.Visible = False
        '
        'fieldExDate
        '
        Me.fieldExDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldExDate.AreaIndex = 0
        Me.fieldExDate.Caption = "Ex Date"
        Me.fieldExDate.FieldName = "ExDate"
        Me.fieldExDate.Name = "fieldExDate"
        Me.fieldExDate.ValueFormat.FormatString = "dd-MMM-yy"
        Me.fieldExDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldOrderQuantity
        '
        Me.fieldOrderQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldOrderQuantity.AreaIndex = 14
        Me.fieldOrderQuantity.Caption = "Order Quantity"
        Me.fieldOrderQuantity.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity.Name = "fieldOrderQuantity"
        Me.fieldOrderQuantity.Visible = False
        '
        'fieldConsumption
        '
        Me.fieldConsumption.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldConsumption.AreaIndex = 15
        Me.fieldConsumption.Caption = "Consumption"
        Me.fieldConsumption.FieldName = "Consumption"
        Me.fieldConsumption.Name = "fieldConsumption"
        Me.fieldConsumption.Visible = False
        '
        'fieldFinishQuantity
        '
        Me.fieldFinishQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFinishQuantity.AreaIndex = 16
        Me.fieldFinishQuantity.Caption = "Finish Quantity"
        Me.fieldFinishQuantity.FieldName = "FinishQuantity"
        Me.fieldFinishQuantity.Name = "fieldFinishQuantity"
        Me.fieldFinishQuantity.Visible = False
        '
        'fieldGreyQuantity
        '
        Me.fieldGreyQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldGreyQuantity.AreaIndex = 0
        Me.fieldGreyQuantity.Caption = "Grey Quantity"
        Me.fieldGreyQuantity.CellFormat.FormatString = "n"
        Me.fieldGreyQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldGreyQuantity.FieldName = "GreyQuantity"
        Me.fieldGreyQuantity.Name = "fieldGreyQuantity"
        Me.fieldGreyQuantity.TotalValueFormat.FormatString = "n"
        Me.fieldGreyQuantity.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldGreyQuantity.ValueFormat.FormatString = "n"
        Me.fieldGreyQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldIsComplete
        '
        Me.fieldIsComplete.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldIsComplete.AreaIndex = 18
        Me.fieldIsComplete.Caption = "Is Complete"
        Me.fieldIsComplete.FieldName = "IsComplete"
        Me.fieldIsComplete.Name = "fieldIsComplete"
        Me.fieldIsComplete.Visible = False
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(12, 6)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 1
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'frmExDateWiseBookingQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 473)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmExDateWiseBookingQuantity"
        Me.Text = "Ex Date Wise Booking Quantity"
        CType(Me.CriticalPathFinishFabricDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriticalPathMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CriticalPathFinishFabricDataSet As KSoft_Inventory.CriticalPathFinishFabricDataSet
    Friend WithEvents CriticalPathMainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CriticalPath_MainTableAdapter As KSoft_Inventory.CriticalPathFinishFabricDataSetTableAdapters.CriticalPath_MainTableAdapter
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldCriticalPathId As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyer As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyle As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricColorName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldColorLD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricType As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricComposition As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYarnCount As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFGSM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricBookingDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLastAmendmentDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricRequireDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldExDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldConsumption As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinishQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGreyQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsComplete As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ExportButton As System.Windows.Forms.Button
End Class
