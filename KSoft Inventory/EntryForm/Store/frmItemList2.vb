Imports System.Windows.Forms

Public Class frmItemList2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If blnIssue Then
            'frmIssuetofloor.ItemIdTextBox.Text = CInt(VItemListDataGridView.CurrentRow.Cells(0).Value)
            frmIssuetofloor.PriceTextBox.Text = CDbl(VItemListDataGridView.CurrentRow.Cells(6).Value)
            blnIssue = False
            Me.Close()
        Else
            'frmReceive.ItemIdTextBox.Text = CInt(VItemListDataGridView.CurrentRow.Cells(0).Value)
            frmReceive.PriceTextBox.Text = CDbl(VItemListDataGridView.CurrentRow.Cells(6).Value)
            Me.Close()

        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmItemList2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VItemListDataSet.vItemList' table. You can move, or remove it, as needed.
        Me.VItemListTableAdapter.FillByDepartmentId(Me.VItemListDataSet.vItemList, DepartmentId)
        'TODO: This line of code loads data into the 'ItemListDataSet.ItemList' table. You can move, or remove it, as needed.
        ColumnComboBox.SelectedIndex = 0

    End Sub

    
   

    Private Sub VItemListDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VItemListDataGridView.DoubleClick

        If blnIssue Then
            'frmIssuetofloor.ItemIdTextBox.Text = CInt(VItemListDataGridView.CurrentRow.Cells(0).Value)
            frmIssuetofloor.PriceTextBox.Text = CDbl(VItemListDataGridView.CurrentRow.Cells(6).Value)
            blnIssue = False
            Me.Close()
        Else
            'frmReceive.ItemIdTextBox.Text = CInt(VItemListDataGridView.CurrentRow.Cells(0).Value)
            frmReceive.PriceTextBox.Text = CDbl(VItemListDataGridView.CurrentRow.Cells(6).Value)
            Me.Close()

        End If



    End Sub

    
    Private Sub VItemListDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VItemListDataGridView.CellContentClick

    End Sub

    Private Sub FillByItemNameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.VItemListTableAdapter.FillByItemName(Me.VItemListDataSet.vItemList, SearchTextBox.Text)
        
    End Sub
End Class
