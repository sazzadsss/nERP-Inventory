﻿Public Class frmDatagridViewCellHighlight
    Private WithEvents dataGridView1 As New DataGridView()
    Private highPriImage As Bitmap
    Private mediumPriImage As Bitmap
    Private lowPriImage As Bitmap
    Private Sub frmDatagridViewCellHighlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize the images. 
        Try
            highPriImage = New Bitmap("highPri.bmp")
            mediumPriImage = New Bitmap("mediumPri.bmp")
            lowPriImage = New Bitmap("lowPri.bmp")
        Catch ex As ArgumentException
            MessageBox.Show("The Priority column requires Bitmap images" & _
                "named highPri.bmp, mediumPri.bmp, and lowPri.bmp " & _
                "residing in the same directory as the executable file.")
        End Try

        ' Initialize the DataGridView.
        With dataGridView1
            .Dock = DockStyle.Fill
            .AllowUserToAddRows = False
            .Columns.AddRange( _
                New DataGridViewTextBoxColumn(), _
                New DataGridViewImageColumn())
            .Columns(0).Name = "Balance"
            .Columns(1).Name = "Priority"
            .Rows.Add("-100", "high")
            .Rows.Add("0", "medium")
            .Rows.Add("100", "low")
        End With

        Me.Controls.Add(dataGridView1)
    End Sub

   


    ' Changes how cells are displayed depending on their columns and values.
    Private Sub dataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dataGridView1.CellFormatting

        ' Set the background to red for negative values in the Balance column.
        If dataGridView1.Columns(e.ColumnIndex).Name.Equals("Balance") Then

            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))

                e.CellStyle.BackColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If

        ' Replace string values in the Priority column with images.
        If dataGridView1.Columns(e.ColumnIndex).Name.Equals("Priority") Then

            ' Ensure that the value is a string.
            Dim stringValue As String = TryCast(e.Value, String)
            If stringValue Is Nothing Then Return

            ' Set the cell ToolTip to the text value.
            Dim cell As DataGridViewCell = _
                dataGridView1(e.ColumnIndex, e.RowIndex)
            cell.ToolTipText = stringValue

            ' Replace the string value with the image value.
            Select Case stringValue

                Case "high"
                    e.Value = highPriImage
                Case "medium"
                    e.Value = mediumPriImage
                Case "low"
                    e.Value = lowPriImage

            End Select

        End If

    End Sub
End Class