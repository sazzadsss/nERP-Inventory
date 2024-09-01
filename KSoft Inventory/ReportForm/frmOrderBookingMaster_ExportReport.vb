Public Class frmOrderBookingMaster_ExportReport

    Private Sub frmOrderBookingMaster_Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrderBookingMasterDataSet.OrderBookingMaster' table. You can move, or remove it, as needed.
        Me.OrderBookingMasterTableAdapter.Fill(Me.OrderBookingMasterDataSet.OrderBookingMaster)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Order Booking Details-" & Today
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then


            Try

                PivotGridControl1.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing



    End Sub
End Class