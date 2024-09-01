Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraGrid.Columns

Public Class frmReceive

    Private Sub frmReceive_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    'Private Sub ReceiveBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.ReceiveBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ReceiveDataSet)

    'End Sub

    Private Sub frmReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitDataSet.Unit' table. You can move, or remove it, as needed.
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)

        On Error Resume Next

        Me.YDOrderTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrder)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
        Me.KWOrderLookupTableAdapter.Fill(Me.KWOrderLookupDataSet.KWOrderLookup)
        Me.LCListTableAdapter.Fill(Me.OpeningLCDataSet.LCList, DepartmentId)
        Me.PIListTableAdapter.FillByDepartmentId(Me.OpeningLCDataSet.PIList, DepartmentId)
        Me.ItemLocationTableAdapter.Fill(Me.ItemLocationDataSet.ItemLocation, DepartmentId)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.BookingProgramNoLookupTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoLookup, DepartmentId)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.VItemListTableAdapter.FillByDepartmentId(Me.ItemNameDataSet.vItemList, DepartmentId)
        Me.ItemListTableAdapter1.Fill(Me.ItemListLookupDataSet.ItemList, DepartmentId)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentId)

        IsLCTracking = ReadBooleanData("Select IsLCTracking From Department Where DepartmentId=" & DepartmentId, cnn)

        Me.ReceiveDataSet.Receive.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.ReceiveDataSet.Receive.ReceiveDateColumn.DefaultValue = Today()
        Me.ReceiveDataSet.Receive.CompanyIdColumn.DefaultValue = 1
        Me.ReceiveDataSet.Receive.DollarValueColumn.DefaultValue = ReadData("Select NumberValue From prmDollarValue", cnn)
        Me.ReceiveDataSet.Receive.LeftOverQuantityColumn.DefaultValue = 0
        Me.ReceiveDataSet.Receive.UserIdColumn.DefaultValue = UserId
        Me.ReceiveDataSet.Receive.ModifiedOnColumn.DefaultValue = Now()

        LoadAutoCompleteList("Select ProgramNo From Booking", ProgramNoTextBox)
        'SetUserRights("Receive", UserId, NewButton, EditButton, DeleteButton)
        DisableControl(GroupBox1)
        LoadAutoCompleteList("Select ChallanNo From Receive Where DepartmentId=" & DepartmentId, ChallanNoTextBox)


        If CheckUserRights("Receive").CanEdit = False Then

            'NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False

            CancelEntryButton.Enabled = False

        ElseIf CheckUserRights("Receive").CanDelete = False Then

            'NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True

        End If


        If DepartmentId = GarmentsStoreId Then
            PopulateAccBookingDetails()
        ElseIf DepartmentId = YDStoreId Then
            PopulateYDBookingDetails()
        End If


        If IsLCTracking = True Then
            ItemIdGridLookUpEdit.Properties.ReadOnly = True
        End If


    End Sub



    Private Sub ReceiveDateDateTimePicker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReceiveDateDateTimePicker.GotFocus

        'If ReceiveDateDateTimePicker.CustomFormat = " " Then
        '    ReceiveDateDateTimePicker.CustomFormat = "dd-MMM-yy"

        '    'if the following is not used the DatePicker does not appear to have
        '    'focus and extra key strokes are required before keyboard data entry can begin
        '    'SendKeys("{LEFT}", True)
        '    'SendKeys("{RIGHT}")
        'End If

    End Sub


    Private Sub ChallanNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChallanNoTextBox.TextChanged

    End Sub

    'Private Sub PriceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceButton.Click

    '    frmItemList.MdiParent = frmMain
    '    frmItemList.WindowState = FormWindowState.Normal
    '    frmItemList.Show()


    'End Sub





    'Private Sub ItemIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemIdTextBox.TextChanged
    '    'On Error Resume Next

    '    '    '----- Start numeric text ------------------------------------
    '    '    Dim Chars() As Char = ItemIdTextBox.Text.ToCharArray
    '    '    Dim NumOnly As New System.Text.StringBuilder(ItemIdTextBox.Text.Length)
    '    '    For Each c As Char In Chars
    '    '        If Char.IsDigit(c) Then
    '    '            NumOnly.Append(c)
    '    '        End If
    '    '    Next
    '    '    Dim InsertionPoint As Integer = ItemIdTextBox.SelectionStart
    '    '    ItemIdTextBox.Text = NumOnly.ToString
    '    '    ItemIdTextBox.SelectionStart = InsertionPoint
    '    '    '------ End numeric text------------------------------------------------




    '    '    If ItemIdTextBox.Text = String.Empty Then
    '    '        Label1.Visible = False
    '    '    Else
    '    '        Label1.Visible = True
    '    '    End If

    '    '    If VItemListBindingSource.Position = -1 Then
    '    '        ErrorProvider1.SetError(ItemIdTextBox, "Item Id is not available in Chemical List")
    '    '        'ItemIdTextBox.Text = String.Empty
    '    '    Else
    '    '        ErrorProvider1.Clear()

    '    'Search Price
    '    'Me.VItemListTableAdapter.FillByItemNo(Me.ItemNameDataSet.vItemList, CType(ItemIdTextBox.Text, Long), DepartmentId)

    '    'Dim dr As ItemNameDataSet.vItemListRow
    '    'dr = CType(CType(Me.VItemListBindingSource.Current, DataRowView).Row, ItemNameDataSet.vItemListRow)
    '    'PriceTextBox.Text = dr.CurrentPrice


    'End Sub



    'Private Sub ItemListComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemListComboBox.SelectedIndexChanged

    '    Dim Index As Integer

    '    Index = ReceiveBindingSource.Find("ItemId", ItemListComboBox.SelectedValue)

    '    If Index > -1 Then

    '        ReceiveBindingSource.Position = Index
    '        ReceiveDataGridView.CurrentRow.Selected = True
    '        ErrorProvider1.Clear()

    '    Else

    '        ErrorProvider1.SetError(ItemListComboBox, "Data Not Found")

    '    End If


    'End Sub


    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click


        ClickNewButton()

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        Dim row As ReceiveDataSet.ReceiveRow
        row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

        '*** Restriction ***'

        If My.Settings.EditRestrictionDays > 0 Then

            Dim RcvDate As Date = ReadDateData("Select ReceiveDate From Receive Where ReceiveId= " & row.ReceiveId, cnn)
            Dim DayCount As Integer = ReadIntData("Select datediff(day,'" & RcvDate & "',getdate())", cnn)

            If DayCount > My.Settings.EditRestrictionDays Then
                MessageBox.Show(DayCount & " days are passed, so not allowed to edit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

        If IsLCTracking = True Then


            Dim ChkLotAndPI As Integer = ReadIntData("Select Count(*) From Issue Where PIId=" & row.PIId & "And LotNo='" & row.YarnLotNo & "'", cnn)

            If ChkLotAndPI > 0 Then
                YarnLotNoTextBox.ReadOnly = True
                OpeningLCButton.Enabled = False
            Else
                YarnLotNoTextBox.ReadOnly = False
                OpeningLCButton.Enabled = True
            End If

            If IsUsed("LCId", row.LCId, "LCLIst", "PIList", "Receive") = True And UserLevel <> 1 Then
                MessageBox.Show("Not allowed , already used.")
                Exit Sub
            End If

        End If

        If EditButton.Text = "&Edit" Then

            EnableControl(GroupBox1)
            'Me.MRRNoTextBox.Enabled = False

            If VBookingLookupBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else
                If IsLCTracking = False Then
                    ItemIdGridLookUpEdit.Properties.ReadOnly = False
                End If

                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If

            If UserLevel = 1 Then
                MRRNoTextBox.Enabled = True
                MRRNoTextBox.ReadOnly = False
            Else
                MRRNoTextBox.Enabled = False
                MRRNoTextBox.ReadOnly = True
            End If


            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            'Validating.... 

            'Dim row As ReceiveDataSet.ReceiveRow
            'row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)


            If IsDBNull(row.ItemId) = True Then
                ErrorProvider1.SetError(ItemIdGridLookUpEdit, "Select an Item")
                ItemIdGridLookUpEdit.Focus()
                Exit Sub

            ElseIf row.ReceiveQuantity <= 0 And IsLeftOverCheckEdit.Checked = False Then
                ErrorProvider1.SetError(ReceiveQuantityTextBox, "Quantity should greater then 0")
                ReceiveQuantityTextBox.Focus()
                Exit Sub

            ElseIf row.IsCompanyIdNull Then
                ErrorProvider1.SetError(BranchComboBox, "Select a Company")
                CompanyIdComboBox.Focus()
                Exit Sub

            Else
                Save()
            End If

            '===================================================
            If ReceiveBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If

            CancelEntryButton.Enabled = False


            DisableControl(GroupBox1)
            EditButton.Text = "&Edit"
            NewButton.Enabled = True
            DeleteButton.Enabled = True


            If CheckUserRights("Receive").CanEdit = False Then

                'NewButton.Enabled = False
                EditButton.Enabled = False
                DeleteButton.Enabled = False

                CancelEntryButton.Enabled = False

            ElseIf CheckUserRights("Receive").CanDelete = False Then

                'NewButton.Enabled = True
                EditButton.Enabled = True
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = True

            End If






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
                ReceiveBindingSource.RemoveCurrent()
            Else

                Exit Sub

            End If


        Else

            'Saveing/Updating...
            Save()
            '======================================================
            If ReceiveBindingSource.Position = -1 Then
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
        Me.ReceiveTableAdapter.FillByDepartmentId(Me.ReceiveDataSet.Receive, DepartmentId)
        'TODO: This line of code loads data into the 'ConveyanceDataSet.ConveyanceBill' table. You can move, or remove it, as needed.
        'Me.ConveyanceBillTableAdapter.Fill(Me.ConveyanceDataSet.ConveyanceBill)

        DisableControl(GroupBox1)

        NewButton.Text = "&New"
        EditButton.Text = "&Edit"
        DeleteButton.Text = "&Delete"

        If CheckUserRights("Receive").CanEdit = False Then

            'NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False

        ElseIf CheckUserRights("Receive").CanDelete = False Then

            DeleteButton.Enabled = False

        End If

        CancelEntryButton.Enabled = False
        TotalReceiveQuantityLabel2.Text = ""
        BalanceLabel.Text = ""

    End Sub

    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.TextChanged

        On Error Resume Next

        If DepartmentId = GarmentsStoreId Then

            Me.VBookingLookupTableAdapter.Fill(Me.BookingDataSet.vBookingLookup, DepartmentId, ProgramNoTextBox.Text)

            If VBookingLookupBindingSource.Position > -1 Then
                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                BookingDetailsIdGridLookUpEdit.Enabled = True
            Else
                ItemIdGridLookUpEdit.Properties.ReadOnly = False
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
    Private Sub PopulateYDBookingDetails()

        'Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderIdGridLookUpEdit.EditValue)

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
        col1.VisibleIndex = 0
        col1.Caption = "Item Details"

       

    End Sub



    Private Sub BookingDetailsIdGridLookUpEdit_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles BookingDetailsIdGridLookUpEdit.Closed
        ''Getting ItemId from VBookingLookupBindingSource eg. row.ItemId

        'Dim row As BookingDataSet.vBookingLookupRow
        'row = CType(CType(Me.VBookingLookupBindingSource.Current, DataRowView).Row, BookingDataSet.vBookingLookupRow)

        ''Dim Index As Integer
        ''Index = ItemListLookupBindingSource.Find("ItemId", row.ItemId)
        ''ItemListLookupBindingSource.Position = Index

        ''ItemIdTextBox.Text = row.ItemId

        ''Dim Index As Integer
        ''Index = ItemListLookupBindingSource.Find("ItemId", row.ItemId)
        ''ItemListLookupBindingSource.Position = Index

        ''ItemIdTextBox.Text = row.ItemId

        'Dim row2 As ReceiveDataSet.ReceiveRow
        'row2 = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)
        'row2.ItemId = row.ItemId
        'row2.BookingDetailsId = row.BookingDetailsId

        ''MessageBox.Show(row2.ReceiveId)
        ''Dim ReceiveRow As ReceiveDataSet.ReceiveRow

        ''If IsDBNull(row2.ReceiveId) = False Then
        ''    ReceiveRow = Me.ReceiveDataSet.Receive.FindByReceiveId(row2.ReceiveId)
        ''    ReceiveRow.ItemId = row.ItemId
        ''    ReceiveRow.BookingDetailsId = row.BookingDetailsId



        'ReceiveBindingSource.ResetCurrentItem()

        'On Error Resume Next

        'Me.TotalReceiveQuantityTableAdapter.Fill(Me.ReceiveDataSet.TotalReceiveQuantity, row.BookingDetailsId)
        'BalanceLabel.Text = row.BookingQuantity - IIf(TotalReceiveQuantityLabel2.Text = String.Empty, 0, TotalReceiveQuantityLabel2.Text)
        ''End If


    End Sub




    'Private Sub ItemIdLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ItemIdLinkLabel.LinkClicked
    '    blnIssue = True
    '    frmItemList2.ShowDialog()
    'End Sub

    Private Sub ItemIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemIdGridLookUpEdit.EditValueChanged, ActUnitGridLookUpEdit.EditValueChanged, UnitIdGridLookUpEdit.EditValueChanged

        On Error Resume Next

        If ItemListBindingSource.Position > -1 Then

            If IsLCTracking = False Then

                If ItemIdGridLookUpEdit.EditValue > -1 AndAlso DepartmentId <> GarmentsStoreId Then
                    PriceTextBox.Text = ReadData("Select CurrentPrice From ItemList Where ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
                    TTLReceivedLabel.Text = ReadData("Select Sum(ReceiveQuantity) From Receive Where ItemId=" & ItemIdGridLookUpEdit.EditValue, cnn)
                End If

            End If

        End If



    End Sub


    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        Me.ReceiveTableAdapter.FillByDepartmentId(Me.ReceiveDataSet.Receive, DepartmentId)
        LoadAutoCompleteList("Select ChallanNo From Receive Where ChallanNo='" & Me.ChallanNoTextBox.Text & "' And DepartmentId=" & DepartmentId, ChallanNoTextBox)

    End Sub

    Private Sub BalanceLabel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BalanceLabel.DoubleClick
        ReceiveQuantityTextBox.Text = BalanceLabel.Text
    End Sub



    Private Sub ImportedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportedCheckBox.CheckedChanged

        'If ImportedCheckBox.Checked = True Then
        '    LCNoTextEdit.Properties.ReadOnly = False
        '    LCDateDateTimePicker.Enabled = True
        'Else
        '    LCNoTextEdit.Properties.ReadOnly = True
        '    LCDateDateTimePicker.Enabled = False
        'End If

    End Sub

    Private Sub ReceiveDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.GotFocus

        ItemIdGridLookUpEdit.Focus()

    End Sub

    Private Sub ItemNameSearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNameSearchTextBox.TextChanged

        On Error Resume Next

        If StartWithCheckBox.Checked Then
            Me.ReceiveTableAdapter.FillByItemNameStartWith(Me.ReceiveDataSet.Receive, DepartmentId, ItemNameSearchTextBox.Text)
        Else
            Me.ReceiveTableAdapter.FillByItemName(Me.ReceiveDataSet.Receive, DepartmentId, ItemNameSearchTextBox.Text)
        End If


    End Sub


    Private Sub OpeningLCButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpeningLCButton.Click


        frmLCDetailsView.DepartmentId = DepartmentId

        ShowMaster(frmLCDetailsView)

        If frmLCDetailsView.DialogResult = System.Windows.Forms.DialogResult.OK Then

            If ReceiveBindingSource.Position > -1 Then

                'Dim row As ReceiveDataSet.ReceiveRow
                'row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

                On Error Resume Next

                'row.LCNo = frmLCDetailsView.LCNo

                'If DBNull.Value.Equals(frmLCDetailsView.LCDate) = False Then
                '    row.LCDate = frmLCDetailsView.LCDate
                'Else
                '    row.LCDate = Today()
                'End If

                'row.PINO = frmLCDetailsView.PINO


                'If DBNull.Value.Equals(frmLCDetailsView.PIDate) = False Then
                '    row.PIDate = frmLCDetailsView.PIDate
                'Else
                '    row.PIDate = Today()
                'End If


                SupplierIdGridLookUpEdit.EditValue = frmLCDetailsView.SupplierId
                ItemIdGridLookUpEdit.EditValue = frmLCDetailsView.ItemId
                'YarnLotNoTextBox.Text = frmLCDetailsView.LotNo
                PriceTextBox.Text = frmLCDetailsView.LCPrice
                CompanyIdComboBox.SelectedValue = frmLCDetailsView.CompanyId
                SupplierIdGridLookUpEdit.EditValue = frmLCDetailsView.SupplierId
                ImportedCheckBox.Checked = True
                LCIdGridLookUpEdit.EditValue = frmLCDetailsView.LCId
                PIGridLookUpEdit.EditValue = frmLCDetailsView.PIId

                'Me.ReceiveBindingSource.ResetBindings(True)
                'MessageBox.Show(frmLCDetailsView.LCId & "," & frmLCDetailsView.PIId & "," & frmLCDetailsView.ItemId)

                Dim TTLReceived As Decimal = ReadData("Select Sum(ReceiveQuantity) From Receive Where PIId=" & frmLCDetailsView.PIId & " And ItemId=" & frmLCDetailsView.ItemId, cnn)
                Dim TTLLCQty As Decimal = ReadData("Select Sum(LCQuantity) From PIList Where PIId=" & frmLCDetailsView.PIId & " And ItemId=" & frmLCDetailsView.ItemId, cnn)

                TTLReceivedLabel.Text = TTLReceived


                Dim row As ReceiveDataSet.ReceiveRow
                row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

                If (row.ReceiveId > 228510 OrElse row.ReceiveId <= -1) Then
                    YarnLotNoTextBox.Text = "{0}::{1}"
                    YarnLotNoTextBox.Text = System.String.Format(YarnLotNoTextBox.Text, Me.LotNoWOLCTextBox.Text, LCIdGridLookUpEdit.Text)
                Else
                    YarnLotNoTextBox.Text = "{0}"
                    YarnLotNoTextBox.Text = System.String.Format(YarnLotNoTextBox.Text, Me.LotNoWOLCTextBox.Text)
                End If



                If IsLeftOverCheckEdit.Checked = False Then
                        ReceiveQuantityTextBox.Text = TTLLCQty - TTLReceived
                    Else
                        ReceiveQuantityTextBox.Text = 0
                    End If

                End If

            End If


    End Sub

    Private Sub frmReceive_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F12 Then

            ClickNewButton()

        End If
    End Sub

    Private Sub ClickNewButton()

        On Error Resume Next
        Dim DV As Decimal = ReadData("Select NumberValue From prmDollarValue", cnn)

        If NewButton.Text = "&New" Then

            EnableControl(GroupBox1)
            Me.MRRNoTextBox.Enabled = False
            OpeningLCButton.Enabled = True
            YarnLotNoTextBox.ReadOnly = False
            'If ImportedCheckBox.Checked = True Then
            '    LCNoTextEdit.Properties.ReadOnly = False
            '    LCDateDateTimePicker.Enabled = True
            'ElseIf ImportedCheckBox.Checked = False Then
            '    LCNoTextEdit.Properties.ReadOnly = True
            '    LCDateDateTimePicker.Enabled = False
            'End If


            If VBookingLookupBindingSource.Position > -1 Then

                ItemIdGridLookUpEdit.Properties.ReadOnly = True
                BookingDetailsIdGridLookUpEdit.Enabled = True

            Else

                If IsLCTracking = False Then
                    ItemIdGridLookUpEdit.Properties.ReadOnly = False
                End If

                BookingDetailsIdGridLookUpEdit.Enabled = False
            End If

            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


            TotalReceiveQuantityLabel2.Text = ""
            BalanceLabel.Text = ""

            If CopyCheckBox.Checked Then

                '---Copy current row
                Dim oldrow As ReceiveDataSet.ReceiveRow
                oldrow = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

                '---Paste current row to new row

                Dim newRow As ReceiveDataSet.ReceiveRow = Me.ReceiveDataSet.Receive.NewRow()


                newRow.ReceiveDate = oldrow.ReceiveDate
                newRow.ChallanNo = oldrow.ChallanNo
                newRow.BranchId = oldrow.BranchId
                newRow.DollarValue = DV

                If ProgramNoTextBox.Text <> String.Empty Then
                    newRow.ProgramNo = oldrow.ProgramNo
                Else
                    newRow.ProgramNo = ""
                End If

                newRow.ItemId = Nothing
                newRow.Price = 0
                newRow.ReceiveQuantity = 0
                'newRow.PrintingMediaId = ""

                If oldrow.IsLCNoNull Then
                    newRow.LCNo = ""
                Else
                    newRow.LCNo = oldrow.LCNo
                End If

                If oldrow.IsLCDateNull Then
                    newRow.LCDate = ""
                Else
                    newRow.LCDate = oldrow.LCDate
                End If

                newRow.SupplierId = oldrow.SupplierId
                newRow.IssueReceiveTypeId = oldrow.IssueReceiveTypeId
                newRow.Remarks = ""
                newRow.CompanyId = oldrow.CompanyId
                newRow.PINO = oldrow.PINO
                newRow.PIDate = oldrow.PIDate
                newRow.Imported = oldrow.Imported
                newRow.PIId = oldrow.PIId
                newRow.LCId = oldrow.LCId
                If ReferenceTextBox.Text = "" Then
                    newRow.Reference = ""
                Else
                    newRow.Reference = oldrow.Reference

                End If

                If oldrow.IsMRRNoNull Then
                    newRow.MRRNo = 0
                Else
                    newRow.MRRNo = oldrow.MRRNo
                End If

                '--------------

                'ReceiveDataGridView.ReadOnly = False

                Me.ReceiveDataSet.Receive.Rows.Add(newRow)
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

                ReceiveDateDateTimePicker.Enabled = False
                ChallanNoTextBox.Enabled = False
                BranchComboBox.Enabled = False
                'LCDateDateTimePicker.Enabled = False
                SupplierIdGridLookUpEdit.Enabled = False
                ReceiveTypeComboBox.Enabled = False
                ReceiveBindingSource.MoveLast()

                ItemIdGridLookUpEdit.Focus()



            Else


                ReceiveDataSet.Receive.DollarValueColumn.DefaultValue = DV
                ReceiveBindingSource.AddNew()

                Dim index As Integer = Me.SupplierBindingSource.Find("SupplierCode", "NCL")
                Me.SupplierBindingSource.Position = index

                ReceiveDateDateTimePicker.Focus()
                SupplierIdGridLookUpEdit.Enabled = True
                SupplierIdGridLookUpEdit.Properties.ReadOnly = False


                'ReceiveDateDateTimePicker.CustomFormat = " "
                'ReceiveDateDateTimePicker.Format = DateTimePickerFormat.Custom

            End If



        Else

            'Validating.... 

            'Dim row As ReceiveDataSet.ReceiveRow
            'row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)


            If ItemIdGridLookUpEdit.Text = String.Empty Then
                ErrorProvider1.SetError(ItemIdGridLookUpEdit, "Select an Item")
                ItemIdGridLookUpEdit.Focus()
                Exit Sub
            ElseIf Val(ReceiveQuantityTextBox.Text) <= 0 AndAlso IsLeftOverCheckEdit.Checked = False Then
                ErrorProvider1.SetError(ReceiveQuantityTextBox, "Quantity should greater then 0")
                ReceiveQuantityTextBox.Focus()
                Exit Sub
            ElseIf CompanyIdComboBox.Text = String.Empty Then
                ErrorProvider1.SetError(CompanyIdComboBox, "Select a Company")
                CompanyIdComboBox.Focus()
                Exit Sub
            Else

                Save()
                UpdateMasterReceiveId()


            End If

            '==================================================

            DisableControl(GroupBox1)
            NewButton.Text = "&New"
            EditButton.Enabled = True
            'EditButton.Enabled = True

            'If ReceiveBindingSource.Position > -1 Then
            '    DeleteButton.Enabled = True
            'End If

            'CancelEntryButton.Enabled = False

            If CheckUserRights("Receive").CanEdit = False Then

                'NewButton.Enabled = False
                EditButton.Enabled = False
                'DeleteButton.Enabled = False

                CancelEntryButton.Enabled = False

            ElseIf CheckUserRights("Receive").CanDelete = False Then

                'NewButton.Enabled = True
                'EditButton.Enabled = True
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = False

            End If



        End If

    End Sub


    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged
        Me.ReceiveTableAdapter.FillByProgramNo(Me.ReceiveDataSet.Receive, ProgramNoGridLookUpEdit.EditValue, DepartmentId)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveDateTimePicker.ValueChanged
        Me.ReceiveTableAdapter.FillByReceiveDate(Me.ReceiveDataSet.Receive, ReceiveDateTimePicker.Text, DepartmentId)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ReceiveTableAdapter.FillByChallanNo(Me.ReceiveDataSet.Receive, ChallanTextBox.Text, DepartmentId)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DBNull.Value.Equals(ItemIdGridLookUpEdit.EditValue) Then

            MessageBox.Show("Pls,select Item Name")

        Else

            LoadAutoCompleteList("Select YarnLotNo From Receive Where ItemId=" & ItemIdGridLookUpEdit.EditValue, YarnLotNoTextBox)
            LoadAutoCompleteList("Select LotNoWOLC From Receive Where ItemId=" & ItemIdGridLookUpEdit.EditValue, LotNoWOLCTextBox)

        End If

        If IsLCTracking = True Then
            Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdGridLookUpEdit.EditValue, YarnLotNoTextBox.Text, DepartmentId)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.ItemLocationTableAdapter.Fill(Me.ItemLocationDataSet.ItemLocation, DepartmentId)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        Me.BookingProgramNoLookupTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoLookup, DepartmentId)
        'Me.VItemListTableAdapter.Fill(Me.ItemNameDataSet.vItemList)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.VItemListTableAdapter.FillByDepartmentId(Me.ItemNameDataSet.vItemList, DepartmentId)

        Me.ItemListTableAdapter1.Fill(Me.ItemListLookupDataSet.ItemList, DepartmentId)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        'Me.ReceiveTableAdapter.FillByReceiveDate(Me.ReceiveDataSet.Receive, Me.ReceiveDateDateTimePicker.Text, DepartmentId)
        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentId)

    End Sub

    Private Sub UpdateItemAvgPrice()

        'If IsLCTracking = True Then
        ExecuteQuery("Execute UpdateItemAvgPrice " & ItemIdGridLookUpEdit.EditValue, cnn)
        'End If

    End Sub

    Private Sub LCIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LCIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.PIListLookupTableAdapter.Fill(Me.OpeningLCDataSet.PIListLookup, DepartmentId, LCIdGridLookUpEdit.EditValue)
    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ''IK Start
        ''Author: Imrul Kaesh, Date on: 07.04.13, Description:	Grid to Excel file Export system
        Try
            GridControl1.ExportToXls("d:\Export to file.xls")
            ''MsgBox("Your file successfully save in dasktop ")
            MessageBox.Show("Your File is Save to ""d:\Export to file.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)


        End Try
        ''IK Stop
    End Sub

    Private Sub UpdateMasterReceiveId()

        If ReceiveBindingSource.Position > -1 Then

            Dim row As ReceiveDataSet.ReceiveRow
            row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

            If row.IsMasterReceiveIdNull Then
                row.MasterReceiveId = row.ReceiveId
            End If

            Save()

        End If

    End Sub

    Private Sub Save()

        Try
            Dim row As ReceiveDataSet.ReceiveRow
            row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)

            row.UserId = UserId
            row.ModifiedOn = ReadDateData("Select GetDate()", cnn)

            Me.Validate()
            Me.ReceiveBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ReceiveDataSet)
            ErrorProvider1.Clear()
            UpdateItemAvgPrice()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub PIIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        If IsLCTracking = True Then

            Dim row As PIAnditemwiseBalanceDataSet.PIAndItemwiseBalanceRow
            row = CType(CType(Me.PIAndItemwiseBalanceBindingSource.Current, DataRowView).Row, PIAnditemwiseBalanceDataSet.PIAndItemwiseBalanceRow)

            LCIdGridLookUpEdit.EditValue = row.LCId
            PIGridLookUpEdit.EditValue = row.PIId

            PriceTextBox.Text = ReadData("Select LCPrice From PIList Where PIId=" & PIGridLookUpEdit.EditValue, cnn)

        End If

    End Sub



    Private Sub BookingDetailsIdGridLookUpEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookingDetailsIdGridLookUpEdit.EditValueChanged

        If ReceiveBindingSource.Position = -1 Then
            Exit Sub
        End If
        On Error Resume Next
        Dim TTLReceive As Double = 0
        Dim TTLBooking As Double = 0
        Dim TotalPIQTY As Double = 0

        If DepartmentId = GarmentsStoreId Then

            ItemIdGridLookUpEdit.EditValue = ReadIntegerData("Select ItemId From BookingDetails where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            PriceTextBox.Text = ReadData("Select UnitPrice From BookingDetails where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TTLReceive = ReadData("Select Sum(ReceiveQuantity) From Receive Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TTLBooking = ReadData("Select Sum(BookingQuantity) From BookingDetails Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TotalReceiveQuantityLabel2.Text = TTLReceive
            BalanceLabel.Text = TTLBooking - TTLReceive
            'ReceiveQuantityTextBox.Text = TTLBooking - TTLReceive

        ElseIf DepartmentId = YDStoreId Then

            ItemIdGridLookUpEdit.EditValue = ReadIntegerData("Select ItemId From ItemList where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            PriceTextBox.Text = ReadData("Select CurrentPrice From ItemList where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TTLReceive = ReadData("Select Sum(ReceiveQuantity) From Receive Where BookingDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TTLBooking = ReadData("Select Sum(OrderQuantity) From YDOrderDetails Where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            YarnLotNoTextBox.Text = ReadStringData("Select LotNo From YDOrderDetails Where YDOrderDetailsId=" & BookingDetailsIdGridLookUpEdit.EditValue, cnn)
            TotalReceiveQuantityLabel2.Text = TTLReceive
            BalanceLabel.Text = TTLBooking - TTLReceive

            'ReceiveQuantityTextBox.Text = TTLBooking - TTLReceive

        Else

            If IsLCTracking = True Then

                TTLReceive = ReadData("Select Sum(ReceiveQuantity) From Receive Where ItemId = " & ItemIdGridLookUpEdit.EditValue & " AND PIId= " & PIGridLookUpEdit.EditValue, cnn)
                TotalPIQTY = ReadData("Select Sum(LCQuantity) From PIList Where PIId=" & PIGridLookUpEdit.EditValue, cnn)
                TotalReceiveQuantityLabel2.Text = TTLReceive
                BalanceLabel.Text = TotalPIQTY - TTLReceive

            Else

                BalanceLabel.Text = 0

            End If


        End If

    End Sub

    Private Sub FinishFabricBookingIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishFabricBookingIdGridLookUpEdit.EditValueChanged
        ProgramNoTextBox.Text = FinishFabricBookingIdGridLookUpEdit.Text
    End Sub

    Private Sub MRRNoLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles MRRNoLinkLabel.LinkClicked
        If MessageBox.Show("Are you sure you want to create New MRR No?.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim XYZ As Integer = ReadIntData("Select Max(MaxMRRNo) From MaxMRRNoList", cnn)
            Me.MRRNoTextBox.Text = XYZ + 1
            Me.MRRDateDateEdit.Text = Today()
            Save()
        End If


    End Sub

    Private Sub YDOrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YDOrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.FinishFabricBookingIdGridLookUpEdit.EditValue = ReadIntegerData("Select FinishFabricBookingId From YDOrder Where YDOrderId=" & YDOrderIdGridLookUpEdit.EditValue, cnn)
    End Sub

    Private Sub KnittingOrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnittingOrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        FinishFabricBookingIdGridLookUpEdit.EditValue = ReadIntegerData("Select FinishFabricBookingId From KnittingOrder Where KnittingOrderId=" & KnittingOrderIdGridLookUpEdit.EditValue, cnn)
    End Sub

    
    
    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click

        'On Error Resume Next

        Dim XYZ As Integer = ReadIntData("Select Max(MRRNo)From Receive Where DepartmentId=" & DepartmentId, cnn)
        Dim MR2Date As Date = ReadDateData("Select Max(MRRDate) From Receive Where DepartmentId=" & DepartmentId & " And MRRNo=" & XYZ, cnn)
        Me.MRRNoTextBox.Text = XYZ
        Me.MRRDateDateEdit.Text = MR2Date
        Me.DollarValueTextBox.Text = ReadData("Select NumberValue From prmDollarValue", cnn)


    End Sub

    Private Sub PIGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub ExpiryDateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ShowByItemButton.Click
        Me.ReceiveTableAdapter.FillByItemId(Me.ReceiveDataSet.Receive, ItemNameSrchGridLookUpEdit.EditValue)
    End Sub

    Private Sub IsLeftOverCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles IsLeftOverCheckEdit.CheckedChanged
        If IsLeftOverCheckEdit.Checked Then
            ReceiveQuantityTextBox.Visible = False
        Else
            ReceiveQuantityTextBox.Visible = True
        End If
    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged, DollarValueTextBox.TextChanged

    End Sub
    Function IsUsed(ByVal ColName As String, ByVal ColValue As Integer, ByVal extblname1 As String, ByVal extblname2 As String, ByVal extblname3 As String) As Boolean 'excluded table name

        Dim cnt As Integer = 0 'count
        Dim bln As Boolean = False 'boolean

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "SELECT name FROM sysobjects WHERE id IN ( SELECT id FROM syscolumns WHERE name = '" & ColName & "' ) And xtype='U'"

            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()


            While reader.Read()

                Dim i As Integer = 0
                If reader(0).ToString = extblname1 Then
                    i = 1
                ElseIf reader(0).ToString = extblname2 Then
                    i = 1
                ElseIf reader(0).ToString = extblname3 Then
                    i = 1
                Else
                    i = 0
                End If

                If i = 0 Then
                    cnt = cnt + ReadIntData("Select Count(*) As cnt From [" & reader(0).ToString & "] Where " & ColName & " = " & ColValue, cnn)
                End If

            End While

            reader.Close()
            connection.Close()

        End Using

        If cnt > 0 Then
            bln = True
        Else
            bln = False
        End If

        Return bln

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LotNoWOLCTextBox.TextChanged
        '228510

        On Error Resume Next
        Dim row As ReceiveDataSet.ReceiveRow
            row = CType(CType(Me.ReceiveBindingSource.Current, DataRowView).Row, ReceiveDataSet.ReceiveRow)
        If (row.ReceiveId > 228510 OrElse row.ReceiveId <= -1) Then
            YarnLotNoTextBox.Text = "{0}::{1}"
            YarnLotNoTextBox.Text = System.String.Format(YarnLotNoTextBox.Text, Me.LotNoWOLCTextBox.Text, LCIdGridLookUpEdit.Text)
        Else
            YarnLotNoTextBox.Text = "{0}"
            YarnLotNoTextBox.Text = System.String.Format(YarnLotNoTextBox.Text, Me.LotNoWOLCTextBox.Text)
        End If




    End Sub
End Class