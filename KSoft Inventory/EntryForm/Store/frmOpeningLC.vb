Imports System.Data.SqlClient

Public Class frmOpeningLC
    Dim LCDate As Date
    Dim SupplierId As Integer
    Dim IID As Integer

    Private Sub LCListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.LCListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmOpeningLC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BuyerDataSet.Buyer' table. You can move, or remove it, as needed.
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentId)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.PIListTableAdapter.Fill(Me.OpeningLCDataSet.PIList)
        Me.LCListTableAdapter.Fill(Me.OpeningLCDataSet.LCList, DepartmentId)



        Me.OpeningLCDataSet.LCList.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.OpeningLCDataSet.LCList.CompanyIdColumn.DefaultValue = 1
        Me.OpeningLCDataSet.PIList.UnitIdColumn.DefaultValue = 1

        Dim CANEDIT As Boolean
        Dim CANDELETE As Boolean

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Opening LC'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)
        CANDELETE = ReadBooleanData("Select CAN_DELETE From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then
            'NewButton.Enabled = False
            EditButton.Enabled = False
            'DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = False
            'BindingNavigatorDeleteItem.Enabled = False
            'LCListBindingNavigatorSaveItem.Enabled = False
        End If

        If CANDELETE = False Then
            DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = False
        End If

    End Sub

    Private Sub CopyLCDateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CopyLCDateLinkLabel.LinkClicked
        If LCListBindingSource.Position > -1 Then

            If CopyLCDateLinkLabel.Text = "&Copy" Then


                Dim row As OpeningLCDataSet.LCListRow
                row = CType(CType(Me.LCListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.LCListRow)

                LCDateTimePicker.Text = row.LCDate
                SupplierId = row.SupplierId

                CopyLCDateLinkLabel.Text = "&Paste"

            Else

                'Dim row As OpeningLCDataSet.LCListRow
                'row = CType(CType(Me.LCListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.LCListRow)

                'row.LCDate = L
                'row.SupplierId = SupplierId
                MessageBox.Show(LCDate.ToString)

                If GridView1.FocusedColumn.Caption = "LC Date" Then
                    GridView1.SetFocusedRowCellValue("LCDate", LCDateTimePicker.Text)
                ElseIf GridView1.FocusedColumn.Caption = "Supplier" Then
                    GridView1.SetFocusedRowCellValue("SupplierId", SupplierId)
                End If

                CopyLCDateLinkLabel.Text = "&Copy"


            End If




        End If

    End Sub

    Private Sub PIListGridControl_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIListGridControl.Enter

        'Me.Validate()
        'Me.LCListBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)

    End Sub

    Private Sub frmOpeningLC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F12 Then

            Me.Validate()
            Me.LCListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)

        End If

    End Sub

    Private Sub RefreshToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridView2_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged


        Dim row As OpeningLCDataSet.PIListRow
        row = CType(CType(Me.PIListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.PIListRow)

        If e.Column.Caption = "LC Price" Then

            ExecuteQuery("Update Receive Set Price=" & e.Value & " Where PIId=" & row.PIId & "And DepartmentId=" & DepartmentId, cnn)
            ExecuteQuery("Update Issue Set Price=" & e.Value & " Where PIId=" & row.PIId & "And DepartmentId=" & DepartmentId, cnn)

        ElseIf e.Column.Caption = "Item List" Then

            If row.IsUsed = True Then
                row.ItemId = IID
            End If

        End If

    End Sub

    Private Sub CopyPILinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CopyPILinkLabel.LinkClicked


        '---Copy current row
        Dim oldrow As OpeningLCDataSet.PIListRow
        oldrow = CType(CType(Me.PIListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.PIListRow)

        '---Paste current row to new row

        Dim newRow As OpeningLCDataSet.PIListRow = Me.OpeningLCDataSet.PIList.NewRow()
        On Error Resume Next
        newRow.PINo = oldrow.PINo
        newRow.LCId = oldrow.LCId
        newRow.ETA = oldrow.ETA
        newRow.PIDate = oldrow.PIDate
        newRow.RequisitionId = oldrow.RequisitionId
        newRow.UnitId = oldrow.UnitId
        Me.OpeningLCDataSet.PIList.Rows.Add(newRow)

        Me.PIListBindingSource.MoveLast()

        'With Me.OpeningLCDataSet.PIList


        '    .PINoColumn.DefaultValue = oldrow.PINo
        '    .PIDateColumn.DefaultValue = oldrow.PIDate
        '    .RequisitionIdColumn.DefaultValue = oldrow.RequisitionId
        '    .UnitIdColumn.DefaultValue = oldrow.UnitId
        '    .ETAColumn.DefaultValue = oldrow.ETA



        'End With

        'Me.PIListBindingSource.AddNew()

        Panel1.Enabled = True

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If Me.LCListBindingSource.Position = -1 Then
            Exit Sub
        End If



        If EditButton.Text = "&Edit" Then
            LCNoTextEdit.Enabled = True
            EditButton.Text = "&Update"

        Else


            Dim row As OpeningLCDataSet.LCListRow
            row = CType(CType(Me.LCListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.LCListRow)

            EditButton.Text = "&Edit"

            Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Opening LC'", cnn)
            Dim CANEDIT As Boolean = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)


            If IsUsed("LCId", row.LCId, "LCLIst") = False Or CANEDIT = True Or UserId = 1 Then
                Me.Validate()
                Me.LCListBindingSource.EndEdit()
                Me.LCListTableAdapter.Update(Me.OpeningLCDataSet.LCList)
            Else
                MessageBox.Show("Not Saved,Already Used")
            End If
            'Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)
            LCNoTextEdit.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentId)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
    End Sub

    Private Sub MasterLCLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        If NewButton.Text = "&New" Then
            Me.LCListBindingSource.AddNew()
            LCNoTextEdit.Enabled = True
            NewButton.Text = "&Save"
        Else
            NewButton.Text = "&New"
            LCNoTextEdit.Enabled = True
            Me.Validate()
            Me.LCListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)
        End If
    End Sub

    Function IsUsed(ByVal ColName As String, ByVal ColValue As Integer, ByVal extblname As String) As Boolean 'excluded table name

        Dim cnt As Integer = 0 'count
        Dim bln As Boolean = False 'boolean

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "SELECT name FROM sysobjects WHERE id IN ( SELECT id FROM syscolumns WHERE name = '" & ColName & "' ) And xtype='U'"

            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()


            While reader.Read()

                If reader(0).ToString <> extblname Then

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

    Private Sub LCListBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles LCListBindingSource.PositionChanged

        If Me.LCListBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As OpeningLCDataSet.LCListRow
        row = CType(CType(Me.LCListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.LCListRow)

        If IsUsed("LCId", row.LCId, "LCList") = True Then

            row.IsUsed = True
        Else
            row.IsUsed = False
        End If

        For Each drv As DataRowView In PIListBindingSource.List

            If IsUsed("PIId", drv!PIId, "PIList") = True Then
                drv!IsUsed = True
                Panel1.Enabled = False
            Else
                drv!IsUsed = False
                Panel1.Enabled = False
            End If

        Next

    End Sub

    Private Sub PIListBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles PIListBindingSource.PositionChanged

        If Me.PIListBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim row As OpeningLCDataSet.PIListRow
        row = CType(CType(Me.PIListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.PIListRow)

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Opening LC'", cnn)
        Dim CANEDIT As Boolean = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)


        If IsUsed("PIId", row.PIId, "PIList") = True Then
            row.IsUsed = True
            Panel1.Enabled = False
        Else
            row.IsUsed = False
            Panel1.Enabled = False
        End If

    End Sub

    'Private Sub GridView2_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView2.ShowingEditor
    '    On Error Resume Next
    '    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
    '    If (view.GetRowCellValue(view.FocusedRowHandle, "IsUsed").Equals(vbTrue)) Then
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub GridView2_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView2.RowClick

    End Sub

    Private Sub GridView2_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanging
        If e.Column.Caption = "Item Name" Then
            Dim row As OpeningLCDataSet.PIListRow
            row = CType(CType(Me.PIListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.PIListRow)

            IID = row.ItemId

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddLinkLabel.LinkClicked

        If AddLinkLabel.Text = "Add" Then
            AddLinkLabel.Text = "Save"
            PIListBindingSource.AddNew()
            Panel1.Enabled = True
        Else
            AddLinkLabel.Text = "Add"
            Panel1.Enabled = False
            Me.Validate()
            Me.PIListBindingSource.EndEdit()
            PIListTableAdapter.Update(OpeningLCDataSet.PIList)
        End If

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If MessageBox.Show("Are your sure you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If IsEditableCheckEdit.Checked = False Then
                Me.LCListBindingSource.RemoveCurrent()
                Me.LCListTableAdapter.Update(Me.OpeningLCDataSet.LCList)
            Else
                MessageBox.Show("Not Deleted, Already in used", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Not Deleted, Already in used", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            End If

        End If


    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked
        If IsUsedCheckEdit.Checked = False Then

            If MessageBox.Show("Are you sure you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Me.PIListBindingSource.RemoveCurrent()
                Me.Validate()
                Me.LCListBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OpeningLCDataSet)

            End If

        End If
    End Sub

    Private Sub EditLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If PIListBindingSource.Position = -1 Then
            Exit Sub
        End If

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Opening LC'", cnn)
        Dim CANEDIT As Boolean = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        Dim row As OpeningLCDataSet.PIListRow
        row = CType(CType(Me.PIListBindingSource.Current, DataRowView).Row, OpeningLCDataSet.PIListRow)

        If EditLinkLabel.Text = "Edit" Then

            EditLinkLabel.Text = "Update"
            If row.IsUsed = False Or CANEDIT = True Then
                Panel1.Enabled = True
            End If

        Else

            EditLinkLabel.Text = "Edit"



            If row.IsUsed = False Or CANEDIT = True Then
                Me.Validate()
                Me.PIListBindingSource.EndEdit()
                Me.PIListTableAdapter.Update(Me.OpeningLCDataSet.PIList)
            Else
                MessageBox.Show("Not Saved PI , Already used")
            End If

        End If

    End Sub
End Class