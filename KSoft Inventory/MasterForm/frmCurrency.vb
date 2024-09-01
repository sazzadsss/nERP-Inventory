Public Class frmCurrency

    Private Sub CurrencyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CurrencyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CurrencyDataSet)

    End Sub

    Private Sub frmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CurrencyDataSet.Currency' table. You can move, or remove it, as needed.
        Me.CurrencyTableAdapter.Fill(Me.CurrencyDataSet.Currency)
        If CheckUserRights("Currency").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            CurrencyBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Currency").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            CurrencyBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class