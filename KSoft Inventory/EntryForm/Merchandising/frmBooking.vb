Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmBooking
    Dim cellvalue As String = ""
    Dim AWSId As Integer
    Private Sub BookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

    End Sub
    Private Sub save()
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
    End Sub

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)
        Me.BookingProgramNoLookupTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoLookup, DepartmentId)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        'Me.BookingDetailsTableAdapter.Fill(Me.BookingDataSet.BookingDetails, ProgramNoGridLookUpEdit.EditValue)
        'Me.BookingTableAdapter.Fill(Me.BookingDataSet.Booking, DepartmentId)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, My.Settings.AccDepartmentId)
        Me.BookingDataSet.Booking.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.BookingDataSet.Booking.BookingDateColumn.DefaultValue = Today()

        'DisableControl(Me)


        If BookingBindingSource.Position > -1 Then

            BookingBindingSource.MoveLast()
            BookingProgramNoLookupBindingSource.MoveLast()

            ProgramNoGridLookUpEdit.Enabled = True

        End If
        '====================================================
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select AWSNo From AccessoriesWorkOrderSheet", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            list.Add(reader.Item("AWSNo"))
        End While
        reader.Close()
        ProgramNoTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ProgramNoTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        ProgramNoTextBox.AutoCompleteCustomSource = list
        connection.Close()
        '===============================================================

        'Start -------- Check and Set user rights

        'Dim CANEDIT As Boolean
        'Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Booking'", cnn)
        'CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        'If CANEDIT = False Then

        '    NewButton.Enabled = False
        '    EditButton.Enabled = False
        '    DeleteButton.Enabled = False
        '    CancelEntryButton.Enabled = False
        '    SaveDetailsButton.Enabled = False

        'End If

        'End ------- Check and Set user rights
        If CheckUserRights("Booking").CanEdit = False Then

            NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = False

        ElseIf CheckUserRights("Booking").CanDelete = False Then
            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        End If

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&New" Then

            'EnableFormControl(Me)
            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            BookingBindingSource.AddNew()
            BookingDateDateTimePicker.Focus()
            BookingDetailsGridControl.Enabled = False
            ProgramNoGridLookUpEdit.Enabled = False
            SaveDetailsButton.Enabled = False


        ElseIf NewButton.Text = "&Save" Then

            'Saveing/Updating...
            If ProgramNoTextBox.Text = String.Empty Then

                ErrorProvider1.SetError(ProgramNoTextBox, "Program No is Require")
                ProgramNoTextBox.Focus()

                Exit Sub

            Else
                ErrorProvider1.Clear()
            End If


            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

            '===================================================

            NewButton.Text = "&Save Details"
            'DisableFromControl(Me)
            BookingDetailsGridControl.Enabled = True
            SaveDetailsButton.Enabled = True


        Else

            'Saveing/Updating...

            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)

            '===================================================
            NewButton.Text = "&New"
            EditButton.Enabled = True
            If BookingDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            Else
                DeleteButton.Enabled = False
            End If
            CancelEntryButton.Enabled = False
            ProgramNoGridLookUpEdit.Enabled = True
            BookingDetailsGridControl.Enabled = False
            SaveDetailsButton.Enabled = False
        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If EditButton.Text = "&Edit" Then
            EnableFormControl(Me)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            ProgramNoGridLookUpEdit.Enabled = False

            BookingDetailsGridControl.Enabled = True
            SaveDetailsButton.Enabled = True

        Else

            'Saveing/Updating...
            If ProgramNoTextBox.Text = String.Empty Then

                ErrorProvider1.SetError(ProgramNoTextBox, "Program No is Require")
                ProgramNoTextBox.Focus()
                Exit Sub
            Else
                ErrorProvider1.Clear()
            End If

            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
            Me.BookingProgramNoLookupTableAdapter.FillByAll(Me.BookingDataSet.BookingProgramNoLookup)
            '===================================================
            DisableFromControl(Me)
            'BookingDetailsGridControl.Enabled = False
            EditButton.Text = "&Edit"
            DeleteButton.Enabled = True
            NewButton.Enabled = True
            If BookingBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If
            CancelEntryButton.Enabled = False

            ProgramNoGridLookUpEdit.Enabled = True

            'BookingDetailsGridControl.Enabled = False
            SaveDetailsButton.Enabled = False
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If DeleteButton.Text = "&Delete" Then

            DeleteButton.Text = "&Update"
            NewButton.Enabled = False
            EditButton.Enabled = False
            SaveDetailsButton.Enabled = False
            CancelEntryButton.Enabled = True
            If BookingBindingSource.Position > -1 Then
                BookingBindingSource.RemoveCurrent()
            End If

        Else

            'Saveing/Updating...
            Me.Validate()
            Me.BookingBindingSource.EndEdit()
            Me.BookingDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
            '======================================================
            If BookingDetailsBindingSource.Position = -1 Then
                DeleteButton.Enabled = True
            End If

            DeleteButton.Text = "&Delete"
            NewButton.Enabled = True
            EditButton.Enabled = True
            CancelEntryButton.Enabled = False
            SaveDetailsButton.Enabled = True

        End If
    End Sub

    Private Sub CancelEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEntryButton.Click

        'Reset
        Me.BookingTableAdapter.Fill(Me.BookingDataSet.Booking, DepartmentId)

        DisableFromControl(Me)
        NewButton.Enabled = True
        NewButton.Text = "&New"
        EditButton.Enabled = True
        EditButton.Text = "&Edit"

        If BookingDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        End If

        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
        ProgramNoGridLookUpEdit.Enabled = True
        ErrorProvider1.Clear()

        SaveDetailsButton.Enabled = False


    End Sub

    Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub BookingDetailsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BookingDetailsBindingSource.PositionChanged, BookingDetailsBindingSource.CurrentChanged
        If BookingDetailsBindingSource.Position = -1 Then
            DeleteButton.Enabled = True
        Else
            DeleteButton.Enabled = False
        End If
    End Sub

    
    

    

    'Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
    '    If e.Column.Caption = "Item Style" Then
    '        If e.Value = "No Style" Then e.DisplayText = ""
    '    End If

    'End Sub

    Private Sub GridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        'On Error Resume Next

        'If AutocompleteCheckBox.Checked = False Then
        '    Exit Sub
        'End If

        ''Finding Booking Id

        'Dim row As BookingDataSet.BookingRow
        'row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

        ''Filter By Booking Id

        '''''''''''Me.ItemColorLookupTableAdapter.Fill(Me.BookingDataSet.ItemColorLookup, row.BookingId)


        'If e.Column.Caption = "Item Color" Then

        '    'Dim cellValue As String = e.Value.ToString() + " " + GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("ItemStyle")).ToString()
        '    'Filter By Item Color Cell Value

        '    ItemColorLookupBindingSource.Filter = "ItemColor LIKE '" & e.Value.ToString() & "' + '%'"

        '    If ItemColorLookupBindingSource.Position > -1 Then

        '        'Get ItemColor
        '        ''''''''''Dim row2 As BookingDataSet.ItemColorLookupRow
        '        ''''''''''row2 = CType(CType(Me.ItemColorLookupBindingSource.Current, DataRowView).Row, BookingDataSet.ItemColorLookupRow)


        '        If e.Value.ToString() <> "" Then

        '            ''''''''''GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("ItemColor"), row2.ItemColor)


        '        End If

        '    Else

        '        Exit Sub

        '    End If

        'End If

    End Sub

    Private Sub SaveDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDetailsButton.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.BookingDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookingDataSet)
    End Sub

    
    'Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown

    '    If e.KeyData = Keys.F5 Then
    '        If colItemColor.Caption = "Item Color" Then
    '            If ItemColorLookupBindingSource.Position <> -1 Then

    '                ItemColorLookupBindingSource.MoveNext()

    '            End If

    '        End If
    '    End If

    'End Sub

    
    Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow

        'Dim view As ColumnView = CType(sender, ColumnView)
        'Dim column1 As GridColumn = view.Columns("ItemId")
        ''Get the value of the first column
        'Dim ItemId As Integer = view.GetRowCellValue(e.RowHandle, column1)
        ''Get the value of the second column
        ''Dim time2 As DateTime = CType(view.GetRowCellValue(e.RowHandle, column2), DateTime)
        ''Validity criterion
        'If ItemId = "" Then
        '    e.Valid = False
        '    'Set errors with specific descriptions for the columns
        '    view.SetColumnError(column1, "Item Name is require")
        '    'view.SetColumnError(column2, "The value must be greater than StartTime")
        'End If

    End Sub

    Private Sub BuyerIdComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerIdComboBox.SelectedIndexChanged
        'Me.ItemStyleTableAdapter.FillByBuyerId(Me.BookingDataSet.ItemStyle, BuyerIdComboBox.SelectedValue)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Me.ItemStyleTableAdapter.Fill(Me.BookingDataSet.ItemStyle)

    End Sub

    Private Sub ProgramNoTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.BookingProgramNoSearchTableAdapter.Fill(Me.BookingDataSet.BookingProgramNoSearch, ProgramNoTextBox.Text)

        If Me.BookingProgramNoSearchBindingSource.Position > -1 Then

            ErrorProvider1.SetError(ProgramNoTextBox, "Booking for this Program has already been done")
            ProgramNoTextBox.Focus()

        Else

            ErrorProvider1.Clear()

        End If

    End Sub

    Private Sub GenerateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


        Dim connection As New SqlConnection(cnn)
        Dim StyleId As Integer = ReadIntegerData("Select StyleId From [Order] Where ProgramNo='" & ProgramNoTextBox.Text & "'", cnn)

        connection.Open()


        Dim SCcmd As SqlCommand = New SqlCommand("Select AccessoriesId,GarmentsQuantity,Consumption,TUnitId,WastagePercentage,IsSizeWise,IsColorWise,IsDestinationWise,IsPack,PackType,SupplierId,StyleId,Remarks,SLNo From StyleCapture_Accessories Where StyleId=" & StyleId, connection)
        Dim SCreader As SqlDataReader = SCcmd.ExecuteReader()

        While SCreader.Read()

            '''''Based OnSize

            If SCreader("IsColorWise") = 1 And SCreader("IsSizeWise") = 1 And SCreader("IsDestinationWise") = 0 And SCreader("IsPack") = 0 Then

                Dim Colorcmd As SqlCommand = New SqlCommand("Select AccessoriesId,GarmentsQuantity,Consumption,TUnitId,WastagePercentage,IsSizeWise,IsColorWise,IsDestinationWise,IsPack,PackType,SupplierId,StyleId,Remarks,SLNo From StyleCapture_Accessories Where StyleId=" & StyleId, connection)
                Dim Colorreader As SqlDataReader = Colorcmd.ExecuteReader()

                While Colorreader.Read()

                    Dim Sizecmd As SqlCommand = New SqlCommand("Select AccessoriesId,GarmentsQuantity,Consumption,TUnitId,WastagePercentage,IsSizeWise,IsColorWise,IsDestinationWise,IsPack,PackType,SupplierId,StyleId,Remarks,SLNo From StyleCapture_Accessories Where StyleId=" & StyleId, connection)
                    Dim Sizereader As SqlDataReader = Sizecmd.ExecuteReader()

                    While Sizereader.Read()


                        Dim newRow As BookingDataSet.BookingDetailsRow = Me.BookingDataSet.BookingDetails.NewRow()

                        'newRow.BookingId=
                        'newRow.ItemId=
                        'newRow.ItemSize=
                        'newRow.ItemColor=
                        'newRow.BookingQuantity=
                        'newRow.ItemStyeId =
                        'newRow.AccessoriesId =
                        'newRow.OrderQuantity =
                        Me.BookingDataSet.BookingDetails.Rows.Add(newRow)


                    End While


                End While


            End If



        End While


    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged

        On Error Resume Next



        'Me.AccBOMItemLookupNewTableAdapter.FillByOrderId(Me.AccBOMItemLookupNewDataSet.AccBOMItemLookupNew, Me.OrderIdGridLookUpEdit.EditValue)
        Me.BookingTableAdapter.FillByBookingId(Me.BookingDataSet.Booking, DepartmentId, ProgramNoGridLookUpEdit.EditValue)
        Me.BookingDetailsTableAdapter.Fill(Me.BookingDataSet.BookingDetails, ProgramNoGridLookUpEdit.EditValue)
        Me.AWSItemProgramWiseLookUpTableAdapter.FillByAWSNo(Me.AWSItemProgramWiaeLookUpDataSet.AWSItemProgramWiseLookUp, ProgramNoTextBox.Text)

    End Sub

    Private Sub ProgramNoTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyData = Keys.F10 Then

        End If

    End Sub

   

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        On Error Resume Next
        StyleTextBox.Text = ReadStringData("Select StyleName From Style Where StyleId=(Select StyleId From [Order] Where ProgramNo='" & OrderIdGridLookUpEdit.Text & "')", cnn)
        RefNoTextEdit.Text = ReadStringData("Select StyleReferenceNo From [Order] Where ProgramNo='" & OrderIdGridLookUpEdit.Text & "'", cnn)
        BuyerIdComboBox.SelectedValue = ReadIntegerData("Select BuyerId From [Order] Where ProgramNo='" & OrderIdGridLookUpEdit.Text & "'", cnn)
        OrderDateDateEdit.Text = ReadDateData("Select OrderReceiveDate From [Order] Where ProgramNo='" & OrderIdGridLookUpEdit.Text & "'", cnn)


        'OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, ProgramNoTextBox.Text)

    End Sub

    Private Sub frmBooking_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F11 Or e.KeyData = Keys.Control + Keys.F11 Then

            ShowMaster(frmAccItemList)
            Dim row As BookingDataSet.BookingRow
            row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

            If frmAccItemList.DialogResult = System.Windows.Forms.DialogResult.OK Then

                Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, My.Settings.AccDepartmentId)
                'GridView1.SetFocusedRowCellValue("ItemId", frmAccItemList.ItemID)
                Dim newRow As BookingDataSet.BookingDetailsRow = Me.BookingDataSet.BookingDetails.NewRow()
                newRow.BookingId = row.BookingId
                newRow.ItemId = frmAccItemList.ItemID
                newRow.ItemSize = "All Size"
                newRow.ItemColor = "All Color"
                newRow.UnitId = frmAccItemList.UnitId
                newRow.UnitPrice = frmAccItemList.UnitPrice
                newRow.BookingQuantity = 0

                Me.BookingDataSet.BookingDetails.Rows.Add(newRow)

                Me.BookingDetailsBindingSource.MoveLast()

            End If

        End If

    End Sub

    Private Sub AddItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemButton.Click

        ShowMaster(frmAccItemList)
        Dim row As BookingDataSet.BookingRow
        row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

        If frmAccItemList.DialogResult = System.Windows.Forms.DialogResult.OK Then
            On Error Resume Next

            Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, My.Settings.AccDepartmentId)
            'GridView1.SetFocusedRowCellValue("ItemId", frmAccItemList.ItemID)
            Dim newRow As BookingDataSet.BookingDetailsRow = Me.BookingDataSet.BookingDetails.NewRow()
            newRow.BookingId = row.BookingId
            newRow.ItemId = frmAccItemList.ItemID
            newRow.ItemSize = "All Size"
            newRow.ItemColor = "All Color"
            newRow.UnitId = frmAccItemList.UnitId
            newRow.UnitPrice = frmAccItemList.UnitPrice
            newRow.SupplierId = row.SupplierId
            newRow.BookingQuantity = 0

            Me.BookingDataSet.BookingDetails.Rows.Add(newRow)
            Me.BookingDetailsBindingSource.MoveLast()


        End If
    End Sub

    Private Sub CopyItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyItemButton.Click
        If Me.BookingDetailsBindingSource.Position > -1 Then

            On Error Resume Next

            Dim row As BookingDataSet.BookingRow
            row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

            Dim row2 As BookingDataSet.BookingDetailsRow
            row2 = CType(CType(Me.BookingDetailsBindingSource.Current, DataRowView).Row, BookingDataSet.BookingDetailsRow)


            Dim newRow As BookingDataSet.BookingDetailsRow = Me.BookingDataSet.BookingDetails.NewRow()

            newRow.BookingId = row.BookingId
            newRow.ItemId = row2.ItemId
            newRow.Consumption = row2.Consumption
            newRow.UnitPrice = row2.UnitPrice
            newRow.UnitId = row2.UnitId
            newRow.ItemSize = row2.ItemSize
            newRow.ItemColor = row2.ItemColor
            newRow.OrderQuantity = 0
            newRow.Remarks = row2.Remarks
            newRow.SupplierId = row2.SupplierId

            Me.BookingDataSet.BookingDetails.Rows.Add(newRow)

        End If
    End Sub

    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click
        Dim AWS_App_Chk As Boolean = ReadBooleanData(" Select IsApproved From AccessoriesWorkOrderSheet Where AWSNo = '" & Me.ProgramNoTextBox.Text & "'", cnn)
        Dim count As Int32 = ReadIntData("Select COUNT(ProgramNo) As ProgramNo FROM Booking Where ProgramNo = '" & Me.ProgramNoTextBox.Text & "'", cnn)
        If AWS_App_Chk = True Then

            If count <= 0 Then



                GetAWS()
                save()

                Me.AWSItemProgramWiseLookUpTableAdapter.FillByAWSNo(Me.AWSItemProgramWiaeLookUpDataSet.AWSItemProgramWiseLookUp, Me.ProgramNoTextBox.Text)
                'Me.AccBOMItemLookupNewTableAdapter.FillByOrderId(Me.AccBOMItemLookupNewDataSet.AccBOMItemLookupNew, Me.OrderIdGridLookUpEdit.EditValue)

                BookingDetailsGridControl.Enabled = True
                SaveDetailsButton.Enabled = True
                GetAWSDetails()
            Else
                MessageBox.Show("This Program already Booked")
            End If
        Else
            MessageBox.Show("This Program Not Approved")
        End If

    End Sub
    Private Sub GetAWS()

        Dim connection As New SqlConnection(cnn)
        connection.Open()
       
        Dim cmd As SqlCommand = New SqlCommand("Select * From AccessoriesWorkOrderSheet Where AWSNo = '" & Me.ProgramNoTextBox.Text & "'", connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()

        While reader.Read
            On Error Resume Next

            AWSId = reader("AWSId")
            OrderDateDateEdit.EditValue = reader("AWSDate")
            SupplierIdGridLookUpEdit.EditValue = reader("SupplierID")
            RemarksTextBox.Text = reader("Remarks")
            DiscontinedCheckEdit.EditValue = reader("IsCancel")

        End While
        reader.Close()
        
        connection.Close()

    End Sub
    Private Sub GetAWSDetails()

        Dim connection As New SqlConnection(cnn)
        connection.Open()

        Dim cmd1 As SqlCommand = New SqlCommand("SELECT AWSId,[AWSDetailsId],AccessoriesBookingDetailsId,OrderQuantity,UnitId,UnitPrice,Remarks FROM [dbo].[AccessoriesWorkOrderSheetDetails]
        WHERE Not EXISTS
        (SELECT AccessoriesBookingDetailsId FROM BookingDetails WHERE AWSDetailsId=AccessoriesWorkOrderSheetDetails.[AWSDetailsId])
        And  AWSId = " & AWSId, connection)
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader()

        If Me.BookingBindingSource.Position > -1 Then

            Dim row As BookingDataSet.BookingRow
            row = CType(CType(Me.BookingBindingSource.Current, DataRowView).Row, BookingDataSet.BookingRow)

            While reader1.Read

                Dim newRow As BookingDataSet.BookingDetailsRow = Me.BookingDataSet.BookingDetails.NewRow()
                'On Error Resume Next

                newRow.AWSDetailsId = reader1("AWSDetailsId")
                newRow.BookingId = row.BookingId
                newRow.ItemId = ReadIntegerData("Select Top (1) ItemId from AccessoresBookingDetails Where AccessoriesBookingDetailsId = " & reader1("AccessoriesBookingDetailsId"), cnn)
                newRow.ItemColor = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId = (Select Top (1) FabricColorId from AccessoresBookingDetails Where AccessoriesBookingDetailsId = " & reader1("AccessoriesBookingDetailsId") & ")", cnn)
                newRow.ItemSize = ReadStringData("Select SizeCode From Size Where SizeId = (Select Top (1) SizeId from AccessoresBookingDetails Where AccessoriesBookingDetailsId = " & reader1("AccessoriesBookingDetailsId") & ")", cnn)
                newRow.Consumption = ReadData("Select Top (1) Consumption from AccessoresBookingDetails Where AccessoriesBookingDetailsId = " & reader1("AccessoriesBookingDetailsId"), cnn)
                newRow.UnitPrice = ReadData("Select UnitPrice From AccessoriesWorkOrderSheetDetails Where AWSDetailsId =" & reader1("AWSDetailsId"), cnn)
                newRow.BookingQuantity = reader1("OrderQuantity")
                newRow.SupplierId = SupplierIdGridLookUpEdit.EditValue 'ReadIntegerData("Select Top (1) SupplierId from AccessoresBooking Where AccessoriesBookingId =(Select AccessoriesBookingId From AccessoriesBoo " & reader1("AccessoriesBookingDetailsId"), cnn)

                newRow.UnitId = reader1("UnitId")
                newRow.UnitPrice = reader1("UnitPrice")
                newRow.Remarks = reader1("Remarks")

                Me.BookingDataSet.BookingDetails.Rows.Add(newRow)

            End While

            reader1.Close()

        End If

        connection.Close()

    End Sub

    Private Sub ProgramNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProgramNoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.BookingBindingSource.Position > -1 Then
            AWSId = ReadIntegerData("Select AWSId From AccessoriesWorkOrderSheet Where AWSNo='" & ProgramNoTextBox.Text & "'", cnn)
            GetAWSDetails()
        End If

    End Sub
End Class