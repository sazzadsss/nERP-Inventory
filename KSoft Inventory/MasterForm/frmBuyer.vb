Public Class frmBuyer

    Private Sub frmBuyer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BuyerDataSet.Buyer' table. You can move, or remove it, as needed.
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked
        If NewLinkLabel.Text = "Add" Then

            BuyerBindingSource.AddNew()
            BuyerDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.BuyerBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BuyerDataSet)
                BuyerDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        'On Error Resume Next
        'Me.BuyerTableAdapter.FillByBuyerName(Me.BuyerDataSet.Buyer, SearchTextBox.Text)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If BuyerBindingSource.Position > -1 Then
            BuyerBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub BuyerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            BuyerDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.BuyerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BuyerDataSet)
            BuyerDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            BuyerDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub
End Class




