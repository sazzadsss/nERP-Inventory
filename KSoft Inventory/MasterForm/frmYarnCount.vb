Public Class frmYarnCount

    Private Sub YarnCountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnCountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.YarnCountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.YCountDataSet)

    End Sub

    Private Sub frmYarnCount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YCountDataSet.YarnCount' table. You can move, or remove it, as needed.
        Me.YarnCountTableAdapter.Fill(Me.YCountDataSet.YarnCount)

        If CheckUserRights("Yarn Count").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            YarnCountBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Yarn Count").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            YarnCountBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub
End Class