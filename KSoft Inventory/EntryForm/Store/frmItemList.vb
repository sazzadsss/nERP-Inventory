Imports System.Data.SqlClient
Imports System.Data
Public Class frmItemList
    Dim Deleted As Boolean

    Private Sub frmItemList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmItemList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.F5 Then

            If NewButton.Text = "Add" Then

                ItemListBindingSource.AddNew()
                'ItemListDataGridView.ReadOnly = False
                NewButton.Text = "Save"
                EditButton.Enabled = False
                DeleteButton.Enabled = False

                'EnableControl(GroupBox5)
                ItemNameTextBox.Focus()

            Else
                If ItemNameTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(ItemNameTextBox, "Item Name is require")
                    ItemNameTextBox.Focus()

                ElseIf PreviousPriceTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(PreviousPriceTextBox, "Add Previous Price")
                    PreviousPriceTextBox.Focus()

                ElseIf CurrentPriceTextBox.Text = String.Empty Then
                    ErrorProvider1.SetError(CurrentPriceTextBox, "Add Current Price")
                    CurrentPriceTextBox.Focus()

                Else

                    'Try
                    Me.Validate()
                    Me.ItemListBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)
                    'ItemListDataGridView.ReadOnly = True
                    NewButton.Text = "Add"
                    EditButton.Enabled = True
                    DeleteButton.Enabled = True
                    'DisableControl(GroupBox5)
                    ErrorProvider1.Clear()
                    'Catch ex As Exception
                    '    'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                    '    MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
                    'End Try
                End If

            End If

        End If

    End Sub

    Private Sub frmItemList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If DepartmentId = YarnDyeingDepartmentId Then

            Me.YDOrderTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrder)
            Me.YarnQualityTableAdapter.Fill(Me.YarnQualityDataSet.YarnQuality)
            Me.YarnCountTableAdapter.Fill(Me.YCountDataSet.YarnCount)
            Me.YarnTypeTableAdapter.Fill(Me.YarnTypeDataSet.YarnType)

        ElseIf DepartmentId = YarnStoreId Then

            Me.YarnQualityTableAdapter.Fill(Me.YarnQualityDataSet.YarnQuality)
            Me.YarnCountTableAdapter.Fill(Me.YCountDataSet.YarnCount)
            Me.YarnTypeTableAdapter.Fill(Me.YarnTypeDataSet.YarnType)

        End If

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.OriginTableAdapter.Fill(Me.OriginDataSet.Origin)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.SubCategoryTableAdapter.Fill(Me.SubCategoryDataSet.SubCategory, DepartmentId)
        Me.SubCategoryLookupTableAdapter.FillByDepartmentId(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentId)
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)

        'Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        'Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        'DisableControl(GroupBox5)

        SearchTextBox.Focus()

        ItemListDataSet.ItemList.DepartmentIdColumn.DefaultValue = DepartmentId
        ItemListDataSet.ItemList.UserLabelColumn.DefaultValue = UserLevel
        DisableFromControl(Me)


        '====================================================
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select ItemName From ItemList", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read

            If reader.IsDBNull(0) = False Then

                list.Add(reader.Item("ItemName"))

            End If

        End While

        reader.Close()
        ItemNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ItemNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        ItemNameTextBox.AutoCompleteCustomSource = list
        connection.Close()
        '===============================================================


        CheckUserRights()


    End Sub
    Private Sub CheckUserRights()
        Dim CANEDIT As Boolean
        Dim CANDELETE As Boolean

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Item List'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)
        CANDELETE = ReadBooleanData("Select CAN_DELETE From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then

            EditButton.Enabled = False
            CancelEntryButton.Enabled = False

        End If

        If CANDELETE = False Then
            DeleteButton.Enabled = False
        Else
            DeleteButton.Enabled = True
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.ItemListTableAdapter.FillByItemName(Me.ItemListDataSet.ItemList, SearchTextBox.Text, DepartmentId)
    End Sub

    'Private Sub UpdateAcc()

    '    'If Accessories Store Which Department No =29


    '    Dim connection As New SqlConnection(cnn)
    '    connection.Open()
    '    Dim sqlstring As String = "Select AccessoriesId,AccessoriesName,(Select ItemStyle From ItemStyle Where ItemStyleId=AccessoriesList.ItemStyleId) As ItemStyle,UnitId From AccessoriesList Where NOT EXISTS (Select AccessoriesId From ItemList Where ItemList.AccessoriesId=AccessoriesList.AccessoriesId )"
    '    Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
    '    Dim reader As SqlDataReader = cmd.ExecuteReader()


    '    While reader.Read

    '        On Error Resume Next

    '        Dim newRow As ItemListDataSet.ItemListRow = Me.ItemListDataSet.ItemList.NewRow()


    '        newRow.AccessoriesId = reader("AccessoriesId").ToString()
    '        newRow.ItemName = reader("AccessoriesName").ToString()
    '        newRow.ItemDescription = reader("ItemStyle").ToString()
    '        newRow.CurrentPrice = reader("MaxPrice").ToString()
    '        newRow.CategoryId = reader("CategoryId").ToString()
    '        newRow.SubCategoryId = reader("SubCategoryId").ToString()

    '        Me.ItemListDataSet.ItemList.Rows.Add(newRow)


    '    End While

    '    reader.Close()
    '    connection.Close()


    '    'Saving Data
    '    Me.Validate()
    '    Me.ItemListBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)



    'End Sub

    

    
    




   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CategoryLinkLabel.LinkClicked
        frmCategory.ShowDialog()

        If frmCategory.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)

            CategoryIdGridLookUpEdit.EditValue = frmCategory.CategoryId


        End If

    End Sub

    Private Sub SubCategoryLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SubCategoryLinkLabel.LinkClicked

        frmSubCategory.ItemListForm = True
        frmSubCategory.varCategoryId = Me.CategoryIdGridLookUpEdit.EditValue

        frmSubCategory.ShowDialog()

        If frmSubCategory.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.SubCategoryLookupTableAdapter.Fill(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentId, CategoryIdGridLookUpEdit.EditValue)

            Dim index As Integer = Me.SubCategoryBindingSource.Find("SubCategoryId", frmSubCategory.SubCategoryId)
            Me.SubCategoryBindingSource.Position = index

        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        frmOrigin.ShowDialog()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        frmBrand.ShowDialog()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        frmUnit.ShowDialog()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With frmChemicalListReport
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With


    End Sub

 
    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        If NewButton.Text = "&New" Then

            EnableFormControl(Me)
            NewButton.Text = "&Save"
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True
            ItemListBindingSource.AddNew()
            ItemNameTextBox.Focus()


            'ItemComboBox.Focus()


        Else

            'Saveing/Updating...
            If ItemNameTextBox.Text = String.Empty Then

                If DepartmentId <> My.Settings.AccDepartmentId Then

                    ErrorProvider1.SetError(ItemNameTextBox, "Item Name is Require")
                    ItemNameTextBox.Focus()
                    Exit Sub

                End If


            Else

                ErrorProvider1.Clear()

            End If

            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)

            '===================================================
            DisableFromControl(Me)
            NewButton.Text = "&New"
            CheckUserRights()
            CancelEntryButton.Enabled = False

        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If EditButton.Text = "&Edit" Then

            EnableFormControl(Me)
            EditButton.Text = "&Update"
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            CancelEntryButton.Enabled = True


        Else

            Me.ItemListDataSet.ItemList.ModifiedOnColumn.DefaultValue = ReadDateData("Select GetDate()", cnn)
            Me.ItemListDataSet.ItemList.UserIdColumn.DefaultValue = UserId
            'Saveing/Updating...
            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)

            '===================================================

            DisableFromControl(Me)
            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If ItemListBindingSource.Position > -1 Then
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
                ItemListBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If


        Else

            'Saveing/Updating...
            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)
            '======================================================
            If ItemListBindingSource.Position = -1 Then
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
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)


        DisableFromControl(Me)
        CheckUserRights()
        NewButton.Text = "&New"
        EditButton.Text = "&Edit"
        DeleteButton.Text = "&Delete"
        CancelEntryButton.Enabled = False
    End Sub

    Private Sub ItemNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemNameTextBox.LostFocus

        'If ItemNameTextBox.Text = String.Empty Then
        '    ErrorProvider1.SetError(ItemNameTextBox, "Item Name is require")
        '    ItemNameTextBox.Focus()
        'Else
        '    ErrorProvider1.Clear()
        'End If

    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    '    Me.SubCategoryLookupTableAdapter.Fill(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentId, ComboBox1.SelectedValue)

    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ItemListDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

        On Error Resume Next


    End Sub

    Private Sub ItemListBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ItemListBindingSource.AddingNew

        Me.ItemListDataSet.ItemList.UserIdColumn.DefaultValue = UserId
        Me.ItemListDataSet.ItemList.ModifiedOnColumn.DefaultValue = Today()


    End Sub

   
   

    
    Private Sub YarnCountTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub YarnCountTextEdit_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.YarnCountTextEdit.EditValue = Replace(Me.YarnCountTextEdit.EditValue.ToString, " ", "")
    'End Sub

   

   
    
    
    Private Sub CategoryIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.SubCategoryTableAdapter.FillByCategoryId(Me.SubCategoryDataSet.SubCategory, CategoryIdGridLookUpEdit.EditValue)
    End Sub

    
    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Panel1.Top = 45 Then
            Panel1.Top = 420
            Panel1.Height = Me.Height - Panel1.Top - 50
        Else
            Panel1.Top = 45
            Panel1.Height = Me.Height - Panel1.Top - 50
        End If
    End Sub

    
    Private Sub UpdateAccButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccButton.Click

        Me.YarnQualityTableAdapter.Fill(Me.YarnQualityDataSet.YarnQuality)
        Me.YarnCountTableAdapter.Fill(Me.YCountDataSet.YarnCount)
        Me.YarnTypeTableAdapter.Fill(Me.YarnTypeDataSet.YarnType)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.OriginTableAdapter.Fill(Me.OriginDataSet.Origin)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.SubCategoryTableAdapter.Fill(Me.SubCategoryDataSet.SubCategory, DepartmentId)
        Me.SubCategoryLookupTableAdapter.FillByDepartmentId(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentId)
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)

    End Sub
    Private Sub GenerateFullAccName()

        On Error Resume Next
        Dim ItemName As String = "{0}{1}{2}"
        Dim BCode As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & AccBuyerIdGridLookUpEdit.EditValue, cnn)
        Dim AccName As String = Me.AccItemNameTextEdit.Text
        Dim AccStyle As String = ""

        If Me.AccItemStyleTextEdit.Text <> String.Empty Then
            AccStyle = "\" & Me.AccItemStyleTextEdit.Text
        End If

        If Me.AccBuyerIdGridLookUpEdit.Text <> String.Empty Then
            BCode = "\" & BCode.ToString()
        End If

        ItemName = System.String.Format(ItemName, AccName, AccStyle, BCode)
        ItemNameTextBox.Text = ItemName

    End Sub




    Private Sub AccItemNameTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemNameTextEdit.EditValueChanged
        GenerateFullAccName()
    End Sub

    Private Sub AccItemStyleTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemStyleTextEdit.EditValueChanged
        GenerateFullAccName()
    End Sub

    Private Sub AccBuyerIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccBuyerIdGridLookUpEdit.EditValueChanged
        GenerateFullAccName()
    End Sub

    Private Sub BookingDetailsIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingDetailsIdGridLookUpEdit.EditValueChanged
        ItemNameTextBox.Text = BookingDetailsIdGridLookUpEdit.Text

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Me.YDOrderDetailsTableAdapter.Fill(Me.YDOrderLookupDataSet.YDOrderDetails, YDOrderGridLookUpEdit.EditValue)
        Me.ItemListTableAdapter.FillByYDOrderId(Me.ItemListDataSet.ItemList, DepartmentId, YDOrderGridLookUpEdit.EditValue)

        If Me.ItemListBindingSource.Position = -1 Then
            Using connection As New SqlConnection(cnn)
                Dim QueryString As String = "Select YDOrderDetailsId,ItemDetails,ISNULL(YarnCount,'') AS YarnCount,ISNULL(YarnQuality,'') AS YarnQuality,ISNULL(YarnTypeId,-1) AS YarnTypeId,Rate from YDOrderItemDetails Where YDOrderId=@YDOrderId"

                Dim command As New SqlCommand(QueryString, connection)
                command.Parameters.Add("@YDOrderId", SqlDbType.BigInt).Value = YDOrderGridLookUpEdit.EditValue
                command.Connection.Open()
                command.ExecuteNonQuery()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()

                    Dim newRow = CType(Me.ItemListDataSet.ItemList.NewRow(), ItemListDataSet.ItemListRow)

                    newRow.ItemName = reader("ItemDetails")
                    newRow.YDOrderDetailsId = reader("YDOrderDetailsId")
                    newRow.YarnTypeId = reader("YarnTypeId")
                    newRow.YarnCount = reader("YarnCount")
                    newRow.YarnQuality = reader("YarnQuality")
                    newRow.CurrentPrice = reader("Rate")
                    newRow.UnitId = 1

                    Me.ItemListDataSet.ItemList.Rows.Add(newRow)

                End While
                reader.Close()
                command.Connection.Close()


            End Using
        End If
    End Sub
End Class