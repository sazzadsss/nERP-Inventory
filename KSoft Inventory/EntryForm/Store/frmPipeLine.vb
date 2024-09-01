Public Class frmPipeLine

    Private Sub ItemListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemListBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.ItemListTableAdapter.Update(Me.ItemListDataSet.ItemList)
            ' Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       

    End Sub

    Private Sub frmPipeLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentId)
        If CheckUserRights("PIPE LINE").CanEdit = False Then

            ItemListBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.ItemListTableAdapter.FillByItemName(Me.ItemListDataSet.ItemList, SearchTextBox.Text, DepartmentId)

    End Sub
End Class