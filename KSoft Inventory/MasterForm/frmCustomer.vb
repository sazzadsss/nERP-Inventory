Public Class frmCustomer

    Private Sub CustomerListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerListDataSet)

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerListDataSet.CustomerList' table. You can move, or remove it, as needed.
        Me.CustomerListTableAdapter.Fill(Me.CustomerListDataSet.CustomerList)

    End Sub
End Class