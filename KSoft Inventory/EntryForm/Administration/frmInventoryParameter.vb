Public Class frmInventoryParameter

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        My.Settings.EditRestrictionDays = RestrictionNumericUpDown.Value
        My.Settings.Save()
    End Sub

    Private Sub frmInventoryParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RestrictionNumericUpDown.Value = My.Settings.EditRestrictionDays
    End Sub
End Class