Imports System.IO

Public Class frmMiscDelivery
    Dim Addflag As Boolean = False
    Private _DepID As Integer
    Public Property DepID() As Integer
        Get
            Return _DepID
        End Get
        Set(ByVal value As Integer)
            _DepID = value
        End Set
    End Property

    Private Sub MiscDeliveryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub frmMiscDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)

        Me.MiscChallanLookupTableAdapter.FillByDepartmentId(Me.MiscChallanLookupDataSet.MiscChallanLookup, DepID)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.MiscDeliveryDetailsTableAdapter.Fill(Me.MiscDeliveryDataSet.MiscDeliveryDetails)
        Me.MiscDeliveryDataSet.MiscDelivery.DepartmentIdColumn.DefaultValue = DepID


        If CheckUserRights("Misc Delivery").CanEdit = False Then

            'NewButton.Enabled = False
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = True

        ElseIf CheckUserRights("Misc Delivery").CanDelete = False Then

            'NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = False
            'CancelEntryButton.Enabled = True

        End If



    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.MiscDeliveryTableAdapter.FillByMiscDeliveryId(Me.MiscDeliveryDataSet.MiscDelivery, Me.ChallanNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        frmMiscDeliveryChallanReport.MDID = Me.ChallanNoGridLookUpEdit.EditValue
        ShowForm(frmMiscDeliveryChallanReport)

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If PrintCount(Me.ChallanNoTextBox.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select USER_LEVEL From [User] Where User_Id=" & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to edit a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:
        If EditButton.Text = "&Edit" Then
            EditButton.Text = "&Update"
            NewButton.Enabled = False
        Else
            Try



                If Addflag = True Then

                    Dim ABC As String = Now.Year.ToString.Substring(2) & "MDC"
                    Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0,CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From MiscDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

                    ''Dim NewOrder As String = Now.Year.ToString.Substring(2) & "K" & (Val(XYZ) + 1).ToString("0000")
                    Me.ChallanNoTextBox.Text = Now.Year.ToString.Substring(2) & "MDC" & (Val(XYZ) + 1).ToString()
                    Me.ChallanDateDateTimePicker.Text = Today()

                End If

                UserGridLookUpEdit.EditValue = UserId

                If ChallanNoTextBox.Text = String.Empty Then
                    MessageBox.Show("Challan No is Missing.")
                    Exit Sub
                ElseIf SupplierIdGridLookUpEdit.EditValue = -1 Then
                    MessageBox.Show("Supplier is Missing.")
                    Exit Sub
                ElseIf AttentionTextBox.Text = String.Empty Then
                    MessageBox.Show("Attention is Missing.")
                    Exit Sub
                ElseIf RemarksTextBox.Text = String.Empty Then
                    MessageBox.Show("Remarks is Missing.")
                    Exit Sub
                End If

                Me.Validate()
                Me.MiscDeliveryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MiscDeliveryDataSet)

                If Addflag = True Then
                    Me.MiscChallanLookupTableAdapter.Fill(Me.MiscChallanLookupDataSet.MiscChallanLookup)
                End If


                If Me.MiscDeliveryBindingSource.Position > -1 Then
                    Dim row As MiscDeliveryDataSet.MiscDeliveryRow
                    row = CType(CType(Me.MiscDeliveryBindingSource.Current, DataRowView).Row, MiscDeliveryDataSet.MiscDeliveryRow)

                    Me.ChallanNoGridLookUpEdit.EditValue = row.MiscDeliveryId

                End If


                Addflag = False
                NewButton.Enabled = True

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            EditButton.Text = "&Edit"

        End If



    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click


        Me.MiscDeliveryBindingSource.AddNew()

        Dim ABC As String = Now.Year.ToString.Substring(2) & "MDC"
        Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0,CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From MiscDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

        ''Dim NewOrder As String = Now.Year.ToString.Substring(2) & "K" & (Val(XYZ) + 1).ToString("0000")
        Me.ChallanNoTextBox.Text = Now.Year.ToString.Substring(2) & "MDC" & (Val(XYZ) + 1).ToString()
        Me.ChallanDateDateTimePicker.Text = Today()


        Addflag = True
        NewButton.Enabled = False

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Me.MiscDeliveryDetailsBindingSource.Position > -1 Then
            MessageBox.Show("Please delete Misc Delete Details first")
            Exit Sub

        End If
        Me.MiscDeliveryBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowFormWithUserRights(frmGeneralGatePass, "General Gate Pass")
    End Sub
End Class