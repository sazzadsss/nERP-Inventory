Imports System.Windows.Forms


Public Class frmMain

    Dim Loginflag As Boolean = False
    Dim QueryString As String = String.Empty

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip1.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim sessionManager As New SessionManager

            sessionManager.DeleteSession(My.Settings.UserId)

            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

        'If CC = "HAL" Then
        '    Me.BackgroundImage = Global.KSoft_Inventory.My.Resources.Resources.Hornbill_Inventory

        'End If

        QueryString = "SELECT DepartmentName FROM DEPARTMENT WHERE (DepartmentId=" & DepartmentId & ")"
        DepartmentToolStripStatusLabel.Text = "Department :" & " " & ReadValue(QueryString, cnn)

        Dim UserName As String = ReadValue("Select User_Name from [User] where User_Id=" & UserId, cnn)

        Loginflag = True


    End Sub



    Private Sub BrandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandToolStripMenuItem.Click
       
        ShowMasterWithUserRights(frmBrand, "Brand")

    End Sub



    Private Sub MediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaToolStripMenuItem.Click

        ShowMasterWithUserRights(frmPrintingMedia, "Media")

    End Sub

    Private Sub PriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPrice.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
      
        ShowMasterWithUserRights(frmCategory, "Category")

    End Sub

    Private Sub SubCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubCategoryToolStripMenuItem.Click
       
        ShowMasterWithUserRights(frmSubCategory, "Sub Category")

    End Sub


    Private Sub UnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem.Click
       
        ShowMasterWithUserRights(frmUnit, "Unit")

    End Sub

    Private Sub OriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginToolStripMenuItem.Click
        ShowMasterWithUserRights(frmOrigin, "Origin")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub SignOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem.Click

        Dim sessionManager As New SessionManager

        sessionManager.DeleteSession(My.Settings.UserId)
        MenuStrip.Visible = False
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog()

    End Sub
    'Checking user right for ToolStripMenuItem
    Private Sub SetMenu(ByVal MyMenuName As String, ByVal MyToolStrip As ToolStripMenuItem, Optional ByVal MyToolbarButton As ToolStripItem = Nothing)

        On Error Resume Next
        Dim MenuId As Integer = -1
        Dim Menurow As MenuDataSet.MenuRow = Nothing
        Dim UserRightsrow As UserRightsDataSet.UserRightsRow = Nothing

        '-----------------Start : Check User Right For Entry------------------------

        Me.MenuTableAdapter.FillByMenuName(Me.MenuDataSet.Menu, MyMenuName)
        Menurow = CType(CType(Me.MenuBindingSource.Current, DataRowView).Row, MenuDataSet.MenuRow)
        MenuId = CInt(Menurow.MENU_ID)

        Me.UserRightsTableAdapter.FillByUserRights(Me.UserRightsDataSet.UserRights, UserId, MenuId)
        UserRightsrow = CType(CType(Me.UserRightsBindingSource.Current, DataRowView).Row, UserRightsDataSet.UserRightsRow)

        If UserRightsrow.CAN_VIEW = False Then

            MyToolStrip.Visible = False
            MyToolbarButton.Visible = False

        Else

            MyToolStrip.Visible = True
            MyToolbarButton.Visible = True

        End If

    End Sub

    Private Sub YarnTypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowMasterWithUserRights(frmYarnType, "Yarn Type")

    End Sub


    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
        ShowFormWithUserRights(frmBooking, "Booking")

    End Sub



    Private Sub NeedleIssueReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeedleIssueReportToolStripMenuItem.Click
 
        ShowFormWithUserRights(frmNeedleIssueReport, "Needle Issue")

    End Sub


    Private Sub IssueReceiveReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueReceiveReportToolStripMenuItem.Click

       

        ShowForm(frmIssueReceiveReport)

    End Sub

    Private Sub ChemicalListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChemicalListToolStripMenuItem1.Click


        ShowForm(frmChemicalListReport)

    End Sub

    Private Sub BalanceMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceMasterToolStripMenuItem.Click
    
        ShowForm(frmStoreBalance)

    End Sub

    Private Sub ReOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReOrderToolStripMenuItem.Click


        ShowForm(frmReorderReport)

    End Sub

    Private Sub ConveyanceBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowForm(frmBillReport)
    End Sub

    Private Sub ItemStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowMaster(frmItemStyle)
    End Sub

    Private Sub RequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionToolStripMenuItem.Click

        ShowForm(frmRequisitionReport)
    End Sub

    Private Sub DailyDyeingCostingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyDyeingCostingReportToolStripMenuItem.Click

        ShowForm(frmDailyBatchCostingReport)

    End Sub

    Private Sub ItemLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowMaster(frmItemLocation)
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionToolStripMenuItem.Click

        ShowMasterWithUserRights(frmUnitConversion, "Unit Conversion")

    End Sub


    Private Sub Test2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDatagridViewCellHighlight.Show()


    End Sub


    Private Sub PhysicalInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalInventoryToolStripMenuItem.Click

        ShowMasterWithUserRights(frmPhysicalInventory, "Physical Inventory")

    End Sub


    Private Sub MaintenanceComplainAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceComplainAllToolStripMenuItem.Click

        frmMaintenanceComplainSystem.RequestForLabel.Text = "Maintenance"

        With frmMaintenanceComplainSystem
            .ForAll = True
        End With
       
        ShowFormWithUserRights(frmMaintenanceComplainSystem, "Maintenance Request [All]")

    End Sub

    Private Sub MaintenanceComplainDepartmnetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceComplainDepartmnetToolStripMenuItem.Click

        frmMaintenanceComplainSystem.RequestForLabel.Text = "Maintenance"

        '    SetMenu("Maintenance Complain", MaintenanceComplainDepartmnetToolStripMenuItem)
        With frmMaintenanceComplainSystem
            .ForAll = False
        End With
        ShowFormWithUserRights(frmMaintenanceComplainSystem, "Maintenance Request [Department]")
    End Sub

    Private Sub MachineListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineListToolStripMenuItem.Click
 
        ShowMasterWithUserRights(frmMachineList, "Machine List")
    End Sub

   
    Private Sub YarnCompositionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnCompositionToolStripMenuItem.Click
        ShowMasterWithUserRights(frmYarnType, "Yarn Type")
    End Sub

    Private Sub YarnQualityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnQualityToolStripMenuItem.Click

        ShowMasterWithUserRights(frmYarnQuality, "Yarn Quality")
    End Sub

    Private Sub YarnCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnCountToolStripMenuItem.Click
        ShowMasterWithUserRights(frmYarnCount, "Yarn Count")
    End Sub

    Private Sub YarnStockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnStockReportToolStripMenuItem.Click
     
        ShowForm(frmYarnStockReport)
    End Sub

    Private Sub ProgramWiseYarnIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramWiseYarnIssueToolStripMenuItem.Click
        With frmProgramwiseYarnIssueReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub MasterStoreBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterStoreBalanceToolStripMenuItem.Click
        With frmMasterStoreBalanceReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

  
    Private Sub FaultyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaultyReportToolStripMenuItem.Click
        With frmStockFaultyReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

 

    Private Sub MaterialReceivingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialReceivingReportToolStripMenuItem.Click
        With frmMRRReport
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
    End Sub

    Private Sub MaterialDeliveryChallanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialDeliveryChallanToolStripMenuItem.Click
        With frmDeliveryChallanReport
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
    End Sub

    Private Sub ParameterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowMaster(frmParameter)
    End Sub

    Private Sub CurrencyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub AccessoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub SupplierToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem2.Click

        ShowFormWithUserRights(frmGeneral, "General")


    End Sub

    Private Sub PipeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PipeToolStripMenuItem.Click


        '    SetMenu("Maintenance Complain", MaintenanceComplainDepartmnetToolStripMenuItem)


        ShowMasterWithUserRights(frmPipeLine, "PIPE LINE")
    End Sub

    Private Sub OpeningLCToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpeningLCToolStripMenuItem1.Click
    
      

        ShowFormWithUserRights(frmOpeningLC, "Opening LC")



    End Sub

    Private Sub IssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueToolStripMenuItem.Click
      
    End Sub

    Private Sub ItemListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemListToolStripMenuItem1.Click
 
        'SetMenu("Item List", ItemListToolStripMenuItem)
        ShowFormWithUserRights(frmItemList, "Item List")

    End Sub

    Private Sub CurrencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CurrencyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyToolStripMenuItem2.Click
        
        ShowMasterWithUserRights(frmCurrency, "Currency")

    End Sub

    Private Sub IssueSubStoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WithFrmReceivedMaterialTestStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithFrmReceivedMaterialTestStatusToolStripMenuItem.Click
        
        ShowFormWithUserRights(frmReceivedItemTestStatus, "Received Item Test Status")
    End Sub

    Private Sub SubStoreIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubStoreIssueToolStripMenuItem.Click

      

        ShowFormWithUserRights(frmIssueDetails, "Issue Details")


    End Sub

    Private Sub BookingReceiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingReceiveToolStripMenuItem.Click



        ShowFormWithUserRights(frmBooking, "Booking")
    End Sub

    Private Sub ItemLocationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLocationToolStripMenuItem1.Click

        ShowMasterWithUserRights(frmItemLocation, "Item Location")
    End Sub

    Private Sub ReceiveMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveMaterialToolStripMenuItem.Click
        'SetMenu("Receive", ReceiveToolStripMenuItem, ToolStripButton4)
        ShowFormWithUserRights(frmReceive, "Receive")
    End Sub

    Private Sub PurchaseRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseRequisitionToolStripMenuItem.Click

        ShowFormWithUserRights(frmRequisition, "Create Requisition")


    End Sub

    Private Sub MainStoreIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainStoreIssueToolStripMenuItem.Click

       
        ShowFormWithUserRights(frmIssuetofloor, "Issue to Floor")
    End Sub

    Private Sub FinishFabricReceiveIssueDyeingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With frmFinishFabricIssueReceive
            .IsGMT = False
        End With
        ShowFormWithUserRights(frmFinishFabricIssueReceive, "Finish Fabric Receive Issue")

    End Sub

    Private Sub FinishFabricReceiveIssueApparelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmFinishFabricIssueReceive.IsGMT = True
        ShowFormWithUserRights(frmFinishFabricIssueReceive, "Finish Fabric Receive Issue [Garments]")

    End Sub

    Private Sub FToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DailyFinishingFabricStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FabricFabricStockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmFinishFabricReceiveIssueReport)
    End Sub

    Private Sub FinishFabricStockReport2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmFinishFabricStoreReport)
    End Sub

    Private Sub FinishFabricBookingClosingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFinishFabricBookingClosing.IsGreige = False
        ShowMasterWithUserRights(frmFinishFabricBookingClosing, "Finish Fabric Booking Closing")
    End Sub

   
    
    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDepartment, "Department")
    End Sub

    Private Sub ParameterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParameterToolStripMenuItem.Click
        ShowMasterWithUserRights(frmInventoryParameter, "Inventory Parameter")
        'ShowMaster(frmInventoryParameter)
    End Sub

    Private Sub FloorRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorRequisitionToolStripMenuItem.Click
        ShowFormWithUserRights(frmFloorRequisition, "Floor Requisition")
    End Sub

    Private Sub MRRRemarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRRRemarksToolStripMenuItem.Click
        ShowMasterWithUserRights(frmMRRRemarks, "MRRRemarks")
    End Sub

    Private Sub FloorRequisitionnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorRequisitionnToolStripMenuItem.Click
        ShowForm(frmRequisitionFloorPrint)
    End Sub

    Private Sub ItemReceivedReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemReceivedReportToolStripMenuItem.Click
        ShowForm(frmItemReceivedReport)
    End Sub

    Private Sub GenarelGatePassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenarelGatePassToolStripMenuItem.Click
        'ShowForm(frmGeneralGatePass)
        ShowFormWithUserRights(frmGeneralGatePass, "General Gate Pass")
    End Sub

    Private Sub SupplierListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierListToolStripMenuItem.Click
        ShowForm(frmSupplierListReport)
    End Sub

    Private Sub MiscDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscDeliveryToolStripMenuItem.Click
        frmMiscDelivery.DepID = MiscDepartmentId
        ShowFormWithUserRights(frmMiscDelivery, "Misc Delivery")
    End Sub

    Private Sub MiscDeliveryCuttingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscDeliveryCuttingToolStripMenuItem.Click
        frmMiscDelivery.DepID = CuttingDepartmentId
        ShowFormWithUserRights(frmMiscDelivery, "Misc Delivery (Cutting)")
    End Sub

    Private Sub MiscDeliveryPrintingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscDeliveryPrintingToolStripMenuItem.Click
        frmMiscDelivery.DepID = PrintingDepartmentId
        ShowFormWithUserRights(frmMiscDelivery, "Misc Delivery (Printing)")
    End Sub

    Private Sub MiscDeliveryEmbroideryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscDeliveryEmbroideryToolStripMenuItem.Click
        frmMiscDelivery.DepID = EmbroideryDepartmentId
        ShowFormWithUserRights(frmMiscDelivery, "Misc Delivery (Embroidery)")
    End Sub

    Private Sub MiscDeliveryYarnDyeingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscDeliveryYarnDyeingToolStripMenuItem.Click
        frmMiscDelivery.DepID = YarnDyeingDepartmentId
        ShowFormWithUserRights(frmMiscDelivery, "Misc Delivery (YarnDyeing)")
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ShowMasterWithUserRights(frmChangePassword, "Change Password")
    End Sub

    Private Sub DyesCamicalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DyesCamicalToolStripMenuItem.Click
        ' ShowFormWithUserRights(frmDyesChemicalRequirementReport, "Dyes Chemical Requirement Report")
        ShowForm(frmDyesChemicalRequirementReport)
    End Sub

    Private Sub SearchEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEntryToolStripMenuItem.Click
        ShowForm(frmSearchEntry)
    End Sub

    Private Sub SearchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchReportToolStripMenuItem.Click
        ShowForm(frmSearchReport)
    End Sub

    Private Sub ITRequestAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITRequestAllToolStripMenuItem.Click
        frmMaintenanceComplainSystem.RequestForLabel.Text = "IT"

        With frmMaintenanceComplainSystem
            .ForAll = True
        End With

        ShowFormWithUserRights(frmMaintenanceComplainSystem, "IT Request [All]")
    End Sub

    Private Sub ITRequestDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITRequestDepartmentToolStripMenuItem.Click
        frmMaintenanceComplainSystem.RequestForLabel.Text = "IT"

        With frmMaintenanceComplainSystem
            .ForAll = False
        End With

        ShowFormWithUserRights(frmMaintenanceComplainSystem, "IT Request [Department]")
    End Sub

    Private Sub AccessoriesWorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessoriesWorkToolStripMenuItem.Click
        ShowForm(frmAccessoriesWorkOrderSheetPrint)
    End Sub

    Private Sub AccessoriesBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessoriesBookingToolStripMenuItem.Click
        ShowForm(frmAccessoriesBookingPrint)
    End Sub

    Private Sub YarnDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmYarnDeliveryChallan)
    End Sub

    Private Sub MISCDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MISCDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmMiscDeliveryChallanReport)
    End Sub

    Private Sub YarnStocksAndLeftoverStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnStocksAndLeftoverStatusToolStripMenuItem.Click
        ShowForm(frmYarnStocksLeftoverStatus)
    End Sub

    Private Sub CuttingDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub AccessoriesBookingStatusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccessoriesBookingStatusToolStripMenuItem1.Click
        ShowForm(frmAccessoriesBookingStatusReport)
    End Sub

    Private Sub ToolStripSeparator10_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator10.Click

    End Sub

    Private Sub YarnAllocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnAllocationToolStripMenuItem.Click
        ShowFormWithUserRights(frmAdvanceYarnLotAllocation, "Advance Yarn Allocation")
    End Sub

    Private Sub OrderWiseYarnAllocationStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderWiseYarnAllocationStatusToolStripMenuItem.Click
        ShowForm(frmOrderwiseadvanceyarnallocation)
    End Sub

    Private Sub SupportComplainReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportComplainReportToolStripMenuItem.Click
        ShowForm(frmSupportComplain)
    End Sub

    Private Sub MaterialReceiveIssueReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialReceiveIssueReportToolStripMenuItem.Click
        ShowForm(frmMaterrialReceiveIssueReport)
    End Sub

    Private Sub YarnDyeingDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDyeingDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmYarnDyeingDeliveryChallanPrint)

    End Sub

    Private Sub YarnDyeingStocksReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YarnDyeingStocksReportToolStripMenuItem.Click
        ShowForm(frmYarnDyeingReciveIssueStocks)
    End Sub
End Class
