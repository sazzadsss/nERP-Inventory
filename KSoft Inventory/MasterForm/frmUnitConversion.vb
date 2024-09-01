Public Class frmUnitConversion

    Private Sub UnitConversionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnitConversionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnitConversionDataSet)

    End Sub

    Private Sub frmUnitConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitDataSet.Unit' table. You can move, or remove it, as needed.
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        'TODO: This line of code loads data into the 'UnitConversionDataSet.UnitConversion' table. You can move, or remove it, as needed.
        Me.UnitConversionTableAdapter.Fill(Me.UnitConversionDataSet.UnitConversion)

        If CheckUserRights("Unit Conversion").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            UnitConversionBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Unit Conversion").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            UnitConversionBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class