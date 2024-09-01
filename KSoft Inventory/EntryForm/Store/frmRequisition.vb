Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class frmRequisition
    Dim LTMFirstDay As Date = Today
    Dim LTMLastDay As Date = Today


    Dim LMFirstDay As Date = Today
    Dim LMLastDay As Date = Today
    Private Sub frmRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RequisitionFloorLookupTableAdapter.FillByItemDepartmentId(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookup, DepartmentId)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        'If UserLevel = 3 Then
        '    Me.ItemListDepartmentTableAdapter.FillByUserLabel(Me.ItemListDataSet.ItemListDepartment, UserLevel)
        '    'Me.ItemListTableAdapter.FillByUserLabel(Me.ItemListDataSet.ItemList, UserLevel)
        'Else

        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)

        'Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        'End If


        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentId)
        Me.RequisitionForTableAdapter.Fill(Me.RequisitionDataSet.RequisitionFor)
        Me.RequisitionDetailsTableAdapter.Fill(Me.RequisitionDataSet.RequisitionDetails)
        Me.RequisitionTableAdapter.FillByDepartmentId(Me.RequisitionDataSet.Requisition, DepartmentId)
        Me.RequisitionDataSet.Requisition.DepartmentIdColumn.DefaultValue = DepartmentId


        If CheckUserRights("Create Requisition").CanEdit = False Then

            NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = False
        ElseIf CheckUserRights("Create Requisition").CanDelete = False Then
            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True

        End If


    End Sub


    Private Sub RequisitionDetailsDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


        'Dim dr As RequisitionDataSet.RequisitionDetailsRow

        'If RequisitionDetailsBindingSource.Position > -1 Then
        '    dr = CType(CType(Me.RequisitionDetailsBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionDetailsRow)
        '    If dr.IsItemIdNull = False Then
        '        Me.ItemBalanceTableAdapter.FillItemId(Me.ItemBalanceDataSet.ItemBalance, dr.ItemId)
        '        Dim dr2 As ItemBalanceDataSet.ItemBalanceRow
        '        dr2 = CType(CType(Me.ItemBalanceBindingSource.Current, DataRowView).Row, ItemBalanceDataSet.ItemBalanceRow)

        '        'If IsDBNull(row!TotalPrice) = False Then
        '        '    TotalPrice = TotalPrice + row!TotalPrice
        '        'Else
        '        '    TotalPrice = TotalPrice + 0
        '        'End If



        '        If IsDBNull(dr2.TTLBalance) = False Then
        '            dr.InHand = dr2.TTLBalance
        '        End If



        '    End If
        'End If

    End Sub


    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged

        'Dim row As RequisitionDataSet.RequisitionLookupRow
        'row = CType(CType(Me.RequisitionLookupBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionLookupRow)

        'RequisitionBindingSource.Filter = "RequisitionId=" & row.RequisitionId

        Me.RequisitionTableAdapter.FillBy(Me.RequisitionDataSet.Requisition, GridLookUpEdit1.EditValue)



    End Sub


    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.RequisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RequisitionDataSet)




    End Sub


    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '---Copy current row
        Dim oldRow As RequisitionDataSet.RequisitionDetailsRow
        oldRow = CType(CType(Me.RequisitionDetailsBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionDetailsRow)

        Dim newRow As RequisitionDataSet.RequisitionDetailsRow = Me.RequisitionDataSet.RequisitionDetails.NewRow

        newRow.RequisitionId = oldRow.RequisitionId
        newRow.ItemId = oldRow.ItemId
        newRow.InHand = oldRow.InHand
        newRow.Quantity = 0
        'newRow.PrintingMediaId = ""
        'newRow.PaymentMode = newRow.PaymentMode
        newRow.Remarks = ""

        'newRow.DestinationId = oldRow.DestinationId

        Me.RequisitionDataSet.RequisitionDetails.Rows.Add(newRow)


    End Sub


    Private Sub GridView2_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged

        Dim LTMAverage As Decimal = 0
        Dim LMAverage As Decimal = 0
        Dim LMRequisition As Decimal = 0

        CalculateMonth()


        If e.Column.Caption = "ID/Item Name" Then

            Dim dr As RequisitionDataSet.RequisitionDetailsRow

            If RequisitionDetailsBindingSource.Position > -1 Then

                dr = CType(CType(Me.RequisitionDetailsBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionDetailsRow)

                If dr.IsItemIdNull = False Then

                    Me.ItemBalanceTableAdapter.FillItemId(Me.ItemBalanceDataSet.ItemBalance, dr.ItemId)
                    Dim dr2 As ItemBalanceDataSet.ItemBalanceRow
                    dr2 = CType(CType(Me.ItemBalanceBindingSource.Current, DataRowView).Row, ItemBalanceDataSet.ItemBalanceRow)

                    'If IsDBNull(row!TotalPrice) = False Then
                    '    TotalPrice = TotalPrice + row!TotalPrice
                    'Else
                    '    TotalPrice = TotalPrice + 0
                    'End If
                    dr.LMUsages = ReadData("SELECT SUM(IssueQuantity) AS LMUsages FROM Issue WHERE (IssueDate >= '" & LMFirstDateTimePicker.Text & "')AND (IssueDate <= '" & LMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn)
                    dr.LMRequisition = ReadData("SELECT SUM(ReceiveQuantity) AS LMUsages FROM Receive WHERE (ReceiveDate >= '" & LMFirstDateTimePicker.Text & "')AND (ReceiveDate <= '" & LMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn)
                    'ReadData("Select Sum(Quantity) From RequisitionDetails Where ItemId = " & dr.ItemId & " AND RequisitionId IN(Select RequisitionId From Requisition where RequisitionDate Between '" & LMFirstDateTimePicker.Text & "'and'" & LMLastDateTimePicker.Text & "')", cnn)
                    dr.LTMAverage = ReadData("SELECT SUM(IssueQuantity) AS LTMAverage FROM Issue WHERE (IssueDate >= '" & LTMFirstDateTimePicker.Text & "')AND (IssueDate <= '" & LTMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn) / 3

                    If IsDBNull(dr2.TTLBalance) = False Then
                        dr.InHand = dr2.TTLBalance
                    End If

                    Dim LRD As DateTime = ReadDateData("Select LastReceivedDate From LastReceivedDate Where ItemId=" & dr.ItemId, cnn)
                    Dim LRID As Integer = ReadIntegerData("Select ReceiveId From LastReceivedDate Where ItemId=" & dr.ItemId, cnn)

                    If LRD > "01/01/1900" Then
                        dr.LastReceiveDate = LRD
                        dr.LastReceivePrice = ReadData("Select Price From Receive Where ItemId=" & dr.ItemId & "And ReceiveId=" & LRID, cnn)
                    Else
                        dr.LastReceiveDate = "01/01/1900"
                        dr.LastReceivePrice = 0
                    End If

                    dr.BrandId = ReadIntegerData("Select BrandId From ItemList Where ItemId=" & dr.ItemId, cnn)

                End If

            End If

        End If
    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        '---Copy current row
        Dim oldRow As RequisitionDataSet.RequisitionDetailsRow
        oldRow = CType(CType(Me.RequisitionDetailsBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionDetailsRow)

        Dim newRow As RequisitionDataSet.RequisitionDetailsRow = Me.RequisitionDataSet.RequisitionDetails.NewRow

        newRow.RequisitionId = oldRow.RequisitionId
        newRow.ItemId = oldRow.ItemId
        newRow.InHand = oldRow.InHand
        newRow.Quantity = 0
        'newRow.PrintingMediaId = ""
        'newRow.PaymentMode = newRow.PaymentMode
        newRow.Remarks = ""
        newRow.ReceivingClosed = 0

        'newRow.DestinationId = oldRow.DestinationId

        Me.RequisitionDataSet.RequisitionDetails.Rows.Add(newRow)

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        If Me.RequisitionBindingSource.Position > -1 Then

            Dim row As RequisitionDataSet.RequisitionRow
            row = CType(CType(Me.RequisitionBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionRow)


            With frmRequisitionReport

                .RqId = row.RequisitionId
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

        End If

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&New" Then

            EnableFormControl(Me)
            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            RequisitionBindingSource.AddNew()
            'BookingDateDateTimePicker.Focus()
            RequisitionDetailsGridControl.Enabled = False
            GridLookUpEdit1.Enabled = False
            RequisitionDateDateEdit.Text = Today()
            'SaveDetailsButton.Enabled = False




        ElseIf NewButton.Text = "&Save" Then

            'Saveing/Updating...
            If RequisitionNoTextEdit.Text = String.Empty Then

                Dim DT As Date = ReadDateData("Select GetDate()", cnn)
                Dim RQNo As String = ""

                Dim ABC As String = DT.Year.ToString.Substring(2) & "RQ"
                Dim XYZ As String = ReadStringData("Select ISNULL(Max(REVERSE(SUBSTRING(REVERSE(RequisitionNo),0,CHARINDEX('Q',REVERSE(RequisitionNO))))),0) From Requisition Where RequisitionNo Like '" & ABC & "%'", cnn)

                RQNo = DT.Year.ToString.Substring(2) & "RQ" & (Val(XYZ) + 1).ToString("00000")

                RequisitionNoTextEdit.Text = RQNo

            Else
                ErrorProvider1.Clear()
            End If


            Me.Validate()
            Me.RequisitionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RequisitionDataSet)

            '===================================================

            NewButton.Text = "&Save Details"
            DisableFromControl(Me)
            RequisitionDetailsGridControl.Enabled = True
            'SaveDetailsButton.Enabled = True


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.RequisitionBindingSource.EndEdit()
            Me.RequisitionDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RequisitionDataSet)

            '===================================================
            NewButton.Text = "&New"
            EditButton.Enabled = True
            If RequisitionDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            Else
                DeleteButton.Enabled = False
            End If
            CancelEntryButton.Enabled = False
            GridLookUpEdit1.Enabled = True
            RequisitionDetailsGridControl.Enabled = False
            'SaveDetailsButton.Enabled = False
        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If PrintCount(Me.GridLookUpEdit1.Text, True) > 0 And Me.GridLookUpEdit1.Text <> String.Empty Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Floor Requisition", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        If EditButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            GridLookUpEdit1.Enabled = False

            RequisitionDetailsGridControl.Enabled = True
            'SaveDetailsButton.Enabled = True

        Else

            'Saveing/Updating...
            If RequisitionNoTextEdit.Text = String.Empty Then

                ErrorProvider1.SetError(RequisitionNoTextEdit, "Program No is Require")
                RequisitionNoTextEdit.Focus()
                Exit Sub
            Else
                ErrorProvider1.Clear()
            End If

            Me.Validate()
            Me.RequisitionBindingSource.EndEdit()
            Me.RequisitionDetailsBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.RequisitionDataSet)

            '===================================================
            DisableFromControl(Me)
            RequisitionDetailsGridControl.Enabled = False
            EditButton.Text = "&Edit"
            NewButton.Enabled = True
            If RequisitionBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False

            GridLookUpEdit1.Enabled = True

            RequisitionDetailsGridControl.Enabled = False
            'SaveDetailsButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If DeleteButton.Text = "&Delete" Then

            DeleteButton.Text = "&Update"
            NewButton.Enabled = False
            EditButton.Enabled = False
            'SaveDetailsButton.Enabled = False
            CancelEntryButton.Enabled = True
            If RequisitionBindingSource.Position > -1 Then
                RequisitionBindingSource.RemoveCurrent()
            End If



        Else

            'Saveing/Updating...
            Me.Validate()
            Me.RequisitionBindingSource.EndEdit()
            Me.RequisitionDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RequisitionDataSet)
            '======================================================
            If RequisitionDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If

            DeleteButton.Text = "&Delete"
            NewButton.Enabled = True
            EditButton.Enabled = True
            CancelEntryButton.Enabled = False
            'SaveDetailsButton.Enabled = True

        End If
    End Sub

    Private Sub CancelEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryButton.Click
        'Reset
        Me.RequisitionTableAdapter.FillByDepartmentId(Me.RequisitionDataSet.Requisition, DepartmentId)

        DisableFromControl(Me)
        NewButton.Enabled = True
        NewButton.Text = "&New"
        EditButton.Enabled = True
        EditButton.Text = "&Edit"

        If RequisitionDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        End If

        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
        GridLookUpEdit1.Enabled = True
        ErrorProvider1.Clear()

        'SaveDetailsButton.Enabled = False

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        CalculateMonth()

    End Sub

    Private Sub CalculateMonth()

        On Error Resume Next

        Dim TD As Date = CType(RequisitionDateDateEdit.Text, Date)


        'If CheckBox1.Checked Then

        LTMFirstDay = DateAdd(DateInterval.Day, -90, TD) 'DateSerial(Year(TD), Month(TD) - 2, 1)
        LTMLastDay = DateAdd(DateInterval.Day, -1, TD) 'DateSerial(Year(TD), Month(TD) + 1, 0)


        LMFirstDay = DateAdd(DateInterval.Day, -30, TD) 'DateSerial(Year(TD), Month(TD), 1)
        LMLastDay = DateAdd(DateInterval.Day, -1, TD) 'DateSerial(Year(TD), Month(TD) + 1, 0)


        'Else

        'LTMFirstDay = DateSerial(Year(TD), Month(TD) - 3, 1)
        'LTMLastDay = DateSerial(Year(TD), Month(TD), 0)

        'LMFirstDay = DateSerial(Year(TD), Month(TD) - 1, 1)
        'LMLastDay = DateSerial(Year(TD), Month(TD), 0)


        'End If


        LMFirstDateTimePicker.Text = LMFirstDay
        LMLastDateTimePicker.Text = LMLastDay

        'LTMFirstDateTimePicker.Text = LTMFirstDay
        'LTMLastDateTimePicker.Text = LTMLastDay


    End Sub

    Private Sub RecalculateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RecalculateLinkLabel.LinkClicked

        Dim LTMAverage As Decimal = 0
        Dim LMAverage As Decimal = 0
        Dim LMRequisition As Decimal = 0

        CalculateMonth()


        Dim dr As RequisitionDataSet.RequisitionDetailsRow

        If RequisitionDetailsBindingSource.Position > -1 Then

            dr = CType(CType(Me.RequisitionDetailsBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionDetailsRow)

            If dr.IsItemIdNull = False Then

                Me.ItemBalanceTableAdapter.FillItemId(Me.ItemBalanceDataSet.ItemBalance, dr.ItemId)

                Dim dr2 As ItemBalanceDataSet.ItemBalanceRow
                dr2 = CType(CType(Me.ItemBalanceBindingSource.Current, DataRowView).Row, ItemBalanceDataSet.ItemBalanceRow)

                'If IsDBNull(row!TotalPrice) = False Then
                '    TotalPrice = TotalPrice + row!TotalPrice
                'Else
                '    TotalPrice = TotalPrice + 0
                'End If
                dr.LMUsages = ReadData("SELECT SUM(IssueQuantity) AS LMUsages FROM Issue WHERE (IssueDate >= '" & LMFirstDateTimePicker.Text & "')AND (IssueDate <= '" & LMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn)
                dr.LMRequisition = ReadData("SELECT SUM(ReceiveQuantity) AS LMUsages FROM Receive WHERE (ReceiveDate >= '" & LMFirstDateTimePicker.Text & "')AND (ReceiveDate <= '" & LMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn)
                'ReadData("Select Sum(Quantity) From RequisitionDetails Where ItemId = " & dr.ItemId & " AND RequisitionId IN(Select RequisitionId From Requisition where RequisitionDate Between '" & LMFirstDateTimePicker.Text & "'and'" & LMLastDateTimePicker.Text & "')", cnn)
                dr.LTMAverage = ReadData("SELECT SUM(IssueQuantity) AS LTMAverage FROM Issue WHERE (IssueDate >= '" & LTMFirstDateTimePicker.Text & "')AND (IssueDate <= '" & LTMLastDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")", cnn) / 3

                If IsDBNull(dr2.TTLBalance) = False Then
                    dr.InHand = dr2.TTLBalance
                End If

                Dim LRD As DateTime = ReadDateData("Select LastReceivedDate From LastReceivedDate Where ItemId=" & dr.ItemId, cnn)
                Dim LRID As Integer = ReadIntegerData("Select ReceiveId From LastReceivedDate Where ItemId=" & dr.ItemId, cnn)
                If LRD > "01/01/1900" Then
                    dr.LastReceiveDate = LRD
                    dr.LastReceivePrice = ReadData("Select Price From Receive Where ItemId=" & dr.ItemId & "And ReceiveId=" & LRID, cnn)
                Else
                    dr.LastReceiveDate = "01/01/1900"
                    dr.LastReceivePrice = 0
                End If


                dr.BrandId = ReadIntegerData("Select BrandId From ItemList Where ItemId=" & dr.ItemId, cnn)

            End If


        End If


    End Sub

    Private Sub RequisitionNoTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionNoTextEdit.EditValueChanged

    End Sub

    Private Sub RequisitionDetailsGridControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionDetailsGridControl.Click

    End Sub

    Private Sub RequisitionDateDateEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequisitionDateDateEdit.EditValueChanged
        CalculateMonth()
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        If Me.RequisitionBindingSource.Position > -1 Then

            Dim row As RequisitionDataSet.RequisitionRow
            row = CType(CType(Me.RequisitionBindingSource.Current, DataRowView).Row, RequisitionDataSet.RequisitionRow)


            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim sqlstring As String = "SELECT RequisitionFloorDetaildId,ItemId,RequisitionQuantity,UnitId,Remarks From RequisitionFloorDetails  
                                       WHERE RequisitionFloorId=" & GridLookUpEdit2.EditValue & " And NOT EXISTS (SELECT RequisitionFloorDetailsId FROM RequisitionDetails  WHERE RequisitionFloorDetailsId = RequisitionFloorDetaildId)"

            Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()

                Dim newRow = CType(Me.RequisitionDataSet.RequisitionDetails.NewRow(), RequisitionDataSet.RequisitionDetailsRow)
                newRow.RequisitionId = row.RequisitionId
                newRow.RequisitionFloorDetailsId = reader("RequisitionFloorDetaildId")
                newRow.ItemId = reader("ItemId")
                newRow.Quantity = reader("RequisitionQuantity")
                newRow.InHand = 0
                newRow.PrintingMediaId = -1
                newRow.PaymentMode = ""
                newRow.SupplierId = -1
                newRow.LMUsages = 0
                newRow.LMRequisition = 0
                newRow.LTMAverage = 0
                newRow.ReceivingClosed = 0
                newRow.LastReceivePrice = 0
                If reader("Remarks") IsNot DBNull.Value Then
                    newRow.Remarks = reader("Remarks")
                End If


                newRow.FloorRequistionNo = GridLookUpEdit2.Text


                Me.RequisitionDataSet.RequisitionDetails.Rows.Add(newRow)

            End While




            reader.Close()
            connection.Close()


        End If


    End Sub

    Private Sub RequisitionForGridControl_Click(sender As Object, e As EventArgs) Handles RequisitionForGridControl.Click

    End Sub
End Class