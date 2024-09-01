Public Class frmCompany

    Private Sub CompanyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompanyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CompanyDataSet)

    End Sub

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.Company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

    End Sub
End Class