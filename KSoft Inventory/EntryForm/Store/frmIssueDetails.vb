Imports System.Data.SqlClient
Imports System.Data
Public Class frmIssueDetails

    'Private Sub IssuetoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuetoBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.IssuetoBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.IssuetoDataSet)

    'End Sub

    Private _ItemId As Integer
    Public Property ItemId() As Integer
        Get
            Return _ItemId
        End Get
        Set(ByVal value As Integer)
            _ItemId = value
        End Set
    End Property

    Private Sub frmIssueDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProgramNoWithStyleBuyerDataSet.ProgramNoWithStyleBuyerLookUp' table. You can move, or remove it, as needed.
        Me.ProgramNoWithStyleBuyerLookUpTableAdapter.Fill(Me.ProgramNoWithStyleBuyerDataSet.ProgramNoWithStyleBuyerLookUp)


        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.MachineListTableAdapter.Fill(Me.MachineListDataSet.MachineList)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, DepartmentId)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.ShiftTableAdapter.Fill(Me.ShiftDataSet.Shift)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        'Me.IssuetoTableAdapter.Fill(Me.IssuetoDataSet.Issueto, DepartmentId)

        With Me.IssuetoDataSet
            .Issueto.DepartmentIdColumn.DefaultValue = DepartmentId
            .Issueto.IssuetoDateColumn.DefaultValue = Now()
            .Issueto.UserIdColumn.DefaultValue = UserId
            .Issueto.UpdateOnColumn.DefaultValue = Now()
        End With

		Me.RecipeDateTimePicker.Text = DateAdd(DateInterval.Day, -1, Today())

        DisableControl(Me)

        If DepartmentId = 7 Then

            With IssuetoQuantityTextBox
                Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatString = "n6"

                Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatString = "n6"
            End With


        Else

            With IssuetoQuantityTextBox
                Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.IssuetoQuantityTextBox.Properties.DisplayFormat.FormatString = "n3"

                Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.IssuetoQuantityTextBox.Properties.EditFormat.FormatString = "n3"
            End With

        End If


        Dim CANEDIT As Boolean
        Dim CANDELETE As Boolean

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Issue Details'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)
        CANDELETE = ReadBooleanData("Select CAN_DELETE From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then
            NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = False

        End If

        If CANDELETE = False Then
            DeleteButton.Visible = False
        Else
            DeleteButton.Visible = True
        End If

        'Me.BatchInformationLookupTableAdapter.Fill(Me.BatchInformationLookupDataSet.BatchInformationLookup)

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click


        If NewButton.Text = "&New" Then

            EnableControl(GroupBox1)
            ''''''''''''''''''''''''''
            UnitIdComboBox.Text = "KG"
            ''''''''''''''''''''''''''

            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            'IssuetoBindingSource.AddNew()
            'ItemNameSrchGridLookUpEdit.Focus()


            '=====================

            If CopyCheckEdit.Checked Then
                On Error Resume Next

                '---Copy current row
                Dim oldrow As IssuetoDataSet.IssuetoRow
                oldrow = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)

                '---Paste current row to new row

                Dim newRow As IssuetoDataSet.IssuetoRow = Me.IssuetoDataSet.Issueto.NewRow()


                newRow.IssuetoDate = oldrow.IssuetoDate
                newRow.RequisitionNo = oldrow.RequisitionNo
                newRow.BranchId = oldrow.BranchId

                If oldrow.IsOrderIdNull Then

                    newRow.OrderId = Nothing

                Else

                    newRow.OrderId = oldrow.OrderId

                End If


                If ItemIdCopyCheckEdit.Checked Then

                    newRow.ItemId = oldrow.ItemId

                Else

                    newRow.ItemId = Nothing

                End If

                'newRow.Price = 0
                newRow.IssuetoQuantity = 0
                newRow.PrintingmediaId = oldrow.PrintingmediaId
                newRow.Remarks = ""
                newRow.SupplierId = oldrow.SupplierId
                newRow.IssueReceiveTypeId = oldrow.IssueReceiveTypeId


                'If oldrow.IsBatchInformationIdNull Then
                '    newRow.BatchInformationId = Nothing
                'ElseIf oldrow.BatchInformationId = Nothing Then
                '    newRow.BatchInformationId = Nothing
                'Else
                newRow.BatchInformationId = oldrow.BatchInformationId
                'End If


                If oldrow.Is_AutoNull Then
                    newRow._Auto = 0
                Else
                    newRow._Auto = oldrow._Auto
                End If


                If oldrow.IsProductionTypeNull Then
                    newRow.ProductionType = "Bulk"
                Else
                    newRow.ProductionType = oldrow.ProductionType
                End If


                If oldrow.IsProductionQuantityNull Then
                    newRow.ProductionQuantity = 0
                Else
                    newRow.ProductionQuantity = oldrow.ProductionQuantity
                End If

                newRow.ProductionDate = oldrow.ProductionDate

                'If oldrow.IsProductionDateNull Then
                '    newRow.ProductionDate = Nothing
                'ElseIf oldrow.ProductionDate = Nothing Then
                '    newRow.ProductionDate = Nothing
                'Else
                '    newRow.ProductionDate = oldrow.ProductionDate
                'End If


                '--------------

                'ReceiveDataGridView.ReadOnly = False

                Me.IssuetoDataSet.Issueto.Rows.Add(newRow)
                EnableControl(GroupBox1)



                IssuetoDateDateTimePicker.Enabled = False
                RequisitionNoTextEdit.Enabled = False
                'BranchComboBox.Enabled = False
                SupplierIdGridLookUpEdit.Enabled = False
                IssueReceiveTypeIdComboBox.Enabled = False
                'CompanyComboBox.Enabled = False
                ProgramNoComboBox.Enabled = False


                IssuetoBindingSource.MoveLast()
                ItemNameGridLookUpEdit.Focus()

            Else

                IssuetoBindingSource.AddNew()
                IssuetoDateDateTimePicker.Focus()
                SupplierIdGridLookUpEdit.Enabled = True
                SupplierIdGridLookUpEdit.Properties.ReadOnly = False
                RequisitionNoTextEdit.Enabled = True
                RequisitionNoTextEdit.Properties.ReadOnly = False


                'IssueDateDateTimePicker.CustomFormat = " "
                'IssueDateDateTimePicker.Format = DateTimePickerFormat.Custom

            End If

            '=====================



        Else

            'Saveing/Updating...
            Dim row As IssuetoDataSet.IssuetoRow
            row = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)


            If row.IsItemIdNull Or row.ItemId = Nothing Then
                ErrorProvider1.SetError(ItemNameGridLookUpEdit, "Select an Item")
                ItemNameGridLookUpEdit.Focus()
                Exit Sub

            ElseIf Me.IssuetoQuantityTextBox.Text <= 0 Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Issue Quantity should be greater than 0 ")
                IssuetoQuantityTextBox.Focus()
                Exit Sub

            ElseIf Me.PriceTextEdit.Text = String.Empty Then
                ErrorProvider1.SetError(PriceTextEdit, "Pric is Require")
                PriceTextEdit.Focus()
                Exit Sub
            ElseIf Me.PriceTextEdit.Text <= 0 Then
                ErrorProvider1.SetError(PriceTextEdit, "Pric should be greater than 0")
                PriceTextEdit.Focus()
                Exit Sub

            ElseIf Me.BalanceQtyLabel.Text <= 0 Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Balance Quantity should be greater than 0")
                IssuetoQuantityTextBox.Focus()
                Exit Sub
            ElseIf Val(Me.IssuetoQuantityTextBox.EditValue) > Val(Me.BalanceQtyLabel.Text) Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Issue Quantity should be less than or equal Balance Quantity")
                IssuetoQuantityTextBox.Focus()
                Exit Sub
            End If

            Save()
            


            If DepartmentId = 7 Then
                ExecuteQuery("Update Issueto Set UnitId=Null Where UnitId<>12 And DepartmentId=7 And IssuetoId=" & row.IssuetoId, cnn)
            End If

            '===================================================


            DisableControl(GroupBox1)
            NewButton.Text = "&New"
            EditButton.Enabled = True
            If IssuetoBindingSource.Position > -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False

            End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        Dim row As IssuetoDataSet.IssuetoRow
        row = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)

        If My.Settings.EditRestrictionDays > 0 Then


            Dim RcvDate As Date = ReadDateData("Select IssuetoDate From Issueto Where IssuetoId= " & row.IssuetoId, cnn)
            Dim DayCount As Integer = ReadIntData("Select datediff(day,'" & RcvDate & "',getdate())", cnn)

            If DayCount > 7 Then
                MessageBox.Show(DayCount & " days are passed, so not allowed to edit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


        End If



        If EditButton.Text = "&Edit" Then

            EnableControl(GroupBox1)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            'Saveing/Updating...

            'Dim row As IssuetoDataSet.IssuetoRow
            'row = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)


            If row.IsItemIdNull Or row.ItemId = Nothing Then
                ErrorProvider1.SetError(ItemNameGridLookUpEdit, "Select an Item")
                ItemNameGridLookUpEdit.Focus()
                Exit Sub
            ElseIf Me.IssuetoQuantityTextBox.Text <= 0 Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Issue Quantity should be greater than 0 ")
                IssuetoQuantityTextBox.Focus()
                Exit Sub
            ElseIf Me.PriceTextEdit.Text <= 0 Then
                ErrorProvider1.SetError(PriceTextEdit, "Pric should be greater than 0")
                PriceTextEdit.Focus()
                Exit Sub
            ElseIf Me.BalanceQtyLabel.Text <= 0 Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Balance Quantity should be greater than 0")
                IssuetoQuantityTextBox.Focus()
                Exit Sub
            ElseIf Val(Me.IssuetoQuantityTextBox.EditValue) > Val(Me.BalanceQtyLabel.Text) Then
                ErrorProvider1.SetError(IssuetoQuantityTextBox, "Issue Quantity should be less than or equal Balance Quantity")
                IssuetoQuantityTextBox.Focus()
                Exit Sub
            End If

            Save()

            If DepartmentId = 7 Then
                ExecuteQuery("Update Issueto Set UnitId=Null Where UnitId<>12 And DepartmentId=7 And IssuetoId=" & row.IssuetoId, cnn)
            End If

            '===================================================
            DisableControl(GroupBox1)
            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If IssuetoBindingSource.Position = -1 Then
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

                If IssuetoBindingSource.Position > -1 Then
                    IssuetoBindingSource.RemoveCurrent()
                End If

            Else
                Exit Sub
            End If

        Else

            'Saveing/Updating...
            Save()
            '======================================================
            If IssuetoBindingSource.Position = -1 Then
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

        Me.IssuetoTableAdapter.Fill(Me.IssuetoDataSet.Issueto, DepartmentId)
        
        DisableControl(GroupBox1)
        NewButton.Enabled = True
        NewButton.Text = "&New"
        EditButton.Enabled = True
        EditButton.Text = "&Edit"
        If IssuetoBindingSource.Position > -1 Then
            DeleteButton.Enabled = True
        End If
        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
    End Sub

    Private Sub CompanyComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.IssuetoDataSet.Issueto.CompanyIdColumn.DefaultValue = 1
    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.IssuetoDataSet.Issueto.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
    End Sub

    Private Sub IssuetoDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuetoDateDateTimePicker.ValueChanged

        'Me.IssuetoDataSet.Issueto.IssuetoDateColumn.DefaultValue = IssuetoDateDateTimePicker.Value
        'ProductionDateDateTimePicker.Text = IssuetoDateDateTimePicker.Text


    End Sub

    Private Sub ShiftComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftComboBox.SelectedIndexChanged

        Me.IssuetoDataSet.Issueto.ShiftIdColumn.DefaultValue = ShiftComboBox.SelectedValue

    End Sub

   
    

    Private Sub ItemNameSrchGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNameSrchGridLookUpEdit.EditValueChanged, ItemNameSrchGridLookUpEdit.Closed
        If ItemListLookupBindingSource.Position > -1 Then
            Me.IssuetoTableAdapter.FillByItemId(Me.IssuetoDataSet.Issueto, DepartmentId, ItemNameSrchGridLookUpEdit.EditValue)
        End If
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged, GridLookUpEdit1.Closed
        If SupplierBindingSource.Position > -1 Then
            Dim row As SupplierDataSet.SupplierRow
            row = CType(CType(Me.SupplierBindingSource.Current, DataRowView).Row, SupplierDataSet.SupplierRow)

            Me.IssuetoTableAdapter.FillBySupplierId(Me.IssuetoDataSet.Issueto, DepartmentId, row.SupplierId)
        End If

    End Sub

    

    Private Sub IssuetoDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        On Error Resume Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.IssuetoTableAdapter.Fill(Me.IssuetoDataSet.Issueto, DepartmentId)

    End Sub

    Private Sub TabStopCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStopCheckBox.CheckedChanged

        If TabStopCheckBox.Checked Then

            IssuetoComboBox.TabStop = True

        Else

            IssuetoComboBox.TabStop = False

        End If

    End Sub

   
   

    Private Sub IssuetoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuetoComboBox.SelectedIndexChanged

        'If IssuetoComboBox.Text = "Finishing" Then
        'AutoCheckEdit.Checked = False
        'AutoCheckEdit.Properties.ReadOnly = True
        'Else
        ' AutoCheckEdit.Properties.ReadOnly = False
        'End If

    End Sub

   
    Private Sub GetPriceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetPriceButton.Click

        Try

            Dim row As IssuetoDataSet.IssuetoRow
            row = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)

            PriceTextEdit.Text = ReadData("Select AvgPrice From ItemPriceForIssueto Where ItemId=" & row.ItemId, cnn)
            BalanceQtyLabel.Text = ReadData("Select BalanceQty From ItemPriceForIssueto Where ItemId=" & row.ItemId, cnn)

            If row.IsUnitIdNull Then
                row.UnitId = ReadIntegerData("Select UnitId From ItemList Where ItemId=" & row.ItemId, cnn)
            End If


            Me.ItemId = ItemNameGridLookUpEdit.EditValue


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        


    End Sub

   
    Private Sub BatchInformationIdComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        'If e.KeyData = Keys.F10 Then

        '    frmBatchInformation.IsIssueDetails = True
        '    ShowMaster(frmBatchInformation)

        '    If frmBatchInformation.DialogResult = Windows.Forms.DialogResult.OK Then

        '        Me.BatchInformationTableAdapter.FillByAll(Me.BatchInformationDataSet.BatchInformation)

        '        Dim index As Integer = Me.BatchInformationBindingSource.Find("BatchNo", frmBatchInformation.BatchNo)
        '        Me.BatchInformationBindingSource.Position = index
        '        Me.ProductionQuantityTextEdit.Text = frmBatchInformation.DQty

        '        If frmBatchInformation.DialogResult = Windows.Forms.DialogResult.OK Then
        '            Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup)
        '        End If

        '    End If

        'End If



    End Sub

   
    'Private Sub ProductionDateUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionDateUpdateButton.Click

    '    Dim ProdDate As Date = ProductionDateDateTimePicker.Text

    '    Me.IssuetoTableAdapter.FillByBatchInformationId(Me.IssuetoDataSet.Issueto, DepartmentId, Me.BatchInformationIdGridLookUpEdit.Text)

    '    If Me.IssuetoBindingSource.Position > -1 Then




    '        Dim msgstring As String = ""
    '        msgstring = "This will update the date in Batch No:" & BatchInformationIdGridLookUpEdit.Text & vbCrLf
    '        msgstring = msgstring & "Are you sure u want to update ? "


    '        If MessageBox.Show(msgstring, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

    '            'ExecuteQuery("Update Issueto Set ProductionDate='" & Me.ProductionDateDateTimePicker.Text & "' where BatchInformationId=" & Me.BatchInformationIdComboBox.SelectedValue, cnn)


    '            For Each dr As DataRowView In IssuetoBindingSource.List
    '                dr!ProductionDate = ProdDate
    '            Next


    '            'Me.BatchInformationDataGridView.CurrentRow.Cells("BookingDate").Value = BookingDate


    '        Else

    '            Exit Sub

    '        End If


    '    End If

    'End Sub

   
    

   
    Private Sub BatchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchButton.Click
        'frmBatchInformation.IsIssueDetails = True
        'ShowMaster(frmBatchInformation)

        'If frmBatchInformation.DialogResult = Windows.Forms.DialogResult.OK Then

        '    Me.BatchInformationTableAdapter.FillByAll(Me.BatchInformationDataSet.BatchInformation)

        '    Dim index As Integer = Me.BatchInformationBindingSource.Find("BatchNo", frmBatchInformation.BatchNo)
        '    Me.BatchInformationBindingSource.Position = index
        '    Me.ProductionQuantityTextEdit.Text = frmBatchInformation.DQty

        '    If frmBatchInformation.DialogResult = Windows.Forms.DialogResult.OK Then
        '        Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup)
        '    End If
        'End If

    End Sub

    Private Sub IssuetoQuantityTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IssuetoQuantityTextBox.LostFocus

        'On Error Resume Next

        'Dim QTYLength As Decimal = Val(Me.IssuetoQuantityTextBox.Text)

        'If QTYLength >= 0.0001 And QTYLength <= 0.000999 Then
        '    Dim index As Integer = Me.UnitBindingSource.Find("UnitCode", "grm")
        '    Me.UnitBindingSource.Position = index
        '    Me.IssuetoQuantityTextBox.Text = Math.Round(Math.Round(CDbl(Me.IssuetoQuantityTextBox.Text), 6) * 1000, 3)
        'Else
        '    Dim index As Integer = Me.UnitBindingSource.Find("UnitCode", "kg")
        '    Me.UnitBindingSource.Position = index
        '    Me.IssuetoQuantityTextBox.Text = Math.Round(CDbl(Me.IssuetoQuantityTextBox.Text), 3)
        'End If

    End Sub

    
    Private Sub IssuetoQuantityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmIssueDetails_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F12 Then



            If NewButton.Text = "&New" Then

                EnableControl(GroupBox1)
                NewButton.Text = "&Save"
                EditButton.Enabled = False
                DeleteButton.Enabled = False
                CancelEntryButton.Enabled = True
                'IssuetoBindingSource.AddNew()
                'ItemNameSrchGridLookUpEdit.Focus()


                '=====================

                If CopyCheckEdit.Checked Then

                    On Error Resume Next

                    '---Copy current row
                    Dim oldrow As IssuetoDataSet.IssuetoRow
                    oldrow = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)

                    '---Paste current row to new row

                    Dim newRow As IssuetoDataSet.IssuetoRow = Me.IssuetoDataSet.Issueto.NewRow()


                    newRow.IssuetoDate = oldrow.IssuetoDate
                    newRow.RequisitionNo = oldrow.RequisitionNo
                    newRow.BranchId = oldrow.BranchId

                    If oldrow.IsOrderIdNull Then

                        newRow.OrderId = Nothing

                    Else

                        newRow.OrderId = oldrow.OrderId

                    End If


                    If ItemIdCopyCheckEdit.Checked Then

                        newRow.ItemId = oldrow.ItemId

                    Else

                        newRow.ItemId = Nothing

                    End If

                    'newRow.Price = 0
                    newRow.IssuetoQuantity = 0
                    newRow.PrintingmediaId = oldrow.PrintingmediaId
                    newRow.Remarks = ""
                    newRow.SupplierId = oldrow.SupplierId
                    newRow.IssueReceiveTypeId = oldrow.IssueReceiveTypeId


                    'If oldrow.IsBatchInformationIdNull Then
                    'newRow.BatchInformationId = Nothing
                    'ElseIf oldrow.BatchInformationId = Nothing Then
                    'newRow.BatchInformationId = Nothing
                    'Else
                    newRow.BatchInformationId = oldrow.BatchInformationId
                    'End If


                    If oldrow.Is_AutoNull Then
                        newRow._Auto = 0
                    Else
                        newRow._Auto = oldrow._Auto
                    End If


                    If oldrow.IsProductionTypeNull Then
                        newRow.ProductionType = "Bulk"
                    Else
                        newRow.ProductionType = oldrow.ProductionType
                    End If


                    If oldrow.IsProductionQuantityNull Then
                        newRow.ProductionQuantity = 0
                    Else
                        newRow.ProductionQuantity = oldrow.ProductionQuantity
                    End If

                    newRow.ProductionDate = oldrow.ProductionDate

                    'If oldrow.IsProductionDateNull Then
                    '    newRow.ProductionDate = Nothing
                    'ElseIf oldrow.ProductionDate = Nothing Then
                    '    newRow.ProductionDate = Nothing
                    'Else
                    '    newRow.ProductionDate = oldrow.ProductionDate
                    'End If


                    '--------------

                    'ReceiveDataGridView.ReadOnly = False

                    Me.IssuetoDataSet.Issueto.Rows.Add(newRow)
                    EnableControl(GroupBox1)



                    IssuetoDateDateTimePicker.Enabled = False
                    RequisitionNoTextEdit.Enabled = False
                    'BranchComboBox.Enabled = False
                    SupplierIdGridLookUpEdit.Enabled = False
                    IssueReceiveTypeIdComboBox.Enabled = False
                    'CompanyComboBox.Enabled = False
                    ProgramNoComboBox.Enabled = False


                    IssuetoBindingSource.MoveLast()
                    ItemNameGridLookUpEdit.Focus()

                Else

                    IssuetoBindingSource.AddNew()
                    IssuetoDateDateTimePicker.Focus()
                    SupplierIdGridLookUpEdit.Enabled = True
                    SupplierIdGridLookUpEdit.Properties.ReadOnly = False
                    RequisitionNoTextEdit.Enabled = True
                    RequisitionNoTextEdit.Properties.ReadOnly = False


                    'IssueDateDateTimePicker.CustomFormat = " "
                    'IssueDateDateTimePicker.Format = DateTimePickerFormat.Custom

                End If

                '=====================



            Else

                'Saveing/Updating...
                Dim row As IssuetoDataSet.IssuetoRow
                row = CType(CType(Me.IssuetoBindingSource.Current, DataRowView).Row, IssuetoDataSet.IssuetoRow)


                If row.IsItemIdNull Or row.ItemId = Nothing Then
                    ErrorProvider1.SetError(ItemNameGridLookUpEdit, "Select an Item")
                    ItemNameGridLookUpEdit.Focus()
                    Exit Sub

                ElseIf Me.IssuetoQuantityTextBox.Text <= 0 Then
                    ErrorProvider1.SetError(IssuetoQuantityTextBox, "Issue Quantity should be greater than 0 ")
                    IssuetoQuantityTextBox.Focus()
                    Exit Sub

                ElseIf Me.PriceTextEdit.Text = String.Empty Then
                    ErrorProvider1.SetError(PriceTextEdit, "Pric is Require")
                    PriceTextEdit.Focus()
                    Exit Sub
                End If

                Save()

                '===================================================


                DisableControl(GroupBox1)
                NewButton.Text = "&New"
                EditButton.Enabled = True

                If IssuetoBindingSource.Position > -1 Then
                    DeleteButton.Enabled = True
                End If

                CancelEntryButton.Enabled = False

            End If

        End If


        If e.KeyData = Keys.F11 Then

            ShowMaster(frmCalculator)

            If frmCalculator.DialogResult = System.Windows.Forms.DialogResult.OK Then
                Me.IssuetoQuantityTextBox.Text = frmCalculator.TTLValue
            End If

        End If



		
    End Sub

    
    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If BatchLookupBindingSource.Position > -1 Then

            If FinishingCheckBox.Checked = True Then
                Me.IssuetoTableAdapter.FillByBatchAndFinishing(Me.IssuetoDataSet.Issueto, DepartmentId, BatchLookupGridLookUpEdit.EditValue)
            Else
                Me.IssuetoTableAdapter.FillByBatchInformationId(Me.IssuetoDataSet.Issueto, DepartmentId, BatchLookupGridLookUpEdit.EditValue)
            End If

            ProductionDateUpdateButton.Enabled = True
        Else

            ProductionDateUpdateButton.Enabled = True

        End If

    End Sub

    Private Sub IssuetoQuantityTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

       

    End Sub

    
    
   
    Private Sub BatchInformationIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchInformationIdGridLookUpEdit.EditValueChanged

        If BatchLookupBindingSource.Position > -1 Then

            On Error Resume Next

            Me.BatchInformationLookupTableAdapter.FillByBatchNo(Me.BatchInformationLookupDataSet.BatchInformationLookup, BatchInformationIdGridLookUpEdit.Text)
            BatchCommentsTextBox.Text = ReadStringData("Select ChemicalStoreComments From BatchInformation Where BatchInformationId=" & BatchInformationIdGridLookUpEdit.EditValue, cnn)



        End If

    End Sub

    
    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup)
    End Sub

   
   
   

    Private Sub UpdateBatchCommentsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles UpdateBatchCommentsLinkLabel.LinkClicked

        On Error Resume Next
        If DepartmentId = 7 Then 'Only For Dyes and Chemical Store
            ExecuteQuery("Update BatchInformation Set ChemicalStoreComments='" & Me.BatchCommentsTextBox.Text & "' Where BatchInformationId=" & BatchInformationIdGridLookUpEdit.EditValue, cnn)
            MessageBox.Show("Comments Updated")
        Else
            MessageBox.Show("Not Allowed for your Department")
        End If
        

		
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    'Me.BatchInformationLookupTableAdapter.Fill(Me.BatchInformationLookupDataSet.BatchInformationLookup)
    'End Sub

   
   
    Private Sub ItemNameGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNameGridLookUpEdit.EditValueChanged


        'Me.ReceivedMRNoLookupTableAdapter.Fill(Me.ReceiveDataSet.ReceivedMRNoLookup, ItemNameGridLookUpEdit.EditValue)


        'If IsLCTracking = True Then

        '    Me.PIAndItemwiseBalanceSubTableAdapter.Fill(Me.PIAndItemwiseBalanceSubDataSet.PIAndItemwiseBalanceSub, ItemNameGridLookUpEdit.EditValue)

        'End If


    End Sub

    Private Sub ReceiveIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'On Error Resume Next

        'PriceTextEdit.Text = ReadData("Select Price From Receive Where ReceiveId =" & ReceiveIdGridLookUpEdit.EditValue, cnn)

        'Dim TTLReceive As Decimal = ReadData("Select ISNULL(Sum(IssueQuantity),0) From Issue Where ReceiveId=" & ReceiveIdGridLookUpEdit.EditValue, cnn)
        'Dim TTLIssue As Decimal = ReadData("Select ISNULL(Sum(IssuetoQuantity),0) From Issueto Where Auto=0 And ReceiveId=" & ReceiveIdGridLookUpEdit.EditValue, cnn)

        'IssuetoQuantityTextBox.Value = TTLReceive - TTLIssue



    End Sub

    'Function MRBalance() As Decimal

    '    Dim MRNo As Integer = ReceiveIdGridLookUpEdit.EditValue

    '    Dim TTLBalance As Decimal = 0


    '    If MRNo > 0 Then

    '        Dim TTLSubReceive As Decimal = ReadData("Select Sum(IssueQuantity) From Issue Where ReceiveId=" & MRNo, cnn)
    '        Dim TTLIssueto As Decimal = ReadData("Select Sum(IssuetoQuantity) From Issueto Where Auto=0 And IssuetoId=" & MRNo, cnn)

    '        TTLBalance = TTLSubReceive - TTLIssueto

    '    End If

    '    Return TTLBalance

    'End Function

    Private Sub IssuetoQuantityTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuetoQuantityTextBox.Leave

        'If DBNull.Value.Equals(ReceiveIdGridLookUpEdit.EditValue) = False Then

        '    If MRBalance() < Val(IssuetoQuantityTextBox.Text) Then

        '        ErrorProvider1.SetError(IssuetoQuantityTextBox, "Not Allowed Excess Quantity")
        '        IssuetoQuantityTextBox.Focus()
        '        IssuetoQuantityTextBox.Value = 0
        '        Exit Sub

        '    Else

        '        ErrorProvider1.Clear()

        '    End If


        'Else


        '    'If Val(ItemBalanceLabel.Text) < Val(IssueQuantityTextBox.Text) Then

        '    '    If IssueTypeComboBox.Text = "Normal" Then

        '    '        ErrorProvider1.SetError(IssueQuantityTextBox, "Not Allowed Excess Quantity")
        '    '        IssueQuantityTextBox.Focus()
        '    '        Exit Sub

        '    '    End If

        '    'Else

        '    '    ErrorProvider1.Clear()

        '    'End If

        'End If

    End Sub

    Private Sub PIIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If IsLCTracking = True Then

        '    PriceTextEdit.Text = ReadData("SELECT LCPrice FROM PIList where PIID=" & PIIdGridLookUpEdit.EditValue, cnn)

        'End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ''IK Start
        ''Author: Imrul Kaesh, Date on: 13.04.13, Description:	Grid to Excel file Export system
        Try
            IssuetoGridControl.ExportToXls("d:\Issue to Floor in Excell.xls")
            ''MsgBox("Your file successfully save in dasktop ")
            MessageBox.Show("Your File is Save to ""d:\Issue to Floor in Excell.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)


        End Try
        ''IK Stop
    End Sub

    Private Sub UpdateItemAvgPrice()
If Me.IssuetoBindingSource.Position > -1 Then
        If IsLCTracking = True Then
            ExecuteQuery("Execute UpdateItemAvgPrice " & ItemNameGridLookUpEdit.EditValue, cnn)
        End If
End If

    End Sub

    Private Sub Save()

  
        Try
            Me.Validate()
            Me.IssuetoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.IssuetoDataSet)
            ErrorProvider1.Clear()
            UpdateItemAvgPrice()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub GetRecipeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetRecipeButton.Click

        If BatchLookupGridLookUpEdit.EditValue > 0 Then

            Me.IssuetoTableAdapter.FillByBatchInformationId(Me.IssuetoDataSet.Issueto, DepartmentId, BatchLookupGridLookUpEdit.EditValue)

            'If IssuetoBindingSource.Position > -1 Then
            '    Exit Sub

            'End If

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim DyelineId As Integer = ReadIntegerData("Select DyelineId From DyelineBatch Where BatchInformationId=" & BatchLookupGridLookUpEdit.EditValue, cnn)
            Dim cmd As SqlCommand = New SqlCommand("Select DyelineDetailsId,ItemId,CategoryId,LR,UsagePercentage,UsageGL,ReceipeQuantity, ISNULL(Add1,0)AS Add1,ISNULL(Add2,0) AS Add2 From DyeLineDetails Where DyeLineId= " & DyelineId & " And ItemId > 0 And ItemId not in (Select ItemId From Issueto Where BatchInformationId=" & BatchLookupGridLookUpEdit.EditValue & ")", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim list As New AutoCompleteStringCollection
            Dim MissingLog As String = String.Empty

            ListBox1.Items.Clear()

            'While reader.Read

            '    If ReadData("Select AvgPrice From ItemPriceForIssueto Where ItemId=" & reader("ItemId"), cnn) <= 0 Then
            '        Dim ItemName As String = ReadStringData("Select ItemName From ItemList Where ItemId=" & reader("ItemId"), cnn)
            '        MessageBox.Show("Failed , Please, check " & ItemName & " AveragePrice.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        reader.Close()
            '        connection.Close()
            '        Exit Sub
            '    End If

            'End While


            While reader.Read

                If reader.IsDBNull(0) = False Then


                    Dim TTLBatchQty As Decimal = ReadData("Select Sum(TTLBatchQuantity) From BatchQuantityByBatchNo Where BatchInformationId in (Select BatchInformationId From DyeLineBatch Where DyelineId=" & DyelineId & ")", cnn)
                    Dim BatchQty As Decimal = ReadData("Select TTLBatchQuantity From BatchQuantityByBatchNo Where BatchInformationId =" & Me.BatchLookupGridLookUpEdit.EditValue, cnn)

                    Dim TTLRecipeQuantity = ((Val(reader("ReceipeQuantity")) + Val(reader("Add1")) + Val(reader("Add2"))) / TTLBatchQty * BatchQty) / 1000
                    Dim BalanceQuantity = ReadData("Select BalanceQty From ItemPriceForIssueto Where ItemId=" & reader("ItemId").ToString(), cnn)
                    Dim AvgPrice As Decimal = ReadData("Select AvgPrice From ItemPriceForIssueto Where ItemId=" & reader("ItemId"), cnn)
                    Dim ItemName As String = ReadStringData("Select ItemName From ItemList Where ItemId=" & reader("ItemId"), cnn)

                    If BalanceQuantity >= TTLRecipeQuantity AndAlso AvgPrice > 0 Then

                        Dim newRow As IssuetoDataSet.IssuetoRow = Me.IssuetoDataSet.Issueto.NewRow()

                        newRow.IssuetoDate = Me.RecipeDateTimePicker.Text
                        newRow.ShiftId = 1
                        newRow.RequisitionNo = 0
                        newRow.IssueReceiveTypeId = 1
                        newRow.BatchInformationId = BatchLookupGridLookUpEdit.EditValue
                        newRow.PrintingmediaId = ReadIntegerData("select PrintingmediaId From PrintingMedia Where MediaName='Dyeing' And DepartmentId=" & DepartmentId, cnn)
                        newRow.ItemId = reader("ItemId")
                        newRow.Remarks = ""
                        newRow.DyeLineDetailsId = reader("DyeLineDetailsId")
                        newRow.Price = AvgPrice
                        newRow.IssuetoQuantity = TTLRecipeQuantity

                      

                        Me.IssuetoDataSet.Issueto.Rows.Add(newRow)

                    Else

                       
                        MissingLog = "Item Name : " & ItemName & " Avg Price : " & AvgPrice & " RecipeQuantity : " & TTLRecipeQuantity & " BalanceQty : " & BalanceQuantity

                        ListBox1.Items.Add(MissingLog)

                        If AvgPrice < 0 Then
                            ListBox1.Items.Add("Price is less than 0")
                        ElseIf AvgPrice = 0 Then
                            ListBox1.Items.Add("Price is 0")
                        ElseIf BalanceQuantity < TTLRecipeQuantity Then
                            ListBox1.Items.Add("Balance Quantity is less than Recipe Quantity")
                        End If

                   
                    End If


                End If

            End While

            reader.Close()
            connection.Close()


        Else
            MessageBox.Show("Batch No is require.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BatchLookupGridLookUpEdit.Focus()
        End If

    End Sub



    Private Sub RequisitionNoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RequisitionNoLinkLabel.LinkClicked

        ShowMaster(frmRequisitionNo)

        If frmRequisitionNo.DialogResult = System.Windows.Forms.DialogResult.OK Then
            RequisitionNoTextEdit.Text = frmRequisitionNo.RqNo
        End If

    End Sub
End Class