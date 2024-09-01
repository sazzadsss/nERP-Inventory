<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderBookingMaster_ExportReport
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
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.OrderBookingMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBookingMasterDataSet = New KSoft_Inventory.OrderBookingMasterDataSet
        Me.fieldEX = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBuyerCode = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderQuantity = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldProgramNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStyleName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderReceiveDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPrintDetails = New DevExpress.XtraPivotGrid.PivotGridField
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.OrderBookingMasterTableAdapter = New KSoft_Inventory.OrderBookingMasterDataSetTableAdapters.OrderBookingMasterTableAdapter
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBookingMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBookingMasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
        '
        'fieldMonth
        '
        Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMonth.AreaIndex = 1
        Me.fieldMonth.Caption = "Month"
        Me.fieldMonth.CellFormat.FormatString = "MMM"
        Me.fieldMonth.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldMonth.FieldName = "Month"
        Me.fieldMonth.Name = "fieldMonth"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Appearance.HeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PivotGridControl1.Appearance.HeaderArea.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PivotGridControl1.Appearance.HeaderGroupLine.ForeColor = System.Drawing.Color.Black
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseForeColor = True
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.OrderBookingMasterBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldEX, Me.fieldYear, Me.fieldMonth, Me.fieldBuyerCode, Me.fieldOrderQuantity, Me.fieldProgramNo, Me.fieldStyleName, Me.fieldOrderReceiveDate, Me.fieldPrintDetails})
        PivotGridGroup1.Fields.Add(Me.fieldYear)
        PivotGridGroup1.Fields.Add(Me.fieldMonth)
        PivotGridGroup1.Hierarchy = Nothing
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 29)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.Size = New System.Drawing.Size(946, 434)
        Me.PivotGridControl1.TabIndex = 0
        '
        'OrderBookingMasterBindingSource
        '
        Me.OrderBookingMasterBindingSource.DataMember = "OrderBookingMaster"
        Me.OrderBookingMasterBindingSource.DataSource = Me.OrderBookingMasterDataSet
        '
        'OrderBookingMasterDataSet
        '
        Me.OrderBookingMasterDataSet.DataSetName = "OrderBookingMasterDataSet"
        Me.OrderBookingMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldEX
        '
        Me.fieldEX.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEX.AreaIndex = 0
        Me.fieldEX.Caption = "EX"
        Me.fieldEX.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldEX.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldEX.FieldName = "EX"
        Me.fieldEX.Name = "fieldEX"
        Me.fieldEX.Options.ShowTotals = False
        Me.fieldEX.ValueFormat.FormatString = """dd-MMM-yy'"
        Me.fieldEX.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldBuyerCode
        '
        Me.fieldBuyerCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyerCode.AreaIndex = 4
        Me.fieldBuyerCode.Caption = "Buyer Code"
        Me.fieldBuyerCode.FieldName = "BuyerCode"
        Me.fieldBuyerCode.Name = "fieldBuyerCode"
        '
        'fieldOrderQuantity
        '
        Me.fieldOrderQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOrderQuantity.AreaIndex = 0
        Me.fieldOrderQuantity.Caption = "Order Quantity"
        Me.fieldOrderQuantity.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity.Name = "fieldOrderQuantity"
        '
        'fieldProgramNo
        '
        Me.fieldProgramNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProgramNo.AreaIndex = 1
        Me.fieldProgramNo.Caption = "Program No"
        Me.fieldProgramNo.FieldName = "ProgramNo"
        Me.fieldProgramNo.Name = "fieldProgramNo"
        '
        'fieldStyleName
        '
        Me.fieldStyleName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStyleName.AreaIndex = 2
        Me.fieldStyleName.Caption = "Style Name"
        Me.fieldStyleName.FieldName = "StyleName"
        Me.fieldStyleName.Name = "fieldStyleName"
        '
        'fieldOrderReceiveDate
        '
        Me.fieldOrderReceiveDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldOrderReceiveDate.AreaIndex = 5
        Me.fieldOrderReceiveDate.Caption = "Order Receive Date"
        Me.fieldOrderReceiveDate.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldOrderReceiveDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldOrderReceiveDate.FieldName = "OrderReceiveDate"
        Me.fieldOrderReceiveDate.Name = "fieldOrderReceiveDate"
        '
        'fieldPrintDetails
        '
        Me.fieldPrintDetails.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPrintDetails.AreaIndex = 3
        Me.fieldPrintDetails.FieldName = "PrintDetails"
        Me.fieldPrintDetails.Name = "fieldPrintDetails"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "E&xport"
        '
        'OrderBookingMasterTableAdapter
        '
        Me.OrderBookingMasterTableAdapter.ClearBeforeFill = True
        '
        'frmOrderBookingMaster_Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 463)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmOrderBookingMaster_Export"
        Me.Text = "Order Booking Master Export"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBookingMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBookingMasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents OrderBookingMasterDataSet As KSoft_Inventory.OrderBookingMasterDataSet
    Friend WithEvents OrderBookingMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderBookingMasterTableAdapter As KSoft_Inventory.OrderBookingMasterDataSetTableAdapters.OrderBookingMasterTableAdapter
    Friend WithEvents fieldEX As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderReceiveDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldPrintDetails As DevExpress.XtraPivotGrid.PivotGridField
End Class
