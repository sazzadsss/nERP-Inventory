Public Class frmDepartment

    Private Sub DepartmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepartmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DepartmentDataSet)

    End Sub

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CurrencyDataSet.Currency' table. You can move, or remove it, as needed.
        Me.CurrencyTableAdapter.Fill(Me.CurrencyDataSet.Currency)
        'TODO: This line of code loads data into the 'DepartmentDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        If CheckUserRights("Department").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DepartmentBindingNavigatorSaveItem.Enabled = False


        End If
    End Sub


End Class