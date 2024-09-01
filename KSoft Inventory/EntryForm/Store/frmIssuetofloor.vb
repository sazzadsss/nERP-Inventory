Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraGrid.Columns

Public Class frmIssuetofloor
    Dim Addflag As Boolean = False
    Dim Editflag As Boolean = False
    Dim IssQty As Decimal = 0
    Private Sub frmIssuetofloor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitDataSet.Unit' table. You can move, or remove it, as needed.
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)


        Me.KWOrderLookupTableAdapter.Fill(Me.KWOrderLookupDataSet.KWOrderLookup)
        Me.YDOrderTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrder)
        Me.PIListTableAdapter.FillByDepartment(Me.PiListDataSet.PIList, DepartmentId)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.VItemListTableAdapter.FillByDepartmentId(Me.ItemNameDataSet.vItemList, DepartmentId)
        Me.PILookUpTableAdapter.FillByDeparmentId(Me.PILookUpDataSet.PILookUp, DepartmentId)
        Me.LCNoLookUpFromPIIdTableAdapter.FillByPIId(Me.PILookUpDataSet.LCNoLookUpFromPIId)

        DisableControl(GroupBox1)


        Me.IssueDataSet.Issue.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.IssueDataSet.Issue.IssueDateColumn.DefaultValue = Today()
        Me.IssueDataSet.Issue.CompanyIdColumn.DefaultValue = 1
        Me.IssueDataSet.Issue.UserIdColumn.DefaultValue = UserId
        Me.IssueDataSet.Issue.ModifiedOnColumn.DefaultValue = Now()
        Me.IssueDataSet.Issue.LeftOverQuantityColumn.DefaultValue = 0


        LoadAutoCompleteList("Select ProgramNo From Booking", ProgramNoTextBox)

        'SetUserRights("Issue to Floor", UserId, NewButton, EditButton, DeleteButton)

        IsLCTracking = ReadBooleanData("Select IsLCTracking From Department Where DepartmentId=" & DepartmentId, cnn)


        If DepartmentId = GarmentsStoreId Then
            PopulateAccBookingDetails()
        ElseIf DepartmentId = YDStoreId Then
            PopulateYDBookingDetails()
        End If

        If CheckUserRights("Issue to Floor").CanEdit = False Then

            'NewButton.Enabled = False
            EditButton.Enabled = False
            IsLeftOverCheckEdit.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = False

        ElseIf CheckUserRights("Issue to Floor").CanDelete = False Then

            'NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True

        End If

        CompanyIdComboBox.Enabled = True

    End Sub

    Private Sub IssueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Save()

    End Sub



    Private Sub IssueDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next
    End Sub




    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        ClickNewButton()


    End Sub
    Private Sub CreateChallanNo()
        If ChallanNoTextEdit.Text = String.Empty Then

            If DepartmentId = YarnStoreId Then

                Dim ABC As String = Now.Year.ToString.Substring(2) & "YSC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Issue Where ChallanNo Like '" & ABC & "%'", cnn)
                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "YSC" & (Val(XYZ) + 1).ToString("0000")
                Me.IssueDateDateTimePicker.Text = Today()

            ElseIf DepartmentId = YDStoreId Then

                Dim ABC As String = Now.Year.ToString.Substring(2) & "YDC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Issue Where ChallanNo Like '" & ABC & "%'", cnn)
                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "YDC" & (Val(XYZ) + 1).ToString("0000")
                Me.IssueDateDateTimePicker.Text = Today()

            Else

                Dim ABC As String = Now.Year.ToString.Substring(2) & "GSC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0,CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Issue Where ChallanNo Like '" & ABC & "%'", cnn)
                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "GSC" & (Val(XYZ) + 1).ToString()
                Me.IssueDateDateTimePicker.Text = Today()

            End If

        End If

    End Sub
    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If PrintCount(Me.ChallanNoTextEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select USER_LEVEL From [User] Where User_Id=" & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to edit a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:
        Editflag = True

        Dim row As IssueDataSet.IssueRow
        row = CType(CType(Me.IssueBindingSource.Current, DataRowView).Row, IssueDataSet.IssueRow)

        If My.Settings.EditRestrictionDays > 0 Then

            Dim RcvDate As Date = ReadDateData("Select IssueDate From Issue Where IssueId= " & row.IssueId, cnn)
            Dim DayCount As Integer = ReadIntData("Select datediff(day,'" & RcvDate & "',getdate())", cnn)

            If DayCount > 7 Then
                MessageBox.Show(DayCount & " days are passed, so not allowed to edit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

        If EditButton.Text = "&Edit" Then

            EnableControl(GroupBox1)

            If VBookingLookupBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                'ItemIdLinkLabel.Enabled = False
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else
                ItemIdGridLookUpEdit.Properties.ReadOnly = False
                'ItemIdLinkLabel.Enabled = True
                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If


            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            'Validating.... 

            'Dim row1 As IssueDataSet.IssueRow
            'row1 = CType(CType(Me.IssueBindingSource.Current, DataRowView).Row, IssueDataSet.IssueRow)
            Dim UL As Integer = ReadIntData("Select USER_LEVEL From [User] Where User_Id=" & UserId, cnn)

            If ItemIdGridLookUpEdit.Text = String.Empty Then

                ErrorProvider1.SetError(ItemIdGridLookUpEdit, "Select an Item")
                ItemIdGridLookUpEdit.Focus()
                Exit Sub

            ElseIf row.IssueQuantity > Val(YarnBalanceLabel.Text) + IssQty AndAlso IsLeftOverCheckEdit.Checked = False AndAlso DepartmentId = YarnStoreId AndAlso IssueTypeComboBox.Text = "Normal" AndAlso UL <> 1 Then

                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be less than or equal Balance Quantity. ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf row.IssueQuantity > Val(YarnAllocationLabel.Text) + IssQty AndAlso DepartmentId = YarnStoreId Then

                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be less than or equal Allocation Quantity. ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf IssueTypeComboBox.Text = String.Empty Then
                ErrorProvider1.SetError(IssueTypeComboBox, "Select Issue Type")
                IssueTypeComboBox.Focus()
                Exit Sub
            ElseIf row.IssueQuantity <= 0 And IsLeftOverCheckEdit.Checked = False Then

                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should greater then 0")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf row.IsBranchIdNull Then

                ErrorProvider1.SetError(BranchComboBox, "Select a Branch")
                BranchComboBox.Focus()
                Exit Sub
                '' For validating PI ANd Lot for departmentid=15 Dyeng Cemical Store----Babu--08/06/2013
            ElseIf LotNoGridLookUpEdit.Text = String.Empty And IsLCTracking = True Then

                ErrorProvider1.SetError(LotNoGridLookUpEdit, "Select Lot No")
                LotNoGridLookUpEdit.Focus()
                Exit Sub
            ElseIf PIIdGridLookUpEdit.Text = String.Empty And IsLCTracking = True Then

                ErrorProvider1.SetError(PIIdGridLookUpEdit, "Select L/C No")
                PIIdGridLookUpEdit.Focus()
                Exit Sub



            Else
                'Saveing/Updating...
                Save()

                Me.LotWiseReceivedIssuedTableAdapter.FillByItemId(Me.YarnLotNoLookupDataSet.LotWiseReceivedIssued, ItemIdGridLookUpEdit.EditValue)


            End If


            '===================================================

            DisableControl(GroupBox1)
            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If ReceiveBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If

            CancelEntryButton.Enabled = False


        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If DeleteButton.Text = "&Delete" Then

            MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DialogResult.Yes Then
                DeleteButton.Text = "&Update"
                NewButton.Enabled = False
                EditButton.Enabled = False
                CancelEntryButton.Enabled = True
                IssueBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If

        Else

            'Saveing/Updating...
            Save()
            '======================================================
            If IssueBindingSource.Position = -1 Then
                DeleteButton.Enabled = False
            End If

            DeleteButton.Text = "&Delete"
            NewButton.Enabled = True
            EditButton.Enabled = True
            CancelEntryButton.Enabled = False

            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub CancelEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryButton.Click

        'Reset
        Me.IssueTableAdapter.FillByDepartmentId(Me.IssueDataSet.Issue, DepartmentId)
        'TODO: This line of code loads data into the 'ConveyanceDataSet.ConveyanceBill' table. You can move, or remove it, as needed.
        'Me.ConveyanceBillTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceBill)


        DisableControl(GroupBox1)
        NewButton.Text = "&New"
        EditButton.Text = "&Edit"

        If CheckUserRights("Issue to Floor").CanEdit = False Then

            'NewButton.Enabled = False
            EditButton.Enabled = False
            'DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = False

        ElseIf CheckUserRights("Issue to Floor").CanDelete = False Then

            'NewButton.Enabled = True
            'EditButton.Enabled = True
            DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = True

        End If


        'If IssueBindingSource.Position > -1 Then
        '    DeleteButton.Enabled = True
        'End If

        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False

    End Sub

    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.TextChanged
        On Error Resume Next

        If DepartmentId = GarmentsStoreId Then

            Me.VBookingLookupTableAdapter.Fill(Me.BookingDataSet.vBookingLookup, DepartmentId, ProgramNoTextBox.Text)

            If VBookingLookupBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                'ItemIdLinkLabel.Enabled = False
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else
                ItemIdGridLookUpEdit.Properties.ReadOnly = False
                'ItemIdLinkLabel.Enabled = True
                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If

        ElseIf DepartmentId = YDStoreId Then

            Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

            If YDOrderDetailsBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else
                ItemIdGridLookUpEdit.Properties.ReadOnly = False
                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If

        End If







    End Sub

    Private Sub UpdateBalance()

        Try
            'On Error Resume Next
            Dim TotalYarnRequire As Double = 0
            Dim TotalYarnIssued As Decimal = 0
            Dim TotalYarnReturn As Decimal = 0
            Dim TotalYarnBalance As Double = 0

            Dim TotalReceive As Decimal = 0
            Dim TotalReceiveReturn As Decimal = 0
            Dim TotalIssue As Decimal = 0
            Dim TotalIssueReturn As Decimal = 0

            Dim AllocateId As Integer = ReadIntegerData("Select IssueReceiveTypeId From IssueReceiveType Where IssueTypeName='Allocate'", cnn)

            TotalIssue = ReadData("Select ISNULL(Sum(IssueQuantity),0) From Issue Where IssueReceiveTypeId not in (" & AllocateId & ") And  ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
            TotalReceive = ReadData("Select ISNULL(Sum(ReceiveQuantity),0) From Receive Where ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
            TotalYarnRequire = ReadDoubleData("Select ISNULL(Sum(YarnRequire),0)+ISNULL(Sum(TTLExcessFabric),0) From YBGeneration Where ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)
            TotalYarnIssued = ReadData("Select ISNULL(Sum(IssueQuantity),0) From Issue Where IssueReceiveTypeId=(Select IssueReceiveTypeId From IssueReceiveType Where IssueTypeName='Normal') And  ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)
            TotalYarnReturn = ReadData("Select ISNULL(Sum(ReceiveQuantity),0) From Receive Where IssueReceiveTypeId=(Select IssueReceiveTypeId From IssueReceiveType Where IssueTypeName='Return')And  ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)
            TotalYarnBalance = TotalYarnRequire - (TotalYarnIssued - TotalYarnReturn)
            YarnRquireLabel.Text = TotalYarnRequire.ToString()
            YarnIssuedLabel.Text = TotalYarnIssued
            ReturnLabel.Text = TotalYarnReturn
            YarnBalanceLabel.Text = FormatNumber(TotalYarnBalance, 2)

            AIssuedLabel.Text = TotalIssue
            ItemBalanceLabel.Text = TotalReceive - TotalIssue


            Dim SupId As Integer = ReadIntegerData("Select SupplierId From LCList Where LCId =(Select LCId From PIList Where PIId=" & PIIdGridLookUpEdit.EditValue & ")", cnn)
            Dim TTLAllocation As Double = ReadData("Select AllocateQuantity From YarnAllocationByProgAndLotAndSup Where ProgramNo='" & ProgramNoTextBox.Text.ToString() & "' And ItemId=" & ItemIdGridLookUpEdit.EditValue & " And LotNo = '" & LotNoGridLookUpEdit.EditValue & "' And SupplierId = " & SupId, cnn)
            YarnAllocationLabel.Text = TTLAllocation.ToString()




        Catch ex As Exception

            '    MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub ItemIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemIdGridLookUpEdit.EditValueChanged, ActUnitGridLookUpEdit.EditValueChanged

        On Error Resume Next

        If ItemListBindingSource.Position > -1 Then
            IssQty = Val(IssueQuantityTextBox.Text)
            UpdateBalance()

            If IsLCTracking = True Then

                Me.LotWiseReceivedIssuedTableAdapter.FillByItemId(Me.YarnLotNoLookupDataSet.LotWiseReceivedIssued, ItemIdGridLookUpEdit.EditValue)
                'Me.LotAndItemwiseBalanceTableAdapter.Fill(Me.LotAndItemBalanceDataSet.LotAndItemwiseBalance, ItemIdGridLookUpEdit.EditValue)
                Me.LotAndItemwiseBalanceNewTableAdapter.Fill(Me.LotAndItemwiseBalanceNewDataSet.LotAndItemwiseBalanceNew, ItemIdGridLookUpEdit.EditValue)
                Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdGridLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, DepartmentId)
                Me.YarnLotNoLookupTableAdapter.Fill(Me.YarnLotNoLookupDataSet.YarnLotNoLookup, ItemIdGridLookUpEdit.EditValue)



            Else

                If (DepartmentId <> GarmentsStoreId) AndAlso (DepartmentId <> YDStoreId) AndAlso YarnStoreId Then

                    If ItemIdGridLookUpEdit.EditValue > -1 Then
                        PriceTextBox.Text = ReadData("Select AvgPrice From ItemList Where ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
                        AIssuedLabel.Text = ReadData("Select Sum(IssueQuantity) From Issue Where ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
                    End If

                End If

            End If

            Me.ReceivedMRNoLookupTableAdapter.Fill(Me.ReceiveDataSet.ReceivedMRNoLookup, ItemIdGridLookUpEdit.EditValue)

        End If


    End Sub




    'Private Sub ItemIdGridLookUpEdit_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles ItemIdGridLookUpEdit.EditValueChanging

    '    Dim row As ItemListDataSet.ItemListLookupRow
    '    row = CType(CType(Me.ItemListLookupBindingSource.Current, DataRowView).Row, ItemListDataSet.ItemListLookupRow)
    '    ItemIdTextBox.Text = row.ItemId

    '    Me.VItemListTableAdapter.FillByItemNo(Me.ItemNameDataSet.vItemList, row.ItemId, DepartmentId)

    '    Dim dr As ItemNameDataSet.vItemListRow
    '    dr = CType(CType(Me.VItemListBindingSource.Current, DataRowView).Row, ItemNameDataSet.vItemListRow)

    '    PriceTextBox.Text = dr.CurrentPrice
    '    Me.ReceiveTableAdapter.FillByItemId(Me.ReceiveDataSet.Receive, dr.ItemId, DepartmentId)


    'End Sub


    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click


        Me.IssueTableAdapter.FillByDepartmentId(Me.IssueDataSet.Issue, DepartmentId)
        ErrorProvider1.Clear()

    End Sub



    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub CompanyIdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyIdComboBox.SelectedIndexChanged
        'Me.IssueDataSet.Issue.CompanyIdColumn.DefaultValue = Me.CompanyIdComboBox.SelectedValue
    End Sub

    Private Sub frmIssuetofloor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F12 Then

            ClickNewButton()


        End If


    End Sub
    Private Sub ClickNewButton()
        If NewButton.Text = "&New" Then

            EnableControl(GroupBox1)

            If CopyCheckBox.Checked Then
                Addflag = False
            Else
                Addflag = True
            End If

            If VBookingLookupBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                'ItemIdLinkLabel.Enabled = False
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else
                ItemIdGridLookUpEdit.Properties.ReadOnly = False
                'ItemIdLinkLabel.Enabled = True
                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If


            NewButton.Text = "&Save"


            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


            If CopyCheckBox.Checked Then

                '---Copy current row
                Dim oldrow As IssueDataSet.IssueRow
                oldrow = CType(CType(Me.IssueBindingSource.Current, DataRowView).Row, IssueDataSet.IssueRow)

                '---Paste current row to new row

                Dim newRow As IssueDataSet.IssueRow = Me.IssueDataSet.Issue.NewRow()


                newRow.IssueDate = oldrow.IssueDate
                newRow.RequistionNo = oldrow.RequistionNo
                newRow.BranchId = oldrow.BranchId

                If ProgramNoTextBox.Text <> String.Empty Then
                    newRow.ProgramNo = oldrow.ProgramNo
                Else
                    newRow.ProgramNo = ""
                End If

                newRow.ItemId = Nothing
                newRow.Price = 0
                newRow.IssueQuantity = 0
                newRow.PrintingMediaId = oldrow.PrintingMediaId
                newRow.Remarks = ""
                newRow.SupplierId = oldrow.SupplierId
                newRow.IssueReceiveTypeId = oldrow.IssueReceiveTypeId
                newRow.CompanyId = oldrow.CompanyId
                newRow.ChallanNo = oldrow.ChallanNo

                If YTRNoTextBox.Text <> String.Empty Then
                    newRow.YTRNo = oldrow.YTRNo
                Else
                    newRow.YTRNo = ""
                End If




                '--------------

                'ReceiveDataGridView.ReadOnly = False

                Me.IssueDataSet.Issue.Rows.Add(newRow)
                EnableControl(GroupBox1)

                If VBookingLookupBindingSource.Position > -1 Then
                    ItemIdGridLookUpEdit.Properties.ReadOnly = True
                    'ItemIdLinkLabel.Enabled = False
                    BookingDetailsIdGridLookUpEdit.Enabled = True

                Else
                    ItemIdGridLookUpEdit.Properties.ReadOnly = False
                    'ItemIdLinkLabel.Enabled = True
                    BookingDetailsIdGridLookUpEdit.Enabled = False
                End If

                IssueDateDateTimePicker.Enabled = False
                RequistionNoTextBox.Enabled = True
                BranchComboBox.Enabled = False
                'SupplierIdComboBox.Enabled = False
                IssueTypeComboBox.Enabled = False
                IssueBindingSource.MoveLast()
                ItemIdGridLookUpEdit.Focus()

            Else

                IssueBindingSource.AddNew()
                IssueDateDateTimePicker.Focus()

                'IssueDateDateTimePicker.CustomFormat = " "
                'IssueDateDateTimePicker.Format = DateTimePickerFormat.Custom

            End If



        Else

            'Validating.... 
            ErrorProvider1.Clear()

            Dim UL As Integer = ReadIntData("Select USER_LEVEL From [User] Where User_Id=" & UserId, cnn)

            Dim row As IssueDataSet.IssueRow
            row = CType(CType(Me.IssueBindingSource.Current, DataRowView).Row, IssueDataSet.IssueRow)



            If ItemIdGridLookUpEdit.Text = String.Empty Then

                ErrorProvider1.SetError(ItemIdGridLookUpEdit, "Select an Item")
                ItemIdGridLookUpEdit.Focus()
                Exit Sub

            ElseIf IssueTypeComboBox.Text = String.Empty Then

                ErrorProvider1.SetError(IssueTypeComboBox, "Select Issue Type")
                IssueTypeComboBox.Focus()
                Exit Sub

            ElseIf row.IssueQuantity > Val(ItemBalanceLabel.Text) AndAlso IsLeftOverCheckEdit.Checked = False AndAlso DepartmentId <> GarmentsStoreId AndAlso IssueTypeComboBox.Text = "Normal" Then

                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be less than or equal Balance Quantity. ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf ProgramNoTextBox.Text <> String.Empty AndAlso YTRNoTextBox.Text = String.Empty AndAlso row.IssueQuantity > Val(YarnAllocationLabel.Text) AndAlso DepartmentId = YarnStoreId Then

                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be less than or equal Allocation Quantity. ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf ProgramNoTextBox.Text <> String.Empty AndAlso YTRNoTextBox.Text = String.Empty AndAlso row.IssueQuantity > FormatNumber(YarnBalanceLabel.Text, 2) AndAlso IsLeftOverCheckEdit.Checked = False AndAlso DepartmentId = YarnStoreId AndAlso IssueTypeComboBox.Text = "Normal" Then
                Debug.Print("Yarn Balance Quantity: " & FormatNumber(YarnBalanceLabel.Text, 2).ToString())
                Debug.Print("Yarn Issue Quantity :" & row.IssueQuantity.ToString())
                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be less than or equal Balance Quantity. ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf row.IssueQuantity <= 0 AndAlso IsLeftOverCheckEdit.Checked = False Then
                ErrorProvider1.SetError(IssueQuantityTextBox, "Quantity should be greater than 0 ")
                IssueQuantityTextBox.Focus()
                Exit Sub

            ElseIf row.IsBranchIdNull Then

                ErrorProvider1.SetError(BranchComboBox, "Select a Branch")
                BranchComboBox.Focus()
                Exit Sub

            ElseIf row.IsLotNoNull And IsLCTracking = True Then

                ErrorProvider1.SetError(LotNoGridLookUpEdit, "Select Lot No")
                LotNoGridLookUpEdit.Focus()
                Exit Sub

            ElseIf row.IsPIIdNull And IsLCTracking = True Then

                ErrorProvider1.SetError(PIIdGridLookUpEdit, "Select L/C No")
                PIIdGridLookUpEdit.Focus()
                Exit Sub

                'If DepartmentId = YarnStoreId Then

                '    If ProgramNoTextBox.Text <> String.Empty Then

                '        Dim TotalYarnRequire As Double = ReadDoubleData("Select ISNULL(Sum(YarnRequire),0) From YBGeneration Where ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)
                '        Dim TotalYarnIssued As Double = ReadData("Select ISNULL(Sum(IssueQuantity),0) From Issue Where IssueReceiveTypeId=(Select IssueReceiveTypeId From IssueReceiveType Where IssueTypeName='Normal') And  ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)
                '        Dim TotalYarnReturn As Double = ReadData("Select ISNULL(Sum(ReceiveQuantity),0) From Receive Where IssueReceiveTypeId=(Select IssueReceiveTypeId From IssueReceiveType Where IssueTypeName='Return')And  ItemId=" & ItemIdGridLookUpEdit.EditValue & " And ProgramNo='" & ProgramNoTextBox.Text.ToString() & "'", cnn)

                '        Dim TotalYarnBalance As Double = TotalYarnRequire - (TotalYarnIssued - TotalYarnReturn)


                '        If Val(IssueQuantityTextBox.Text) > TotalYarnBalance Then
                '            ErrorProvider1.SetError(IssueQuantityTextBox, "Issue Quantity should be less than or equal Issue Balance Quantity")
                '            IssueQuantityTextBox.Focus()
                '            Exit Sub

                '        End If

                '    End If

                'End If


            Else

                If Addflag = True Then
                    CreateChallanNo()
                    Me.IssueBindingSource.ResetBindings(True)
                End If

                'Saveing/Updating...
                Save()


            End If


            '==================================================

            DisableControl(GroupBox1)
            NewButton.Text = "&New"
            'EditButton.Enabled = True

            'If ReceiveBindingSource.Position > -1 Then
            '    DeleteButton.Enabled = True
            'End If

            'CancelEntryButton.Enabled = False

            If CheckUserRights("Issue to Floor").CanEdit = False Then

                'NewButton.Enabled = False
                EditButton.Enabled = False
                'DeleteButton.Enabled = False


            ElseIf CheckUserRights("Issue to Floor").CanDelete = False Then

                'NewButton.Enabled = True
                'EditButton.Enabled = True
                DeleteButton.Enabled = False


            End If

        End If
    End Sub


    Private Sub LotNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotNoGridLookUpEdit.EditValueChanged
        On Error Resume Next

        FillPIAndItemwiseBalance()

        'Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdGridLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, DepartmentId)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
        'Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)


        Dim DN As String = ReadStringData("Select DepartmentName From Department Where DepartmentId=" & DepartmentId, cnn)

        If DN = "Yarn Store" Then
            Me.SupplierTableAdapter.FillBySupplierType(Me.SupplierDataSet.Supplier, "Knitting")
            SupplierLabel.Text = "Knitting Supplier"

        Else
            Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
            SupplierLabel.Text = "Supplier"
        End If




        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        MessageBox.Show("Refresh", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ExportLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportLinkLabel.LinkClicked

        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Issue to Floor Report"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            Try
                IssueGridControl.MainView.ExportToXls(objSaveFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbNewLine & "The mentioned file is already open. Pls,Close it", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing

    End Sub

    Private Sub FinishFabricBookingIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishFabricBookingIdGridLookUpEdit.EditValueChanged
        ProgramNoTextBox.Text = FinishFabricBookingIdGridLookUpEdit.Text
    End Sub



    Private Sub IssueBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBindingSource.PositionChanged

        FillPIAndItemwiseBalance()

    End Sub
    Private Sub FillPIAndItemwiseBalance()
        On Error Resume Next
        If IsLCTracking = True Then
            Dim row As YarnLotNoLookupDataSet.LotWiseReceivedIssuedRow
            row = CType(CType(Me.LotWiseReceivedIssuedBindingSource.Current, DataRowView).Row, YarnLotNoLookupDataSet.LotWiseReceivedIssuedRow)

            'CompanyIdComboBox.SelectedValue = row.CompanyId
            Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdGridLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, DepartmentId)
            Me.LotwiseHistoryTableAdapter.Fill(Me.LotwiseHistoryDataSet.LotwiseHistory, LotNoGridLookUpEdit.EditValue)
            For Each row1 As DataGridViewRow In DataGridView1.Rows
                Dim num As String = row1.Cells(1).Value.ToString()
                If num = "Allocate" Then
                    row1.DefaultCellStyle.BackColor = Color.Yellow
                End If
            Next
        End If
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click

        FillPIAndItemwiseBalance()
        UpdateBalance()

    End Sub

    Private Sub ReceiveIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        'ItemIdGridLookUpEdit.EditValue = ReadIntegerData("Select ItemId From Receive Where ReceiveId=" & ReceiveIdGridLookUpEdit.EditValue, cnn)
        'PriceTextBox.Text = ReadData("Select Price From Receive Where ReceiveId =" & ReceiveIdGridLookUpEdit.EditValue, cnn)
        'IssueQuantityTextBox.Text = MRBalance()

    End Sub

    Function MRBalance() As Decimal

        Dim MRNo As Integer = ReceiveIdGridLookUpEdit.EditValue

        Dim TTLBalance As Decimal = 0

        If MRNo > 0 Then

            Dim TTLReceive As Decimal = ReadData("Select Sum(ReceiveQuantity) From Receive Where ReceiveId=" & MRNo, cnn)
            Dim TTLIssue As Decimal = ReadData("Select Sum(IssueQuantity) From Issue Where ReceiveId=" & MRNo, cnn)


            TTLBalance = TTLReceive - TTLIssue

        End If

        Return TTLBalance

    End Function

    Private Sub IssueQuantityTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueQuantityTextBox.Leave, LeftOverQtyTextBox.Leave, ActIssueQtyTextBox.Leave
        'Exit Sub
        If IsLCTracking = True Then
            Exit Sub

        End If

        If DBNull.Value.Equals(ReceiveIdGridLookUpEdit.EditValue) = False Then

            '    If MRBalance() < Val(IssueQuantityTextBox.Text) Then

            '        ErrorProvider1.SetError(IssueQuantityTextBox, "Not Allowed Excess Quantity")
            '        IssueQuantityTextBox.Focus()
            '        IssueQuantityTextBox.Text = 0
            '        Exit Sub

            '    Else

            '        ErrorProvider1.Clear()

            '    End If


            'Else


            If Val(ItemBalanceLabel.Text) < Val(IssueQuantityTextBox.Text) Then

                If IssueTypeComboBox.Text = "Normal" Then

                    ErrorProvider1.SetError(IssueQuantityTextBox, "Not Allowed Excess Quantity")
                    IssueQuantityTextBox.Focus()
                    Exit Sub

                End If

            Else

                ErrorProvider1.Clear()

            End If

        End If


    End Sub

    Private Sub PIIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIIdGridLookUpEdit.EditValueChanged

        On Error Resume Next
        'Get Price From PIList
        If IsLCTracking = True Then

            If PIIdGridLookUpEdit.EditValue > 0 Then

                Debug.Print("PI No :" & PIIdGridLookUpEdit.EditValue.ToString())
                PriceTextBox.Text = ReadData("Select LCPrice From PIList Where PIId = " & PIIdGridLookUpEdit.EditValue, cnn)
                ManufactureDateDateTimePicker.Text = ReadDateData("Select Min(ManufactureDate) As MDate From Receive Where PIId = " & PIIdGridLookUpEdit.EditValue, cnn)
                ExpiryDateDateTimePicker.Text = ReadDateData("Select Min(ExpiryDate) AS EDate From Receive Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)

                Dim TTLReceive As Double = ReadData("Select Sum(ReceiveQuantity) From Receive Where PIid=" & PIIdGridLookUpEdit.EditValue & "And YarnLotNo='" & LotNoGridLookUpEdit.EditValue & "' And ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
                Dim TTLIssue As Double = ReadData("Select Sum(IssueQuantity) From Issue Where PIid=" & PIIdGridLookUpEdit.EditValue & "And LotNo='" & LotNoGridLookUpEdit.EditValue & "' And ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)

                Dim TTLBalance As Double = TTLReceive - TTLIssue
                AIssuedLabel.Text = TTLIssue.ToString()
                ItemBalanceLabel.Text = TTLBalance.ToString()


                Dim SupId As Integer = ReadIntegerData("Select SupplierId From LCList Where LCId =(Select LCId From PIList Where PIId=" & PIIdGridLookUpEdit.EditValue & ")", cnn)
                Dim TTLAllocation As Double = ReadData("Select AllocateQuantity From YarnAllocationByProgAndLotAndSup Where ProgramNo='" & ProgramNoTextBox.Text.ToString() & "' And ItemId=" & ItemIdGridLookUpEdit.EditValue & " And LotNo = '" & LotNoGridLookUpEdit.EditValue & "' And SupplierId = " & SupId, cnn)
                YarnAllocationLabel.Text = TTLAllocation.ToString()

            End If


        End If


    End Sub

    Private Sub UpdateItemAvgPrice()

        If IsLCTracking = True Then
            ExecuteQuery("Execute UpdateItemAvgPrice " & ItemIdGridLookUpEdit.EditValue, cnn)
        End If

    End Sub

    Private Sub Save()

        Try

            Dim row As IssueDataSet.IssueRow
            row = CType(CType(Me.IssueBindingSource.Current, DataRowView).Row, IssueDataSet.IssueRow)

            row.UserId = UserId
            row.ModifiedOn = ReadDateData("Select GetDate()", cnn)

            Me.Validate()
            Me.IssueBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.IssueDataSet)

            ErrorProvider1.Clear()
            UpdateItemAvgPrice()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BookingDetailsIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingDetailsIdGridLookUpEdit.EditValueChanged


        If IssueBindingSource.Position = -1 Then
            Exit Sub
        End If


        If DepartmentId = YDStoreId Then

            ItemIdGridLookUpEdit.EditValue = ReadIntegerData("Select ItemId From ItemList where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            PriceTextBox.Text = ReadData("Select CurrentPrice From ItemList where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)

            Dim TTLReceive As Double = ReadData("Select Sum(ReceiveQuantity) From Receive Where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            Dim TTLIssue As Double = ReadData("Select Sum(IssueQuantity) From Issue Where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            Dim TTLBooking As Double = ReadData("Select Sum(OrderQuantity) From YDOrderDetails Where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TotalIssueQuantityLabel.Text = TTLReceive
            BalanceLabel.Text = TTLReceive - TTLIssue
            ReceiveBalanceLabel.Text = TTLBooking - TTLReceive
            'IssueQuantityTextBox.Text = TTLReceive - TTLIssue


        ElseIf DepartmentId = GarmentsStoreId Then

            'MessageBox.Show(BookingDetailsIdGridLookUpEdit.EditValue.ToString())

            ItemIdGridLookUpEdit.EditValue = ReadIntegerData("Select ItemId From BookingDetails where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            PriceTextBox.Text = ReadData("Select UnitPrice From BookingDetails where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)

            Dim TTLReceive As Double = ReadData("Select Sum(ReceiveQuantity) From Receive Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            Dim TTLIssue As Double = ReadData("Select Sum(IssueQuantity) From Issue Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            Dim TTLBooking As Double = ReadData("Select Sum(BookingQuantity) From BookingDetails Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TotalIssueQuantityLabel.Text = TTLIssue
            BalanceLabel.Text = TTLReceive - TTLIssue
            ReceiveBalanceLabel.Text = TTLBooking - TTLReceive


        End If


    End Sub

    Private Sub ChallanLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ChallanLinkLabel.LinkClicked

        'If DepartmentId = YarnStoreId Then
        '    Dim ABC As String = Now.Year.ToString.Substring(2) & "YSC"
        '    Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Issue Where ChallanNo Like '" & ABC & "%'", cnn)
        '    Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "YSC" & (Val(XYZ) + 1).ToString("0000")
        '    Me.IssueDateDateTimePicker.Text = Today()
        'Else
        '    Dim ABC As String = Now.Year.ToString.Substring(2) & "GSC"
        '    Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0,CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Issue Where ChallanNo Like '" & ABC & "%'", cnn)
        '    Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "GSC" & (Val(XYZ) + 1).ToString()
        '    Me.IssueDateDateTimePicker.Text = Today()
        'End If

    End Sub

    Private Sub YDOrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YDOrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next

        Me.FinishFabricBookingIdGridLookUpEdit.EditValue = ReadIntegerData("Select FinishFabricBookingId From YDOrder Where YDOrderId=" & YDOrderIdGridLookUpEdit.EditValue, cnn)

    End Sub

    Private Sub KnittingOrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnittingOrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        FinishFabricBookingIdGridLookUpEdit.EditValue = ReadIntegerData("Select FinishFabricBookingId From KnittingOrder Where KnittingOrderId=" & KnittingOrderIdGridLookUpEdit.EditValue, cnn)

    End Sub

    Private Sub RqNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RqNoTextBox.TextChanged
        On Error Resume Next
        Me.IssueTableAdapter.FillByRqNo(Me.IssueDataSet.Issue, RqNoTextBox.Text)
    End Sub

    Private Sub PopulateYDBookingDetails()



        With BookingDetailsIdGridLookUpEdit
            .Properties.DataSource = YDOrderDetailsBindingSource
            .Properties.DisplayMember = "ItemDetails"
            .Properties.ValueMember = "YDOrderDetailsId"
            .Properties.View.OptionsBehavior.AutoPopulateColumns = False
            .Properties.View.BestFitColumns()
            .Properties.PopupFormWidth = 300
        End With

        ' Add two columns in the dropdown:
        Dim col1 As GridColumn = BookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("ItemDetails")
        col1.VisibleIndex = 0
        col1.Caption = "Item Details"

    End Sub
    Private Sub PopulateAccBookingDetails()

        With BookingDetailsIdGridLookUpEdit
            .Properties.DataSource = VBookingLookupBindingSource
            .Properties.DisplayMember = "ItemDetails"
            .Properties.ValueMember = "BookingDetailsId"
            .Properties.View.OptionsBehavior.AutoPopulateColumns = False
            .Properties.View.BestFitColumns()
            .Properties.PopupFormWidth = 300
        End With

        Dim col1 As GridColumn = BookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("ItemDetails")
        Dim col2 As GridColumn = BookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("BookingDetailsId")
        col1.VisibleIndex = 0
        col1.Caption = "Item Details"
        col2.VisibleIndex = 1
        col1.Caption = "BDID"


        With TransBookingDetailsIdGridLookUpEdit
            .Properties.DataSource = VBookingLookup1BindingSource
            .Properties.DisplayMember = "ItemDetails"
            .Properties.ValueMember = "BookingDetailsId"
            .Properties.View.OptionsBehavior.AutoPopulateColumns = False
            .Properties.View.BestFitColumns()
            .Properties.PopupFormWidth = 300
        End With

        Dim col3 As GridColumn = TransBookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("ItemDetails")
        Dim col4 As GridColumn = TransBookingDetailsIdGridLookUpEdit.Properties.View.Columns.AddField("BookingDetailsId")
        col3.VisibleIndex = 0
        col3.Caption = "Item Details"
        col4.VisibleIndex = 1
        col4.Caption = "BDID"


    End Sub

    Private Sub RequisitionNoLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RequisitionNoLinkLabel.LinkClicked
        ShowMaster(frmRequisitionNo)

        If frmRequisitionNo.DialogResult = System.Windows.Forms.DialogResult.OK Then
            RequistionNoTextBox.Text = frmRequisitionNo.RqNo
        End If

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles IsLeftOverCheckEdit.CheckedChanged
        If IsLeftOverCheckEdit.Checked Then
            IssueQuantityTextBox.Visible = False
        Else
            IssueQuantityTextBox.Visible = False
        End If
    End Sub

    Private Sub IssueQuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles IssueQuantityTextBox.TextChanged, ActIssueQtyTextBox.TextChanged



    End Sub

    Private Sub IssueGridControl_Click(sender As Object, e As EventArgs) Handles IssueGridControl.Click

    End Sub

    Private Sub TransProgramNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TransProgramNoTextBox.TextChanged
        On Error Resume Next

        If DepartmentId = GarmentsStoreId Then

            Me.VBookingLookup1TableAdapter.Fill(Me.BookingDataSet.vBookingLookup1, DepartmentId, ProgramNoTextBox.Text)

            '    If VBookingLookupBindingSource.Position > -1 Then
            '        ItemIdGridLookUpEdit.Properties.ReadOnly = True
            '        'ItemIdLinkLabel.Enabled = False
            '        BookingDetailsIdGridLookUpEdit.Enabled = True

            '    Else
            '        ItemIdGridLookUpEdit.Properties.ReadOnly = False
            '        'ItemIdLinkLabel.Enabled = True
            '        BookingDetailsIdGridLookUpEdit.Enabled = False
            '    End If

            'ElseIf DepartmentId = YDStoreId Then

            '    Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

            '    If YDOrderDetailsBindingSource.Position > -1 Then
            '        ItemIdGridLookUpEdit.Properties.ReadOnly = True
            '        BookingDetailsIdGridLookUpEdit.Enabled = True

            '    Else
            '        ItemIdGridLookUpEdit.Properties.ReadOnly = False
            '        BookingDetailsIdGridLookUpEdit.Enabled = False
            '    End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ShowByItemButton.Click

        On Error Resume Next
        If ItemListBindingSource.Position > -1 Then



            Me.IssueTableAdapter.FillByItemId(Me.IssueDataSet.Issue, GridLookUpEdit1.EditValue, DepartmentId)
            Me.PILookUpTableAdapter.Fill(Me.PILookUpDataSet.PILookUp, Me.GridLookUpEdit1.EditValue)


        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If DepartmentId = YarnStoreId AndAlso ProgramNoTextBox.Text = String.Empty Then

            Dim ABC As String = Now.Year.ToString.Substring(2) & "YTR"
            Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(YTRNo),0, CHARINDEX('C',REVERSE(YTRNo)))) AS INT))  From Issue Where YTRNo Like '" & ABC & "%'", cnn)
            Me.YTRNoTextBox.Text = Now.Year.ToString.Substring(2) & "YTR" & (Val(XYZ) + 1).ToString()
            Me.IssueDateDateTimePicker.Text = Today()

        End If

    End Sub


End Class
