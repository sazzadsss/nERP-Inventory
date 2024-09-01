Public Class frmYarnQuality

    Private Sub YarnQualityBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnQualityBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.YarnQualityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.YarnQualityDataSet)

    End Sub

    Private Sub frmYarnQuality_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YarnQualityDataSet.YarnQuality' table. You can move, or remove it, as needed.
        Me.YarnQualityTableAdapter.Fill(Me.YarnQualityDataSet.YarnQuality)

        If CheckUserRights("Yarn Quality").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            YarnQualityBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Yarn Quality").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            YarnQualityBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class