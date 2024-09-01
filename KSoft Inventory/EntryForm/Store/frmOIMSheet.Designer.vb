<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOIMSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOIMSheet))
        Me.OIM_SheetDataSet = New KSoft_Inventory.OIM_SheetDataSet
        Me.OIM_SHEETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OIM_SHEETTableAdapter = New KSoft_Inventory.OIM_SheetDataSetTableAdapters.OIM_SHEETTableAdapter
        Me.TableAdapterManager = New KSoft_Inventory.OIM_SheetDataSetTableAdapters.TableAdapterManager
        Me.OIM_SHEETBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.OIM_SHEETBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OIMPendingToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AcknowledgementPendingToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AllToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ReceiveAcknowledgeToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OIM_SHEETGridControl = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colOIM_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSLNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPO_DATE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colESL_REF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSTYLE_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOIM_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOIM_DATE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPO_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBARCHODE_PRICE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCOMMENTS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPO_TYPE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colIS_ACKNOWLEDGEMENT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colACKNOWLEDGEMENTDATE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBARCODE_RECEIVED = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBARCODE_DELIVERED = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDeliveredBy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colDESCRIPTION = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFABRIC_DESCRIPTION = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCOLOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCOLOR_CODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLAB_DIP_REF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colORDER_QUANTITY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSEAL_BY_DATE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colEX_FACTORY_DATE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMUST_EX_BD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPACK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTTL_PACKS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFOB_PRICE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDESTINATION = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colADDRESS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTABTEST = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPRINT_LINE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIS_OIMRECEIVED = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIS_BARCHODERECEIVED = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ReceivedComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.OIM_SheetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OIM_SHEETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OIM_SHEETBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OIM_SHEETBindingNavigator.SuspendLayout()
        CType(Me.OIM_SHEETGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivedComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OIM_SheetDataSet
        '
        Me.OIM_SheetDataSet.DataSetName = "OIM_SheetDataSet"
        Me.OIM_SheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OIM_SHEETBindingSource
        '
        Me.OIM_SHEETBindingSource.DataMember = "OIM_SHEET"
        Me.OIM_SHEETBindingSource.DataSource = Me.OIM_SheetDataSet
        '
        'OIM_SHEETTableAdapter
        '
        Me.OIM_SHEETTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OIM_SHEETTableAdapter = Me.OIM_SHEETTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.OIM_SheetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OIM_SHEETBindingNavigator
        '
        Me.OIM_SHEETBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OIM_SHEETBindingNavigator.AutoSize = False
        Me.OIM_SHEETBindingNavigator.BindingSource = Me.OIM_SHEETBindingSource
        Me.OIM_SHEETBindingNavigator.CountItem = Nothing
        Me.OIM_SHEETBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OIM_SHEETBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.BindingNavigatorAddNewItem, Me.OIM_SHEETBindingNavigatorSaveItem, Me.ExportToolStripButton, Me.CopyToolStripButton, Me.OIMPendingToolStripButton, Me.AcknowledgementPendingToolStripButton, Me.AllToolStripButton, Me.ReceiveAcknowledgeToolStripButton})
        Me.OIM_SHEETBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OIM_SHEETBindingNavigator.MoveFirstItem = Nothing
        Me.OIM_SHEETBindingNavigator.MoveLastItem = Nothing
        Me.OIM_SHEETBindingNavigator.MoveNextItem = Nothing
        Me.OIM_SHEETBindingNavigator.MovePreviousItem = Nothing
        Me.OIM_SHEETBindingNavigator.Name = "OIM_SHEETBindingNavigator"
        Me.OIM_SHEETBindingNavigator.PositionItem = Nothing
        Me.OIM_SHEETBindingNavigator.Size = New System.Drawing.Size(1007, 33)
        Me.OIM_SHEETBindingNavigator.TabIndex = 0
        Me.OIM_SHEETBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 30)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 30)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'OIM_SHEETBindingNavigatorSaveItem
        '
        Me.OIM_SHEETBindingNavigatorSaveItem.Image = CType(resources.GetObject("OIM_SHEETBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OIM_SHEETBindingNavigatorSaveItem.Name = "OIM_SHEETBindingNavigatorSaveItem"
        Me.OIM_SHEETBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 30)
        Me.OIM_SHEETBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(96, 30)
        Me.ExportToolStripButton.Text = "Print Preview"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.Image = Global.KSoft_Inventory.My.Resources.Resources.CopyIcon
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(55, 30)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'OIMPendingToolStripButton
        '
        Me.OIMPendingToolStripButton.Image = CType(resources.GetObject("OIMPendingToolStripButton.Image"), System.Drawing.Image)
        Me.OIMPendingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OIMPendingToolStripButton.Name = "OIMPendingToolStripButton"
        Me.OIMPendingToolStripButton.Size = New System.Drawing.Size(129, 30)
        Me.OIMPendingToolStripButton.Text = "Show OIM Pending"
        '
        'AcknowledgementPendingToolStripButton
        '
        Me.AcknowledgementPendingToolStripButton.Image = CType(resources.GetObject("AcknowledgementPendingToolStripButton.Image"), System.Drawing.Image)
        Me.AcknowledgementPendingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AcknowledgementPendingToolStripButton.Name = "AcknowledgementPendingToolStripButton"
        Me.AcknowledgementPendingToolStripButton.Size = New System.Drawing.Size(206, 30)
        Me.AcknowledgementPendingToolStripButton.Text = "Show Acknowledgement Pending"
        '
        'AllToolStripButton
        '
        Me.AllToolStripButton.Image = CType(resources.GetObject("AllToolStripButton.Image"), System.Drawing.Image)
        Me.AllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AllToolStripButton.Name = "AllToolStripButton"
        Me.AllToolStripButton.Size = New System.Drawing.Size(73, 30)
        Me.AllToolStripButton.Text = "Show All"
        '
        'ReceiveAcknowledgeToolStripButton
        '
        Me.ReceiveAcknowledgeToolStripButton.Image = CType(resources.GetObject("ReceiveAcknowledgeToolStripButton.Image"), System.Drawing.Image)
        Me.ReceiveAcknowledgeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReceiveAcknowledgeToolStripButton.Name = "ReceiveAcknowledgeToolStripButton"
        Me.ReceiveAcknowledgeToolStripButton.Size = New System.Drawing.Size(160, 30)
        Me.ReceiveAcknowledgeToolStripButton.Text = "ReceiveAcknowlegement"
        '
        'OIM_SHEETGridControl
        '
        Me.OIM_SHEETGridControl.DataSource = Me.OIM_SHEETBindingSource
        Me.OIM_SHEETGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OIM_SHEETGridControl.Location = New System.Drawing.Point(0, 33)
        Me.OIM_SHEETGridControl.LookAndFeel.SkinName = "Money Twins"
        Me.OIM_SHEETGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OIM_SHEETGridControl.MainView = Me.BandedGridView1
        Me.OIM_SHEETGridControl.Name = "OIM_SHEETGridControl"
        Me.OIM_SHEETGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ReceivedComboBox, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2})
        Me.OIM_SHEETGridControl.Size = New System.Drawing.Size(1007, 440)
        Me.OIM_SHEETGridControl.TabIndex = 1
        Me.OIM_SHEETGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand5, Me.GridBand6})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colOIM_ID, Me.colOIM_NO, Me.colPO_DATE, Me.colESL_REF, Me.colSTYLE_NO, Me.colDESCRIPTION, Me.colFABRIC_DESCRIPTION, Me.colPO_NO, Me.colCOLOR, Me.colCOLOR_CODE, Me.colLAB_DIP_REF, Me.colORDER_QUANTITY, Me.colSEAL_BY_DATE, Me.colEX_FACTORY_DATE, Me.colMUST_EX_BD, Me.colMODE, Me.colPACK, Me.colBARCHODE_PRICE, Me.colTTL_PACKS, Me.colFOB_PRICE, Me.colPO_TYPE, Me.colDESTINATION, Me.colADDRESS, Me.colTABTEST, Me.colCOMMENTS, Me.colACKNOWLEDGEMENTDATE, Me.colOIM_DATE, Me.colIS_ACKNOWLEDGEMENT, Me.colSLNO, Me.colBARCODE_RECEIVED, Me.colBARCODE_DELIVERED, Me.colPRINT_LINE, Me.colDeliveredBy, Me.colIS_OIMRECEIVED, Me.colProgramNo, Me.colIS_BARCHODERECEIVED})
        Me.BandedGridView1.GridControl = Me.OIM_SHEETGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsCustomization.AllowGroup = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOIM_NO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "OIM_INFORMATION"
        Me.GridBand1.Columns.Add(Me.colOIM_ID)
        Me.GridBand1.Columns.Add(Me.colSLNO)
        Me.GridBand1.Columns.Add(Me.colPO_DATE)
        Me.GridBand1.Columns.Add(Me.colESL_REF)
        Me.GridBand1.Columns.Add(Me.colSTYLE_NO)
        Me.GridBand1.Columns.Add(Me.colOIM_NO)
        Me.GridBand1.Columns.Add(Me.colOIM_DATE)
        Me.GridBand1.Columns.Add(Me.colPO_NO)
        Me.GridBand1.Columns.Add(Me.colProgramNo)
        Me.GridBand1.Columns.Add(Me.colBARCHODE_PRICE)
        Me.GridBand1.Columns.Add(Me.colCOMMENTS)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 861
        '
        'colOIM_ID
        '
        Me.colOIM_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.colOIM_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOIM_ID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOIM_ID.FieldName = "OIM_ID"
        Me.colOIM_ID.Name = "colOIM_ID"
        Me.colOIM_ID.OptionsColumn.ReadOnly = True
        '
        'colSLNO
        '
        Me.colSLNO.FieldName = "SLNO"
        Me.colSLNO.Name = "colSLNO"
        Me.colSLNO.Visible = True
        Me.colSLNO.Width = 56
        '
        'colPO_DATE
        '
        Me.colPO_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.colPO_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO_DATE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPO_DATE.FieldName = "PO_DATE"
        Me.colPO_DATE.Name = "colPO_DATE"
        Me.colPO_DATE.Visible = True
        '
        'colESL_REF
        '
        Me.colESL_REF.AppearanceHeader.Options.UseTextOptions = True
        Me.colESL_REF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colESL_REF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colESL_REF.AutoFillDown = True
        Me.colESL_REF.FieldName = "ESL_REF"
        Me.colESL_REF.Name = "colESL_REF"
        Me.colESL_REF.Visible = True
        Me.colESL_REF.Width = 92
        '
        'colSTYLE_NO
        '
        Me.colSTYLE_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.colSTYLE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSTYLE_NO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSTYLE_NO.AutoFillDown = True
        Me.colSTYLE_NO.FieldName = "STYLE_NO"
        Me.colSTYLE_NO.Name = "colSTYLE_NO"
        Me.colSTYLE_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSTYLE_NO.Visible = True
        '
        'colOIM_NO
        '
        Me.colOIM_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.colOIM_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOIM_NO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOIM_NO.FieldName = "OIM_NO"
        Me.colOIM_NO.Name = "colOIM_NO"
        Me.colOIM_NO.Visible = True
        Me.colOIM_NO.Width = 86
        '
        'colOIM_DATE
        '
        Me.colOIM_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.colOIM_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOIM_DATE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOIM_DATE.FieldName = "OIM_DATE"
        Me.colOIM_DATE.Name = "colOIM_DATE"
        Me.colOIM_DATE.Visible = True
        '
        'colPO_NO
        '
        Me.colPO_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPO_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO_NO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPO_NO.FieldName = "PO_NO"
        Me.colPO_NO.Name = "colPO_NO"
        Me.colPO_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPO_NO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colPO_NO.Visible = True
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.Caption = "PROGRAM NO"
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.Width = 87
        '
        'colBARCHODE_PRICE
        '
        Me.colBARCHODE_PRICE.AppearanceHeader.Options.UseTextOptions = True
        Me.colBARCHODE_PRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBARCHODE_PRICE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBARCHODE_PRICE.FieldName = "BARCHODE_PRICE"
        Me.colBARCHODE_PRICE.Name = "colBARCHODE_PRICE"
        Me.colBARCHODE_PRICE.Visible = True
        Me.colBARCHODE_PRICE.Width = 129
        '
        'colCOMMENTS
        '
        Me.colCOMMENTS.AppearanceHeader.Options.UseTextOptions = True
        Me.colCOMMENTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOMMENTS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCOMMENTS.FieldName = "COMMENTS"
        Me.colCOMMENTS.Name = "colCOMMENTS"
        Me.colCOMMENTS.Visible = True
        Me.colCOMMENTS.Width = 111
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "PO_INFORMATION"
        Me.GridBand2.Columns.Add(Me.colPO_TYPE)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Visible = False
        Me.GridBand2.Width = 75
        '
        'colPO_TYPE
        '
        Me.colPO_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.colPO_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO_TYPE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPO_TYPE.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colPO_TYPE.FieldName = "PO_TYPE"
        Me.colPO_TYPE.Name = "colPO_TYPE"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"New", "Repeat"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "ACKNOWLEDGEMENT/PACKING"
        Me.GridBand3.Columns.Add(Me.colIS_ACKNOWLEDGEMENT)
        Me.GridBand3.Columns.Add(Me.colACKNOWLEDGEMENTDATE)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 175
        '
        'colIS_ACKNOWLEDGEMENT
        '
        Me.colIS_ACKNOWLEDGEMENT.AppearanceHeader.Options.UseTextOptions = True
        Me.colIS_ACKNOWLEDGEMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIS_ACKNOWLEDGEMENT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIS_ACKNOWLEDGEMENT.Caption = "IS RECEIVED ?"
        Me.colIS_ACKNOWLEDGEMENT.FieldName = "IS_ACKNOWLEDGEMENT"
        Me.colIS_ACKNOWLEDGEMENT.Name = "colIS_ACKNOWLEDGEMENT"
        Me.colIS_ACKNOWLEDGEMENT.Visible = True
        Me.colIS_ACKNOWLEDGEMENT.Width = 100
        '
        'colACKNOWLEDGEMENTDATE
        '
        Me.colACKNOWLEDGEMENTDATE.AppearanceHeader.Options.UseTextOptions = True
        Me.colACKNOWLEDGEMENTDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colACKNOWLEDGEMENTDATE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colACKNOWLEDGEMENTDATE.Caption = "DATE"
        Me.colACKNOWLEDGEMENTDATE.FieldName = "ACKNOWLEDGEMENTDATE"
        Me.colACKNOWLEDGEMENTDATE.Name = "colACKNOWLEDGEMENTDATE"
        Me.colACKNOWLEDGEMENTDATE.Visible = True
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "COMMENTS"
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Visible = False
        Me.GridBand5.Width = 111
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "BARCODE"
        Me.GridBand6.Columns.Add(Me.colBARCODE_RECEIVED)
        Me.GridBand6.Columns.Add(Me.colBARCODE_DELIVERED)
        Me.GridBand6.Columns.Add(Me.colDeliveredBy)
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 256
        '
        'colBARCODE_RECEIVED
        '
        Me.colBARCODE_RECEIVED.AppearanceHeader.Options.UseTextOptions = True
        Me.colBARCODE_RECEIVED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBARCODE_RECEIVED.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBARCODE_RECEIVED.Caption = "RECEIVED"
        Me.colBARCODE_RECEIVED.FieldName = "BARCODE_RECEIVED"
        Me.colBARCODE_RECEIVED.Name = "colBARCODE_RECEIVED"
        Me.colBARCODE_RECEIVED.Visible = True
        Me.colBARCODE_RECEIVED.Width = 85
        '
        'colBARCODE_DELIVERED
        '
        Me.colBARCODE_DELIVERED.AppearanceHeader.Options.UseTextOptions = True
        Me.colBARCODE_DELIVERED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBARCODE_DELIVERED.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBARCODE_DELIVERED.Caption = "DELIVERED"
        Me.colBARCODE_DELIVERED.FieldName = "BARCODE_DELIVERED"
        Me.colBARCODE_DELIVERED.Name = "colBARCODE_DELIVERED"
        Me.colBARCODE_DELIVERED.Visible = True
        Me.colBARCODE_DELIVERED.Width = 85
        '
        'colDeliveredBy
        '
        Me.colDeliveredBy.Caption = "DELIVERED BY"
        Me.colDeliveredBy.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colDeliveredBy.FieldName = "DeliveredBy"
        Me.colDeliveredBy.Name = "colDeliveredBy"
        Me.colDeliveredBy.Visible = True
        Me.colDeliveredBy.Width = 86
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"YASIN", "DELWAR", "SHAHED", "ROKON"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colDESCRIPTION
        '
        Me.colDESCRIPTION.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESCRIPTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDESCRIPTION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDESCRIPTION.FieldName = "DESCRIPTION"
        Me.colDESCRIPTION.Name = "colDESCRIPTION"
        Me.colDESCRIPTION.Width = 101
        '
        'colFABRIC_DESCRIPTION
        '
        Me.colFABRIC_DESCRIPTION.AppearanceHeader.Options.UseTextOptions = True
        Me.colFABRIC_DESCRIPTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFABRIC_DESCRIPTION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFABRIC_DESCRIPTION.FieldName = "FABRIC_DESCRIPTION"
        Me.colFABRIC_DESCRIPTION.Name = "colFABRIC_DESCRIPTION"
        Me.colFABRIC_DESCRIPTION.Width = 151
        '
        'colCOLOR
        '
        Me.colCOLOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colCOLOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOLOR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCOLOR.FieldName = "COLOR"
        Me.colCOLOR.Name = "colCOLOR"
        Me.colCOLOR.Visible = True
        Me.colCOLOR.Width = 149
        '
        'colCOLOR_CODE
        '
        Me.colCOLOR_CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.colCOLOR_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOLOR_CODE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCOLOR_CODE.FieldName = "COLOR_CODE"
        Me.colCOLOR_CODE.Name = "colCOLOR_CODE"
        Me.colCOLOR_CODE.Width = 96
        '
        'colLAB_DIP_REF
        '
        Me.colLAB_DIP_REF.AppearanceHeader.Options.UseTextOptions = True
        Me.colLAB_DIP_REF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLAB_DIP_REF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLAB_DIP_REF.FieldName = "LAB_DIP_REF"
        Me.colLAB_DIP_REF.Name = "colLAB_DIP_REF"
        '
        'colORDER_QUANTITY
        '
        Me.colORDER_QUANTITY.AppearanceHeader.Options.UseTextOptions = True
        Me.colORDER_QUANTITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colORDER_QUANTITY.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colORDER_QUANTITY.FieldName = "ORDER_QUANTITY"
        Me.colORDER_QUANTITY.Name = "colORDER_QUANTITY"
        Me.colORDER_QUANTITY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colORDER_QUANTITY.Width = 112
        '
        'colSEAL_BY_DATE
        '
        Me.colSEAL_BY_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.colSEAL_BY_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSEAL_BY_DATE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSEAL_BY_DATE.FieldName = "SEAL_BY_DATE"
        Me.colSEAL_BY_DATE.Name = "colSEAL_BY_DATE"
        Me.colSEAL_BY_DATE.Width = 92
        '
        'colEX_FACTORY_DATE
        '
        Me.colEX_FACTORY_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.colEX_FACTORY_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEX_FACTORY_DATE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEX_FACTORY_DATE.FieldName = "EX_FACTORY_DATE"
        Me.colEX_FACTORY_DATE.Name = "colEX_FACTORY_DATE"
        Me.colEX_FACTORY_DATE.Visible = True
        Me.colEX_FACTORY_DATE.Width = 114
        '
        'colMUST_EX_BD
        '
        Me.colMUST_EX_BD.AppearanceHeader.Options.UseTextOptions = True
        Me.colMUST_EX_BD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMUST_EX_BD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMUST_EX_BD.FieldName = "MUST_EX_BD"
        Me.colMUST_EX_BD.Name = "colMUST_EX_BD"
        Me.colMUST_EX_BD.Width = 112
        '
        'colMODE
        '
        Me.colMODE.AppearanceHeader.Options.UseTextOptions = True
        Me.colMODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMODE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMODE.FieldName = "MODE"
        Me.colMODE.Name = "colMODE"
        '
        'colPACK
        '
        Me.colPACK.AppearanceHeader.Options.UseTextOptions = True
        Me.colPACK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPACK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPACK.FieldName = "PACK"
        Me.colPACK.Name = "colPACK"
        '
        'colTTL_PACKS
        '
        Me.colTTL_PACKS.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTL_PACKS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTL_PACKS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTL_PACKS.FieldName = "TTL_PACKS"
        Me.colTTL_PACKS.Name = "colTTL_PACKS"
        '
        'colFOB_PRICE
        '
        Me.colFOB_PRICE.AppearanceHeader.Options.UseTextOptions = True
        Me.colFOB_PRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFOB_PRICE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFOB_PRICE.FieldName = "FOB_PRICE"
        Me.colFOB_PRICE.Name = "colFOB_PRICE"
        Me.colFOB_PRICE.Width = 83
        '
        'colDESTINATION
        '
        Me.colDESTINATION.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESTINATION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDESTINATION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDESTINATION.FieldName = "DESTINATION"
        Me.colDESTINATION.Name = "colDESTINATION"
        Me.colDESTINATION.Width = 121
        '
        'colADDRESS
        '
        Me.colADDRESS.AppearanceHeader.Options.UseTextOptions = True
        Me.colADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colADDRESS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colADDRESS.FieldName = "ADDRESS"
        Me.colADDRESS.Name = "colADDRESS"
        Me.colADDRESS.Width = 100
        '
        'colTABTEST
        '
        Me.colTABTEST.AppearanceHeader.Options.UseTextOptions = True
        Me.colTABTEST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTABTEST.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTABTEST.FieldName = "TABTEST"
        Me.colTABTEST.Name = "colTABTEST"
        '
        'colPRINT_LINE
        '
        Me.colPRINT_LINE.FieldName = "PRINT_LINE"
        Me.colPRINT_LINE.Name = "colPRINT_LINE"
        Me.colPRINT_LINE.Visible = True
        Me.colPRINT_LINE.Width = 97
        '
        'colIS_OIMRECEIVED
        '
        Me.colIS_OIMRECEIVED.FieldName = "IS_OIMRECEIVED"
        Me.colIS_OIMRECEIVED.Name = "colIS_OIMRECEIVED"
        Me.colIS_OIMRECEIVED.Visible = True
        '
        'colIS_BARCHODERECEIVED
        '
        Me.colIS_BARCHODERECEIVED.FieldName = "IS_BARCHODERECEIVED"
        Me.colIS_BARCHODERECEIVED.Name = "colIS_BARCHODERECEIVED"
        Me.colIS_BARCHODERECEIVED.Visible = True
        '
        'ReceivedComboBox
        '
        Me.ReceivedComboBox.AutoHeight = False
        Me.ReceivedComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReceivedComboBox.Items.AddRange(New Object() {"", "Received", "Cancel"})
        Me.ReceivedComboBox.Name = "ReceivedComboBox"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.OIM_SHEETGridControl
        Me.PrintableComponentLink1.CustomPaperSize = New System.Drawing.Size(0, 0)
        Me.PrintableComponentLink1.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(35, 27, 100, 100)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"DATE : [Date Printed]", "", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        '
        'frmOIMSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 473)
        Me.Controls.Add(Me.OIM_SHEETGridControl)
        Me.Controls.Add(Me.OIM_SHEETBindingNavigator)
        Me.Name = "frmOIMSheet"
        Me.Text = "OIM Sheet"
        CType(Me.OIM_SheetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OIM_SHEETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OIM_SHEETBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OIM_SHEETBindingNavigator.ResumeLayout(False)
        Me.OIM_SHEETBindingNavigator.PerformLayout()
        CType(Me.OIM_SHEETGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivedComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OIM_SheetDataSet As KSoft_Inventory.OIM_SheetDataSet
    Friend WithEvents OIM_SHEETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OIM_SHEETTableAdapter As KSoft_Inventory.OIM_SheetDataSetTableAdapters.OIM_SHEETTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.OIM_SheetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OIM_SHEETBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OIM_SHEETBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OIM_SHEETGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colOIM_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOIM_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOIM_DATE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPO_DATE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colESL_REF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSTYLE_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDESCRIPTION As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFABRIC_DESCRIPTION As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPO_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCOLOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCOLOR_CODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLAB_DIP_REF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colORDER_QUANTITY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSEAL_BY_DATE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEX_FACTORY_DATE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMUST_EX_BD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPACK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBARCHODE_PRICE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTL_PACKS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFOB_PRICE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPO_TYPE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDESTINATION As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colADDRESS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTABTEST As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCOMMENTS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colACKNOWLEDGEMENTDATE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents ExportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReceivedComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colIS_ACKNOWLEDGEMENT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colSLNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents OIMPendingToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AcknowledgementPendingToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colBARCODE_RECEIVED As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBARCODE_DELIVERED As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPRINT_LINE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeliveredBy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIS_OIMRECEIVED As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ReceiveAcknowledgeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colIS_BARCHODERECEIVED As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
